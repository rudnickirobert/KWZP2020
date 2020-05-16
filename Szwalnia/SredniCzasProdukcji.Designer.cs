namespace Szwalnia
{
    partial class SredniCzasProdukcji
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
            this.dgvSredniCzasProdukcji = new System.Windows.Forms.DataGridView();
            this.lblOpis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSredniCzasProdukcji)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSredniCzasProdukcji
            // 
            this.dgvSredniCzasProdukcji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSredniCzasProdukcji.Location = new System.Drawing.Point(42, 83);
            this.dgvSredniCzasProdukcji.Name = "dgvSredniCzasProdukcji";
            this.dgvSredniCzasProdukcji.Size = new System.Drawing.Size(277, 240);
            this.dgvSredniCzasProdukcji.TabIndex = 0;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(66, 40);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(235, 18);
            this.lblOpis.TabIndex = 1;
            this.lblOpis.Text = "Średni czas produkcji wg produktu";
            // 
            // SredniCzasProdukcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 335);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.dgvSredniCzasProdukcji);
            this.Name = "SredniCzasProdukcji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Średni czas produkcji";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSredniCzasProdukcji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSredniCzasProdukcji;
        private System.Windows.Forms.Label lblOpis;
    }
}