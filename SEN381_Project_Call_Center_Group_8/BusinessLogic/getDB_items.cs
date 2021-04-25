using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
