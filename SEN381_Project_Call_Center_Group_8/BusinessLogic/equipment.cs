using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8.BusinessLogic
{
    class equipment
    {
        private string name;
        private string serialNr;
        private string modelNr;

        public equipment(string serialNr, string modelNr, string name)
        {
            SerialNr = serialNr;
            ModelNr = modelNr;
            Name = name;
        }

        public string SerialNr { get => serialNr; set => serialNr = value; }
        public string ModelNr { get => modelNr; set => modelNr = value; }
        public string Name { get => name; set => name = value; }
    }
}
