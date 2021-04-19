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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        int startPos = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblPercentage.Text = startPos.ToString() + "%";
            startPos += 1;
            startProgress.Value = startPos;
            if (startProgress.Value == 100)
            {
                startProgress.Value = 0;
                timer1.Stop();
                this.Hide();
                login log = new login();
                log.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
