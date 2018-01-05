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
    public partial class AdminLogin : Form
    {
        Form1 form;
        public List<Doktor> doktorlar;
        public List<Randevular> randevu = new List<Randevular>();
        public List<Doktor> doktorliste = new List<Doktor>();
        public AdminLogin(Form1 f1)
        {
            form = f1;
            this.randevu =form.randevu;
            this.doktorliste = form.doktorliste;
            InitializeComponent();
            
        }
       
        
        private void btndoktor_Click(object sender, EventArgs e)
        {
            DoktorEkle doktor = new DoktorEkle(this);
            this.Hide();
            doktor.Show();
        }
        
        private void AdminLogin_Load(object sender, EventArgs e)
        {
            lbladmin.Text = "Merhaba  Admin ";
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }

        private void btntrandevugor_Click(object sender, EventArgs e)
        {
            AdminRandevuGor admingor = new AdminRandevuGor(this);
            admingor.Show();
        }
    }
}
