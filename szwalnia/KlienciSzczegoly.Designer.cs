namespace Szwalnia
{
    partial class KlienciSzczegoly
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
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.txtNIP = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.lblNIP = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dgvKlienci = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlienci)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(129, 42);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(306, 22);
            this.txtNazwa.TabIndex = 0;
            // 
            // txtNIP
            // 
            this.txtNIP.Location = new System.Drawing.Point(129, 70);
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Size = new System.Drawing.Size(306, 22);
            this.txtNIP.TabIndex = 1;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(129, 98);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(306, 22);
            this.txtAdres.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(129, 126);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(306, 22);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(306, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Location = new System.Drawing.Point(12, 42);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(88, 17);
            this.lblNazwa.TabIndex = 6;
            this.lblNazwa.Text = "Nazwa Firmy";
            // 
            // lblNIP
            // 
            this.lblNIP.AutoSize = true;
            this.lblNIP.Location = new System.Drawing.Point(12, 75);
            this.lblNIP.Name = "lblNIP";
            this.lblNIP.Size = new System.Drawing.Size(30, 17);
            this.lblNIP.TabIndex = 7;
            this.lblNIP.Text = "NIP";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(12, 103);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(45, 17);
            this.lblAdres.TabIndex = 8;
            this.lblAdres.Text = "Adres";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(12, 131);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 17);
            this.lblTelefon.TabIndex = 9;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 159);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 17);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "email";
            // 
            // dgvKlienci
            // 
            this.dgvKlienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlienci.Location = new System.Drawing.Point(15, 188);
            this.dgvKlienci.Name = "dgvKlienci";
            this.dgvKlienci.RowHeadersWidth = 51;
            this.dgvKlienci.RowTemplate.Height = 24;
            this.dgvKlienci.Size = new System.Drawing.Size(603, 240);
            this.dgvKlienci.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(126, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 17);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Nazwa firmy";
            // 
            // Klienci_szczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvKlienci);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblNIP);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtNIP);
            this.Controls.Add(this.txtNazwa);
            this.Name = "Klienci_szczegoly";
            this.Text = "Klienci_szczegoly";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlienci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Label lblNIP;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridView dgvKlienci;
        private System.Windows.Forms.Label lblTitle;
    }
}