namespace Szwalnia
{
    partial class SzacowanyCzasWykonaniaNowegoElementu
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
            this.dgvSzacowanyCzas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzacowanyCzas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSzacowanyCzas
            // 
            this.dgvSzacowanyCzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzacowanyCzas.Location = new System.Drawing.Point(80, 64);
            this.dgvSzacowanyCzas.Name = "dgvSzacowanyCzas";
            this.dgvSzacowanyCzas.Size = new System.Drawing.Size(644, 326);
            this.dgvSzacowanyCzas.TabIndex = 0;
            // 
            // SzacowanyCzasWykonaniaNowegoElementu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSzacowanyCzas);
            this.Name = "SzacowanyCzasWykonaniaNowegoElementu";
            this.Text = "Szacowany Czas Wykonania Nowego Elementu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzacowanyCzas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSzacowanyCzas;
    }
}