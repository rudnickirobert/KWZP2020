namespace Szwalnia
{
    partial class NiewykorzystanyMaterialWMiesiacu
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
            this.dgvNiewykorzystanyMaterial = new System.Windows.Forms.DataGridView();
            this.lblMiesiac = new System.Windows.Forms.Label();
            this.nudNumerMiesiaca = new System.Windows.Forms.NumericUpDown();
            this.btnPokaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiewykorzystanyMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerMiesiaca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNiewykorzystanyMaterial
            // 
            this.dgvNiewykorzystanyMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiewykorzystanyMaterial.Location = new System.Drawing.Point(36, 78);
            this.dgvNiewykorzystanyMaterial.Name = "dgvNiewykorzystanyMaterial";
            this.dgvNiewykorzystanyMaterial.Size = new System.Drawing.Size(709, 344);
            this.dgvNiewykorzystanyMaterial.TabIndex = 0;
            // 
            // lblMiesiac
            // 
            this.lblMiesiac.AutoSize = true;
            this.lblMiesiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMiesiac.Location = new System.Drawing.Point(208, 37);
            this.lblMiesiac.Name = "lblMiesiac";
            this.lblMiesiac.Size = new System.Drawing.Size(159, 18);
            this.lblMiesiac.TabIndex = 1;
            this.lblMiesiac.Text = "Wpisz numer miesiąca";
            // 
            // nudNumerMiesiaca
            // 
            this.nudNumerMiesiaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudNumerMiesiaca.Location = new System.Drawing.Point(431, 34);
            this.nudNumerMiesiaca.Name = "nudNumerMiesiaca";
            this.nudNumerMiesiaca.Size = new System.Drawing.Size(120, 24);
            this.nudNumerMiesiaca.TabIndex = 2;
            // 
            // btnPokaz
            // 
            this.btnPokaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPokaz.Location = new System.Drawing.Point(591, 31);
            this.btnPokaz.Name = "btnPokaz";
            this.btnPokaz.Size = new System.Drawing.Size(75, 23);
            this.btnPokaz.TabIndex = 3;
            this.btnPokaz.Text = "Pokaż";
            this.btnPokaz.UseVisualStyleBackColor = true;
            this.btnPokaz.Click += new System.EventHandler(this.btnPokaz_Click);
            // 
            // NiewykorzystanyMaterialWMiesiacu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPokaz);
            this.Controls.Add(this.nudNumerMiesiaca);
            this.Controls.Add(this.lblMiesiac);
            this.Controls.Add(this.dgvNiewykorzystanyMaterial);
            this.Name = "NiewykorzystanyMaterialWMiesiacu";
            this.Text = "Niewykorzystany Material W Miesiacu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiewykorzystanyMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerMiesiaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNiewykorzystanyMaterial;
        private System.Windows.Forms.Label lblMiesiac;
        private System.Windows.Forms.NumericUpDown nudNumerMiesiaca;
        private System.Windows.Forms.Button btnPokaz;
    }
}