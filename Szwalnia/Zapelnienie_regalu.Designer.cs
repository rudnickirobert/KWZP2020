namespace Szwalnia
{
    partial class Zapelnienie_regalu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvRegaly = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegaly)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(530, 78);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 39);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "label1";
            // 
            // dgvRegaly
            // 
            this.dgvRegaly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegaly.Location = new System.Drawing.Point(317, 167);
            this.dgvRegaly.Name = "dgvRegaly";
            this.dgvRegaly.RowHeadersWidth = 25;
            this.dgvRegaly.Size = new System.Drawing.Size(571, 396);
            this.dgvRegaly.TabIndex = 5;
            // 
            // Zapelnienie_regalu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 606);
            this.Controls.Add(this.dgvRegaly);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Zapelnienie_regalu";
            this.Text = "Zapełnienie regału";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegaly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvRegaly;
    }
}