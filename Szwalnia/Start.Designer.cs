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
            this.btnFakturyZewnetrzne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElementy
            // 
            this.btnElementy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnElementy.Location = new System.Drawing.Point(28, 34);
            this.btnElementy.Name = "btnElementy";
            this.btnElementy.Size = new System.Drawing.Size(214, 75);
            this.btnElementy.TabIndex = 0;
            this.btnElementy.Text = "Elementy";
            this.btnElementy.UseVisualStyleBackColor = true;
            this.btnElementy.Click += new System.EventHandler(this.btnElementy_Click);
            // 
            // btnFakturyZewnetrzne
            // 
            this.btnFakturyZewnetrzne.Font = new System.Drawing.Font("Microsoft Sans Serif", 31F);
            this.btnFakturyZewnetrzne.Location = new System.Drawing.Point(270, 34);
            this.btnFakturyZewnetrzne.Name = "btnFakturyZewnetrzne";
            this.btnFakturyZewnetrzne.Size = new System.Drawing.Size(419, 92);
            this.btnFakturyZewnetrzne.TabIndex = 1;
            this.btnFakturyZewnetrzne.Text = "Faktury zewnetrzne";
            this.btnFakturyZewnetrzne.UseVisualStyleBackColor = true;
            this.btnFakturyZewnetrzne.Click += new System.EventHandler(this.btnKlienci_Click);
            this.btnFakturyZewnetrzne.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFakturyZewnetrzne_MouseClick);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 633);
            this.Controls.Add(this.btnFakturyZewnetrzne);
            this.Controls.Add(this.btnElementy);
            this.Name = "Start";
            this.Text = "Szwalnia";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnElementy;
        private System.Windows.Forms.Button btnFakturyZewnetrzne;
    }
}

