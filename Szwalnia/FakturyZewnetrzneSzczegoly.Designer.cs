namespace Szwalnia
{
    partial class FakturyZewnetrzneSzczegoly
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
            this.dgvFakturyZewnetrzne = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFakturyZewnetrzne)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFakturyZewnetrzne
            // 
            this.dgvFakturyZewnetrzne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFakturyZewnetrzne.Location = new System.Drawing.Point(10, 79);
            this.dgvFakturyZewnetrzne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFakturyZewnetrzne.Name = "dgvFakturyZewnetrzne";
            this.dgvFakturyZewnetrzne.RowHeadersWidth = 51;
            this.dgvFakturyZewnetrzne.RowTemplate.Height = 24;
            this.dgvFakturyZewnetrzne.Size = new System.Drawing.Size(1360, 293);
            this.dgvFakturyZewnetrzne.TabIndex = 1;
            // 
            // FakturyZewnetrzneSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 450);
            this.Controls.Add(this.dgvFakturyZewnetrzne);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FakturyZewnetrzneSzczegoly";
            this.Text = "FakturyZewnetrzneSzczegoly";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFakturyZewnetrzne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFakturyZewnetrzne;
    }
}