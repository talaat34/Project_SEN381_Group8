using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8
{
    // Since in windows forms there is no the concept of sessions like web applications
    // We created this static class to store the logged in person's details so we can use their details across 
    // The entire application
    public static class loginPersonDetails
    {
        public static string id;
        public static string username;
        public static string password;
        //This will only be applied if a client logs in
        public static string clientType;
    }
}
