using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXProject
{
    class User
    {
        public string Name;
        public string Password;
        public bool isAdmin;

        public User(string name, string pass)
        {
            Name = name;
            Password = pass;
            if (Name == "Admin") isAdmin = true;
        }
    }
}
