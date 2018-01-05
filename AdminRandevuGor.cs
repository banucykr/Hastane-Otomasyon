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
    public partial class AdminRandevuGor : Form
    {
        AdminLogin admin;
        public List<Randevular> randevu = new List<Randevular>();
       
        public AdminRandevuGor(AdminLogin don)
        {
            admin = don;
            this.randevu = admin.randevu;
            InitializeComponent();
        }
     
        private void AdminRandevuGor_Load(object sender, EventArgs e)
        {
            gbgor.Visible = false;
            foreach (var item in randevu)
            {
                listrandevugor.Items.Add(item);
            }

        }

        private void listrandevugor_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbgor.Visible = true;
            Randevular randevugorsec = (Randevular)listrandevugor.SelectedItem;
            lbladsoyad.Text = randevugorsec.name +"  "+ randevugorsec.lastname;
            lbldoktor.Text = randevugorsec.Doktorname;
            lblrahatsizlik.Text = randevugorsec.Rahatsizlik;
            lbltarih.Text = randevugorsec.Tarih.ToLongDateString();
        }
    }
}
