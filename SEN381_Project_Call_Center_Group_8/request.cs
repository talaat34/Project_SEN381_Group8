using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8
{
    class request
    {
        private string id;
        private string requestIssue;
        private string clientType;
        private string clientID;
        private string callEmpID;
        private bool completed;
        private bool accepted;
        private string acceptedTechnicianID;

        public request()
        {

        }
        public request(string id, string requestIssue, string clientType, string clientID, string callEmpID, bool completed, bool accepted, string acceptedTechnicianID)
        {
            this.id = id;
            this.requestIssue = requestIssue;
            this.clientType = clientType;
            this.clientID = clientID;
            this.callEmpID = callEmpID;
            this.completed = completed;
            this.accepted = accepted;
            this.acceptedTechnicianID = acceptedTechnicianID;
        }

        public string Id { get => id; set => id = value; }
        public string RequestIssue { get => requestIssue; set => requestIssue = value; }
        public string ClientType { get => clientType; set => clientType = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string CallEmpID { get => callEmpID; set => callEmpID = value; }
        public bool Completed { get => completed; set => completed = value; }
        public bool Accepted { get => accepted; set => accepted = value; }
        public string AcceptedTechnicianID { get => acceptedTechnicianID; set => acceptedTechnicianID = value; }

        public string generateUserIssue()
        {
            List<string> userIssue = new List<string>();
            userIssue.Add("Long Wait on Hold");
            userIssue.Add("Unavailable or Out of Stock Product");
            userIssue.Add("Repeating the Customer's Problem");
            userIssue.Add("Uninterested Service Rep");
            userIssue.Add("Poor Product or Service");
            userIssue.Add("No First Call Resolution");
            userIssue.Add("Lack of Follow Up");
            userIssue.Add("New Product or Feature Request");
            userIssue.Add("I keep getting shuffled from one person to the next.");
            userIssue.Add("You don’t seem to care.");
            userIssue.Add("I bought your product but it doesn’t do what it’s supposed to do.");
            userIssue.Add("I talked to someone else and they were no help.");
            userIssue.Add("Well, your competitors said they would do this…");


            Random random = new Random();
            int index = random.Next(userIssue.Count);

            string issue = userIssue[index];
            return issue;
        }
    }
}
