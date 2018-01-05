using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevu.Models
{
   public class User
    {
       
        public string Username;
        public string Password;
        public Admin AName;
        public string Names;
        public string Lastname;
        public string ImagePath;
        public User( string username,string password)
        {
            
            Username = username;
            Password = password;
         
        }

        public User()
        {
        }
    }
}
