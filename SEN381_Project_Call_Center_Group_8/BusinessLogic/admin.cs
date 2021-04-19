using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8
{
    class admin
    {
        private string id;
        private string name;
        private string surname;
        private string username;
        private string password;
        
        /*Properties*/
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        
        /*Constructors*/
        public admin()
        {
        }
        public admin(string id, string name, string surname, string username, string password)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.username = username;
            this.password = password;
        }

        /*Overrides*/
        public override string ToString()
        {
            return string.Format("ID: {0} - Name: {1} - Surname: {2} - Username: {3} - Password: {4}", Id, Name, Surname, Username, Password);
        }
        public override bool Equals(object obj)
        {
            admin ad = obj as admin;
            if (ad == null)
            {
                return false;
            }
            else
            {
                return this.Id.Equals(ad.Id);
            }
        }
        public override int GetHashCode()
        {
            return id.GetHashCode() + name.GetHashCode() + surname.GetHashCode() + username.GetHashCode() + password.GetHashCode();
        }
    }
}
