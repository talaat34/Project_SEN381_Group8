using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8
{
    class serviceTier
    {
        string ServiceTierID, ServiceTierpromotion, ServiceTierDescription;
        float ServiceTierCost;

        public serviceTier(string serviceTierID, string serviceTierpromotion, string serviceTierDescription, float serviceTierCost)
        {
            ServiceTierID1 = serviceTierID;
            ServiceTierpromotion1 = serviceTierpromotion;
            ServiceTierDescription1 = serviceTierDescription;
            ServiceTierCost1 = serviceTierCost;
        }

        public string ServiceTierID1 { get => ServiceTierID; set => ServiceTierID = value; }
        public string ServiceTierpromotion1 { get => ServiceTierpromotion; set => ServiceTierpromotion = value; }
        public string ServiceTierDescription1 { get => ServiceTierDescription; set => ServiceTierDescription = value; }
        public float ServiceTierCost1 { get => ServiceTierCost; set => ServiceTierCost = value; }
        public override string ToString()
        {
            return string.Format("ID: {0} - Promotion: {1} - Description: {2} - Cost: {3}", ServiceTierID, ServiceTierpromotion, ServiceTierDescription, ServiceTierCost);
        }
        public override bool Equals(object obj)
        {
            serviceTier ser = obj as serviceTier;
            if (ser == null)
            {
                return false;
            }
            else
            {
                return this.ServiceTierID.Equals(ser.ServiceTierID);
            }

        }
        public override int GetHashCode()
        {
            return ServiceTierID.GetHashCode() * ServiceTierCost.GetHashCode();
        }
    }
}