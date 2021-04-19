using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Project_Call_Center_Group_8.userControls
{
    public partial class technicianRequest : UserControl
    {
        dbAcccess access = new dbAcccess();
        commonMethods common = new commonMethods();
        DataSet ds;
        public technicianRequest()
        {
            InitializeComponent();
        }

        private void TechnicianRequest_Load(object sender, EventArgs e)
        {
            ds = access.getTableData("techRequest");
            populate_dgv(ds);
        }

        public void populate_dgv(DataSet ds)
        {
            dgvTechnicianRequest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTechnicianRequest.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvTechnicianRequest.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvTechnicianRequest.Rows.Add(
                    new object[]
                    {
                        ds.Tables[0].Rows[i][0].ToString(),
                        ds.Tables[0].Rows[i][1].ToString(),
                        ds.Tables[0].Rows[i][2].ToString(),
                        ds.Tables[0].Rows[i][3].ToString(),
                        ds.Tables[0].Rows[i][4].ToString(),
                        ds.Tables[0].Rows[i][5].ToString(),
                        ds.Tables[0].Rows[i][6].ToString(),
                        ds.Tables[0].Rows[i][7].ToString()
                    }
                    );
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchID = txtSearch.Text;
            if (searchID == "" || searchID == "Enter YOUR ID or REQUEST ID")
            {
                common.alertt("Please enter YOUR ID or Request ID");
            }
            else
            {
                //search for id
                string tableName = "techRequest";
                string colOneName = "id";
                string colTwoName = "acceptedTechnicianID";
                ds = access.searchTabel_twoParameters(tableName, colOneName, searchID, colTwoName, searchID, "OR");

                if (ds.Tables[0].Rows.Count == 0)
                {
                    common.alertt("No Request found with the given ID");
                }
                else
                {
                    btnSearch.Visible = false;
                    btnRefresh.Visible = true;
                    dgvTechnicianRequest.Rows.Clear();
                    dgvTechnicianRequest.Refresh();
                    populate_dgv(ds);
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Visible = false;
            btnSearch.Visible = true;
            txtSearch.Text = "Enter YOUR ID or REQUEST ID";
            dgvTechnicianRequest.Rows.Clear();
            dgvTechnicianRequest.Refresh();
            ds = access.getTableData("techRequest");
            populate_dgv(ds);
        }


        private void BtnAccept_Click(object sender, EventArgs e)
        {
            int index = dgvTechnicianRequest.CurrentRow.Index;
            string id = dgvTechnicianRequest.Rows[index].Cells[0].Value.ToString();
            string technicianID = loginPersonDetails.id;
            string accepted = dgvTechnicianRequest.Rows[index].Cells[6].Value.ToString();
            if (accepted == "True")
            {
                common.alertt("This request has already been accepted.");
            }
            else
            {
                //Update accepted column in the database
                string tableName = "techRequest";
                string colOneName = "id";
                string ColTwoName = "accepted";
                int colTwoValue = 1;
                string ColThreeName = "acceptedTechnicianID";
                string updateType = "accept";
                string result = access.updateRequest(updateType, tableName, colOneName, id, ColTwoName, colTwoValue, ColThreeName, technicianID);
                if (result != "An unexpected error occured! Please try again.")
                {
                    common.alertt(result);

                    btnRefresh.Visible = false;
                    btnSearch.Visible = true;
                    txtSearch.Text = "Enter YOUR ID or REQUEST ID";
                    dgvTechnicianRequest.Rows.Clear();
                    dgvTechnicianRequest.Refresh();
                    ds = access.getTableData("techRequest");
                    populate_dgv(ds);
                }
                else
                {
                    common.alertt(result);
                }
            }
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            //First check if the selected request belongs to the technician
            //Second if the request is his then check if he/she accepted the request or not
            //Third check if he had already completed the request or not
            int index = dgvTechnicianRequest.CurrentRow.Index;
            string reqTechnicianID = dgvTechnicianRequest.Rows[index].Cells[7].Value.ToString();
            string logedTechnicianID = loginPersonDetails.id;
            string accepted = dgvTechnicianRequest.Rows[index].Cells[6].Value.ToString();
            string completed = dgvTechnicianRequest.Rows[index].Cells[5].Value.ToString();
            if (reqTechnicianID != logedTechnicianID)
            {
                common.alertt("This request does not belong to you. IF it does not belong to any one please accept it and re-try.");
            }
            else
            {
                if (accepted == "False")
                {
                    common.alertt("Please accept the request and re-try.");
                }
                else
                {
                    if (completed == "True")
                    {
                        common.alertt("You have already completed this request.");
                    }
                    else
                    {
                        string updateType = "complete";
                        string tableName = "techRequest";
                        string colOneName = "id";
                        string colOneValue = dgvTechnicianRequest.Rows[index].Cells[0].Value.ToString();
                        string ColTwoName = "completed";
                        int colTwoValue = 1;
                        string ColThreeName = "acceptedTechnicianID";
                        string result = access.updateRequest(updateType, tableName, colOneName, colOneValue, ColTwoName, colTwoValue, ColThreeName, reqTechnicianID);
                        if (result != "An unexpected error occured! Please try again.")
                        {
                            common.alertt(result);

                            btnRefresh.Visible = false;
                            btnSearch.Visible = true;
                            txtSearch.Text = "Enter YOUR ID or REQUEST ID";
                            dgvTechnicianRequest.Rows.Clear();
                            dgvTechnicianRequest.Refresh();
                            ds = access.getTableData("techRequest");
                            populate_dgv(ds);
                        }
                        else
                        {
                            common.alertt(result);
                        }
                    }
                }
            }
        }

        //txtSearch Placeholder - START
        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter YOUR ID or REQUEST ID")
            {
                txtSearch.Text ="";
            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Enter YOUR ID or REQUEST ID";
            }
        }
        //txtSearch Placeholder - END
    }
}
