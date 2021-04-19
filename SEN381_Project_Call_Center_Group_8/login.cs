using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Project_Call_Center_Group_8
{
    public partial class login : Form
    {
        calls cls = new calls();
        dbAcccess acccess = new dbAcccess();
        public login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userLevel = dropUserLevel.selectedValue.ToString();
            string tableName = null;
            

            if (username == "")
            {
                MessageBox.Show("Username can not be empty. Please enter your username.");
            }
            else if (password == "")
            {
                MessageBox.Show("Password can not be empty. Please enter the password.");
            }
            else
            {
                // ASSIGNING TABLE NAME
                if (userLevel == "Adminstrator")
                {
                    tableName = "adminstrators";
                }
                else if (userLevel == "Business Client")
                {
                    tableName = "businessClient";
                }
                else if (userLevel == "Technician")
                {
                    tableName = "technician";
                }
                else if (userLevel == "Admin")
                {
                    tableName = "admin";
                }
                else
                {
                    tableName = "clientIndividual";
                }
                switch (tableName)
                {
                    case "admin":
                        List<admin> adm = acccess.getLoginPerson(tableName, username, password);
                        if (adm.Any())
                        {
                            foreach (admin item in adm)
                            {
                                //This is for storing the logged in person's details (CREATING A SESSION)
                                loginPersonDetails.id = item.Id;
                                loginPersonDetails.username = item.Username;
                                loginPersonDetails.password = item.Password;

                                //Closing the login form and opeing the Technician Dashboard
                                this.Hide();
                                AdministratorDashboard ad = new AdministratorDashboard();
                                ad.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("There is no user with the given details. Please provide correct credentials.");
                        }
                        break;
                    case "technician":
                        List<Technician> technician = acccess.getLoginPerson(tableName, username, password);
                        if (technician == null)
                        {
                            MessageBox.Show("Your account had not been verified yet.\nPleasee contact the admin to verify your account.");
                        }
                        else
                        {
                            if (technician.Any())
                            {
                                foreach (Technician tech in technician)
                                {
                                    //This is for storing the logged in person's details (CREATING A SESSION)
                                    loginPersonDetails.id = tech.TechnicianID1;
                                    loginPersonDetails.username = tech.TechnicianName1;
                                    loginPersonDetails.password = tech.TechnicianPassword1;

                                    //Closing the login form and opeing the Technician Dashboard
                                    this.Hide();
                                    TechnicianDashboard td = new TechnicianDashboard();
                                    td.Show();
                                    //The Technician client form needs to be implemeted
                                    //MessageBox.Show("The Bysiness client form needs to be implemented");
                                    //Application.Exit();
                                }
                            }
                            else
                            {
                                MessageBox.Show("There is no user with the given details. Please provide correct credentials.");
                            }
                        }
                        break;
                    case "adminstrators":
                        List<adminstrator> adminstrators = acccess.getLoginPerson(tableName, username, password);
                        if (adminstrators == null)
                        {
                            MessageBox.Show("Your account had not been verified yet.\nPleasee contact the admin to verify your account.");
                        }
                        else
                        {
                            if (adminstrators.Any())
                            {
                                foreach (adminstrator admin in adminstrators)
                                {
                                    //This is for storing the logged in person's details (CREATING A SESSION)
                                    loginPersonDetails.id = admin.ID;
                                    loginPersonDetails.username = admin.Username;
                                    loginPersonDetails.password = admin.Password;
                                }


                                //Closing the login form and opeing the adminstartor dashboard
                                this.Hide();
                                callCenterDashoard callCenter = new callCenterDashoard();
                                callCenter.Show();

                            }
                            else
                            {
                                MessageBox.Show("There is no user with the given details. Please provide correct credentials.");

                            }
                        }
                        break;
                    case "businessClient":
                        List<BusinessClient> busiCleint = acccess.getLoginPerson(tableName, username, password);
                        if(busiCleint == null)//Acciunt not been verified
                        {
                            MessageBox.Show("Your account had not been verified yet.\nPleasee contact the adminstrator to verify your account.");
                        }
                        else
                        {
                            if (busiCleint.Any())
                            {
                                foreach (BusinessClient busiClient in busiCleint)
                                {
                                    //This is for storing the logged in person's details (CREATING A SESSION)
                                    loginPersonDetails.id = busiClient.Id;
                                    loginPersonDetails.username = busiClient.Username;
                                    loginPersonDetails.password = busiClient.Password;

                                    //Closing the login form and opeing the Business client dashboard
                                    this.Hide();
                                    //The Business client form needs to be implemeted
                                    MessageBox.Show("The Bysiness client form needs to be implemented");
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                MessageBox.Show("There is no user with the given details. Please provide correct credentials.");
                            }
                        }
                        break;
                    case "clientIndividual":
                        List<individualClient> indiClient = acccess.getLoginPerson(tableName, username, password);
                        if (indiClient == null)
                        {
                            MessageBox.Show("Your account had not been verified yet.\nPleasee contact the adminstrator to verify your account.");
                        }
                        else
                        {
                            if (indiClient.Any())
                            {
                                foreach (individualClient indClient in indiClient)
                                {
                                    //This is for storing the logged in person's details (CREATING A SESSION)
                                    loginPersonDetails.id = indClient.Id;
                                    loginPersonDetails.username = indClient.Username;
                                    loginPersonDetails.password = indClient.Password;

                                    //Closing the login form and opeing the call center dashboard
                                    this.Hide();
                                    //The individual client form needs to be implemeted
                                    MessageBox.Show("The individual client form needs to be implemented");
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                MessageBox.Show("There is no user with the given details. Please provide correct credentials.");
                            }
                        }
                        break;
                }
            }
        }
    }
}
