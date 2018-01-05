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
    public partial class UyeRandevuGor : Form
    {

        public Randevu randevudon;
        public List<Randevular> randevu = new List<Randevular>();
        public User user;
        public Randevular randevual;
        public UyeRandevuGor(Randevu don)
        {
            randevudon = don;
            this.randevu = randevudon.randevu;
            this.user = randevudon.form.user;
            this.randevual = randevudon.randevual;
            InitializeComponent();
        }
      
       
        private void UyeRandevuGor_Load(object sender, EventArgs e)
        {
            randevual = new Randevular();
            randevual.name = user.Names;
            gbgor.Visible = false;
            if (user.Names == randevual.name) { 
            foreach (var item in randevu)
            {
                listrandevugor.Items.Add(item);
            }
            }
            
               
     
            
        }

          private void listrandevugor_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbgor.Visible = true;
            Randevular randevugorsec = (Randevular)listrandevugor.SelectedItem;
          
            lblrahatsizlik.Text = randevugorsec.Rahatsizlik;
            lbldoktor.Text = randevugorsec.Doktorname;
            lbltarih.Text = randevugorsec.Tarih.ToLongDateString();
        }

        private void UyeRandevuGor_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            randevudon.Show();
        } 
    }
}
