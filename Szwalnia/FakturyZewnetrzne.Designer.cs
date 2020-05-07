namespace Szwalnia
{
    partial class FakturyZewnetrzne
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
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFakturyZewnetrzne)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFakturyZewnetrzne
            // 
            this.dgvFakturyZewnetrzne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFakturyZewnetrzne.Location = new System.Drawing.Point(12, 92);
            this.dgvFakturyZewnetrzne.Name = "dgvFakturyZewnetrzne";
            this.dgvFakturyZewnetrzne.RowHeadersWidth = 51;
            this.dgvFakturyZewnetrzne.RowTemplate.Height = 24;
            this.dgvFakturyZewnetrzne.Size = new System.Drawing.Size(782, 293);
            this.dgvFakturyZewnetrzne.TabIndex = 0;
            this.dgvFakturyZewnetrzne.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFakturyZewnetrzne_CellMouseDoubleClick);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(363, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(129, 17);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "FakturyZewnetrzne";
            // 
            // FakturyZewnetrzne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dgvFakturyZewnetrzne);
            this.Name = "FakturyZewnetrzne";
            this.Text = "FakturyZewnetrzne";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFakturyZewnetrzne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFakturyZewnetrzne;
        private System.Windows.Forms.Label labelTitle;
    }
}