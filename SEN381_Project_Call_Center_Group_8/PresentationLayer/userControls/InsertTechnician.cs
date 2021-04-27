using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEN381_Project_Call_Center_Group_8.BusinessLogic;

namespace SEN381_Project_Call_Center_Group_8.PresentationLayer.userControls
{
    public partial class InsertTechnician : UserControl
    {
        public InsertTechnician()
        {
            InitializeComponent();
        }
        getDB_items dbitem = new getDB_items();
        private void BtnInsertAdmin_Click(object sender, EventArgs e)
        {
            dbitem.SendTechnicianInsert(TechnicianID.Text, TechnicianName.Text, TechnicianSurname.Text, TechnicianServiceID.Text, Int32.Parse(TechnicianVerified.Text), TechnicianUsername.Text, TechnicianPassword.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
