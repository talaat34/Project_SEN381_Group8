using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SEN381_Project_Call_Center_Group_8
{
    public partial class callCenterDashboard_CALLS : UserControl
    {
        //Objects 
        dbAcccess access = new dbAcccess();
        commonMethods Common = new commonMethods();

        public callCenterDashboard_CALLS()
        {
            InitializeComponent();
            dgvCalls.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CallCenterDashboard_CALLS_Load(object sender, EventArgs e)
        {
            loadDataTo_DvgCalls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvCalls.CurrentRow.Index;
            string id = dgvCalls.Rows[index].Cells[0].Value.ToString();
            MessageBoxManager.Yes = "Confirm";
            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this call.", "Confirmation",MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                //Delete call from the databse
                string tableName = "calls";
                string columnName = "callID";
                bool deletedStat = access.deleteQuery(tableName, columnName, id);
                if (deletedStat == true)
                {
                    Common.alertt("Call have been deleted successfully.");
                    dgvCalls.Rows.Clear();
                    dgvCalls.Refresh();
                    loadDataTo_DvgCalls();
                }
                else
                {
                    MessageBox.Show(deletedStat.ToString());
                }
            }
        }

        public void loadDataTo_DvgCalls()
        {
            DataSet ds = access.getTableData("calls");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvCalls.Rows.Add(
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
            string inputSearch = txtSearhBox.Text;
            if (inputSearch == "" || inputSearch == "Enter the call ID...")
            {
                txtSearhBox.Focus();
                txtSearhBox.BackColor = Color.FromArgb(224, 116, 148);
                Common.delaySomeTime(2000, new Action(() => 
                {
                    txtSearhBox.BackColor = Color.FromArgb(254, 254, 254);
                    MessageBox.Show("Please enter a call ID");
                }));

            }
            else
            {
                bool verificationResult = Common.checkForLetters(inputSearch);
                if (verificationResult == false)
                {
                    MessageBox.Show("Please eneter a correct Call ID.");
                }
                else
                {
                    //Search for call in database
                    string tablename = "calls";
                    string columnName = "callID";
                    DataSet ds = access.searchForData(tablename, columnName, inputSearch, "");
                    int returnedRows = ds.Tables[0].Rows.Count;
                    if (returnedRows == 0)
                    {
                        MessageBox.Show("Ooops. Looks like we have not find any call that matched the gievn ID. Please re-try.");
                    }
                    else
                    {
                        //Showing the reload btn to ge all the data from database once more
                        btnReloadData.Visible = true;

                        //Showing the serchResult
                        dgvCalls.Rows.Clear();
                        dgvCalls.Refresh();
                        for (int i = 0; i < returnedRows; i++)
                        {
                            dgvCalls.Rows.Add(
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
                }
            }
        }

        private void BtnReloadAfterSearch_Click(object sender, EventArgs e)
        {
            txtSearhBox.Text = "Enter the call ID...";
            dgvCalls.Rows.Clear();
            dgvCalls.Refresh();
            loadDataTo_DvgCalls();
            btnReloadData.Visible = false;
        }

        //This part is for adding placeholder to the textbox - START
        private void TxtSearhBox_Enter(object sender, EventArgs e)
        {
            if (txtSearhBox.Text == "Enter the call ID...")
            {
                txtSearhBox.Text = "";
            }
        }

        private void TxtSearhBox_Leave(object sender, EventArgs e)
        {
            if (txtSearhBox.Text == "")
            {
                txtSearhBox.Text = "Enter the call ID...";
            }
        }
        //This part is for adding placeholder to the textbox - END
    }
}
