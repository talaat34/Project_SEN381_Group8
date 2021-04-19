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
    public partial class register : Form
    {
        dbAcccess access = new dbAcccess();
        public register()
        {
            InitializeComponent();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            // Left = 15 - This is the indi
            // Left = 403 - This is the busi
            // Left = 784 - This is the admin

            slideA.Visible = false;
            slideC.Visible = false;
            slideB.Visible = true;
        }


        private void BunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Hide();
            log.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
            slideB.Left = 10;
            slideC.Left = 10;
            slideB.Visible = false;
            slideC.Visible = false;
        }

        private void btnIndividualAccount(object sender, EventArgs e)
        {
            if (slideB.Visible == true)
            {
                slideB.Visible = false;
                slideC.Visible = false;
                slideA.Visible = true;

                //Changing color
                btnIndividualTap.IdleFillColor = Color.FromArgb(26, 177, 136);
                btnIndividualTap.IdleLineColor = Color.FromArgb(26, 177, 136);

                //changing color of the buttons
                btnBusinessTap.IdleFillColor = Color.FromArgb(68, 81, 95);
                btnBusinessTap.IdleLineColor = Color.FromArgb(68, 81, 95);
                btnAdminstratorTap.IdleFillColor = Color.FromArgb(68, 81, 95);
                btnAdminstratorTap.IdleLineColor = Color.FromArgb(68, 81, 95);
            }
            else 
            {
                slideC.Visible = false;
                slideB.Visible = false;
                slideA.Visible = true;

                //Changing color
                btnIndividualTap.IdleFillColor = Color.FromArgb(26, 177, 136);
                btnIndividualTap.IdleLineColor = Color.FromArgb(26, 177, 136);

                //changing color of the buttons
                btnBusinessTap.IdleFillColor = Color.FromArgb(68, 81, 95);
                btnBusinessTap.IdleLineColor = Color.FromArgb(68, 81, 95);
                btnAdminstratorTap.IdleFillColor = Color.FromArgb(68, 81, 95);
                btnAdminstratorTap.IdleLineColor = Color.FromArgb(68, 81, 95);
            }
        }

        private void btnBusinessAccount(object sender, EventArgs e)
        {
            if (slideC.Visible == true)
            {
                slideC.Visible = false;
                slideA.Visible = false;
                slideB.Visible = true;

                //Changing color
                btnBusinessTap.IdleFillColor = Color.FromArgb(26, 177, 136);
                btnBusinessTap.IdleLineColor = Color.FromArgb(26, 177, 136);

                //changing color of the buttons
                btnAdminstratorTap.IdleFillColor = Color.FromArgb(68, 81, 95);
                btnAdminstratorTap.IdleLineColor = Color.FromArgb(68, 81, 95);
                btnIndividualTap.IdleFillColor = Color.FromArgb(68, 81, 95);
                btnIndividualTap.IdleLineColor = Color.FromArgb(68, 81, 95);
            }
            else
            {
                slideA.Visible = false;
                slideC.Visible = false;
                slideB.Visible = true;

                //Changing color
                btnBusinessTap.IdleFillColor = Color.FromArgb(26, 177, 136);
                btnBusinessTap.IdleLineColor = Color.FromArgb(26, 177, 136);

                //changing color of the buttons
                btnAdminstratorTap.IdleFillColor = Color.FromArgb(68, 81, 95);
                btnAdminstratorTap.IdleLineColor = Color.FromArgb(68, 81, 95);
                btnIndividualTap.IdleFillColor = Color.FromArgb(68, 81, 95);
                btnIndividualTap.IdleLineColor = Color.FromArgb(68, 81, 95);
            }
        }

        private void btnAdminstratorAccount(object sender, EventArgs e)
        {
            if (slideA.Visible == true)
            {
                slideA.Visible = false;
                slideB.Visible = false;
                slideC.Visible = true;

                //Changing color
                btnAdminstratorTap.IdleFillColor = Color.FromArgb(26, 177, 136);
                btnAdminstratorTap.IdleLineColor = Color.FromArgb(26, 177, 136);

                //changing color of the buttons
                btnBusinessTap.IdleFillColor = Color.FromArgb(68, 81, 95);
                btnBusinessTap.IdleLineColor = Color.FromArgb(68, 81, 95);
                btnIndividualTap.IdleFillColor = Color.FromArgb(68, 81, 95);
                btnIndividualTap.IdleLineColor = Color.FromArgb(68, 81, 95);
            }
            else
            {
                slideB.Visible = false;
                slideA.Visible = false;
                slideC.Visible = true;

                //Changing color
                btnAdminstratorTap.IdleFillColor = Color.FromArgb(26, 177, 136);
                btnAdminstratorTap.IdleLineColor = Color.FromArgb(26, 177, 136);

                //changing color of the buttons
                btnBusinessTap.IdleFillColor = Color.FromArgb(68, 81, 95);
                btnBusinessTap.IdleLineColor = Color.FromArgb(68, 81, 95);
                btnIndividualTap.IdleFillColor = Color.FromArgb(68, 81, 95);
                btnIndividualTap.IdleLineColor = Color.FromArgb(68, 81, 95);
            }
        }

        private void BtnCloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuThinButton211_Click(object sender, EventArgs e)
        {
            string name = txtIndiName.Text;
            string surname = txtIndiSurname.Text;
            string role = txtIndiRole.Text;
            string pass = txtIndiPass.Text;
            string confirm = txtIndiConPass.Text;

            if (name == "")
            {
                MessageBox.Show("Please enter your name");
            }
            else
            {
                if (surname == "")
                {
                    MessageBox.Show("Please enter your Surname");
                }
                else
                {
                    if (role == "")
                    {
                        MessageBox.Show("Please enter your role");
                    }
                    else
                    {
                        if (pass == "")
                        {
                            MessageBox.Show("Please enter your password");
                        }
                        else
                        {
                            if (pass.Length < 4)
                            {
                                MessageBox.Show("The length of the password must at least be 4 or greater.");
                            }
                            else
                            {
                                if (pass != confirm)
                                {
                                    MessageBox.Show("The two passwords dont match. Please re confirm your above password.");
                                }
                                else
                                {
                                    string userType = "individual";
                                    string result = access.registration(userType, name, surname, role, pass);
                                    MessageBox.Show(result);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void BtnBusiSignUp_Click(object sender, EventArgs e)
        {
            string name = txtBusiName.Text;
            string location = txtBusiLocation.Text;
            string email = txtBusiEmail.Text;
            string pass = txtBusiPass.Text;
            string conPass = txtBusiConf.Text;

            if (name == "")
            {
                MessageBox.Show("Please enter your name");
            }
            else
            {
                if (location == "")
                {
                    MessageBox.Show("Please enter your location");
                }
                else
                {
                    if (email == "")
                    {
                        MessageBox.Show("Please enter your email");
                    }
                    else
                    {
                        if (pass == "")
                        {
                            MessageBox.Show("Please enter your password");
                        }
                        else
                        {
                            if (pass.Length < 4)
                            {
                                MessageBox.Show("The length of the password must at least be 4 or greater.");
                            }
                            else
                            {
                                if (pass != conPass)
                                {
                                    MessageBox.Show("The two passwords dont match. Please re confirm your above password.");
                                }
                                else
                                {
                                    string userType = "business";
                                    string result = access.registration(userType, name, location, email, pass);
                                    MessageBox.Show(result);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void BtnAdminSignUp_Click(object sender, EventArgs e)
        {
            string name = txtAdminName.Text;
            string surname = txtAdminSurname.Text;
            string role_email = string.Empty;
            string pass = txtAdminPass.Text;
            string conPass = txtAdminConf.Text;

            if (name == "")
            {
                MessageBox.Show("Please enter your name");
            }
            else
            {
                if (surname == "")
                {
                    MessageBox.Show("Please enter your surname");
                }
                else
                {
                    if (pass == "")
                    {
                        MessageBox.Show("Please enter your password");
                    }
                    else
                    {
                        if (pass.Length < 4)
                        {
                            MessageBox.Show("The length of the password must at least be 4 or greater.");
                        }
                        else
                        {
                            if (pass != conPass)
                            {
                                MessageBox.Show("The two passwords dont match. Please re confirm your above password.");
                            }
                            else
                            {
                                string userType = "admin";
                                string result = access.registration(userType, name, surname, role_email, pass);
                                MessageBox.Show(result);
                            }
                        }
                    }
                }
            }
        }
    }
}
