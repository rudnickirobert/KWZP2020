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
            this.btnProcesProdukcyjny = new System.Windows.Forms.Button();
            this.btnRaporty = new System.Windows.Forms.Button();
            this.btnInne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcesyZamowienie
            // 
            this.btnProcesyZamowienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProcesyZamowienie.Location = new System.Drawing.Point(440, 385);
            this.btnProcesyZamowienie.Name = "btnProcesyZamowienie";
            this.btnProcesyZamowienie.Size = new System.Drawing.Size(46, 44);
            this.btnProcesyZamowienie.TabIndex = 0;
            this.btnProcesyZamowienie.Text = "Procesy produkcyjne w zamowieniu";
            this.btnProcesyZamowienie.UseVisualStyleBackColor = true;
            this.btnProcesyZamowienie.Click += new System.EventHandler(this.btnProcesyZamowienie_Click);
            // 
            // btnRealizacjaProcesu
            // 
            this.btnRealizacjaProcesu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRealizacjaProcesu.Location = new System.Drawing.Point(511, 385);
            this.btnRealizacjaProcesu.Name = "btnRealizacjaProcesu";
            this.btnRealizacjaProcesu.Size = new System.Drawing.Size(54, 44);
            this.btnRealizacjaProcesu.TabIndex = 1;
            this.btnRealizacjaProcesu.Text = "Szczegóły realizacji procesu";
            this.btnRealizacjaProcesu.UseVisualStyleBackColor = true;
            this.btnRealizacjaProcesu.Click += new System.EventHandler(this.btnRealizacjaProcesu_Click);
            // 
            // btnPrzydzialZasobow
            // 
            this.btnPrzydzialZasobow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzydzialZasobow.Location = new System.Drawing.Point(583, 385);
            this.btnPrzydzialZasobow.Name = "btnPrzydzialZasobow";
            this.btnPrzydzialZasobow.Size = new System.Drawing.Size(46, 44);
            this.btnPrzydzialZasobow.TabIndex = 2;
            this.btnPrzydzialZasobow.Text = "Przydział zasobów";
            this.btnPrzydzialZasobow.UseVisualStyleBackColor = true;
            // 
            // btnProcesProdukcyjny
            // 
            this.btnProcesProdukcyjny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProcesProdukcyjny.Location = new System.Drawing.Point(56, 21);
            this.btnProcesProdukcyjny.Name = "btnProcesProdukcyjny";
            this.btnProcesProdukcyjny.Size = new System.Drawing.Size(300, 120);
            this.btnProcesProdukcyjny.TabIndex = 3;
            this.btnProcesProdukcyjny.Text = "Proces Produkcyjny";
            this.btnProcesProdukcyjny.UseVisualStyleBackColor = true;
            this.btnProcesProdukcyjny.Click += new System.EventHandler(this.btnProcesProdukcyjny_Click);
            // 
            // btnRaporty
            // 
            this.btnRaporty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRaporty.Location = new System.Drawing.Point(56, 164);
            this.btnRaporty.Name = "btnRaporty";
            this.btnRaporty.Size = new System.Drawing.Size(300, 120);
            this.btnRaporty.TabIndex = 4;
            this.btnRaporty.Text = "Raporty";
            this.btnRaporty.UseVisualStyleBackColor = true;
            this.btnRaporty.Click += new System.EventHandler(this.btnRaporty_Click);
            // 
            // btnInne
            // 
            this.btnInne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInne.Location = new System.Drawing.Point(56, 318);
            this.btnInne.Name = "btnInne";
            this.btnInne.Size = new System.Drawing.Size(300, 120);
            this.btnInne.TabIndex = 5;
            this.btnInne.Text = "Inne";
            this.btnInne.UseVisualStyleBackColor = true;
            this.btnInne.Click += new System.EventHandler(this.btnInne_Click);
            // 
            // Produkcja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.btnInne);
            this.Controls.Add(this.btnRaporty);
            this.Controls.Add(this.btnProcesProdukcyjny);
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
        private System.Windows.Forms.Button btnProcesProdukcyjny;
        private System.Windows.Forms.Button btnRaporty;
        private System.Windows.Forms.Button btnInne;
    }
}