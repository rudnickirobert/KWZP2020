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
            this.btnElementy = new System.Windows.Forms.Button();
            this.btnPrzydzialZasobow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElementy
            // 
            this.btnElementy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnElementy.Location = new System.Drawing.Point(37, 42);
            this.btnElementy.Margin = new System.Windows.Forms.Padding(4);
            this.btnElementy.Name = "btnElementy";
            this.btnElementy.Size = new System.Drawing.Size(285, 92);
            this.btnElementy.TabIndex = 0;
            this.btnElementy.Text = "Elementy";
            this.btnElementy.UseVisualStyleBackColor = true;
            this.btnElementy.Click += new System.EventHandler(this.btnElementy_Click);
            // 
            // btnPrzydzialZasobow
            // 
            this.btnPrzydzialZasobow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzydzialZasobow.Location = new System.Drawing.Point(671, 49);
            this.btnPrzydzialZasobow.Name = "btnPrzydzialZasobow";
            this.btnPrzydzialZasobow.Size = new System.Drawing.Size(254, 92);
            this.btnPrzydzialZasobow.TabIndex = 1;
            this.btnPrzydzialZasobow.Text = "Przydzial Zasobow";
            this.btnPrzydzialZasobow.UseVisualStyleBackColor = true;
            this.btnPrzydzialZasobow.Click += new System.EventHandler(this.btnPrzydzialZasobow_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnPrzydzialZasobow);
            this.Controls.Add(this.btnElementy);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Start";
            this.Text = "Szwalnia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnElementy;
        private System.Windows.Forms.Button btnPrzydzialZasobow;
    }
}

