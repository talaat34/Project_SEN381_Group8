using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Media;
using System.Collections.Generic;
using System.Data;

namespace SEN381_Project_Call_Center_Group_8.PresentationLayer
{
    public partial class phone_call : Form
    {
        /*This part involve muting, rising, and lowering the sound - START*/
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);
        /*This part involve muting, rising, and lowering the sound - END*/

        //OBJECTS
        commonMethods common = new commonMethods();
        BusinessLogic.getDB_items getDB_Items = new BusinessLogic.getDB_items();
        BusinessLogic.sendDB_items sendDB_Items = new BusinessLogic.sendDB_items();
        SoundPlayer player = new SoundPlayer(@"C:\Users\user-pc\source\repos\Project_SEN381_Group8\RESOURCES\Outgoing_call_sound_effect.wav");
        Timer tm = new Timer();
        List<SoundPlayer> conversation = new List<SoundPlayer>();
        SoundPlayer issuePlayer;

        //Common Variables
        bool _playerOn = false;
        bool _conversationOn = false;

        //THIS INVOLVES THE DETAILS OF THE CALL
        string callID, callTime, indiID, busiID, empID, requestID;
        int callLength = 0;

        /*Some Fields and Properties - START*/
        private string prev_form;
        private string clientID;
        private string callStat;

        public string Prev_form { get => prev_form; set => prev_form = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string CallStat { get => callStat; set => callStat = value; }

        //paramertarized constructor
        public phone_call(string prev_form, string clientID)
        {
            InitializeComponent();

            //Loading the conversation between customer and employee
            conversation = common.customer_employee_conversation();

            //This is to delay some time 
            //Because if a play the calloing ringtone right away the phone_call form
            //never appears until the ringtone is stopped/finshed
            common.delaySomeTime(1000, new Action(() => {

                //This variable will be used to detect if the player is on or not
                //So that when the user clicks on the cancel call button
                //The player is stopped when the form closes
                _playerOn = true;

                player.Play();
            }));

            //The prevois form will be used to navigate back to the previos form if it was closed
            Prev_form = prev_form;
            ClientID = clientID;

            //Setting the client id to the 'label user id'
            lblUserID.Text = ClientID;

            //Here i will generate a random number 
            //IF the generated number is between 0 AND 11 
            //===> Then the callStat will be regarded as answered.
            //Else if the generated number is between 10 and 10
            //===> Then the callStat will be regarded as notAnswered
            int randomNumber = common.generateRandomNumber(1, 21);
            if (randomNumber <= 10)
            {
                CallStat = "Answered";
            }
            else
            {
                CallStat = "Canceled";
            }
        }
        //non paramertarized constructor
        public phone_call()
        {
            InitializeComponent();

            //Loading the conversation between customer and employee
            conversation = common.customer_employee_conversation();

            //This is to delay some time 
            //Because if a play the calloing ringtone right away the phone_call form
            //never appears until the ringtone is stopped/finshed
            common.delaySomeTime(1000, new Action(() => {

                //This variable will be used to detect if the player is on or not
                //So that when the user clicks on the cancel call button
                //The player is stopped when the form closes
                _playerOn = true;

                player.Play();
            }));

            //Here i will generate a random number 
            //IF the generated number is between 0 AND 11 
            //===> Then the callStat will be regarded as answered.
            //Else if the generated number is between 10 and 10
            //===> Then the callStat will be regarded as notAnswered
            int randomNumber = common.generateRandomNumber(1, 21);
            if (randomNumber <= 10)
            {
                CallStat = "Answered";
            }
            else
            {
                CallStat = "Canceled";
            }
        }
        /*Some Fields and Properties - END*/

        private void Phone_call_Load(object sender, EventArgs e)
        {
            //Check the callStat <= varibale explained on line 62 to 66
            if (CallStat == "Answered")
            {
                tm.Interval = 10000;
                tm.Tick += new EventHandler(answerTheCall);
                tm.Start();
            }
            else if (CallStat == "Canceled")
            {
                tm.Interval = 6000;
                tm.Tick += new EventHandler(BtnCancelCall_Click);
                tm.Start();
            }

        }
        private void BtnCancelCall_Click(object sender, EventArgs e)
        {
            //We have to do insertion of data when the call is cancelled
            //Insert the call Into database - START
            insertCall("Not-Answered");
            //Insert the call Into database - END

            if (_playerOn == true)
            {
                _playerOn = false;
                player.Stop();
                if (prev_form == "client")
                {
                    this.Hide();
                    clientDashboard cd = new clientDashboard();
                    cd.Show();
                }
                else if (prev_form == "adminstrator")
                {
                    this.Hide();
                    callCenterDashoard ccd = new callCenterDashoard();
                    ccd.Show();
                }
                else
                {
                    MessageBox.Show("The player has finished");
                }
            }
            else if (_conversationOn == true)
            {
                issuePlayer.Stop();
            }
        }

        //THIS METHOD WILL BE USED TO ANSWER THE CALL
        //FIRST I WILL CLOSE THE CURRENT PLAYER AND THEN PLAY 
        //A CALL_CENTER-CUSTOMER LIKE CONVERSATION
        //AND THEN INSERT DETAILS IN CALL TABLE IN DATABASE
        public void answerTheCall(object sender, EventArgs e)
        {
            if (_playerOn == true)
            {
                //Stoping the first Player
                _playerOn = false;
                player.Stop();

                //Tell The user that the call will be recorded for safety purposes :)
                common.alertt("Please note that the call will be Recorded for security Purposes.");

                //Then we start a new player with the conversation between the call center employee
                //and the customer
                int conversationIndex = common.generateRandomColectionNumber(conversation.Count);
                issuePlayer = conversation[conversationIndex];
                _conversationOn = true;

                //Insert the call Into database - START
                insertCall("Answered");
                //Insert the call Into database - END

                //Insert the call Into database - START
                issuePlayer.Play();

            }
        }

        /*THIS IS FOR INSERTING THE CALL*/
        public void insertCall(string clStat)
        {
            callID = common.generateID(10);
            callLength = common.generateRandomNumber(0, 30);
            string actuallCallLength = callLength.ToString() + " min";
            callTime = common.date_time();
            //CallStat already declared above
            if (loginPersonDetails.clientType == "clientIndividual")
            {
                indiID = clientID;
                busiID = null;
            }
            else if (loginPersonDetails.clientType == "businessClient")
            {
                busiID = clientID;
                indiID = null;
            }
            //Getting a random call venter empoloyee's ID - START
            string tableName = "adminstrators";
            string colName = "id";
            List<DataRow> dr = getDB_Items.getCol_data(tableName, colName);
            int randIndex = common.generateRandomColectionNumber(dr.Count);
            if (clStat == "Answered")
            {
                empID = dr[randIndex][0].ToString();
            }
            else
            {
                empID = "";
            }
            //Getting a random call venter empoloyee's ID - END
            calls cls = new calls(callID, actuallCallLength, callTime, CallStat, indiID, busiID, empID);
            List<calls> callList = new List<calls>();
            callList.Add(cls);
            //insert the actual call
            sendDB_Items.insert_Call(callList, clStat);
        }

        //This is for muting, highering, lowering the sound
        //Mute
        private void RoundButton3_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }
        //Increase volume
        private void BtnVolHigh_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);
        }
        //Lower Volume
        private void BtnVolLow_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

    }
}
