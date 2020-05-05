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
            this.lblInformacja = new System.Windows.Forms.Label();
            this.dgvListaKlientow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKlientow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInformacja
            // 
            this.lblInformacja.AutoSize = true;
            this.lblInformacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInformacja.Location = new System.Drawing.Point(190, 19);
            this.lblInformacja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformacja.Name = "lblInformacja";
            this.lblInformacja.Size = new System.Drawing.Size(274, 31);
            this.lblInformacja.TabIndex = 1;
            this.lblInformacja.Text = "Wybierz klienta z listy";
            // 
            // dgvListaKlientow
            // 
            this.dgvListaKlientow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaKlientow.Location = new System.Drawing.Point(9, 61);
            this.dgvListaKlientow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaKlientow.Name = "dgvListaKlientow";
            this.dgvListaKlientow.RowHeadersWidth = 51;
            this.dgvListaKlientow.RowTemplate.Height = 24;
            this.dgvListaKlientow.Size = new System.Drawing.Size(582, 295);
            this.dgvListaKlientow.TabIndex = 2;
            this.dgvListaKlientow.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaKlientow_CellMouseDoubleClick);
            // 
            // WyborKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgvListaKlientow);
            this.Controls.Add(this.lblInformacja);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WyborKlienta";
            this.Text = "Wybor_klienta";
            this.Load += new System.EventHandler(this.WyborKlienta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKlientow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInformacja;
        private System.Windows.Forms.DataGridView dgvListaKlientow;
    }
}