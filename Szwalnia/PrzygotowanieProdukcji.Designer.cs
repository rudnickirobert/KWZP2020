namespace Szwalnia
{
    partial class PrzygotowanieProdukcji
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
            this.btnObslugaMaszyn = new System.Windows.Forms.Button();
            this.btnMaszynySerwis = new System.Windows.Forms.Button();
            this.btnSredniaIloscMaszyn = new System.Windows.Forms.Button();
            this.btnSumaCzasuProcesu = new System.Windows.Forms.Button();
            this.btnMaszynyProcesLiczba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObslugaMaszyn
            // 
            this.btnObslugaMaszyn.Location = new System.Drawing.Point(58, 316);
            this.btnObslugaMaszyn.Margin = new System.Windows.Forms.Padding(4);
            this.btnObslugaMaszyn.Name = "btnObslugaMaszyn";
            this.btnObslugaMaszyn.Size = new System.Drawing.Size(196, 57);
            this.btnObslugaMaszyn.TabIndex = 9;
            this.btnObslugaMaszyn.Text = "Obsluga Maszyn";
            this.btnObslugaMaszyn.UseVisualStyleBackColor = true;
            this.btnObslugaMaszyn.Click += new System.EventHandler(this.btnObslugaMaszyn_Click);
            // 
            // btnMaszynySerwis
            // 
            this.btnMaszynySerwis.Location = new System.Drawing.Point(58, 252);
            this.btnMaszynySerwis.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaszynySerwis.Name = "btnMaszynySerwis";
            this.btnMaszynySerwis.Size = new System.Drawing.Size(196, 55);
            this.btnMaszynySerwis.TabIndex = 8;
            this.btnMaszynySerwis.Text = "Maszyny Serwis";
            this.btnMaszynySerwis.UseVisualStyleBackColor = true;
            this.btnMaszynySerwis.Click += new System.EventHandler(this.btnMaszynySerwis_Click);
            // 
            // btnSredniaIloscMaszyn
            // 
            this.btnSredniaIloscMaszyn.Location = new System.Drawing.Point(58, 188);
            this.btnSredniaIloscMaszyn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSredniaIloscMaszyn.Name = "btnSredniaIloscMaszyn";
            this.btnSredniaIloscMaszyn.Size = new System.Drawing.Size(196, 55);
            this.btnSredniaIloscMaszyn.TabIndex = 7;
            this.btnSredniaIloscMaszyn.Text = "Srednia Ilosc Maszyn";
            this.btnSredniaIloscMaszyn.UseVisualStyleBackColor = true;
            this.btnSredniaIloscMaszyn.Click += new System.EventHandler(this.btnSredniaIloscMaszyn_Click);
            // 
            // btnSumaCzasuProcesu
            // 
            this.btnSumaCzasuProcesu.Location = new System.Drawing.Point(57, 124);
            this.btnSumaCzasuProcesu.Margin = new System.Windows.Forms.Padding(4);
            this.btnSumaCzasuProcesu.Name = "btnSumaCzasuProcesu";
            this.btnSumaCzasuProcesu.Size = new System.Drawing.Size(197, 55);
            this.btnSumaCzasuProcesu.TabIndex = 6;
            this.btnSumaCzasuProcesu.Text = "Suma Czasu Proces";
            this.btnSumaCzasuProcesu.UseVisualStyleBackColor = true;
            this.btnSumaCzasuProcesu.Click += new System.EventHandler(this.btnSumaCzasuProcesu_Click);
            // 
            // btnMaszynyProcesLiczba
            // 
            this.btnMaszynyProcesLiczba.Location = new System.Drawing.Point(57, 61);
            this.btnMaszynyProcesLiczba.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaszynyProcesLiczba.Name = "btnMaszynyProcesLiczba";
            this.btnMaszynyProcesLiczba.Size = new System.Drawing.Size(197, 55);
            this.btnMaszynyProcesLiczba.TabIndex = 5;
            this.btnMaszynyProcesLiczba.Text = "Maszyny Proces Liczba";
            this.btnMaszynyProcesLiczba.UseVisualStyleBackColor = true;
            this.btnMaszynyProcesLiczba.Click += new System.EventHandler(this.btnMaszynyProcesLiczba_Click);
            // 
            // PrzygotowanieProdukcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.btnObslugaMaszyn);
            this.Controls.Add(this.btnMaszynySerwis);
            this.Controls.Add(this.btnSredniaIloscMaszyn);
            this.Controls.Add(this.btnSumaCzasuProcesu);
            this.Controls.Add(this.btnMaszynyProcesLiczba);
            this.Name = "PrzygotowanieProdukcji";
            this.Text = "Przygotowanie_Produkcji";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObslugaMaszyn;
        private System.Windows.Forms.Button btnMaszynySerwis;
        private System.Windows.Forms.Button btnSredniaIloscMaszyn;
        private System.Windows.Forms.Button btnSumaCzasuProcesu;
        private System.Windows.Forms.Button btnMaszynyProcesLiczba;
    }
}