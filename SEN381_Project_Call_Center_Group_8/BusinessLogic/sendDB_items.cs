using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8.BusinessLogic
{
    class sendDB_items
    {
        dbAcccess access = new dbAcccess();
        public void insert_Call(List<calls> callList, string callStat)
        {
            access.insertCall(callList, callStat);
        }
    }
}
