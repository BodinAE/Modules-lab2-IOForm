using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules_lab2_IOForm
{
    internal class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime? DoB { get; set; }
        public string Education { get; set; }
        
        public User(string login, string password, string name, string lastname, DateTime? dob, string education)
        {
            Login = login;
            Password = password;
            Name = name;
            Lastname = lastname;
            DoB = dob;
            Education = education;
        }

        public override string ToString()
        {
            return Login;
        }
    }
}
