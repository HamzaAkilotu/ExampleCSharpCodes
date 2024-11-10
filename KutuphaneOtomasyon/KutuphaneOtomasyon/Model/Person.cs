using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.Model
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public DateTime creationDate { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string permission { get; set; }
        public Person()
        {

        }
        public Person(int id, string name, string lastName, DateTime creationDate, string userName, string password, string permission)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.creationDate = creationDate;
            this.userName = userName;
            this.password = password;
            this.permission = permission;
        }
        public void setId(int id) { this.id = id; }
        public int getId() { return this.id; }
        public void setName(string name) { this.name = name; }
        public string getName() { return this.name; }
        public void setLastName(string lastName) { this.lastName = lastName; }
        public string getLastName() { return this.lastName; }
        public void setCreationDate(DateTime creationDate) { this.creationDate = creationDate; }
        public DateTime getCreationDate() { return this.creationDate; }
        public void setUserName(string userName) { this.userName = userName; }
        public string getUserName() { return this.userName; }
        public void setPassword(string password) { this.password = password; }
        public string getPassword() { return this.password; }
        public void setPermission(string permission) { this.permission = permission; }
        public string getPermission() { return this.permission; }
        public override string ToString()
        {
            return "Name and Lastname" + this.name + " " + this.lastName;
        }
    }
}
