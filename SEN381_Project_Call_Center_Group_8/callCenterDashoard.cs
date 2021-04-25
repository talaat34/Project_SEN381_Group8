using System;
using System.Collections.Generic;
using System.Media;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SEN381_Project_Call_Center_Group_8
{
    public partial class callCenterDashoard : Form
    {

        //Objects
        commonMethods Common = new commonMethods();
        calls cls = new calls();
        dbAcccess access = new dbAcccess();

        //This is for the call ringtone
        SoundPlayer player = new SoundPlayer(@"C:\Users\user-pc\Desktop\TALAAT BCom 3rd YEAR\SEN381\Project\RESOURCES\phone_call_ringtone.wav");
        SoundPlayer issuePlayer;

        //This is a list that will store list of calls
        List<SoundPlayer> callSamples = new List<SoundPlayer>();


        //This is for storing the employee's login details
        string employeeID = loginPersonDetails.id;

        public callCenterDashoard()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void callCenterDashboard_load(object sender, EventArgs e)
        {
            //This is for the tab control 'user controls that i added' - START
            callCenterDashboard_PROFILE1.Visible = false;
            callCenterDashboard_MSGs1.Visible = false;
            //This is for the tab control 'user controls that i added' - END



            callTimer.Enabled = true;
            callInterval = Common.generateRandomNumber(10, 100);

            //Loading calls into list
            callSamples = Common.customer_employee_conversation();
        }

        

        // This is the timer
        int seconds = 0;
        private int callInterval;
        DialogResult res;
        string callInsert_result = null;
        private void CallTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == callInterval)
            {
                seconds = 0;
                callTimer.Stop();
                
                MessageBoxManager.OK = "Accept";
                MessageBoxManager.Cancel = "Cancel";

                // This is for making the call
                List<calls> completeCall = cls.generateCall(loginPersonDetails.id);
                foreach (calls compCall in completeCall)
                {
                    player.PlayLooping();
                    compCall.CallStatus = "Answered";
                    res = MessageBox.Show(compCall.ToString(), "Tests", MessageBoxButtons.OKCancel);
                }
                
                
                if (res == DialogResult.OK)//Accept Call
                {
                    //Insert call details in database
                    callInsert_result = access.insertCall(completeCall, "Answered");

                    //Stop the call ringtone
                    player.Stop();

                    // This is for listening to the customer's issue - START
                    int callIndex = Common.generateRandomNumber(0, 1);
                    issuePlayer = callSamples[callIndex];
                    issuePlayer.PlaySync();
                    Common.alertt(callInsert_result);
                    // This is for listeniong to the customer's issue - END

                    //Restart to make a new call
                    callTimer.Start();
                    callInterval = 1;
                    callInterval = Common.generateRandomNumber(10, 100);
                    seconds = 0;
                }
                else if (res == DialogResult.Cancel)// Cancel Call
                {
                    //Insert call details in database
                    callInsert_result = access.insertCall(completeCall, "Canceled");

                    //Stop the call ringtone
                    player.Stop();

                    //Code to be done when a call is canceled - START
                    Common.alertt("Canceled Call");
                    //Code to be done when a call is canceled - END

                    //Restart to make a new call
                    callTimer.Start();
                    callInterval = 1;
                    callInterval = Common.generateRandomNumber(10, 100);
                    seconds = 0;
                }

            }

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Hover(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.FromArgb(43, 149, 193);
        }

        private void btnClose_Leave(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.FromArgb(0, 206, 209);
        }

        private void minimizeBtn_Hover(object sender, EventArgs e)
        {
            minimizeBtn.BackColor = Color.FromArgb(43, 149, 193);
        }

        private void minimizeBtn_Leave(object sender, EventArgs e)
        {
            minimizeBtn.BackColor = Color.FromArgb(0, 206, 209);
        }

        private void BtnCallAdmin_Click(object sender, EventArgs e)
        {
            callCenterDashboard_PROFILE1.Visible = false;
            callCenterDashboard_MSGs1.Visible = false;
            callCenterDashboard_CALLS1.Visible = true;
        }

        private void BtnMessegesAdmin_Click(object sender, EventArgs e)
        {
            callCenterDashboard_PROFILE1.Visible = false;
            callCenterDashboard_CALLS1.Visible = false;
            callCenterDashboard_MSGs1.Visible = true;
        }

        private void BtnProfileAdmin_Click(object sender, EventArgs e)
        {
            callCenterDashboard_CALLS1.Visible = false;
            callCenterDashboard_MSGs1.Visible = false;
            callCenterDashboard_PROFILE1.Visible = true;
        }


        private void BtnLogoutAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }
    }
}
