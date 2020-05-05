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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFakturyZewnetrzne)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFakturyZewnetrzne
            // 
            this.dgvFakturyZewnetrzne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFakturyZewnetrzne.Location = new System.Drawing.Point(12, 88);
            this.dgvFakturyZewnetrzne.Name = "dgvFakturyZewnetrzne";
            this.dgvFakturyZewnetrzne.Size = new System.Drawing.Size(934, 383);
            this.dgvFakturyZewnetrzne.TabIndex = 0;
            this.dgvFakturyZewnetrzne.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFakturyZewnetrzne_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(305, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Faktury Zewnętrzne";
            // 
            // FakturyZewnetrzne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFakturyZewnetrzne);
            this.Name = "FakturyZewnetrzne";
            this.Text = "Faktury Zewnętrzne";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFakturyZewnetrzne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFakturyZewnetrzne;
        private System.Windows.Forms.Label label1;
    }
}