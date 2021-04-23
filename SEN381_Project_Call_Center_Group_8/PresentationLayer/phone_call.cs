using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Media;

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
        SoundPlayer player = new SoundPlayer(@"C:\Users\user-pc\source\repos\Project_SEN381_Group8\RESOURCES\Outgoing_call_sound_effect.wav");
        Timer tm = new Timer();

        //Common Variables
        bool _playerOn = false;
        public phone_call()
        {
            InitializeComponent();
            common.delaySomeTime(1000, new Action(() => {
                _playerOn = true;
                player.Play();
            }));
        }
        /*Some Fields and Properties - START*/
        private string prev_form;

        public string Prev_form { get => prev_form; set => prev_form = value; }
        public phone_call(string prev_form)
        {
            InitializeComponent();
            common.delaySomeTime(1000, new Action(() => {
                _playerOn = true;
                player.Play();
            }));
            Prev_form = prev_form;
        }

        /*Some Fields and Properties - END*/

        private void BtnCancelCall_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (_playerOn == true)
            {
                _playerOn = false;
                player.Stop();
                if (prev_form == "yes")
                {
                    this.Close();
                    phone_dialer pd = new phone_dialer();
                    pd.Show();
                }
            }
        }

        private void RoundButton3_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void BtnVolHigh_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        private void BtnVolLow_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void Phone_call_Load(object sender, EventArgs e)
        {
            tm.Interval = 60000;
            tm.Tick += new EventHandler(BtnCancelCall_Click);
            tm.Start();
        }
    }
}
