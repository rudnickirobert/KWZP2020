namespace Szwalnia
{
    partial class Produkcja
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
            this.btnProcesyZamowienie = new System.Windows.Forms.Button();
            this.btnRealizacjaProcesu = new System.Windows.Forms.Button();
            this.btnPrzydzialZasobow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcesyZamowienie
            // 
            this.btnProcesyZamowienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProcesyZamowienie.Location = new System.Drawing.Point(49, 25);
            this.btnProcesyZamowienie.Name = "btnProcesyZamowienie";
            this.btnProcesyZamowienie.Size = new System.Drawing.Size(156, 94);
            this.btnProcesyZamowienie.TabIndex = 0;
            this.btnProcesyZamowienie.Text = "Procesy produkcyjne w zamowieniu";
            this.btnProcesyZamowienie.UseVisualStyleBackColor = true;
            this.btnProcesyZamowienie.Click += new System.EventHandler(this.btnProcesyZamowienie_Click);
            // 
            // btnRealizacjaProcesu
            // 
            this.btnRealizacjaProcesu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRealizacjaProcesu.Location = new System.Drawing.Point(250, 25);
            this.btnRealizacjaProcesu.Name = "btnRealizacjaProcesu";
            this.btnRealizacjaProcesu.Size = new System.Drawing.Size(166, 94);
            this.btnRealizacjaProcesu.TabIndex = 1;
            this.btnRealizacjaProcesu.Text = "Szczegóły realizacji procesu";
            this.btnRealizacjaProcesu.UseVisualStyleBackColor = true;
            this.btnRealizacjaProcesu.Click += new System.EventHandler(this.btnRealizacjaProcesu_Click);
            // 
            // btnPrzydzialZasobow
            // 
            this.btnPrzydzialZasobow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzydzialZasobow.Location = new System.Drawing.Point(467, 25);
            this.btnPrzydzialZasobow.Name = "btnPrzydzialZasobow";
            this.btnPrzydzialZasobow.Size = new System.Drawing.Size(150, 94);
            this.btnPrzydzialZasobow.TabIndex = 2;
            this.btnPrzydzialZasobow.Text = "Przydział zasobów";
            this.btnPrzydzialZasobow.UseVisualStyleBackColor = true;
            // 
            // Produkcja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrzydzialZasobow);
            this.Controls.Add(this.btnRealizacjaProcesu);
            this.Controls.Add(this.btnProcesyZamowienie);
            this.Name = "Produkcja";
            this.Text = "Produkcja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcesyZamowienie;
        private System.Windows.Forms.Button btnRealizacjaProcesu;
        private System.Windows.Forms.Button btnPrzydzialZasobow;
    }
}