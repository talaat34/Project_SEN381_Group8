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
    public partial class InsertEquipment : UserControl
    {
        public InsertEquipment()
        {
            InitializeComponent();
        }


        getDB_items dbitem = new getDB_items();
        
        private void BtnInsertAdmin_Click(object sender, EventArgs e)
        {
            dbitem.SendEquipmentInsert(equipmentSerialID.Text,equipmentModelNumber.Text,equipmentName.Text);
        }
    }
}
