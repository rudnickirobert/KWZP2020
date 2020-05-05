namespace Szwalnia
{
    partial class FakturyZewnetrzneSzczegoly
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
            this.btnWrocKlienci = new System.Windows.Forms.Button();
            this.lblTytul = new System.Windows.Forms.Label();
            this.lblBrutto = new System.Windows.Forms.Label();
            this.lblNetto = new System.Windows.Forms.Label();
            this.lblNazwaFirmy = new System.Windows.Forms.Label();
            this.lblNrFaktury = new System.Windows.Forms.Label();
            this.txtKosztBrutto = new System.Windows.Forms.TextBox();
            this.txtKosztNetto = new System.Windows.Forms.TextBox();
            this.txtNazwaFirmy = new System.Windows.Forms.TextBox();
            this.txtNrFaktury = new System.Windows.Forms.TextBox();
            this.textWartoscPodatku = new System.Windows.Forms.TextBox();
            this.lblPodatek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWrocKlienci
            // 
            this.btnWrocKlienci.Location = new System.Drawing.Point(18, 190);
            this.btnWrocKlienci.Margin = new System.Windows.Forms.Padding(2);
            this.btnWrocKlienci.Name = "btnWrocKlienci";
            this.btnWrocKlienci.Size = new System.Drawing.Size(374, 36);
            this.btnWrocKlienci.TabIndex = 26;
            this.btnWrocKlienci.Text = "Wróć";
            this.btnWrocKlienci.UseVisualStyleBackColor = true;
            this.btnWrocKlienci.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnWrocKlienci_MouseClick);
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTytul.Location = new System.Drawing.Point(61, 9);
            this.lblTytul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(299, 37);
            this.lblTytul.TabIndex = 25;
            this.lblTytul.Text = "Faktura zewnętrzna";
            // 
            // lblBrutto
            // 
            this.lblBrutto.AutoSize = true;
            this.lblBrutto.Location = new System.Drawing.Point(15, 132);
            this.lblBrutto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrutto.Name = "lblBrutto";
            this.lblBrutto.Size = new System.Drawing.Size(63, 13);
            this.lblBrutto.TabIndex = 23;
            this.lblBrutto.Text = "Koszt brutto";
            // 
            // lblNetto
            // 
            this.lblNetto.AutoSize = true;
            this.lblNetto.Location = new System.Drawing.Point(15, 109);
            this.lblNetto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNetto.Name = "lblNetto";
            this.lblNetto.Size = new System.Drawing.Size(60, 13);
            this.lblNetto.TabIndex = 22;
            this.lblNetto.Text = "Koszt netto";
            // 
            // lblNazwaFirmy
            // 
            this.lblNazwaFirmy.AutoSize = true;
            this.lblNazwaFirmy.Location = new System.Drawing.Point(15, 87);
            this.lblNazwaFirmy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazwaFirmy.Name = "lblNazwaFirmy";
            this.lblNazwaFirmy.Size = new System.Drawing.Size(67, 13);
            this.lblNazwaFirmy.TabIndex = 21;
            this.lblNazwaFirmy.Text = "Nazwa Firmy";
            // 
            // lblNrFaktury
            // 
            this.lblNrFaktury.AutoSize = true;
            this.lblNrFaktury.Location = new System.Drawing.Point(15, 64);
            this.lblNrFaktury.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNrFaktury.Name = "lblNrFaktury";
            this.lblNrFaktury.Size = new System.Drawing.Size(56, 13);
            this.lblNrFaktury.TabIndex = 20;
            this.lblNrFaktury.Text = "Nr Faktury";
            // 
            // txtKosztBrutto
            // 
            this.txtKosztBrutto.Location = new System.Drawing.Point(162, 129);
            this.txtKosztBrutto.Margin = new System.Windows.Forms.Padding(2);
            this.txtKosztBrutto.Name = "txtKosztBrutto";
            this.txtKosztBrutto.Size = new System.Drawing.Size(230, 20);
            this.txtKosztBrutto.TabIndex = 18;
            // 
            // txtKosztNetto
            // 
            this.txtKosztNetto.Location = new System.Drawing.Point(162, 106);
            this.txtKosztNetto.Margin = new System.Windows.Forms.Padding(2);
            this.txtKosztNetto.Name = "txtKosztNetto";
            this.txtKosztNetto.Size = new System.Drawing.Size(230, 20);
            this.txtKosztNetto.TabIndex = 17;
            // 
            // txtNazwaFirmy
            // 
            this.txtNazwaFirmy.Location = new System.Drawing.Point(162, 84);
            this.txtNazwaFirmy.Margin = new System.Windows.Forms.Padding(2);
            this.txtNazwaFirmy.Name = "txtNazwaFirmy";
            this.txtNazwaFirmy.Size = new System.Drawing.Size(230, 20);
            this.txtNazwaFirmy.TabIndex = 16;
            // 
            // txtNrFaktury
            // 
            this.txtNrFaktury.Location = new System.Drawing.Point(162, 61);
            this.txtNrFaktury.Margin = new System.Windows.Forms.Padding(2);
            this.txtNrFaktury.Name = "txtNrFaktury";
            this.txtNrFaktury.Size = new System.Drawing.Size(230, 20);
            this.txtNrFaktury.TabIndex = 15;
            // 
            // textWartoscPodatku
            // 
            this.textWartoscPodatku.Location = new System.Drawing.Point(162, 153);
            this.textWartoscPodatku.Margin = new System.Windows.Forms.Padding(2);
            this.textWartoscPodatku.Name = "textWartoscPodatku";
            this.textWartoscPodatku.Size = new System.Drawing.Size(230, 20);
            this.textWartoscPodatku.TabIndex = 18;
            // 
            // lblPodatek
            // 
            this.lblPodatek.AutoSize = true;
            this.lblPodatek.Location = new System.Drawing.Point(15, 156);
            this.lblPodatek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPodatek.Name = "lblPodatek";
            this.lblPodatek.Size = new System.Drawing.Size(89, 13);
            this.lblPodatek.TabIndex = 23;
            this.lblPodatek.Text = "Wartosc podatku";
            // 
            // FakturyZewnetrzneSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 237);
            this.Controls.Add(this.btnWrocKlienci);
            this.Controls.Add(this.lblTytul);
            this.Controls.Add(this.lblPodatek);
            this.Controls.Add(this.lblBrutto);
            this.Controls.Add(this.lblNetto);
            this.Controls.Add(this.lblNazwaFirmy);
            this.Controls.Add(this.lblNrFaktury);
            this.Controls.Add(this.textWartoscPodatku);
            this.Controls.Add(this.txtKosztBrutto);
            this.Controls.Add(this.txtKosztNetto);
            this.Controls.Add(this.txtNazwaFirmy);
            this.Controls.Add(this.txtNrFaktury);
            this.Name = "FakturyZewnetrzneSzczegoly";
            this.Text = "Faktury Zewnętrzne - Szczegóły";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrocKlienci;
        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.Label lblBrutto;
        private System.Windows.Forms.Label lblNetto;
        private System.Windows.Forms.Label lblNazwaFirmy;
        private System.Windows.Forms.Label lblNrFaktury;
        private System.Windows.Forms.TextBox txtKosztBrutto;
        private System.Windows.Forms.TextBox txtKosztNetto;
        private System.Windows.Forms.TextBox txtNazwaFirmy;
        private System.Windows.Forms.TextBox txtNrFaktury;
        private System.Windows.Forms.TextBox textWartoscPodatku;
        private System.Windows.Forms.Label lblPodatek;
    }
}