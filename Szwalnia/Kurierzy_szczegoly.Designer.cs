namespace Szwalnia
{
    partial class Kurierzy_szczegoly
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(295, 39);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Obojętne";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(255, 88);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(40, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Nazwa";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(344, 85);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(100, 20);
            this.txtNazwa.TabIndex = 2;
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(344, 111);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(100, 20);
            this.txtTel1.TabIndex = 4;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(255, 114);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(52, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Telefon 1";
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(344, 137);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(100, 20);
            this.txtTel2.TabIndex = 6;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(255, 140);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(52, 13);
            this.lbl4.TabIndex = 5;
            this.lbl4.Text = "Telefon 2";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(344, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(255, 166);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(32, 13);
            this.lbl5.TabIndex = 7;
            this.lbl5.Text = "Email";
            // 
            // Kurierzy_szczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Kurierzy_szczegoly";
            this.Text = "Kurierzy_szczegoly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbl5;
    }
}