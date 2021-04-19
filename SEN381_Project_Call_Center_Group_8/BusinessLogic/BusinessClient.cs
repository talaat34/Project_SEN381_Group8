using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8
{
    class BusinessClient
    {
        string businessID, buinessName, businessLocation, businessEmail, ServiceTypeID, username, password;
        int verified;
        
        public BusinessClient()
        {

        }
        public BusinessClient(string ID, string username)
        {
            this.businessID = ID;
            this.username = username;
        }

        public BusinessClient(string businessID, string buinessName, string businessLocation, string businessEmail, string serviceTypeID)
        {
            this.Id = businessID;
            this.BuinessName = buinessName;
            this.BusinessLocation = businessLocation;
            this.BusinessEmail = businessEmail;
            ServiceTypeID1 = serviceTypeID;
        }

        public BusinessClient(string businessID, string buinessName, string businessLocation, string businessEmail, int verified, string username, string password)
        {
            this.businessID = businessID;
            this.buinessName = buinessName;
            this.businessLocation = businessLocation;
            this.businessEmail = businessEmail;
            this.verified = verified;
            this.username = username;
            this.password = password;
        }

        public string Id { get => businessID; set => businessID = value; }
        public string BuinessName { get => buinessName; set => buinessName = value; }
        public string BusinessLocation { get => businessLocation; set => businessLocation = value; }
        public string BusinessEmail { get => businessEmail; set => businessEmail = value; }
        public string ServiceTypeID1 { get => ServiceTypeID; set => ServiceTypeID = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Verified { get => verified; set => verified = value; }

        public override string ToString()
        {
            return string.Format("ID: {0} - Name: {1} - Email: {2} - Location: {3} - Verified: {4} - Username: {5} - Password: {6}", businessID, BuinessName, businessEmail, businessLocation, verified, username, password);
        }
        public override bool Equals(object obj)
        {
            BusinessClient busiClient = obj as BusinessClient;
            //Check for null and compare run-time types.
            if (busiClient == null)
            {
                return false;
            }
            else {
                return this.businessID.Equals(busiClient.businessID);
            }
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

    }
}


