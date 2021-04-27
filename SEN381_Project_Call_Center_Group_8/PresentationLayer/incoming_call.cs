using System;
using System.Collections.Generic;
using System.Media;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Project_Call_Center_Group_8.PresentationLayer
{
    public partial class incoming_call : Form
    {
        //This is the access layer
        BusinessLogic.sendDB_items sendDB = new BusinessLogic.sendDB_items();
        //This is the common methods that are usually used often
        commonMethods common = new commonMethods();
        //This is the ringtone
        SoundPlayer player = new SoundPlayer(@"C:\Users\user-pc\Desktop\TALAAT BCom 3rd YEAR\SEN381\Project\RESOURCES\phone_call_ringtone.wav");
        //This is a global list of calls
        List<calls> completeCall = new List<calls>();
        public incoming_call()
        {
            InitializeComponent();
        }
        public incoming_call(List<calls> callList)
        {
            InitializeComponent();

            //Initialize the global call list declared at the top of the script
            completeCall = callList;

            //This is to start the call ringtone - START
            player.PlayLooping();
            //This is to start the call ringtone - END

            string clientIndi = callList[0].IndiID;
            string clientBusi = callList[0].BusiID;

            if (clientIndi == "" || clientIndi == null)
            {
                lblUserID.Text = clientBusi;
            }
            else if (clientBusi == "" || clientBusi == null)
            {
                lblUserID.Text = clientIndi;
            }

            lblUsername.Text = callList[0].CallTime;
        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            player.Stop();
            this.Close();
            phone_call pc = new phone_call("Answered", completeCall);
            pc.Show();
        }

        private void BtnCancelCall_Click(object sender, EventArgs e)
        {
            //Hide this form
            this.Close();

            //Insert call details in database
            sendDB.insert_Call(completeCall, "Canceled");

            //Stop the call ringtone
            player.Stop();

            //Code to be done when a call is canceled - START
            common.alertt("Canceled Call");
            //Code to be done when a call is canceled - END
        }
    }
}
