using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Project_Call_Center_Group_8
{
    public partial class callCenterDashboard_MSGs : UserControl
    {
        dbAcccess access = new dbAcccess();
        DataSet ds = new DataSet();
        commonMethods common = new commonMethods();
        public callCenterDashboard_MSGs()
        {
            InitializeComponent();

            //This is for the datagridview messages - START
            dgvMessages.Columns["outgoing"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            populateDGV_Messages();
            //This is for the datagridview messages - END

            //This is for loading all the users names on the left handside to check their messages on 'onClick' - START
            addUserName();
            //This is for loading all the users names on the left handside to check their messages on 'onClick' - END
        }
        void populateDGV_Messages()
        {
            string userTableName = lblUserTable.Text;
            //Individual
            if (userTableName == "clientIndividual")
            {
                string tableName = "sms";
                string colName = "individualID";
                string userID = lblUserID.Text;
                string colname_orderBY = "sentTime";
                ds = access.searchForData(tableName, colName, userID, colname_orderBY);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string incoming = ds.Tables[0].Rows[i][1].ToString();
                    string outgoing = ds.Tables[0].Rows[i][2].ToString();
                    dgvMessages.Rows.Add(
                            new object[]
                            {
                                incoming,
                                outgoing
                            }
                        );
                }
            }
            else
            {
                //businessClient
                string tableName = "sms";
                string colName = "businessID";
                string userID = lblUserID.Text;
                string colname_orderBY = "sentTime";
                ds = access.searchForData(tableName, colName, userID, colname_orderBY);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string incoming = ds.Tables[0].Rows[i][1].ToString();
                    string outgoing = ds.Tables[0].Rows[i][2].ToString();
                    dgvMessages.Rows.Add(
                            new object[]
                            {
                                incoming,
                                outgoing
                            }
                        );
                }
            }

            List<DataGridViewRow> row = new List<DataGridViewRow>();
            row.AddRange(dgvMessages.Rows.Cast<DataGridViewRow>());
            row.Reverse();
            dgvMessages.Rows.Clear();
            dgvMessages.Rows.AddRange(row.ToArray());


            //Rows and Columns - Some Space In between
            for (int i = 0; i < dgvMessages.RowCount - 2; i++)
            {
                //Give sime margin at the top of each row cell
                dgvMessages.Rows[i].DividerHeight = 10;
                dgvMessages.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
            for (int i = 0; i < dgvMessages.ColumnCount - 1; i++)
            {
                dgvMessages.Columns[i].DividerWidth = 10;
                dgvMessages.Columns[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }

            //Add some space in between cells
            for (int i = 0; i < dgvMessages.RowCount; i++)
            {
                if (dgvMessages.Rows[i].Cells[1].Value.ToString() == "")
                {
                    dgvMessages.Rows[i].Cells[0].Style.BackColor = Color.FromArgb(38, 45, 49);
                    dgvMessages.Rows[i].Cells[1].Style.BackColor = Color.WhiteSmoke;
                    dgvMessages.Rows[i].Cells[0].Style.ForeColor = Color.WhiteSmoke;
                }
                if (dgvMessages.Rows[i].Cells[1].Value.ToString() != "")
                {
                    dgvMessages.Rows[i].Cells[1].Style.BackColor = Color.FromArgb(5, 97, 98);
                    dgvMessages.Rows[i].Cells[0].Style.BackColor = Color.WhiteSmoke;
                    dgvMessages.Rows[i].Cells[1].Style.ForeColor = Color.WhiteSmoke;
                }
            }
        }
        public void addUserName()
        {
            dgvUserProfile.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserProfile.RowTemplate.Height = 30;

            //This is for the individual Client
            string tabelName = "clientIndividual";
            ds = access.getTableData(tabelName);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string name = ds.Tables[0].Rows[i][1].ToString();
                string surname = ds.Tables[0].Rows[i][2].ToString();
                string fullName = name + " " + surname;
                dgvUserProfile.Rows.Add(
                        new object[]
                        {
                            fullName
                        }
                    ); 
            }

            //This is for the business Client
            string tabelName_busi = "businessClient";
            ds = access.getTableData(tabelName_busi);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string name = ds.Tables[0].Rows[i][1].ToString();
                string surname = ds.Tables[0].Rows[i][2].ToString();
                string fullName = name + " " + surname;
                dgvUserProfile.Rows.Add(
                        new object[]
                        {
                            fullName
                        }
                    );
            }
        }

        private void DgvUserProfile_SelectionChanged(object sender, EventArgs e)
        {
            //Individual
            string tabelName = "clientIndividual";
            DataSet ds = access.getTableData(tabelName);
            //Business
            string tableName_busi = "businessClient";
            DataSet ds_busi = access.getTableData(tableName_busi);

            //Merging the two tables together
            ds.Tables[0].Merge(ds_busi.Tables[0]);

            //selection index
            int index = dgvUserProfile.SelectedRows[0].Index;

            //User info
            string id = ds.Tables[0].Rows[index][0].ToString();
            string name = ds.Tables[0].Rows[index][1].ToString();
            string surname__or_location = ds.Tables[0].Rows[index][2].ToString();//This could be the surname or location (individualClient OR BusinessClient)
            string fullName = name + " " + surname__or_location;

            //This is to get the user's table in the database
            //This is done so when an onclick event occurs in the dgv
            //the tableName will be used to get the users messages based on the tableName
            string colName_one = "id";
            string colName_two = "name";
            string colName_three = "surname";
            ds = access.searchTable_ThreePrameters(tabelName, colName_one, id, colName_two, name, colName_three, surname__or_location);
            if (ds.Tables[0].Rows.Count == 0)
            {
                //It means that the user is from the business table
                lblUserTable.Text = "businessClient";
            }
            else
            {
                //It means that the user is from the individual table
                lblUserTable.Text = "clientIndividual";
            }

            lblUserFullName.Text = fullName;
            lblUserID.Text = id;

            dgvMessages.Rows.Clear();
            dgvMessages.Refresh();
            populateDGV_Messages();
        }

        private void PcbSend_Click(object sender, EventArgs e)
        {
            string smsID = common.generateID(10);
            string incoming = DBNull.Value.ToString();
            string outgoing = txtMessage.Text;
            string tableName = lblUserTable.Text;
            string businessID = DBNull.Value.ToString();
            string individualID = DBNull.Value.ToString();
            string adminstartorID = loginPersonDetails.id;
            string dateTime = common.date_time();
            if (tableName == "clientIndividual")
            {
                individualID = lblUserID.Text;
            }
            else
            {
                businessID = lblUserID.Text;
            }
            if (outgoing == "")
            {
                MessageBox.Show("Please enter a message to the user.");
            }
            else
            {
                string rowsAffected = access.insertSms(smsID, incoming, outgoing, businessID, individualID, adminstartorID, dateTime);
                if (rowsAffected == "An unexpected error occured")
                {
                    MessageBox.Show(rowsAffected);
                }
                else
                {
                    dgvMessages.Rows.Clear();
                    dgvMessages.Refresh();
                    populateDGV_Messages();
                }
            }
        }

        private void DgvMessages_SelectionChanged(object sender, EventArgs e)
        {
            dgvMessages.ClearSelection();
        }
    }
}
