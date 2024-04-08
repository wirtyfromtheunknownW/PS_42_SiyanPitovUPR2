using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    internal class User
    {
        public string Name { get;  set; }
        public string Password { get;  set; }
        public UserRolesEnum Roles { get;  set; }
        

        public User(string name,string pass, UserRolesEnum role)
        {
            Name = name;
            Password= pass;
            Roles= role;
            
        }

    }
}
