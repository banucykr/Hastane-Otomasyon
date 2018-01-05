namespace HastaneRandevu.Models
{
    partial class DoktorEkle
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
            this.txtdoktor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdoktor
            // 
            this.txtdoktor.Location = new System.Drawing.Point(197, 135);
            this.txtdoktor.Name = "txtdoktor";
            this.txtdoktor.Size = new System.Drawing.Size(164, 20);
            this.txtdoktor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(96, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doktor :";
            // 
            // btnkayit
            // 
            this.btnkayit.BackColor = System.Drawing.Color.Firebrick;
            this.btnkayit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnkayit.Location = new System.Drawing.Point(197, 197);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(146, 48);
            this.btnkayit.TabIndex = 2;
            this.btnkayit.Text = "Ekle";
            this.btnkayit.UseVisualStyleBackColor = false;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // DoktorEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(518, 375);
            this.Controls.Add(this.btnkayit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdoktor);
            this.Name = "DoktorEkle";
            this.Text = "DoktorEkle";
            this.Load += new System.EventHandler(this.DoktorEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdoktor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkayit;
    }
}