namespace Szwalnia
{
    partial class Start
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRealizacjaProcesu = new System.Windows.Forms.Button();
            this.btnMagazyn = new System.Windows.Forms.Button();
            this.btnPrzydzialZasobow = new System.Windows.Forms.Button();
            this.btnPrzygotowanieProdukcji = new System.Windows.Forms.Button();
            this.btnZarzadzanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRealizacjaProcesu
            // 
            this.btnRealizacjaProcesu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRealizacjaProcesu.Location = new System.Drawing.Point(21, 132);
            this.btnRealizacjaProcesu.Margin = new System.Windows.Forms.Padding(2);
            this.btnRealizacjaProcesu.Name = "btnRealizacjaProcesu";
            this.btnRealizacjaProcesu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRealizacjaProcesu.Size = new System.Drawing.Size(160, 58);
            this.btnRealizacjaProcesu.TabIndex = 1;
            this.btnRealizacjaProcesu.Text = "Realizacja procesu";
            this.btnRealizacjaProcesu.UseVisualStyleBackColor = true;
            this.btnRealizacjaProcesu.Click += new System.EventHandler(this.btnRealizacjaProcesu_Click);
            // 
            // btnMagazyn
            // 
            this.btnMagazyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMagazyn.Location = new System.Drawing.Point(28, 34);
            this.btnMagazyn.Name = "btnMagazyn";
            this.btnMagazyn.Size = new System.Drawing.Size(214, 75);
            this.btnMagazyn.TabIndex = 0;
            this.btnMagazyn.Text = "Magazyn";
            this.btnMagazyn.UseVisualStyleBackColor = true;
            this.btnMagazyn.Click += new System.EventHandler(this.btnMagazyn_Click);
            // 
            // btnPrzydzialZasobow
            // 
            this.btnPrzydzialZasobow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzydzialZasobow.Location = new System.Drawing.Point(377, 32);
            this.btnPrzydzialZasobow.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrzydzialZasobow.Name = "btnPrzydzialZasobow";
            this.btnPrzydzialZasobow.Size = new System.Drawing.Size(142, 61);
            this.btnPrzydzialZasobow.TabIndex = 1;
            this.btnPrzydzialZasobow.Text = "Przydzial Zasobow";
            this.btnPrzydzialZasobow.UseVisualStyleBackColor = true;
            // 
            // btnPrzygotowanieProdukcji
            // 
            this.btnPrzygotowanieProdukcji.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzygotowanieProdukcji.Location = new System.Drawing.Point(37, 169);
            this.btnPrzygotowanieProdukcji.Name = "btnPrzygotowanieProdukcji";
            this.btnPrzygotowanieProdukcji.Size = new System.Drawing.Size(285, 90);
            this.btnPrzygotowanieProdukcji.TabIndex = 1;
            this.btnPrzygotowanieProdukcji.Text = "Przygotowanie produkcji";
            this.btnPrzygotowanieProdukcji.UseVisualStyleBackColor = true;
            // 
            // btnZarzadzanie
            // 
            this.btnZarzadzanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZarzadzanie.Location = new System.Drawing.Point(21, 239);
            this.btnZarzadzanie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZarzadzanie.Name = "btnZarzadzanie";
            this.btnZarzadzanie.Size = new System.Drawing.Size(220, 72);
            this.btnZarzadzanie.TabIndex = 0;
            this.btnZarzadzanie.Text = "Zarzadzanie";
            this.btnZarzadzanie.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnZarzadzanie_MouseClick);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnZarzadzanie);
            this.Controls.Add(this.btnRealizacjaProcesu);
            this.Controls.Add(this.btnMagazyn);
            this.Controls.Add(this.btnPrzydzialZasobow);
            this.Name = "Start";
            this.Text = "Szwalnia";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRealizacjaProcesu;
        private System.Windows.Forms.Button btnMagazyn;
        private System.Windows.Forms.Button btnPrzydzialZasobow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnZamowienieProces;
        private System.Windows.Forms.Button btnZarzadzanie;
        private System.Windows.Forms.Button btnPrzygotowanieProdukcji;
    }
}

