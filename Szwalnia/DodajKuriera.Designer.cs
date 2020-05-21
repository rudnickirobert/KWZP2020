namespace Szwalnia
{
    partial class DodajKuriera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajKuriera));
            this.label1 = new System.Windows.Forms.Label();
            this.chkTel2 = new System.Windows.Forms.CheckBox();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.mtxtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTelefon2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wprowadź dane nowego kuriera.";
            // 
            // chkTel2
            // 
            this.chkTel2.AutoSize = true;
            this.chkTel2.Location = new System.Drawing.Point(39, 124);
            this.chkTel2.Name = "chkTel2";
            this.chkTel2.Size = new System.Drawing.Size(15, 14);
            this.chkTel2.TabIndex = 22;
            this.chkTel2.UseVisualStyleBackColor = true;
            this.chkTel2.CheckedChanged += new System.EventHandler(this.chkTel2_CheckedChanged);
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(63, 208);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(75, 23);
            this.btnWstecz.TabIndex = 21;
            this.btnWstecz.Text = "Powrót";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(194, 208);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 20;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // mtxtTel2
            // 
            this.mtxtTel2.Location = new System.Drawing.Point(157, 122);
            this.mtxtTel2.Mask = "000-000-000";
            this.mtxtTel2.Name = "mtxtTel2";
            this.mtxtTel2.Size = new System.Drawing.Size(100, 20);
            this.mtxtTel2.TabIndex = 19;
            this.mtxtTel2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtTel2.ValidatingType = typeof(int);
            // 
            // mtxtTel1
            // 
            this.mtxtTel1.AllowDrop = true;
            this.mtxtTel1.Location = new System.Drawing.Point(157, 83);
            this.mtxtTel1.Mask = "000-000-000";
            this.mtxtTel1.Name = "mtxtTel1";
            this.mtxtTel1.Size = new System.Drawing.Size(100, 20);
            this.mtxtTel1.TabIndex = 18;
            this.mtxtTel1.Text = "000000000";
            this.mtxtTel1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(157, 50);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(100, 20);
            this.txtNazwa.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            // 
            // lblTelefon2
            // 
            this.lblTelefon2.AutoSize = true;
            this.lblTelefon2.Location = new System.Drawing.Point(60, 125);
            this.lblTelefon2.Name = "lblTelefon2";
            this.lblTelefon2.Size = new System.Drawing.Size(52, 13);
            this.lblTelefon2.TabIndex = 14;
            this.lblTelefon2.Text = "Telefon 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nazwa";
            // 
            // DodajKuriera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 264);
            this.Controls.Add(this.chkTel2);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.mtxtTel2);
            this.Controls.Add(this.mtxtTel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTelefon2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajKuriera";
            this.Text = "Dodaj nowego kuriera";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DodajKuriera_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTel2;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.MaskedTextBox mtxtTel2;
        private System.Windows.Forms.MaskedTextBox mtxtTel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTelefon2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}