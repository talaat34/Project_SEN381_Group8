using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SEN381_Project_Call_Center_Group_8
{
    public partial class clientDashboard : Form
    {
        //Object instantiation
        commonMethods common = new commonMethods();
        dbAcccess access = new dbAcccess();

        /*This Dll is used to make the forms's corners round - START*/
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        /*This Dll is used to make the forms's corners round - START*/
        public clientDashboard()
        {
            InitializeComponent();

            /*This is to make the forms's corners round - START*/
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            /*This is to make the forms's corners round - START*/

            /*Manu Sidebar Navigation - START*/
            pnlNav.Height = btnCallHelpCenter.Height;
            pnlNav.Top = btnCallHelpCenter.Top;
            pnlNav.Left = btnCallHelpCenter.Left;
            btnCallHelpCenter.BackColor = Color.FromArgb(187, 238, 255);
            /*Manu Sidebar Navigation - END*/
        }
        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            lblUsername.Text = loginPersonDetails.username;
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnCallHelpCenter_Click(object sender, EventArgs e)
        {
            /*Manu Sidebar Navigation - START*/
            pnlNav.Height = btnCallHelpCenter.Height;
            pnlNav.Top = btnCallHelpCenter.Top;
            pnlNav.Left = btnCallHelpCenter.Left;
            btnCallHelpCenter.BackColor = Color.FromArgb(187, 238, 255);
            /*Manu Sidebar Navigation - END*/

            /*THIS IS TO IMPLEMENT THE CALL FUNCTIONALITY - START*/
            string callID = common.generateID(10);
            string callLength = common.generateRandomNumber(0,25).ToString();
            string callTime = common.date_time();
            string callStat = "Not Answered";
            string clientID = loginPersonDetails.id;
            string empID = "";
            /*THIS IS TO IMPLEMENT THE CALL FUNCTIONALITY - END*/
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            /*Manu Sidebar Navigation - START*/
            pnlNav.Height = btnMsg.Height;
            pnlNav.Top = btnMsg.Top;
            pnlNav.Left = btnMsg.Left;
            btnMsg.BackColor = Color.FromArgb(187, 238, 255);
            /*Manu Sidebar Navigation - END*/
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            /*Manu Sidebar Navigation - START*/
            pnlNav.Height = btnProfile.Height;
            pnlNav.Top = btnProfile.Top;
            pnlNav.Left = btnProfile.Left;
            btnProfile.BackColor = Color.FromArgb(187, 238, 255);
            /*Manu Sidebar Navigation - END*/
        }
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            /*Manu Sidebar Navigation - START*/
            pnlNav.Height = btnLogout.Height;
            pnlNav.Top = btnLogout.Top;
            pnlNav.Left = btnLogout.Left;
            btnLogout.BackColor = Color.FromArgb(187, 238, 255);
            /*Manu Sidebar Navigation - END*/
        }

        private void BtnCallHelpCenter_Leave(object sender, EventArgs e)
        {
            /*Manu Sidebar Navigation - START*/
            btnCallHelpCenter.BackColor = Color.Transparent;
            /*Manu Sidebar Navigation - END*/
        }

        private void BtnMsg_Leave(object sender, EventArgs e)
        {
            /*Manu Sidebar Navigation - START*/
            btnMsg.BackColor = Color.Transparent;
            /*Manu Sidebar Navigation - END*/
        }

        private void BtnProfile_Leave(object sender, EventArgs e)
        {
            /*Manu Sidebar Navigation - START*/
            btnProfile.BackColor = Color.Transparent;
            /*Manu Sidebar Navigation - END*/
        }

        private void BtnLogout_Leave(object sender, EventArgs e)
        {
            /*Manu Sidebar Navigation - START*/
            btnLogout.BackColor = Color.Transparent;
            /*Manu Sidebar Navigation - END*/
        }
    }
}
