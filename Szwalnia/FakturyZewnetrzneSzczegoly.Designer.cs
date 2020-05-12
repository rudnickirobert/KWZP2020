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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNrFaktury = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNazwaFirmy = new System.Windows.Forms.TextBox();
            this.txtKosztNetto = new System.Windows.Forms.TextBox();
            this.txtKosztBrutto = new System.Windows.Forms.TextBox();
            this.txtWartoscPodatku = new System.Windows.Forms.TextBox();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr. Faktury";
            // 
            // txtNrFaktury
            // 
            this.txtNrFaktury.Location = new System.Drawing.Point(134, 38);
            this.txtNrFaktury.Name = "txtNrFaktury";
            this.txtNrFaktury.Size = new System.Drawing.Size(263, 22);
            this.txtNrFaktury.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa Firmy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Koszt Netto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Koszt Brutto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Wartość Podatku";
            // 
            // txtNazwaFirmy
            // 
            this.txtNazwaFirmy.Location = new System.Drawing.Point(134, 73);
            this.txtNazwaFirmy.Name = "txtNazwaFirmy";
            this.txtNazwaFirmy.Size = new System.Drawing.Size(263, 22);
            this.txtNazwaFirmy.TabIndex = 6;
            // 
            // txtKosztNetto
            // 
            this.txtKosztNetto.Location = new System.Drawing.Point(134, 110);
            this.txtKosztNetto.Name = "txtKosztNetto";
            this.txtKosztNetto.Size = new System.Drawing.Size(263, 22);
            this.txtKosztNetto.TabIndex = 7;
            // 
            // txtKosztBrutto
            // 
            this.txtKosztBrutto.Location = new System.Drawing.Point(134, 150);
            this.txtKosztBrutto.Name = "txtKosztBrutto";
            this.txtKosztBrutto.Size = new System.Drawing.Size(263, 22);
            this.txtKosztBrutto.TabIndex = 8;
            // 
            // txtWartoscPodatku
            // 
            this.txtWartoscPodatku.Location = new System.Drawing.Point(134, 185);
            this.txtWartoscPodatku.Name = "txtWartoscPodatku";
            this.txtWartoscPodatku.Size = new System.Drawing.Size(263, 22);
            this.txtWartoscPodatku.TabIndex = 9;
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(15, 236);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(101, 36);
            this.btnZamknij.TabIndex = 10;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // FakturyZewnetrzneSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.txtWartoscPodatku);
            this.Controls.Add(this.txtKosztBrutto);
            this.Controls.Add(this.txtKosztNetto);
            this.Controls.Add(this.txtNazwaFirmy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNrFaktury);
            this.Controls.Add(this.label1);
            this.Name = "FakturyZewnetrzneSzczegoly";
            this.Text = "FakturyZewnetrzneSzczegoly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNrFaktury;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNazwaFirmy;
        private System.Windows.Forms.TextBox txtKosztNetto;
        private System.Windows.Forms.TextBox txtKosztBrutto;
        private System.Windows.Forms.TextBox txtWartoscPodatku;
        private System.Windows.Forms.Button btnZamknij;
    }
}