using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevu.Models
{
   public class Admin
    {

        public string Username;
        public string Password;


        public bool AdminField(string username, string password)
        {
            
            if (username == "Admin" && password== "789")
                return true;
            return false;

        }

    }
}