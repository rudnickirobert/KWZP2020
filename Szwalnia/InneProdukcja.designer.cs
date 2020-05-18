namespace Szwalnia
{
    partial class InneProdukcja
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
            this.btnSredniCzasProdukcji = new System.Windows.Forms.Button();
            this.btnSzacowanyCzasProdukcja = new System.Windows.Forms.Button();
            this.btnNowyRodzajEtapu = new System.Windows.Forms.Button();
            this.btnRodzajEtapu = new System.Windows.Forms.Button();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.btnSzacowanyCzasTechnologia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSredniCzasProdukcji
            // 
            this.btnSredniCzasProdukcji.Location = new System.Drawing.Point(68, 70);
            this.btnSredniCzasProdukcji.Margin = new System.Windows.Forms.Padding(6);
            this.btnSredniCzasProdukcji.Name = "btnSredniCzasProdukcji";
            this.btnSredniCzasProdukcji.Size = new System.Drawing.Size(300, 80);
            this.btnSredniCzasProdukcji.TabIndex = 0;
            this.btnSredniCzasProdukcji.Text = "Średni czas produkcji wg produktu";
            this.btnSredniCzasProdukcji.UseVisualStyleBackColor = true;
            this.btnSredniCzasProdukcji.Click += new System.EventHandler(this.btnSredniCzasProdukcji_Click);
            // 
            // btnSzacowanyCzasProdukcja
            // 
            this.btnSzacowanyCzasProdukcja.Location = new System.Drawing.Point(68, 162);
            this.btnSzacowanyCzasProdukcja.Margin = new System.Windows.Forms.Padding(6);
            this.btnSzacowanyCzasProdukcja.Name = "btnSzacowanyCzasProdukcja";
            this.btnSzacowanyCzasProdukcja.Size = new System.Drawing.Size(300, 80);
            this.btnSzacowanyCzasProdukcja.TabIndex = 0;
            this.btnSzacowanyCzasProdukcja.Text = "Szacowany czas wykonania produktu wg produkcji";
            this.btnSzacowanyCzasProdukcja.UseVisualStyleBackColor = true;
            this.btnSzacowanyCzasProdukcja.Click += new System.EventHandler(this.btnSzacowanyCzas_Click);
            // 
            // btnNowyRodzajEtapu
            // 
            this.btnNowyRodzajEtapu.Location = new System.Drawing.Point(68, 438);
            this.btnNowyRodzajEtapu.Margin = new System.Windows.Forms.Padding(6);
            this.btnNowyRodzajEtapu.Name = "btnNowyRodzajEtapu";
            this.btnNowyRodzajEtapu.Size = new System.Drawing.Size(300, 80);
            this.btnNowyRodzajEtapu.TabIndex = 0;
            this.btnNowyRodzajEtapu.Text = "Nowy rodzaj etapu";
            this.btnNowyRodzajEtapu.UseVisualStyleBackColor = true;
            this.btnNowyRodzajEtapu.Click += new System.EventHandler(this.btnNowyRodzajEtapu_Click);
            // 
            // btnRodzajEtapu
            // 
            this.btnRodzajEtapu.Location = new System.Drawing.Point(68, 346);
            this.btnRodzajEtapu.Margin = new System.Windows.Forms.Padding(6);
            this.btnRodzajEtapu.Name = "btnRodzajEtapu";
            this.btnRodzajEtapu.Size = new System.Drawing.Size(300, 80);
            this.btnRodzajEtapu.TabIndex = 0;
            this.btnRodzajEtapu.Text = "Rodzaj etapu";
            this.btnRodzajEtapu.UseVisualStyleBackColor = true;
            this.btnRodzajEtapu.Click += new System.EventHandler(this.btnRodzajEtapu_Click);
            // 
            // btnWstecz
            // 
            this.btnWstecz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWstecz.Location = new System.Drawing.Point(12, 12);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(75, 30);
            this.btnWstecz.TabIndex = 9;
            this.btnWstecz.Text = "wstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // btnSzacowanyCzasTechnologia
            // 
            this.btnSzacowanyCzasTechnologia.Location = new System.Drawing.Point(68, 254);
            this.btnSzacowanyCzasTechnologia.Margin = new System.Windows.Forms.Padding(6);
            this.btnSzacowanyCzasTechnologia.Name = "btnSzacowanyCzasTechnologia";
            this.btnSzacowanyCzasTechnologia.Size = new System.Drawing.Size(300, 80);
            this.btnSzacowanyCzasTechnologia.TabIndex = 10;
            this.btnSzacowanyCzasTechnologia.Text = "Szacowany czas wykonania zamówienia wg technologii";
            this.btnSzacowanyCzasTechnologia.UseVisualStyleBackColor = true;
            this.btnSzacowanyCzasTechnologia.Click += new System.EventHandler(this.button1_Click);
            // 
            // InneProdukcja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 531);
            this.Controls.Add(this.btnSzacowanyCzasTechnologia);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.btnRodzajEtapu);
            this.Controls.Add(this.btnNowyRodzajEtapu);
            this.Controls.Add(this.btnSzacowanyCzasProdukcja);
            this.Controls.Add(this.btnSredniCzasProdukcji);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "InneProdukcja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSredniCzasProdukcji;
        private System.Windows.Forms.Button btnSzacowanyCzasProdukcja;
        private System.Windows.Forms.Button btnNowyRodzajEtapu;
        private System.Windows.Forms.Button btnRodzajEtapu;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.Button btnSzacowanyCzasTechnologia;
    }
}