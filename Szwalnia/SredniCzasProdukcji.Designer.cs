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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSredniCzasProdukcji)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSredniCzasProdukcji
            // 
            this.dgvSredniCzasProdukcji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSredniCzasProdukcji.Location = new System.Drawing.Point(45, 55);
            this.dgvSredniCzasProdukcji.Name = "dgvSredniCzasProdukcji";
            this.dgvSredniCzasProdukcji.Size = new System.Drawing.Size(698, 347);
            this.dgvSredniCzasProdukcji.TabIndex = 0;
            // 
            // SredniCzasProdukcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSredniCzasProdukcji);
            this.Name = "SredniCzasProdukcji";
            this.Text = "Sredni Czas Produkcji";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSredniCzasProdukcji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSredniCzasProdukcji;
    }
}