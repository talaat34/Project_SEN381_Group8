using System;

namespace SEN381_Project_Call_Center_Group_8
{
    public class call
    {
        private string callLength;
        private string callTime;
        private string indiID;
        private string busiID;
        private string empiID;



        public string CallLength { get => callLength; set => callLength = value; }
        public string CallTime { get => callTime; set => callTime = value; }
        public string IndiID { get => indiID; set => indiID = value; }
        public string BusiID { get => busiID; set => busiID = value; }
        public string EmpID { get => empiID; set => empiID = value; }

        public call()
        {

        }
        public call(string length, string time, string indID, string busID, string empID)
        {
            this.callLength = length;
            this.callTime = time;
            this.indiID = indID;
            this.busiID = busID;
            this.empiID = empID;
        }

        public override string ToString()
        {
            return string.Format("Length: {0} - Time: {1} - IndividualID: {2} - BusinessID: {3} - EmployeeID: {4}", callLength, CallTime, IndiID, busiID, empiID);
        }

        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Point p = (Point)obj;
                return (x == p.x) && (y == p.y);
            }
        }

        public override int GetHashCode()
        {
            return CallLength ^ callTime ^ indiID ^ busiID * empiID;
        }
    }

}


