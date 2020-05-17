namespace Szwalnia
{
    partial class WyborOferty
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
            this.dgvListaOfert = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaOfert)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaOfert
            // 
            this.dgvListaOfert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaOfert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaOfert.Location = new System.Drawing.Point(12, 12);
            this.dgvListaOfert.Name = "dgvListaOfert";
            this.dgvListaOfert.Size = new System.Drawing.Size(776, 426);
            this.dgvListaOfert.TabIndex = 0;
            this.dgvListaOfert.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaOfert_CellDoubleClick);
            // 
            // WyborOferty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.dgvListaOfert);
            this.Name = "WyborOferty";
            this.Text = "WyborOferty";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WyborOferty_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaOfert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaOfert;
    }
}