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
            this.btnMagazyn = new System.Windows.Forms.Button();
            this.btnOferta = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // btnOferta
            // 
            this.btnOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOferta.Location = new System.Drawing.Point(633, 47);
            this.btnOferta.Margin = new System.Windows.Forms.Padding(4);
            this.btnOferta.Name = "btnOferta";
            this.btnOferta.Size = new System.Drawing.Size(285, 87);
            this.btnOferta.TabIndex = 1;
            this.btnOferta.Text = "Oferta";
            this.btnOferta.UseVisualStyleBackColor = true;
            this.btnOferta.Click += new System.EventHandler(this.btnOferta_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnOferta);
            this.Controls.Add(this.btnMagazyn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Start";
            this.Text = "Szwalnia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMagazyn;
        private System.Windows.Forms.Button btnOferta;
    }
}

