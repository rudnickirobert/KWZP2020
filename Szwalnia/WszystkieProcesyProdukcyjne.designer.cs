namespace Szwalnia
{
    partial class WszystkieProcesyProdukcyjne
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
            this.lblProcesy = new System.Windows.Forms.Label();
            this.dgvWszystkieProcesyProdukcyjne = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWszystkieProcesyProdukcyjne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProcesy
            // 
            this.lblProcesy.AutoSize = true;
            this.lblProcesy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProcesy.Location = new System.Drawing.Point(158, 21);
            this.lblProcesy.Name = "lblProcesy";
            this.lblProcesy.Size = new System.Drawing.Size(326, 20);
            this.lblProcesy.TabIndex = 3;
            this.lblProcesy.Text = "Przegląd wszystkich procesów produkcyjnych";
            // 
            // dgvWszystkieProcesyProdukcyjne
            // 
            this.dgvWszystkieProcesyProdukcyjne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWszystkieProcesyProdukcyjne.Location = new System.Drawing.Point(12, 63);
            this.dgvWszystkieProcesyProdukcyjne.Name = "dgvWszystkieProcesyProdukcyjne";
            this.dgvWszystkieProcesyProdukcyjne.Size = new System.Drawing.Size(622, 386);
            this.dgvWszystkieProcesyProdukcyjne.TabIndex = 2;
            // 
            // WszystkieProcesyProdukcyjne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 461);
            this.Controls.Add(this.lblProcesy);
            this.Controls.Add(this.dgvWszystkieProcesyProdukcyjne);
            this.Name = "WszystkieProcesyProdukcyjne";
            this.Text = "Wszystkie Procesy Produkcyjne";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWszystkieProcesyProdukcyjne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcesy;
        private System.Windows.Forms.DataGridView dgvWszystkieProcesyProdukcyjne;
    }
}