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
    public partial class Randevu : Form
    {
        public Form1 form;
        public List<Randevular> randevu = new List<Randevular>();
        public List<Doktor> doktorliste = new List<Doktor>();
        public User user;
        public Randevular randevual;
        public Doktor doktorlar;
        public Randevu(Form1  f1)
        {
            form = f1;
            this.uyegetir =form.user;
            this.randevu = form.randevu;
            this.doktorliste = form.doktorliste;
            InitializeComponent();
        }
        User uyegetir = new User();
        private void btnrandevual_Click(object sender, EventArgs e)
        {
           RandevuAl randevu = new RandevuAl(this);
            this.Hide();
            randevu.Show();
        }

        private void btnrandevugor_Click(object sender, EventArgs e)
        {

           UyeRandevuGor randevugor = new UyeRandevuGor(this);
            this.Hide();
            randevugor.Show();
        }

      
        private void Randevu_Load(object sender, EventArgs e)
        {
            lblname.Text ="MERHABA"+ " "+  uyegetir.Names+" "+ uyegetir.Lastname;
          
        }

        private void btncikis_Click(object sender, EventArgs e)
        {

            form.Show();
            this.Hide();
        }
    }
}
