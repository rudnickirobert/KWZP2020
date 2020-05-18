namespace Szwalnia
{
    partial class SzczegolyZamowienia
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
            this.dgvSzczegoly = new System.Windows.Forms.DataGridView();
            this.lblOpis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegoly)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSzczegoly
            // 
            this.dgvSzczegoly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzczegoly.Location = new System.Drawing.Point(12, 50);
            this.dgvSzczegoly.Name = "dgvSzczegoly";
            this.dgvSzczegoly.RowHeadersWidth = 51;
            this.dgvSzczegoly.RowTemplate.Height = 24;
            this.dgvSzczegoly.Size = new System.Drawing.Size(776, 220);
            this.dgvSzczegoly.TabIndex = 0;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(270, 19);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(46, 17);
            this.lblOpis.TabIndex = 1;
            this.lblOpis.Text = "label1";
            // 
            // SzczegolyZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.dgvSzczegoly);
            this.Name = "SzczegolyZamowienia";
            this.Text = "Szczegóły_zamówienia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegoly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSzczegoly;
        private System.Windows.Forms.Label lblOpis;
    }
}