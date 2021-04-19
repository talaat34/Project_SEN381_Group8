using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8
{
    class Technician
    {
        string TechnicianID, TechnicianName, TechnicianSurname, ServiceTypeID, TechnicianUsername, TechnicianPassword;
        int TechnicianVerified;
        public Technician()
        {

        }
        public Technician(string technicianID, string technicianName, string technicianSurname, string serviceTypeID, int technicianVerified, string technicianUsername, string technicianPassword)
        {
            TechnicianID1 = technicianID;
            TechnicianName1 = technicianName;
            TechnicianSurname1 = technicianSurname;
            ServiceTypeID1 = serviceTypeID;
            this.TechnicianVerified1 = technicianVerified;
            this.TechnicianUsername1 = technicianUsername;
            this.TechnicianPassword1 = technicianPassword;
        }

        public string TechnicianID1 { get => TechnicianID; set => TechnicianID = value; }
        public string TechnicianName1 { get => TechnicianName; set => TechnicianName = value; }
        public string TechnicianSurname1 { get => TechnicianSurname; set => TechnicianSurname = value; }
        public string ServiceTypeID1 { get => ServiceTypeID; set => ServiceTypeID = value; }
        public int TechnicianVerified1 { get => TechnicianVerified; set => TechnicianVerified = value; }
        public string TechnicianUsername1 { get => TechnicianUsername; set => TechnicianUsername = value; }
        public string TechnicianPassword1 { get => TechnicianPassword; set => TechnicianPassword = value; }

        public override string ToString()
        {
            return string.Format("ID: {0} - Name: {1} - Surname: {2} - Service Type ID: {3} - Verified: {4} - Username: {5} - Password: {6}", TechnicianID, TechnicianName, TechnicianSurname, ServiceTypeID, TechnicianVerified, TechnicianUsername, TechnicianPassword);
        }
        public override bool Equals(object obj)
        {
            Technician tech = obj as Technician;

            if (tech == null)
            {
                return false;
            }
            else
            {
                return this.TechnicianID.Equals(tech.TechnicianID);
            }
        }
        public override int GetHashCode()
        {
            return this.TechnicianID.GetHashCode();
        }

    }
}
