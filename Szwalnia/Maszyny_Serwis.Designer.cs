namespace Szwalnia
{
    partial class Maszyny_Serwis
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
            this.dgvMaszynySerwis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszynySerwis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaszynySerwis
            // 
            this.dgvMaszynySerwis.AllowUserToAddRows = false;
            this.dgvMaszynySerwis.AllowUserToDeleteRows = false;
            this.dgvMaszynySerwis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaszynySerwis.Location = new System.Drawing.Point(12, 11);
            this.dgvMaszynySerwis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMaszynySerwis.Name = "dgvMaszynySerwis";
            this.dgvMaszynySerwis.ReadOnly = true;
            this.dgvMaszynySerwis.RowHeadersWidth = 51;
            this.dgvMaszynySerwis.RowTemplate.Height = 24;
            this.dgvMaszynySerwis.Size = new System.Drawing.Size(675, 374);
            this.dgvMaszynySerwis.TabIndex = 2;
            // 
            // Maszyny_Serwis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 389);
            this.Controls.Add(this.dgvMaszynySerwis);
            this.Name = "Maszyny_Serwis";
            this.Text = "Maszyny_Serwis";
            this.Load += new System.EventHandler(this.Maszyny_Serwis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaszynySerwis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaszynySerwis;
    }
}