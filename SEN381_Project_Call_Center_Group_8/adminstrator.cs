using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8
{
    class adminstrator
    {
        //FIELDS
        private string id;
        private string name;
        private string surname;
        private int verified;
        private string username;
        private string password;

        //PROPERTIES
        public string ID { get { return id; } set { this.id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set {surname = value; } }
        public int Verified { get { return verified; } set { verified = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Username { get => username; set => username = value; }


        //CONSTRUCTORS
        public adminstrator()
        {

        }
        public adminstrator(string iD, string nm, string surnm, int verify, string usernm, string pass)
        {
            this.ID = iD;
            this.Name = nm;
            this.Surname = surnm;
            this.Verified = verify;
            this.username = usernm;
            this.Password = pass;
        }

        //OVERRIDE METHOD(S)
        public override string ToString()
        {
            return string.Format("ID: {0} - Name: {1} - Surname: {2} - Verified: {3} - Password: {4}", ID.ToString(), Name, Surname, Verified ,Password);
        }
        public override bool Equals(object obj)
        {
            adminstrator admin = obj as adminstrator;
            if (admin == null)
            {
                return false;
            }
            else
            {
                return this.ID.Equals(admin.ID);
            }
        }
        public override int GetHashCode()
        {
            return id.GetHashCode() + name.GetHashCode() + surname.GetHashCode() + verified.GetHashCode() + password.GetHashCode();
        }
    }
}
