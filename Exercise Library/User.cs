using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Library
{
    class User
    {
        public string name { get; private set; }
        public string userID { get;private set; }

        public User(string name, string userID)
        {
            this.name = name;
            this.userID = userID;
        }
    }
}
