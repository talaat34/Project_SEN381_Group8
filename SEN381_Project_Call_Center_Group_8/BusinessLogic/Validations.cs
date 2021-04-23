using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8.BusinessLogic
{
    class Validations
    {
        //Objects 
        dbAcccess access = new dbAcccess();
        DataSet ds = new DataSet();

        string error_success_msg;
        public string initiateOutgoingCall(string phoneNumber)
        {
            if (phoneNumber == "")
            {
                error_success_msg = "A phone number can not be empty.\nPlease enter the client phone number";
            }
            else if(phoneNumber.Length < 10 || phoneNumber.Length > 10)
            {
                error_success_msg = "The phone number's length must be exactly 10 numbers.";
            }
            else if (!phoneNumber.StartsWith("0"))
            {
                error_success_msg = "A phone number must start with a ZERO(0)";
            }
            else
            {
                string tableName = "phoneNumber";
                string colName = "phoneNumber";
                ds = access.searchForData(tableName, colName, phoneNumber, "");
                if (ds.Tables[0].Rows.Count >= 1)
                {
                    string pNumber = ds.Tables[0].Rows[0][1].ToString();
                    string clientNumber = ds.Tables[0].Rows[0][2].ToString();
                    string cleintType = ds.Tables[0].Rows[0][3].ToString();

                    error_success_msg = pNumber + clientNumber + cleintType;
                }
                else
                {
                    error_success_msg = "There is not user with the given phone number";
                }
            }

            return error_success_msg;
        }
    }
}
