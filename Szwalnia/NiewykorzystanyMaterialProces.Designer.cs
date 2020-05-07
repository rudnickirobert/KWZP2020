namespace Szwalnia
{
    partial class NiewykorzystanyMaterialProces
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
            this.lblTekst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiewykorzystanyMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNiewykorzystanyMaterial
            // 
            this.dgvNiewykorzystanyMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiewykorzystanyMaterial.Location = new System.Drawing.Point(44, 68);
            this.dgvNiewykorzystanyMaterial.Name = "dgvNiewykorzystanyMaterial";
            this.dgvNiewykorzystanyMaterial.Size = new System.Drawing.Size(712, 319);
            this.dgvNiewykorzystanyMaterial.TabIndex = 0;
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Location = new System.Drawing.Point(332, 28);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(35, 13);
            this.lblTekst.TabIndex = 1;
            this.lblTekst.Text = "label1";
            // 
            // NiewykorzystanyMaterialProces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.dgvNiewykorzystanyMaterial);
            this.Name = "NiewykorzystanyMaterialProces";
            this.Text = "Niewykorzystany Material Proces";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiewykorzystanyMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNiewykorzystanyMaterial;
        private System.Windows.Forms.Label lblTekst;
    }
}