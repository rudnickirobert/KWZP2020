namespace Szwalnia
{
    partial class ZakonczZamowienie
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
            this.cbIDZamowienia = new System.Windows.Forms.ComboBox();
            this.dtpZakonczenie = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblZamowienie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbIDZamowienia
            // 
            this.cbIDZamowienia.FormattingEnabled = true;
            this.cbIDZamowienia.Location = new System.Drawing.Point(208, 81);
            this.cbIDZamowienia.Name = "cbIDZamowienia";
            this.cbIDZamowienia.Size = new System.Drawing.Size(73, 24);
            this.cbIDZamowienia.TabIndex = 0;
            // 
            // dtpZakonczenie
            // 
            this.dtpZakonczenie.Location = new System.Drawing.Point(208, 163);
            this.dtpZakonczenie.Name = "dtpZakonczenie";
            this.dtpZakonczenie.Size = new System.Drawing.Size(200, 22);
            this.dtpZakonczenie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zakończ zamówienie";
            // 
            // lblZamowienie
            // 
            this.lblZamowienie.AutoSize = true;
            this.lblZamowienie.Location = new System.Drawing.Point(28, 84);
            this.lblZamowienie.Name = "lblZamowienie";
            this.lblZamowienie.Size = new System.Drawing.Size(157, 17);
            this.lblZamowienie.TabIndex = 3;
            this.lblZamowienie.Text = "Wybierz nr. zamówienie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wybierz date zakończenia";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(31, 233);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 44);
            this.btnAnuluj.TabIndex = 5;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(138, 233);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(115, 44);
            this.btnZapisz.TabIndex = 6;
            this.btnZapisz.Text = "Zakończ zamówienie";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // ZakonczZamowienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 303);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblZamowienie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpZakonczenie);
            this.Controls.Add(this.cbIDZamowienia);
            this.Name = "ZakonczZamowienie";
            this.Text = "Zakończ_zamówienie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIDZamowienia;
        private System.Windows.Forms.DateTimePicker dtpZakonczenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblZamowienie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZapisz;
    }
}