namespace Szwalnia
{
    partial class KontrolaEfektywnosciSzczegoly
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUwagiDoKontroli = new System.Windows.Forms.TextBox();
            this.txtLiczbaPoprawnych = new System.Windows.Forms.TextBox();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnDzis = new System.Windows.Forms.Button();
            this.lblProces = new System.Windows.Forms.Label();
            this.mtbDataKontroli = new System.Windows.Forms.MaskedTextBox();
            this.lblGwiazdka = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWyzeruj = new System.Windows.Forms.Button();
            this.lblOpisGwiazdy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(57, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Liczba poprawnych sztuk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(57, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data kontroli";
            // 
            // txtUwagiDoKontroli
            // 
            this.txtUwagiDoKontroli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUwagiDoKontroli.Location = new System.Drawing.Point(399, 211);
            this.txtUwagiDoKontroli.Margin = new System.Windows.Forms.Padding(4);
            this.txtUwagiDoKontroli.Name = "txtUwagiDoKontroli";
            this.txtUwagiDoKontroli.Size = new System.Drawing.Size(436, 29);
            this.txtUwagiDoKontroli.TabIndex = 16;
            // 
            // txtLiczbaPoprawnych
            // 
            this.txtLiczbaPoprawnych.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLiczbaPoprawnych.Location = new System.Drawing.Point(399, 250);
            this.txtLiczbaPoprawnych.Margin = new System.Windows.Forms.Padding(4);
            this.txtLiczbaPoprawnych.Name = "txtLiczbaPoprawnych";
            this.txtLiczbaPoprawnych.Size = new System.Drawing.Size(436, 29);
            this.txtLiczbaPoprawnych.TabIndex = 18;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.Location = new System.Drawing.Point(402, 340);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(107, 62);
            this.btnAnuluj.TabIndex = 20;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.Location = new System.Drawing.Point(240, 340);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(4);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(107, 62);
            this.btnZapisz.TabIndex = 21;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnDzis
            // 
            this.btnDzis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzis.Location = new System.Drawing.Point(655, 164);
            this.btnDzis.Margin = new System.Windows.Forms.Padding(4);
            this.btnDzis.Name = "btnDzis";
            this.btnDzis.Size = new System.Drawing.Size(63, 28);
            this.btnDzis.TabIndex = 22;
            this.btnDzis.Text = "Dziś";
            this.btnDzis.UseVisualStyleBackColor = true;
            this.btnDzis.Click += new System.EventHandler(this.btnDzisiaj_Click);
            // 
            // lblProces
            // 
            this.lblProces.AutoSize = true;
            this.lblProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProces.Location = new System.Drawing.Point(209, 80);
            this.lblProces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProces.Name = "lblProces";
            this.lblProces.Size = new System.Drawing.Size(64, 25);
            this.lblProces.TabIndex = 23;
            this.lblProces.Text = "label1";
            // 
            // mtbDataKontroli
            // 
            this.mtbDataKontroli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbDataKontroli.Location = new System.Drawing.Point(399, 164);
            this.mtbDataKontroli.Margin = new System.Windows.Forms.Padding(4);
            this.mtbDataKontroli.Mask = "0000/00/00 00:00:00";
            this.mtbDataKontroli.Name = "mtbDataKontroli";
            this.mtbDataKontroli.Size = new System.Drawing.Size(212, 29);
            this.mtbDataKontroli.TabIndex = 24;
            // 
            // lblGwiazdka
            // 
            this.lblGwiazdka.AutoSize = true;
            this.lblGwiazdka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGwiazdka.Location = new System.Drawing.Point(619, 165);
            this.lblGwiazdka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGwiazdka.Name = "lblGwiazdka";
            this.lblGwiazdka.Size = new System.Drawing.Size(17, 24);
            this.lblGwiazdka.TabIndex = 32;
            this.lblGwiazdka.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(57, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Uwagi do kontroli";
            // 
            // btnWyzeruj
            // 
            this.btnWyzeruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyzeruj.Location = new System.Drawing.Point(564, 340);
            this.btnWyzeruj.Margin = new System.Windows.Forms.Padding(4);
            this.btnWyzeruj.Name = "btnWyzeruj";
            this.btnWyzeruj.Size = new System.Drawing.Size(107, 62);
            this.btnWyzeruj.TabIndex = 34;
            this.btnWyzeruj.Text = "Wyzeruj";
            this.btnWyzeruj.UseVisualStyleBackColor = true;
            this.btnWyzeruj.Click += new System.EventHandler(this.btnWyzeruj_Click);
            // 
            // lblOpisGwiazdy
            // 
            this.lblOpisGwiazdy.AutoSize = true;
            this.lblOpisGwiazdy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisGwiazdy.Location = new System.Drawing.Point(58, 306);
            this.lblOpisGwiazdy.Name = "lblOpisGwiazdy";
            this.lblOpisGwiazdy.Size = new System.Drawing.Size(137, 20);
            this.lblOpisGwiazdy.TabIndex = 35;
            this.lblOpisGwiazdy.Text = "* Pole wymagane";
            // 
            // KontrolaEfektywnosciSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 457);
            this.Controls.Add(this.lblOpisGwiazdy);
            this.Controls.Add(this.btnWyzeruj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGwiazdka);
            this.Controls.Add(this.mtbDataKontroli);
            this.Controls.Add(this.lblProces);
            this.Controls.Add(this.btnDzis);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.txtLiczbaPoprawnych);
            this.Controls.Add(this.txtUwagiDoKontroli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KontrolaEfektywnosciSzczegoly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrola efektywności procesu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUwagiDoKontroli;
        private System.Windows.Forms.TextBox txtLiczbaPoprawnych;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnDzis;
        private System.Windows.Forms.Label lblProces;
        private System.Windows.Forms.MaskedTextBox mtbDataKontroli;
        private System.Windows.Forms.Label lblGwiazdka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWyzeruj;
        private System.Windows.Forms.Label lblOpisGwiazdy;
    }
}