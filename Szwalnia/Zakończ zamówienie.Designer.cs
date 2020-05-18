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
            this.cbIDZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbIDZamowienia.FormattingEnabled = true;
            this.cbIDZamowienia.Location = new System.Drawing.Point(364, 113);
            this.cbIDZamowienia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbIDZamowienia.Name = "cbIDZamowienia";
            this.cbIDZamowienia.Size = new System.Drawing.Size(142, 39);
            this.cbIDZamowienia.TabIndex = 0;
            // 
            // dtpZakonczenie
            // 
            this.dtpZakonczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpZakonczenie.Location = new System.Drawing.Point(389, 216);
            this.dtpZakonczenie.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpZakonczenie.Name = "dtpZakonczenie";
            this.dtpZakonczenie.Size = new System.Drawing.Size(494, 38);
            this.dtpZakonczenie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(317, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zakończ zamówienie";
            // 
            // lblZamowienie
            // 
            this.lblZamowienie.AutoSize = true;
            this.lblZamowienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZamowienie.Location = new System.Drawing.Point(15, 113);
            this.lblZamowienie.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZamowienie.Name = "lblZamowienie";
            this.lblZamowienie.Size = new System.Drawing.Size(315, 32);
            this.lblZamowienie.TabIndex = 3;
            this.lblZamowienie.Text = "Wybierz nr. zamówienie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wybierz date zakończenia";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.Location = new System.Drawing.Point(612, 389);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(97, 66);
            this.btnAnuluj.TabIndex = 5;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.Location = new System.Drawing.Point(745, 396);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(136, 59);
            this.btnZapisz.TabIndex = 6;
            this.btnZapisz.Text = "Zakończ zamówienie";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // ZakonczZamowienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 470);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblZamowienie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpZakonczenie);
            this.Controls.Add(this.cbIDZamowienia);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ZakonczZamowienie";
            this.Text = "Zakończ zamówienie";
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