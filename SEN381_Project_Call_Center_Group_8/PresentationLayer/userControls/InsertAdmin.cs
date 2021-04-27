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
    public partial class InsertAdmin : UserControl
    {
        public InsertAdmin()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        getDB_items dbitem = new getDB_items();
        private void BtnInsertAdmin_Click(object sender, EventArgs e)
        {
            dbitem.SendAdminInsert(AdminID.Text, AdminName.Text, AdminSurname.Text, AdminUsername.Text, AdminPassword.Text);
           

        }
       
       
    }
}
