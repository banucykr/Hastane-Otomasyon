using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevu.Models
{
    public partial class DoktorEkle : Form
    {

        AdminLogin adminlogin;
     
        public List<Doktor> doktorlarliste=new List<Doktor>();
    
        public DoktorEkle(AdminLogin admin)
        {
            adminlogin = admin;
            this.doktorlarliste = adminlogin.doktorliste;
           
            InitializeComponent();
        }

      
        Doktor doktor = new Doktor();
        private void btnkayit_Click(object sender, EventArgs e)
        {
           
            doktor.FullName = txtdoktor.Text;
            
            doktorlarliste.Add(doktor);

            adminlogin.Show();
            this.Hide();

        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
