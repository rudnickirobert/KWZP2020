namespace Szwalnia
{
    partial class RozpoczeteProcesy
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
            this.dgvRozpoczeteProcesy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRozpoczeteProcesy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRozpoczeteProcesy
            // 
            this.dgvRozpoczeteProcesy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRozpoczeteProcesy.Location = new System.Drawing.Point(30, 38);
            this.dgvRozpoczeteProcesy.Name = "dgvRozpoczeteProcesy";
            this.dgvRozpoczeteProcesy.Size = new System.Drawing.Size(725, 369);
            this.dgvRozpoczeteProcesy.TabIndex = 0;
            // 
            // RozpoczeteProcesy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRozpoczeteProcesy);
            this.Name = "RozpoczeteProcesy";
            this.Text = "Rozpoczete Procesy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRozpoczeteProcesy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRozpoczeteProcesy;
    }
}