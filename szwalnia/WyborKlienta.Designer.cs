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
            this.lblInformacja.Location = new System.Drawing.Point(253, 23);
            this.lblInformacja.Name = "lblInformacja";
            this.lblInformacja.Size = new System.Drawing.Size(331, 38);
            this.lblInformacja.TabIndex = 1;
            this.lblInformacja.Text = "Wybierz klienta z listy";
            // 
            // dgvListaKlientow
            // 
            this.dgvListaKlientow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaKlientow.Location = new System.Drawing.Point(12, 75);
            this.dgvListaKlientow.Name = "dgvListaKlientow";
            this.dgvListaKlientow.RowHeadersWidth = 51;
            this.dgvListaKlientow.RowTemplate.Height = 24;
            this.dgvListaKlientow.Size = new System.Drawing.Size(776, 363);
            this.dgvListaKlientow.TabIndex = 2;
            // 
            // WyborKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListaKlientow);
            this.Controls.Add(this.lblInformacja);
            this.Name = "WyborKlienta";
            this.Text = "Wybor_klienta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKlientow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInformacja;
        private System.Windows.Forms.DataGridView dgvListaKlientow;
    }
}