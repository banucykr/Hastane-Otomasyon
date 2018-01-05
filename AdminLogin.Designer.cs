namespace HastaneRandevu.Models
{
    partial class AdminLogin
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
            this.btntrandevugor = new System.Windows.Forms.Button();
            this.btndoktor = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.lbladmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntrandevugor
            // 
            this.btntrandevugor.BackColor = System.Drawing.Color.Firebrick;
            this.btntrandevugor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntrandevugor.ForeColor = System.Drawing.Color.Silver;
            this.btntrandevugor.Location = new System.Drawing.Point(200, 71);
            this.btntrandevugor.Name = "btntrandevugor";
            this.btntrandevugor.Size = new System.Drawing.Size(165, 75);
            this.btntrandevugor.TabIndex = 0;
            this.btntrandevugor.Text = "Tüm Randevuları Gör";
            this.btntrandevugor.UseVisualStyleBackColor = false;
            this.btntrandevugor.Click += new System.EventHandler(this.btntrandevugor_Click);
            // 
            // btndoktor
            // 
            this.btndoktor.BackColor = System.Drawing.Color.Firebrick;
            this.btndoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndoktor.ForeColor = System.Drawing.Color.Silver;
            this.btndoktor.Location = new System.Drawing.Point(200, 174);
            this.btndoktor.Name = "btndoktor";
            this.btndoktor.Size = new System.Drawing.Size(165, 79);
            this.btndoktor.TabIndex = 1;
            this.btndoktor.Text = "Doktor Ekle";
            this.btndoktor.UseVisualStyleBackColor = false;
            this.btndoktor.Click += new System.EventHandler(this.btndoktor_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Firebrick;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.ForeColor = System.Drawing.Color.Silver;
            this.btncikis.Location = new System.Drawing.Point(200, 292);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(165, 73);
            this.btncikis.TabIndex = 2;
            this.btncikis.Text = "Exit";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladmin.ForeColor = System.Drawing.Color.Silver;
            this.lbladmin.Location = new System.Drawing.Point(200, 26);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(0, 15);
            this.lbladmin.TabIndex = 3;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(544, 415);
            this.Controls.Add(this.lbladmin);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btndoktor);
            this.Controls.Add(this.btntrandevugor);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntrandevugor;
        private System.Windows.Forms.Button btndoktor;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Label lbladmin;
    }
}