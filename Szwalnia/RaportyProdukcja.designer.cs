namespace Szwalnia
{
    partial class RaportyProdukcja
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
            this.btnOdpadyProces = new System.Windows.Forms.Button();
            this.btnNiewykorzystanyMaterial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdpadyProces
            // 
            this.btnOdpadyProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdpadyProces.Location = new System.Drawing.Point(88, 29);
            this.btnOdpadyProces.Name = "btnOdpadyProces";
            this.btnOdpadyProces.Size = new System.Drawing.Size(300, 120);
            this.btnOdpadyProces.TabIndex = 0;
            this.btnOdpadyProces.Text = "Największy odpad w procesie / miesiąc";
            this.btnOdpadyProces.UseVisualStyleBackColor = true;
            this.btnOdpadyProces.Click += new System.EventHandler(this.btnOdpadyProces_Click);
            // 
            // btnNiewykorzystanyMaterial
            // 
            this.btnNiewykorzystanyMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNiewykorzystanyMaterial.Location = new System.Drawing.Point(88, 164);
            this.btnNiewykorzystanyMaterial.Name = "btnNiewykorzystanyMaterial";
            this.btnNiewykorzystanyMaterial.Size = new System.Drawing.Size(300, 120);
            this.btnNiewykorzystanyMaterial.TabIndex = 1;
            this.btnNiewykorzystanyMaterial.Text = "Niewykorzystany materiał w procesie / miesiąc";
            this.btnNiewykorzystanyMaterial.UseVisualStyleBackColor = true;
            this.btnNiewykorzystanyMaterial.Click += new System.EventHandler(this.btnNiewykorzystanyMaterial_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(88, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 120);
            this.button1.TabIndex = 2;
            this.button1.Text = "Błędne produkty / miesiąc";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RaportyProdukcja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNiewykorzystanyMaterial);
            this.Controls.Add(this.btnOdpadyProces);
            this.Name = "RaportyProdukcja";
            this.Text = "Raporty";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdpadyProces;
        private System.Windows.Forms.Button btnNiewykorzystanyMaterial;
        private System.Windows.Forms.Button button1;
    }
}