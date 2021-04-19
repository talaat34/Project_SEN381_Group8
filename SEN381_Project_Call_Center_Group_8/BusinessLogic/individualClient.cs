using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_Project_Call_Center_Group_8
{
    class individualClient
    {
        private string id;
        private string name;
        private string surname;
        private string role;
        private int verified;
        private string username;
        private string password;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Role { get => role; set => role = value; }
        public int Verified { get => verified; set => verified = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public individualClient()
        {

        }
        public individualClient(string id, string name, string surname, string role,  string userName)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.role = role;
            this.username = userName;
        }
        public individualClient(string id, string name, string surname, string role, int verifi, string userName, string pass)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.role = role;
            this.verified = verifi;
            this.username = userName;
            this.password = pass;
        }

        public override string ToString()
        {
            return string.Format("ID: {0} - Name: {1} - Surname: {2} - Role: {3} - Verified: {4} - Username: {4} - Password: {5}", id, name, surname, role, verified, username, password);
        }
        public override bool Equals(object obj)
        {
            individualClient indClient = obj as individualClient;
            if (indClient == null)
            {
                return false;
            }
            else
            {
                return this.Id.Equals(indClient.Id);
            }
        }

        public override int GetHashCode()
        {
            var hashCode = 1376368437;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Role);
            return hashCode;
        }
    }
}
