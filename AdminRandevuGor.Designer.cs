namespace HastaneRandevu.Models
{
    partial class AdminRandevuGor
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
            this.listrandevugor = new System.Windows.Forms.ListBox();
            this.gbgor = new System.Windows.Forms.GroupBox();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblrahatsizlik = new System.Windows.Forms.Label();
            this.lbldoktor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.gbgor.SuspendLayout();
            this.SuspendLayout();
            // 
            // listrandevugor
            // 
            this.listrandevugor.FormattingEnabled = true;
            this.listrandevugor.Location = new System.Drawing.Point(12, 12);
            this.listrandevugor.Name = "listrandevugor";
            this.listrandevugor.Size = new System.Drawing.Size(304, 147);
            this.listrandevugor.TabIndex = 1;
            this.listrandevugor.SelectedIndexChanged += new System.EventHandler(this.listrandevugor_SelectedIndexChanged);
            // 
            // gbgor
            // 
            this.gbgor.Controls.Add(this.lbladsoyad);
            this.gbgor.Controls.Add(this.label3);
            this.gbgor.Controls.Add(this.label1);
            this.gbgor.Controls.Add(this.lblrahatsizlik);
            this.gbgor.Controls.Add(this.lbldoktor);
            this.gbgor.Controls.Add(this.label2);
            this.gbgor.Controls.Add(this.lbltarih);
            this.gbgor.Controls.Add(this.lbl2);
            this.gbgor.Controls.Add(this.lbl1);
            this.gbgor.Location = new System.Drawing.Point(12, 165);
            this.gbgor.Name = "gbgor";
            this.gbgor.Size = new System.Drawing.Size(399, 214);
            this.gbgor.TabIndex = 9;
            this.gbgor.TabStop = false;
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.ForeColor = System.Drawing.SystemColors.Control;
            this.lbladsoyad.Location = new System.Drawing.Point(108, 70);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(0, 13);
            this.lbladsoyad.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ad Soyad  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doktor Randevunuz";
            // 
            // lblrahatsizlik
            // 
            this.lblrahatsizlik.AutoSize = true;
            this.lblrahatsizlik.ForeColor = System.Drawing.SystemColors.Control;
            this.lblrahatsizlik.Location = new System.Drawing.Point(152, 103);
            this.lblrahatsizlik.Name = "lblrahatsizlik";
            this.lblrahatsizlik.Size = new System.Drawing.Size(0, 13);
            this.lblrahatsizlik.TabIndex = 7;
            // 
            // lbldoktor
            // 
            this.lbldoktor.AutoSize = true;
            this.lbldoktor.ForeColor = System.Drawing.SystemColors.Control;
            this.lbldoktor.Location = new System.Drawing.Point(149, 146);
            this.lbldoktor.Name = "lbldoktor";
            this.lbldoktor.Size = new System.Drawing.Size(0, 13);
            this.lbldoktor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rahatsızlığınız:";
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltarih.Location = new System.Drawing.Point(149, 182);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(0, 13);
            this.lbltarih.TabIndex = 4;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl2.Location = new System.Drawing.Point(6, 139);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(68, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Doktorunuz :";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl1.Location = new System.Drawing.Point(6, 182);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(99, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Randevu Tarihiniz :";
            // 
            // AdminRandevuGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(641, 383);
            this.Controls.Add(this.gbgor);
            this.Controls.Add(this.listrandevugor);
            this.Name = "AdminRandevuGor";
            this.Text = "AdminRandevuGor";
            this.Load += new System.EventHandler(this.AdminRandevuGor_Load);
            this.gbgor.ResumeLayout(false);
            this.gbgor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listrandevugor;
        private System.Windows.Forms.GroupBox gbgor;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblrahatsizlik;
        private System.Windows.Forms.Label lbldoktor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
    }
}