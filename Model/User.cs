using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RepeatProject.Model
{
	public class User
	{
        public int Id { get; set; }

        public string Username { get; set; }
        public String Password { get; set; }

        public User() { }

        public User(String Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }


        public bool CheckInformation()
        {
            // if the username and password is empty, return true. if not return false.
            //return !this.Username.Equals("") && !this.Password.Equals("") ? true : false;

            if (!this.Username.Equals("") || !this.Password.Equals(""))
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
