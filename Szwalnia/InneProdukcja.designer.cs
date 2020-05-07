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
            this.btnSzacowanyCzas = new System.Windows.Forms.Button();
            this.btnNowyRodzajEtapu = new System.Windows.Forms.Button();
            this.btnRodzajEtapu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSredniCzasProdukcji
            // 
            this.btnSredniCzasProdukcji.Location = new System.Drawing.Point(94, 30);
            this.btnSredniCzasProdukcji.Margin = new System.Windows.Forms.Padding(6);
            this.btnSredniCzasProdukcji.Name = "btnSredniCzasProdukcji";
            this.btnSredniCzasProdukcji.Size = new System.Drawing.Size(300, 90);
            this.btnSredniCzasProdukcji.TabIndex = 0;
            this.btnSredniCzasProdukcji.Text = "Średni czas produkcji wg produktu";
            this.btnSredniCzasProdukcji.UseVisualStyleBackColor = true;
            this.btnSredniCzasProdukcji.Click += new System.EventHandler(this.btnSredniCzasProdukcji_Click);
            // 
            // btnSzacowanyCzas
            // 
            this.btnSzacowanyCzas.Location = new System.Drawing.Point(94, 132);
            this.btnSzacowanyCzas.Margin = new System.Windows.Forms.Padding(6);
            this.btnSzacowanyCzas.Name = "btnSzacowanyCzas";
            this.btnSzacowanyCzas.Size = new System.Drawing.Size(300, 90);
            this.btnSzacowanyCzas.TabIndex = 0;
            this.btnSzacowanyCzas.Text = "Szacowany czas wykonania nowego zamówienia";
            this.btnSzacowanyCzas.UseVisualStyleBackColor = true;
            this.btnSzacowanyCzas.Click += new System.EventHandler(this.btnSzacowanyCzas_Click);
            // 
            // btnNowyRodzajEtapu
            // 
            this.btnNowyRodzajEtapu.Location = new System.Drawing.Point(94, 336);
            this.btnNowyRodzajEtapu.Margin = new System.Windows.Forms.Padding(6);
            this.btnNowyRodzajEtapu.Name = "btnNowyRodzajEtapu";
            this.btnNowyRodzajEtapu.Size = new System.Drawing.Size(300, 90);
            this.btnNowyRodzajEtapu.TabIndex = 0;
            this.btnNowyRodzajEtapu.Text = "Nowy rodzaj etapu";
            this.btnNowyRodzajEtapu.UseVisualStyleBackColor = true;
            this.btnNowyRodzajEtapu.Click += new System.EventHandler(this.btnNowyRodzajEtapu_Click);
            // 
            // btnRodzajEtapu
            // 
            this.btnRodzajEtapu.Location = new System.Drawing.Point(94, 234);
            this.btnRodzajEtapu.Margin = new System.Windows.Forms.Padding(6);
            this.btnRodzajEtapu.Name = "btnRodzajEtapu";
            this.btnRodzajEtapu.Size = new System.Drawing.Size(300, 90);
            this.btnRodzajEtapu.TabIndex = 0;
            this.btnRodzajEtapu.Text = "Rodzaj Etapu";
            this.btnRodzajEtapu.UseVisualStyleBackColor = true;
            this.btnRodzajEtapu.Click += new System.EventHandler(this.btnRodzajEtapu_Click);
            // 
            // InneProdukcja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 472);
            this.Controls.Add(this.btnRodzajEtapu);
            this.Controls.Add(this.btnNowyRodzajEtapu);
            this.Controls.Add(this.btnSzacowanyCzas);
            this.Controls.Add(this.btnSredniCzasProdukcji);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "InneProdukcja";
            this.Text = "Inne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSredniCzasProdukcji;
        private System.Windows.Forms.Button btnSzacowanyCzas;
        private System.Windows.Forms.Button btnNowyRodzajEtapu;
        private System.Windows.Forms.Button btnRodzajEtapu;
    }
}