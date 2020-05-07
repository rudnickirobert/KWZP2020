namespace Szwalnia
{
    partial class RodzajEtapu
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
            this.dgvRodzajEtapu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzajEtapu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRodzajEtapu
            // 
            this.dgvRodzajEtapu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRodzajEtapu.Location = new System.Drawing.Point(12, 12);
            this.dgvRodzajEtapu.Name = "dgvRodzajEtapu";
            this.dgvRodzajEtapu.Size = new System.Drawing.Size(518, 298);
            this.dgvRodzajEtapu.TabIndex = 0;
            // 
            // RodzajEtapu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 322);
            this.Controls.Add(this.dgvRodzajEtapu);
            this.Name = "RodzajEtapu";
            this.Text = "Rodzaj Etapu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzajEtapu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRodzajEtapu;
    }
}