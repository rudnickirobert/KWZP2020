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
            this.lblRodzajEtapu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzajEtapu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRodzajEtapu
            // 
            this.dgvRodzajEtapu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRodzajEtapu.Location = new System.Drawing.Point(12, 53);
            this.dgvRodzajEtapu.Name = "dgvRodzajEtapu";
            this.dgvRodzajEtapu.Size = new System.Drawing.Size(340, 345);
            this.dgvRodzajEtapu.TabIndex = 0;
            // 
            // lblRodzajEtapu
            // 
            this.lblRodzajEtapu.AutoSize = true;
            this.lblRodzajEtapu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRodzajEtapu.Location = new System.Drawing.Point(130, 21);
            this.lblRodzajEtapu.Name = "lblRodzajEtapu";
            this.lblRodzajEtapu.Size = new System.Drawing.Size(104, 20);
            this.lblRodzajEtapu.TabIndex = 1;
            this.lblRodzajEtapu.Text = "Rodzaj etapu";
            // 
            // RodzajEtapu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 411);
            this.Controls.Add(this.lblRodzajEtapu);
            this.Controls.Add(this.dgvRodzajEtapu);
            this.Name = "RodzajEtapu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rodzaj Etapu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzajEtapu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRodzajEtapu;
        private System.Windows.Forms.Label lblRodzajEtapu;
    }
}