namespace Szwalnia
{
    partial class ZnajomoscJezykowWFirmie
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
            this.dgvJezyki = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJezyki)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJezyki
            // 
            this.dgvJezyki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJezyki.Location = new System.Drawing.Point(12, 48);
            this.dgvJezyki.Name = "dgvJezyki";
            this.dgvJezyki.RowHeadersWidth = 51;
            this.dgvJezyki.RowTemplate.Height = 24;
            this.dgvJezyki.Size = new System.Drawing.Size(428, 256);
            this.dgvJezyki.TabIndex = 0;
            // 
            // ZnajomoscJezykowWFirmie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 319);
            this.Controls.Add(this.dgvJezyki);
            this.Name = "ZnajomoscJezykowWFirmie";
            this.Text = "Znajomość_języków_w_firmie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJezyki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJezyki;
    }
}