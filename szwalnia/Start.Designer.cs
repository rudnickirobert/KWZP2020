﻿namespace Szwalnia
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
            this.btnRealizacjaProcesu.Location = new System.Drawing.Point(479, 215);
            this.btnRealizacjaProcesu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRealizacjaProcesu.Name = "btnRealizacjaProcesu";
            this.btnRealizacjaProcesu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRealizacjaProcesu.Size = new System.Drawing.Size(213, 71);
            this.btnRealizacjaProcesu.TabIndex = 1;
            this.btnRealizacjaProcesu.Text = "Realizacja procesu";
            this.btnRealizacjaProcesu.UseVisualStyleBackColor = true;
            this.btnRealizacjaProcesu.Click += new System.EventHandler(this.btnRealizacjaProcesu_Click);
            // 
            // btnMagazyn
            // 
            this.btnMagazyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMagazyn.Location = new System.Drawing.Point(37, 42);
            this.btnMagazyn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMagazyn.Name = "btnMagazyn";
            this.btnMagazyn.Size = new System.Drawing.Size(285, 92);
            this.btnMagazyn.TabIndex = 0;
            this.btnMagazyn.Text = "Magazyn";
            this.btnMagazyn.UseVisualStyleBackColor = true;
            this.btnMagazyn.Click += new System.EventHandler(this.btnMagazyn_Click);
            // 
            // btnPrzydzialZasobow
            // 
            this.btnPrzydzialZasobow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzydzialZasobow.Location = new System.Drawing.Point(503, 39);
            this.btnPrzydzialZasobow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrzydzialZasobow.Name = "btnPrzydzialZasobow";
            this.btnPrzydzialZasobow.Size = new System.Drawing.Size(189, 75);
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
            this.btnZarzadzanie.Location = new System.Drawing.Point(49, 205);
            this.btnZarzadzanie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZarzadzanie.Name = "btnZarzadzanie";
            this.btnZarzadzanie.Size = new System.Drawing.Size(293, 89);
            this.btnZarzadzanie.TabIndex = 0;
            this.btnZarzadzanie.Text = "Zarzadzanie";
            this.btnZarzadzanie.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnZarzadzanie_MouseClick);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZarzadzanie);
            this.Controls.Add(this.btnRealizacjaProcesu);
            this.Controls.Add(this.btnMagazyn);
            this.Controls.Add(this.btnPrzydzialZasobow);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Start";
            this.Text = "Szwalnia";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRealizacjaProcesu;
        private System.Windows.Forms.Button btnMagazyn;
        private System.Windows.Forms.Button btnPrzydzialZasobow;
        private System.Windows.Forms.Button btnZarzadzanie;
        private System.Windows.Forms.Button btnPrzygotowanieProdukcji;
    }
}

