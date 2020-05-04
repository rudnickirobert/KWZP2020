namespace Szwalnia
{
    partial class Polki_na_regale
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
            this.lblTest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegaly)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTitle.Location = new System.Drawing.Point(252, 32);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(107, 39);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Regal";
            // 
            // dgvRegaly
            // 
            this.dgvRegaly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegaly.Location = new System.Drawing.Point(68, 107);
            this.dgvRegaly.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgvRegaly.Name = "dgvRegaly";
            this.dgvRegaly.RowHeadersWidth = 25;
            this.dgvRegaly.Size = new System.Drawing.Size(529, 371);
            this.dgvRegaly.TabIndex = 5;
            this.dgvRegaly.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegaly_CellContentDoubleClick);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(307, 508);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(51, 20);
            this.lblTest.TabIndex = 6;
            this.lblTest.Text = "label1";
            // 
            // Polki_na_regale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 559);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.dgvRegaly);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Polki_na_regale";
            this.Text = "Półki na regałach";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegaly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvRegaly;
        private System.Windows.Forms.Label lblTest;
    }
}