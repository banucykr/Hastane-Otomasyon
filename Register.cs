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
    public partial class Register : Form
    {
       public Form1 main;
        public List<User> uyeler = new List<User>();
        public Register(Form1 f1)
        {
            main = f1;
            this.uye = main.uyeler;
            InitializeComponent();
        }

       
        private void Register_Load(object sender, EventArgs e)
        {
            user.ImagePath = "uye.jpg";

            pbImage.Image = Image.FromFile(user.ImagePath);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            lblsummary.Visible = false;
        }
          List<User> uye = new List<User>();
        User user = new User();
        private void btnkayit_Click(object sender, EventArgs e)
        {
              user.Names = txtname.Text;
            user.Lastname = txtlastname.Text;
            user.Username = txtusername.Text;
            user.Password = txtpassword.Text;
           
            uye.Add(user);

            ValidationManager validation = new ValidationManager();
            bool validName = validation.ValidationField(txtusername.Text, txtpassword.Text);

            string summary = "";
            if (!validName)
            {
                summary += "Boşlukları doldurmak zorunludur.";
                lblsummary.Text = summary;
                lblsummary.Visible = true;
                return;
            }
            else
            {
                summary = "";
                lblsummary.Visible = false;

            }

             
            main.Show();
            this.Hide();


        }
    }
}
