namespace Szwalnia
{
    partial class ZarzadzanieForm
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
            this.btnKlienciForm = new System.Windows.Forms.Button();
            this.btnPracownicy = new System.Windows.Forms.Button();
            this.btnFakturyZewnetrzne = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnFakturyWewnetrzne = new System.Windows.Forms.Button();
            this.btnFinanse = new System.Windows.Forms.Button();
            this.btnZamowienie = new System.Windows.Forms.Button();
            this.btnSrodki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKlienciForm
            // 
            this.btnKlienciForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKlienciForm.Location = new System.Drawing.Point(35, 170);
            this.btnKlienciForm.Name = "btnKlienciForm";
            this.btnKlienciForm.Size = new System.Drawing.Size(391, 121);
            this.btnKlienciForm.TabIndex = 0;
            this.btnKlienciForm.Text = "Panel klienta";
            this.btnKlienciForm.UseVisualStyleBackColor = true;
            this.btnKlienciForm.Click += new System.EventHandler(this.btnKlienciForm_Click);
            // 
            // btnPracownicy
            // 
            this.btnPracownicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPracownicy.Location = new System.Drawing.Point(35, 308);
            this.btnPracownicy.Name = "btnPracownicy";
            this.btnPracownicy.Size = new System.Drawing.Size(391, 125);
            this.btnPracownicy.TabIndex = 1;
            this.btnPracownicy.Text = "Panel pracownika";
            this.btnPracownicy.UseVisualStyleBackColor = true;
            this.btnPracownicy.Click += new System.EventHandler(this.btnPracownicy_Click);
            // 
            // btnFakturyZewnetrzne
            // 
            this.btnFakturyZewnetrzne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFakturyZewnetrzne.Location = new System.Drawing.Point(522, 33);
            this.btnFakturyZewnetrzne.Name = "btnFakturyZewnetrzne";
            this.btnFakturyZewnetrzne.Size = new System.Drawing.Size(391, 125);
            this.btnFakturyZewnetrzne.TabIndex = 2;
            this.btnFakturyZewnetrzne.Text = "Faktury Zewnętrzne";
            this.btnFakturyZewnetrzne.UseVisualStyleBackColor = true;
            this.btnFakturyZewnetrzne.Click += new System.EventHandler(this.btnFakturyZewnetrzne_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(768, 512);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(145, 62);
            this.btnZamknij.TabIndex = 3;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnFakturyWewnetrzne
            // 
            this.btnFakturyWewnetrzne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFakturyWewnetrzne.Location = new System.Drawing.Point(522, 170);
            this.btnFakturyWewnetrzne.Name = "btnFakturyWewnetrzne";
            this.btnFakturyWewnetrzne.Size = new System.Drawing.Size(391, 125);
            this.btnFakturyWewnetrzne.TabIndex = 4;
            this.btnFakturyWewnetrzne.Text = "Faktury Wystawione";
            this.btnFakturyWewnetrzne.UseVisualStyleBackColor = true;
            this.btnFakturyWewnetrzne.Click += new System.EventHandler(this.btnFakturyWewnetrzne_Click);
            // 
            // btnFinanse
            // 
            this.btnFinanse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFinanse.Location = new System.Drawing.Point(522, 308);
            this.btnFinanse.Name = "btnFinanse";
            this.btnFinanse.Size = new System.Drawing.Size(391, 125);
            this.btnFinanse.TabIndex = 5;
            this.btnFinanse.Text = "Finanse";
            this.btnFinanse.UseVisualStyleBackColor = true;
            this.btnFinanse.Click += new System.EventHandler(this.btnFinanse_Click);
            // 
            // btnZamowienie
            // 
            this.btnZamowienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZamowienie.Location = new System.Drawing.Point(35, 33);
            this.btnZamowienie.Name = "btnZamowienie";
            this.btnZamowienie.Size = new System.Drawing.Size(391, 125);
            this.btnZamowienie.TabIndex = 6;
            this.btnZamowienie.Text = "Panel zamówień";
            this.btnZamowienie.UseVisualStyleBackColor = true;
            this.btnZamowienie.Click += new System.EventHandler(this.btnZamowienie_Click);
            // 
            // btnSrodki
            // 
            this.btnSrodki.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSrodki.Location = new System.Drawing.Point(35, 449);
            this.btnSrodki.Name = "btnSrodki";
            this.btnSrodki.Size = new System.Drawing.Size(391, 125);
            this.btnSrodki.TabIndex = 7;
            this.btnSrodki.Text = "Środki trwałe";
            this.btnSrodki.UseVisualStyleBackColor = true;
            this.btnSrodki.Click += new System.EventHandler(this.btnSrodki_Click);
            // 
            // ZarzadzanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(944, 610);
            this.Controls.Add(this.btnSrodki);
            this.Controls.Add(this.btnZamowienie);
            this.Controls.Add(this.btnFinanse);
            this.Controls.Add(this.btnFakturyWewnetrzne);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnFakturyZewnetrzne);
            this.Controls.Add(this.btnPracownicy);
            this.Controls.Add(this.btnKlienciForm);
            this.Name = "ZarzadzanieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZarzadzanieForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlienciForm;
        private System.Windows.Forms.Button btnPracownicy;
        private System.Windows.Forms.Button btnFakturyZewnetrzne;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnFakturyWewnetrzne;
        private System.Windows.Forms.Button btnFinanse;
        private System.Windows.Forms.Button btnZamowienie;
        private System.Windows.Forms.Button btnSrodki;
    }
}