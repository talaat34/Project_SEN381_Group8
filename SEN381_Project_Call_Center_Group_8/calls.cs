using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8
{
    class calls
    {
        //THIS IS FOR COMMON OBJECTS THAT WILL BE USED
        dbAcccess access = new dbAcccess();
        commonMethods common = new commonMethods();
        Random rand = new Random();





        private string callID;
        private string callLength;
        private string callTime;
        private string callStatus;
        private string indiID;
        private string busiID;
        private string empID;

        
        public string CallLength { get => callLength; set => callLength = value; }
        public string CallTime { get => callTime; set => callTime = value; }
        public string IndiID { get => indiID; set => indiID = value; }
        public string BusiID { get => busiID; set => busiID = value; }
        public string CallID { get => callID; set => callID = value; }
        public string EmpID { get => empID; set => empID = value; }
        public string CallStatus { get => callStatus; set => callStatus = value; }

        public calls()
        {

        }
        public calls(string callID, string callLength, string callTime, string callStatus, string indiID, string busiID, string empID)
        {
            CallID = callID;
            CallLength = callLength;
            CallTime = callTime;
            CallStatus = callStatus;
            IndiID = indiID;
            BusiID = busiID;
            EmpID = empID;
        }

        public override string ToString()
        {
            if (this.busiID == null)
            {
                return string.Format("Call ID: {0} - Call Length: {1} - Call Time: {2} - Call Status: {3} - Individual Client ID: {4} - Employee ID: {5}", callID, callLength, callTime, callStatus,indiID, empID);
            }
            else
            {
                return string.Format("Call ID: {0} - Call Length: {1} - Call Time: {2} - Call Status: {3} - Business Client ID: {4} - Employee ID: {5}", callID, callLength, callTime, callStatus, busiID, empID);
            }
           
        }
        public override bool Equals(object obj)
        {
            calls cls = obj as calls;
            if (cls == null)
            {
                return false;
            }
            else
            {
                return this.callID.Equals(cls.callID);
            }
        }
        public override int GetHashCode()
        {
            return this.callID.GetHashCode();
        }


        //THIS METHOD WILL BE USED TO GENERATES A RANDOM CALL
        public List<calls> generateCall(string employeeID)
        {
            //This is for the call Satus
            string callStat = null;

            //Checking the return type of the client
            var returnType = access.getClientInfo();
            string name = returnType.GetType().FullName;
            if (name.Contains("BusinessClient"))
            {
                

                //this is for making the call id
                string callID = common.generateID(10);

                //This is for the getting the call length
                int randomNumber = rand.Next(0, 20);
                string callLength = randomNumber.ToString();

                //THIS IS FOR GETTING THE TIME
                DateTime time = DateTime.Now;
                string callTime = DateTime.Now.ToString("yyyy-MM-dd - h:mm:ss tt");

                // THIS IS FOR GETTING A RANDOM USER'S ID
                var client = access.getClientInfo();
                int index = rand.Next(client.Count);
                string busiClientID = client[index].Id;

                //This is the businessID 
                //In this case it will be null for now
                string clientId = null;


                //GENERATING LIST FOR RETURN
                List<calls> callDetails = new List<calls>();
                callDetails.Add(new calls(callID, callLength, callTime, callStat, clientId, busiClientID, employeeID));
                return callDetails;
            }
            else
            {
                //this is for making the call id
                string callID = common.generateID(10);

                //This is for the getting the call length
                int randomNumber = rand.Next(0, 20);
                string callLength = randomNumber.ToString();

                //THIS IS FOR GETTING THE TIME
                DateTime time = DateTime.Now;
                string callTime = DateTime.Now.ToString("yyyy-MM-dd - h:mm:ss tt");

                // THIS IS FOR GETTING A RANDOM USER'S ID
                var client = access.getClientInfo();
                int index = rand.Next(client.Count);
                string clientId = client[index].Id;

                //This is the businessID 
                //In this case it will be null for now
                string busiClientID = null;


                //GENERATING LIST FOR RETURN
                List<calls> callDetails = new List<calls>();
                callDetails.Add(new calls(callID, callLength, callTime, callStat, clientId, busiClientID, employeeID));
                return callDetails;
            }
            
        }
    }
}
