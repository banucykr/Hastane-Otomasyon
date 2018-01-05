using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevu.Models
{
   public class Randevular
    {
        public Randevular(string rahatsizlik,string doktor,DateTime tarih)
        {
            Rahatsizlik = rahatsizlik;
            Tarih = tarih;
            Doktorname = doktor;


        }

        public Randevular()
        {
        }

        public string name;
        public string lastname;
        public string Rahatsizlik;
        public string Doktorname;
        public DateTime Tarih;

        public override string ToString()
        {
            return $"{Rahatsizlik}  {Tarih}";
        }



    }
    
}
