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

namespace SEN381_Project_Call_Center_Group_8.PresentationLayer
{
    public partial class phone_dialer : Form
    {
        //Objects
        BusinessLogic.Validations vl = new BusinessLogic.Validations();


        /*This Dll is used to make the forms's corners round - START*/
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        /*This Dll is used to make the forms's corners round - START*/
        public phone_dialer()
        {
            InitializeComponent();

            /*This is to make the forms's corners round - START*/
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            /*This is to make the forms's corners round - START*/

            /*This is to make the textbox transparent - START*/
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            txtClientID.BackColor = this.BackColor;
            /*This is to make the textbox transparent - END*/
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoundButton1_Click(object sender, EventArgs e)
        {
            string number = "1";
            txtClientID.Text = txtClientID.Text + number;
        }

        private void BtnNumberTwo_Click(object sender, EventArgs e)
        {
            string number = "2";
            txtClientID.Text = txtClientID.Text + number;
        }

        private void BtnNumberThree_Click(object sender, EventArgs e)
        {
            string number = "3";
            txtClientID.Text = txtClientID.Text + number;
        }

        private void BtnNumberFour_Click(object sender, EventArgs e)
        {
            string number = "4";
            txtClientID.Text = txtClientID.Text + number;
        }

        private void BtnNumberFive_Click(object sender, EventArgs e)
        {
            string number = "5";
            txtClientID.Text = txtClientID.Text + number;
        }

        private void BtnNumberSix_Click(object sender, EventArgs e)
        {
            string number = "6";
            txtClientID.Text = txtClientID.Text + number;
        }

        private void BtnNumberSeven_Click(object sender, EventArgs e)
        {
            string number = "7";
            txtClientID.Text = txtClientID.Text + number;
        }

        private void BtnNumberEight_Click(object sender, EventArgs e)
        {
            string number = "8";
            txtClientID.Text = txtClientID.Text + number;
        }

        private void BtnNumberNine_Click(object sender, EventArgs e)
        {
            string number = "9";
            txtClientID.Text = txtClientID.Text + number;
        }

        private void BtnNumberZero_Click(object sender, EventArgs e)
        {
            string number = "0";
            txtClientID.Text = txtClientID.Text + number;
        }

        private void BtnDeleteNumber_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtClientID.Text;
            string newPhoneNumber = phoneNumber.Remove(phoneNumber.Length -1, 1);
            txtClientID.Text = newPhoneNumber;
        }

        private void TxtClientID_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = txtClientID.Text;
            if (phoneNumber == "")
            {
                btnDeleteNumber.Enabled = false;
            }
            else
            {
                btnDeleteNumber.Enabled = true;
            }
        }

        private void BtnCall_Click(object sender, EventArgs e)
        {
            //Since this is the client there will be no phone numbers required
            //as he or she will be calling the call center and the call center will have
            //One constant number whiche is 012-222-3333

            //this.Hide();-
            //phone_call ph = new phone_call("yes");
            //ph.Show();
            //string phoneNumber = txtClientID.Text;
            //string res = vl.initiateOutgoingCall(phoneNumber);
            //if (true)
            //{

            //}
            //else
            //{

            //}
        }
    }
}
