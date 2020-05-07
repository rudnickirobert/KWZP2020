namespace Szwalnia
{
    partial class SzczegolyProcesu
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
            this.btnPrzydzialZasobow = new System.Windows.Forms.Button();
            this.btnRealizacjaProcesu = new System.Windows.Forms.Button();
            this.btnKontrolaEfektywnosci = new System.Windows.Forms.Button();
            this.btnMaterialProdukcja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrzydzialZasobow
            // 
            this.btnPrzydzialZasobow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzydzialZasobow.Location = new System.Drawing.Point(78, 50);
            this.btnPrzydzialZasobow.Name = "btnPrzydzialZasobow";
            this.btnPrzydzialZasobow.Size = new System.Drawing.Size(300, 80);
            this.btnPrzydzialZasobow.TabIndex = 0;
            this.btnPrzydzialZasobow.Text = "Przydział zasobów";
            this.btnPrzydzialZasobow.UseVisualStyleBackColor = true;
            // 
            // btnRealizacjaProcesu
            // 
            this.btnRealizacjaProcesu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRealizacjaProcesu.Location = new System.Drawing.Point(78, 136);
            this.btnRealizacjaProcesu.Name = "btnRealizacjaProcesu";
            this.btnRealizacjaProcesu.Size = new System.Drawing.Size(300, 80);
            this.btnRealizacjaProcesu.TabIndex = 0;
            this.btnRealizacjaProcesu.Text = "Realizacja procesu";
            this.btnRealizacjaProcesu.UseVisualStyleBackColor = true;
            this.btnRealizacjaProcesu.Click += new System.EventHandler(this.btnRealizacjaProcesu_Click);
            // 
            // btnKontrolaEfektywnosci
            // 
            this.btnKontrolaEfektywnosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKontrolaEfektywnosci.Location = new System.Drawing.Point(78, 222);
            this.btnKontrolaEfektywnosci.Name = "btnKontrolaEfektywnosci";
            this.btnKontrolaEfektywnosci.Size = new System.Drawing.Size(300, 80);
            this.btnKontrolaEfektywnosci.TabIndex = 0;
            this.btnKontrolaEfektywnosci.Text = "Kontrola efektywności";
            this.btnKontrolaEfektywnosci.UseVisualStyleBackColor = true;
            this.btnKontrolaEfektywnosci.Click += new System.EventHandler(this.btnKontrolaEfektywnosci_Click);
            // 
            // btnMaterialProdukcja
            // 
            this.btnMaterialProdukcja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMaterialProdukcja.Location = new System.Drawing.Point(78, 308);
            this.btnMaterialProdukcja.Name = "btnMaterialProdukcja";
            this.btnMaterialProdukcja.Size = new System.Drawing.Size(300, 80);
            this.btnMaterialProdukcja.TabIndex = 0;
            this.btnMaterialProdukcja.Text = "Niewkorzystany materiał / Odpad";
            this.btnMaterialProdukcja.UseVisualStyleBackColor = true;
            this.btnMaterialProdukcja.Click += new System.EventHandler(this.btnMaterialProdukcja_Click);
            // 
            // SzczegolyProcesu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 419);
            this.Controls.Add(this.btnMaterialProdukcja);
            this.Controls.Add(this.btnKontrolaEfektywnosci);
            this.Controls.Add(this.btnRealizacjaProcesu);
            this.Controls.Add(this.btnPrzydzialZasobow);
            this.Name = "SzczegolyProcesu";
            this.Text = "Szczegoly Procesu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrzydzialZasobow;
        private System.Windows.Forms.Button btnRealizacjaProcesu;
        private System.Windows.Forms.Button btnKontrolaEfektywnosci;
        private System.Windows.Forms.Button btnMaterialProdukcja;
    }
}