using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN381_Project_Call_Center_Group_8.PresentationLayer.userControls
{
    public partial class AdminDashboard_INSERT : UserControl
    {
        public AdminDashboard_INSERT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void AdminDashboard_INSERT_Load(object sender, EventArgs e)
        {

        }
        
        
        private void insertAdmin1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Admin")
            {
                insertAdmin1.Visible = true;
                insertEquipment1.Visible = false;
                insertTechnicians1.Visible = false;

               // insert

            }
            else
            if (comboBox1.Text == "Technician")
            {
                insertAdmin1.Visible = false;
                insertEquipment1.Visible = false;
                insertTechnicians1.Visible = true;
            }
            else
            if (comboBox1.Text == "Equipment")
            {
                insertAdmin1.Visible = false;
                insertEquipment1.Visible = true;
                insertTechnicians1.Visible = false;
            }
           


        }
    }
}
