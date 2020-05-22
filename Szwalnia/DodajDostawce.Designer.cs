namespace Szwalnia
{
    partial class DodajDostawce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajDostawce));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTelefon2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.chkTel2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj nowego dostawcę";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon 1";
            // 
            // lblTelefon2
            // 
            this.lblTelefon2.AutoSize = true;
            this.lblTelefon2.Enabled = false;
            this.lblTelefon2.Location = new System.Drawing.Point(79, 136);
            this.lblTelefon2.Name = "lblTelefon2";
            this.lblTelefon2.Size = new System.Drawing.Size(52, 13);
            this.lblTelefon2.TabIndex = 3;
            this.lblTelefon2.Text = "Telefon 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(147, 68);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(122, 20);
            this.txtNazwa.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(122, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // mtxtTel1
            // 
            this.mtxtTel1.AllowDrop = true;
            this.mtxtTel1.Location = new System.Drawing.Point(147, 100);
            this.mtxtTel1.Mask = "000-000-000";
            this.mtxtTel1.Name = "mtxtTel1";
            this.mtxtTel1.Size = new System.Drawing.Size(122, 20);
            this.mtxtTel1.TabIndex = 7;
            this.mtxtTel1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtxtTel2
            // 
            this.mtxtTel2.Enabled = false;
            this.mtxtTel2.Location = new System.Drawing.Point(147, 132);
            this.mtxtTel2.Mask = "000-000-000";
            this.mtxtTel2.Name = "mtxtTel2";
            this.mtxtTel2.Size = new System.Drawing.Size(122, 20);
            this.mtxtTel2.TabIndex = 8;
            this.mtxtTel2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtTel2.ValidatingType = typeof(int);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(235, 204);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(88, 38);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Zapisz";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(30, 204);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(88, 38);
            this.btnWstecz.TabIndex = 10;
            this.btnWstecz.Text = "Powrót";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // chkTel2
            // 
            this.chkTel2.AutoSize = true;
            this.chkTel2.Location = new System.Drawing.Point(55, 135);
            this.chkTel2.Name = "chkTel2";
            this.chkTel2.Size = new System.Drawing.Size(15, 14);
            this.chkTel2.TabIndex = 11;
            this.chkTel2.UseVisualStyleBackColor = true;
            this.chkTel2.CheckedChanged += new System.EventHandler(this.chkTel2_CheckedChanged);
            // 
            // DodajDostawce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 256);
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
            this.Name = "DodajDostawce";
            this.Text = "Dodaj nowego dostawcę";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DodajDostawce_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTelefon2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtxtTel1;
        private System.Windows.Forms.MaskedTextBox mtxtTel2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.CheckBox chkTel2;
    }
}