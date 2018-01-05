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
    public partial class RandevuAl : Form
    {
        public  Randevu randevusec;
        public List<Randevular> randevu = new List<Randevular>();
        public List<Doktor> doktorliste = new List<Doktor>();
        public User user;
        public Randevular randevual;
        public Doktor doktor;
        public RandevuAl(Randevu randevu)
        {
            randevusec = randevu;
            this.randevual = randevusec.randevual;
            this.uye = randevusec.form.user;
            this.randevukayit= randevusec.randevu;
            this.doktorliste= randevusec.doktorliste;
            
            InitializeComponent();
        }


        List<Randevular> randevukayit = new List<Randevular>();
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            randevual = new Randevular();
            randevual.name = uye.Names;
            randevual.lastname = uye.Lastname;
            randevual.Rahatsizlik = txtrahatsizlik.Text;
            randevual.Tarih = dtptarih.Value;
            randevual.Doktorname = txtdoktor.Text;

            randevukayit.Add(randevual);
            randevusec.Show();
            this.Hide();
           
        }
        User uye = new User();
      
        private void RandevuAl_Load(object sender, EventArgs e)
        {
            lblAd.Text = uye.Names;
            lblSoyad.Text = uye.Lastname;
            txtdoktor.Visible = false;
            listdoktor.Visible = false;
        //    doktorliste= new List<Doktor>() { 
            
        //        new Doktor("Betül ÇAYKARA"),
        //        new Doktor("Banu ÇAYKARA"),
              
        //};

            foreach (var item in doktorliste)
            {
                cbdoktor.Items.Add(item);
            }

        }

        //List<Doktor> doktordon = new List<Doktor>();
        //private void listdoktor_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    Doktor doktorgorsec= (Doktor)listdoktor.SelectedItem;
        //    txtdoktor.Text = doktorgorsec.FullName.ToString();
            

        //    foreach (var  item in doktorliste)
        //    {
        //       if (doktorgorsec == item) { 
        //       int index = doktorliste.IndexOf(item);
        //         doktor = doktorliste[index];
        //          doktordon.Add(doktor); 
        //        }
                
        //       } 
           
        //}

        private void cbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doktorgorsec = cbdoktor.SelectedItem.ToString();
            txtdoktor.Text= doktorgorsec;
            txtdoktor.Visible = false;
        }
    }
}
