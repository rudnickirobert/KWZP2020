namespace Szwalnia
{
    partial class WyborKlienta
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
            this.LblWyborKlienta = new System.Windows.Forms.Label();
            this.dgvListaKlientow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKlientow)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWyborKlienta
            // 
            this.LblWyborKlienta.AutoSize = true;
            this.LblWyborKlienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblWyborKlienta.Location = new System.Drawing.Point(466, 25);
            this.LblWyborKlienta.Name = "LblWyborKlienta";
            this.LblWyborKlienta.Size = new System.Drawing.Size(331, 38);
            this.LblWyborKlienta.TabIndex = 0;
            this.LblWyborKlienta.Text = "Wybierz klienta z listy";
            // 
            // dgvListaKlientow
            // 
            this.dgvListaKlientow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaKlientow.Location = new System.Drawing.Point(12, 81);
            this.dgvListaKlientow.Name = "dgvListaKlientow";
            this.dgvListaKlientow.RowHeadersWidth = 51;
            this.dgvListaKlientow.RowTemplate.Height = 24;
            this.dgvListaKlientow.Size = new System.Drawing.Size(1395, 357);
            this.dgvListaKlientow.TabIndex = 1;
            this.dgvListaKlientow.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaKlientow_CellMouseDoubleClick);
            // 
            // WyborKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 450);
            this.Controls.Add(this.dgvListaKlientow);
            this.Controls.Add(this.LblWyborKlienta);
            this.Name = "WyborKlienta";
            this.Text = "WyborKlienta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKlientow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblWyborKlienta;
        private System.Windows.Forms.DataGridView dgvListaKlientow;
    }
}