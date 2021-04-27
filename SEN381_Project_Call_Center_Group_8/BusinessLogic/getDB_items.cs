using SEN381_Project_Call_Center_Group_8.PresentationLayer.userControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace SEN381_Project_Call_Center_Group_8.BusinessLogic
{
    class getDB_items
    {
        dbAcccess access = new dbAcccess();
        DataSet ds;
        public List<DataRow> getCol_data(string tableName, string colName)
        {
            List<DataRow> colData = new List<DataRow>();
            ds = access.getColumnData(tableName, colName);
            colData = ds.Tables[0].AsEnumerable().ToList();
            return colData;
        }

        
        
        public  void SendAdminInsert(string ID, string Name, string Surname, string Username, string Password)
        {
            admin adminInsert = new admin(ID,Name,Surname,Username,Password);
            access.AdminAdd(adminInsert);
           
        }
        public void SendTechnicianInsert(string ID, string Name, string Surname,string ServiceID,int Verified,string Username, string Password)
        {
            Technician TechnicianInsert = new Technician(ID, Name, Surname,ServiceID,Verified, Username, Password);

            access.TechnicianAdd(TechnicianInsert);

        }

        public void SendEquipmentInsert(string Serial, string Model, string Name)
        {
            equipment equipmentInsert = new equipment(Serial, Model, Name);
            

        }
    }
}
