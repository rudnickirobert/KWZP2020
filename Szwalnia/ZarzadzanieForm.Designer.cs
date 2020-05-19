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
            this.btnBilans = new System.Windows.Forms.Button();
            this.btnZamowienie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKlienciForm
            // 
            this.btnKlienciForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKlienciForm.Location = new System.Drawing.Point(24, 150);
            this.btnKlienciForm.Name = "btnKlienciForm";
            this.btnKlienciForm.Size = new System.Drawing.Size(211, 93);
            this.btnKlienciForm.TabIndex = 0;
            this.btnKlienciForm.Text = "Panel klienta";
            this.btnKlienciForm.UseVisualStyleBackColor = true;
            this.btnKlienciForm.Click += new System.EventHandler(this.btnKlienciForm_Click);
            // 
            // btnPracownicy
            // 
            this.btnPracownicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPracownicy.Location = new System.Drawing.Point(24, 285);
            this.btnPracownicy.Name = "btnPracownicy";
            this.btnPracownicy.Size = new System.Drawing.Size(211, 93);
            this.btnPracownicy.TabIndex = 1;
            this.btnPracownicy.Text = "Panel pracownika";
            this.btnPracownicy.UseVisualStyleBackColor = true;
            this.btnPracownicy.Click += new System.EventHandler(this.btnPracownicy_Click);
            // 
            // btnFakturyZewnetrzne
            // 
            this.btnFakturyZewnetrzne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFakturyZewnetrzne.Location = new System.Drawing.Point(304, 14);
            this.btnFakturyZewnetrzne.Name = "btnFakturyZewnetrzne";
            this.btnFakturyZewnetrzne.Size = new System.Drawing.Size(208, 91);
            this.btnFakturyZewnetrzne.TabIndex = 2;
            this.btnFakturyZewnetrzne.Text = "Faktury Zewnętrzne";
            this.btnFakturyZewnetrzne.UseVisualStyleBackColor = true;
            this.btnFakturyZewnetrzne.Click += new System.EventHandler(this.btnFakturyZewnetrzne_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(403, 456);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(109, 38);
            this.btnZamknij.TabIndex = 3;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnFakturyWewnetrzne
            // 
            this.btnFakturyWewnetrzne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFakturyWewnetrzne.Location = new System.Drawing.Point(304, 150);
            this.btnFakturyWewnetrzne.Name = "btnFakturyWewnetrzne";
            this.btnFakturyWewnetrzne.Size = new System.Drawing.Size(208, 89);
            this.btnFakturyWewnetrzne.TabIndex = 4;
            this.btnFakturyWewnetrzne.Text = "Faktury Wystawione";
            this.btnFakturyWewnetrzne.UseVisualStyleBackColor = true;
            this.btnFakturyWewnetrzne.Click += new System.EventHandler(this.btnFakturyWewnetrzne_Click);
            // 
            // btnBilans
            // 
            this.btnBilans.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBilans.Location = new System.Drawing.Point(304, 285);
            this.btnBilans.Name = "btnBilans";
            this.btnBilans.Size = new System.Drawing.Size(208, 93);
            this.btnBilans.TabIndex = 5;
            this.btnBilans.Text = "Bilans";
            this.btnBilans.UseVisualStyleBackColor = true;
            this.btnBilans.Click += new System.EventHandler(this.btnBilans_Click);
            // 
            // btnZamowienie
            // 
            this.btnZamowienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZamowienie.Location = new System.Drawing.Point(24, 12);
            this.btnZamowienie.Name = "btnZamowienie";
            this.btnZamowienie.Size = new System.Drawing.Size(211, 93);
            this.btnZamowienie.TabIndex = 6;
            this.btnZamowienie.Text = "Panel zamówień";
            this.btnZamowienie.UseVisualStyleBackColor = true;
            this.btnZamowienie.Click += new System.EventHandler(this.btnZamowienie_Click);
            // 
            // ZarzadzanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(522, 506);
            this.Controls.Add(this.btnZamowienie);
            this.Controls.Add(this.btnBilans);
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
        private System.Windows.Forms.Button btnBilans;
        private System.Windows.Forms.Button btnZamowienie;
    }
}