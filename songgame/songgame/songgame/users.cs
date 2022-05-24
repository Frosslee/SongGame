using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songgame
{
    class Users
    {
        //fields
        private string username;
        private string password;
        //properties
        public string Username { get; set; }
        public string Password { get; set; }

        //constructor
        public Users(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        //methods

        public bool validateuser()
        {

            if (Username == "admin" && Password=="1234")
            {

                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
