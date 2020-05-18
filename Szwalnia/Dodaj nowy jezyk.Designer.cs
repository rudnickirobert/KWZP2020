namespace Szwalnia
{
    partial class DodajNowyJezyk
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbImieNazwisko = new System.Windows.Forms.ComboBox();
            this.cbJezyk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Anuluj = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(449, 201);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(101, 45);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Zapisz i zamknij";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cbImieNazwisko
            // 
            this.cbImieNazwisko.FormattingEnabled = true;
            this.cbImieNazwisko.Location = new System.Drawing.Point(137, 55);
            this.cbImieNazwisko.Name = "cbImieNazwisko";
            this.cbImieNazwisko.Size = new System.Drawing.Size(267, 24);
            this.cbImieNazwisko.TabIndex = 1;
            // 
            // cbJezyk
            // 
            this.cbJezyk.FormattingEnabled = true;
            this.cbJezyk.Location = new System.Drawing.Point(137, 107);
            this.cbJezyk.Name = "cbJezyk";
            this.cbJezyk.Size = new System.Drawing.Size(267, 24);
            this.cbJezyk.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imię i nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Język";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dodaj znajomość języków";
            // 
            // Anuluj
            // 
            this.Anuluj.Location = new System.Drawing.Point(119, 201);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(86, 45);
            this.Anuluj.TabIndex = 7;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(27, 201);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(86, 45);
            this.btnZamknij.TabIndex = 8;
            this.btnZamknij.Text = "Zapisz ";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // ZnajomoscJezyków
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJezyk);
            this.Controls.Add(this.cbImieNazwisko);
            this.Controls.Add(this.btnDodaj);
            this.Name = "ZnajomoscJezyków";
            this.Text = "Dodaj nowy język";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cbImieNazwisko;
        private System.Windows.Forms.ComboBox cbJezyk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Anuluj;
        private System.Windows.Forms.Button btnZamknij;
    }
}