using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class User : Person
    {
        private string _email;
        private string _password;
        public string Email { get { return _email; } set { _email = value.Contains("@") ? value : string.Empty; } }
        public string Password
        {
             get { return _password; }
             set {
                if (value.Length > 4)
                {
                    _password = value;

                }
                else if(value.Length > 4)
                {
                    throw new InvalidPasswordException("Password includes not enough characters!");
                }
            } 
        }
        public UserType userType { get; set; }
      
    }
    }

