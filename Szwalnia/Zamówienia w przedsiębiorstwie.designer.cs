namespace Szwalnia
{
    partial class ZamówieniaWPrzedsiębiorstwie
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
            this.dgvZamowienia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZamowienia
            // 
            this.dgvZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienia.Location = new System.Drawing.Point(22, 97);
            this.dgvZamowienia.Name = "dgvZamowienia";
            this.dgvZamowienia.RowHeadersWidth = 51;
            this.dgvZamowienia.RowTemplate.Height = 24;
            this.dgvZamowienia.Size = new System.Drawing.Size(749, 331);
            this.dgvZamowienia.TabIndex = 0;
            // 
            // ZamówieniaWPrzedsiębiorstwie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvZamowienia);
            this.Name = "ZamówieniaWPrzedsiębiorstwie";
            this.Text = "Zamówienia_w_przedsiębiorstwie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZamowienia;
    }
}