using HastaneRandevu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevu
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblsummary.Visible = false;
            doktorliste = new List<Doktor>() {

                new Doktor("Betül ÇAYKARA"),
                new Doktor("Banu ÇAYKARA"),

        };
        }
        public  List<User> uyeler = new List<User>();
        public List<Randevular> randevu = new List<Randevular>();
        public  User user;
       public Admin admin;
        public List<Doktor> doktorliste = new List<Doktor>();

        private void btnlogin_Click(object sender, EventArgs e)
        {

            ValidationManager validation = new ValidationManager();
            bool validName = validation.ValidationField(txtusername.Text, txtpassword.Text);

            string summary = "";
            if (!validName)
            {
                summary += "Giriş bilgilerini boş geçemezsiniz.";
                lblsummary.Text = summary;
                lblsummary.Visible = true;
                return;
            }
            else
            {
                summary = "";
                lblsummary.Visible = false;

            }
             admin = new Admin();
            bool admincontrol = admin.AdminField(txtusername.Text, txtpassword.Text);
            if (admincontrol)
            {
                AdminLogin adminlogin = new AdminLogin(this);
                this.Hide();
                adminlogin.Show();
            }
            else
            {
                summary += "Admin değilsiniz.";
                lblsummary.Text = summary;
                lblsummary.Visible = true;

            }
            user = new User();
            user.Names = "Banu";
            user.Lastname = "ÇAYKARA";
            user.Username = "Banu";
            user.Password = "456";
            uyeler.Add(user);

         
            foreach (var item in uyeler)
            {
                if (item.Username != txtusername.Text || item.Password != txtpassword.Text)
                {

                    summary = "Kullanıcı bilgilerinizi kontrol ediniz.";
                    lblsummary.Text = summary;
                    lblsummary.Visible = true;


                }
                else
                {
                    summary = "";
                    lblsummary.Visible = false;
                    int index = uyeler.IndexOf(item);
                    user = uyeler[index];
                    Randevu randevu = new Randevu(this);
                    this.Hide();
                    randevu.Show();
                    break;

            
            }

            }
        }
        private void btnregister_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            this.Hide();
            register.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
