namespace HastaneRandevu.Models
{
    partial class RandevuAl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtptarih = new System.Windows.Forms.DateTimePicker();
            this.cbdoktor = new System.Windows.Forms.ComboBox();
            this.txtrahatsizlik = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.listdoktor = new System.Windows.Forms.ListBox();
            this.txtdoktor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rahatasızlığınız :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doktor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tarih :";
            // 
            // dtptarih
            // 
            this.dtptarih.Location = new System.Drawing.Point(210, 271);
            this.dtptarih.MinDate = new System.DateTime(2017, 8, 31, 0, 0, 0, 0);
            this.dtptarih.Name = "dtptarih";
            this.dtptarih.Size = new System.Drawing.Size(200, 20);
            this.dtptarih.TabIndex = 5;
            // 
            // cbdoktor
            // 
            this.cbdoktor.FormattingEnabled = true;
            this.cbdoktor.Location = new System.Drawing.Point(210, 213);
            this.cbdoktor.Name = "cbdoktor";
            this.cbdoktor.Size = new System.Drawing.Size(121, 21);
            this.cbdoktor.TabIndex = 6;
            this.cbdoktor.SelectedIndexChanged += new System.EventHandler(this.cbdoktor_SelectedIndexChanged);
            // 
            // txtrahatsizlik
            // 
            this.txtrahatsizlik.Location = new System.Drawing.Point(210, 144);
            this.txtrahatsizlik.Multiline = true;
            this.txtrahatsizlik.Name = "txtrahatsizlik";
            this.txtrahatsizlik.Size = new System.Drawing.Size(200, 49);
            this.txtrahatsizlik.TabIndex = 7;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.Silver;
            this.lblAd.Location = new System.Drawing.Point(210, 62);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(0, 15);
            this.lblAd.TabIndex = 8;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.Silver;
            this.lblSoyad.Location = new System.Drawing.Point(210, 102);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(0, 15);
            this.lblSoyad.TabIndex = 9;
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Firebrick;
            this.btnkaydet.Location = new System.Drawing.Point(210, 326);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(103, 46);
            this.btnkaydet.TabIndex = 10;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // listdoktor
            // 
            this.listdoktor.FormattingEnabled = true;
            this.listdoktor.Location = new System.Drawing.Point(548, 206);
            this.listdoktor.Name = "listdoktor";
            this.listdoktor.Size = new System.Drawing.Size(84, 95);
            this.listdoktor.TabIndex = 11;
            // 
            // txtdoktor
            // 
            this.txtdoktor.Location = new System.Drawing.Point(548, 307);
            this.txtdoktor.Name = "txtdoktor";
            this.txtdoktor.Size = new System.Drawing.Size(84, 20);
            this.txtdoktor.TabIndex = 12;
            // 
            // RandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(644, 460);
            this.Controls.Add(this.txtdoktor);
            this.Controls.Add(this.listdoktor);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtrahatsizlik);
            this.Controls.Add(this.cbdoktor);
            this.Controls.Add(this.dtptarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "RandevuAl";
            this.Text = "RandevuAl";
            this.Load += new System.EventHandler(this.RandevuAl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrahatsizlik;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Button btnkaydet;
        public System.Windows.Forms.ComboBox cbdoktor;
        public System.Windows.Forms.DateTimePicker dtptarih;
        private System.Windows.Forms.ListBox listdoktor;
        private System.Windows.Forms.TextBox txtdoktor;
    }
}