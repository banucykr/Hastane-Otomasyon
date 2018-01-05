namespace HastaneRandevu.Models
{
    partial class Randevu
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
            this.btncikis = new System.Windows.Forms.Button();
            this.btnrandevugor = new System.Windows.Forms.Button();
            this.btnrandevual = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Firebrick;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.ForeColor = System.Drawing.Color.Silver;
            this.btncikis.Location = new System.Drawing.Point(181, 279);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(165, 73);
            this.btncikis.TabIndex = 5;
            this.btncikis.Text = "Exit";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnrandevugor
            // 
            this.btnrandevugor.BackColor = System.Drawing.Color.Firebrick;
            this.btnrandevugor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrandevugor.ForeColor = System.Drawing.Color.Silver;
            this.btnrandevugor.Location = new System.Drawing.Point(181, 184);
            this.btnrandevugor.Name = "btnrandevugor";
            this.btnrandevugor.Size = new System.Drawing.Size(165, 79);
            this.btnrandevugor.TabIndex = 4;
            this.btnrandevugor.Text = "Randevuları Gör";
            this.btnrandevugor.UseVisualStyleBackColor = false;
            this.btnrandevugor.Click += new System.EventHandler(this.btnrandevugor_Click);
            // 
            // btnrandevual
            // 
            this.btnrandevual.BackColor = System.Drawing.Color.Firebrick;
            this.btnrandevual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrandevual.ForeColor = System.Drawing.Color.Silver;
            this.btnrandevual.Location = new System.Drawing.Point(181, 91);
            this.btnrandevual.Name = "btnrandevual";
            this.btnrandevual.Size = new System.Drawing.Size(165, 75);
            this.btnrandevual.TabIndex = 3;
            this.btnrandevual.Text = "Randevul Al";
            this.btnrandevual.UseVisualStyleBackColor = false;
            this.btnrandevual.Click += new System.EventHandler(this.btnrandevual_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblname.ForeColor = System.Drawing.Color.Silver;
            this.lblname.Location = new System.Drawing.Point(181, 38);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 16);
            this.lblname.TabIndex = 6;
            // 
            // Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(526, 411);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnrandevugor);
            this.Controls.Add(this.btnrandevual);
            this.Name = "Randevu";
            this.Text = "Randevu";
            this.Load += new System.EventHandler(this.Randevu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnrandevugor;
        private System.Windows.Forms.Button btnrandevual;
        private System.Windows.Forms.Label lblname;
    }
}