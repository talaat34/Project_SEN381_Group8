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
    public partial class AdministratorDashboard : Form
    {
        public AdministratorDashboard()
        {
            InitializeComponent();

            /*THIS IS FOR THE MANU NAVIGATION PLEASE DONT CHANGE - START*/
            pnlNav.Height = btnView.Height;
            pnlNav.Left = btnView.Left;
            pnlNav.Top = btnView.Top;
            btnView.BackColor = Color.FromArgb(45, 142, 213);
            /*THIS IS FOR THE MANU NAVIGATION PLEASE DONT CHANGE - END*/
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            /*THIS IS FOR THE MANU NAVIGATION PLEASE DONT CHANGE - START*/
            pnlNav.Height = btnInsert.Height;
            pnlNav.Left = btnInsert.Left;
            pnlNav.Top = btnInsert.Top;
            btnInsert.BackColor = Color.FromArgb(45, 142, 213);
            /*THIS IS FOR THE MANU NAVIGATION PLEASE DONT CHANGE - END*/
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            /*THIS IS FOR THE MANU NAVIGATION PLEASE DONT CHANGE - START*/
            pnlNav.Height = btnUpdate.Height;
            pnlNav.Left = btnUpdate.Left;
            pnlNav.Top = btnUpdate.Top;
            btnUpdate.BackColor = Color.FromArgb(45, 142, 213);
            /*THIS IS FOR THE MANU NAVIGATION PLEASE DONT CHANGE - END*/
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            /*THIS IS FOR THE MANU NAVIGATION PLEASE DONT CHANGE - START*/
            pnlNav.Height = btnDelete.Height;
            pnlNav.Left = btnDelete.Left;
            pnlNav.Top = btnDelete.Top;
            btnDelete.BackColor = Color.FromArgb(45, 142, 213);
            /*THIS IS FOR THE MANU NAVIGATION PLEASE DONT CHANGE - END*/
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            /*THIS IS FOR THE MANU NAVIGATION PLEASE DONT CHANGE - START*/
            pnlNav.Height = btnProfile.Height;
            pnlNav.Left = btnProfile.Left;
            pnlNav.Top = btnProfile.Top;
            btnProfile.BackColor = Color.FromArgb(45, 142, 213);
            /*THIS IS FOR THE MANU NAVIGATION PLEASE DONT CHANGE - END*/
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            /*THIS IS FOR THE MANU NAVIGATION PLEASE DONT CHANGE - START*/
            pnlNav.Height = btnView.Height;
            pnlNav.Left = btnView.Left;
            pnlNav.Top = btnView.Top;
            btnView.BackColor = Color.FromArgb(45, 142, 213);
            /*THIS IS FOR THE MANU NAVIGATION PLEASE DONT CHANGE - END*/
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            /*THIS IS FOR THE MANU NAVIGATION PLEASE DONT CHANGE - START*/
            pnlNav.Height = btnLogout.Height;
            pnlNav.Left = btnLogout.Left;
            pnlNav.Top = btnLogout.Top;
            btnLogout.BackColor = Color.FromArgb(45, 142, 213);
            /*THIS IS FOR THE MANU NAVIGATION PLEASE DONT CHANGE - END*/
        }

        private void BtnView_Leave(object sender, EventArgs e)
        {
            btnView.BackColor = Color.Transparent;
        }

        private void BtnInsert_Leave(object sender, EventArgs e)
        {
            btnInsert.BackColor = Color.Transparent;
        }

        private void BtnUpdate_Leave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Transparent;
        }

        private void BtnDelete_Leave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Transparent;
        }

        private void BtnProfile_Leave(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.Transparent;
        }

        private void BtnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Transparent;
        }
    }
}
