using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace HastaneRandevu.Models
{
   public class Doktor
    {
        public string FullName;
       
        public Doktor()
        {
        }

        public Doktor(string fullname)
        {
            FullName = fullname;

        }
        public override string ToString()
        {
            return $" {FullName} ";
        }

    }
}
