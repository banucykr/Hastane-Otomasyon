using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevu.Models
{
    class ValidationManager
    {
        public bool ValidationField(string user, string pass)
        {
            if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass))
                return true;
            return false;


        }
    }
}
