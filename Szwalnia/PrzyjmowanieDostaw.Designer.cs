namespace Szwalnia
{
    partial class PrzyjmowanieDostaw
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
            this.dgvDostawyDoPrzyjecia = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostawyDoPrzyjecia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDostawyDoPrzyjecia
            // 
            this.dgvDostawyDoPrzyjecia.AllowUserToAddRows = false;
            this.dgvDostawyDoPrzyjecia.AllowUserToDeleteRows = false;
            this.dgvDostawyDoPrzyjecia.AllowUserToOrderColumns = true;
            this.dgvDostawyDoPrzyjecia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDostawyDoPrzyjecia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDostawyDoPrzyjecia.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDostawyDoPrzyjecia.Location = new System.Drawing.Point(16, 60);
            this.dgvDostawyDoPrzyjecia.Name = "dgvDostawyDoPrzyjecia";
            this.dgvDostawyDoPrzyjecia.Size = new System.Drawing.Size(772, 388);
            this.dgvDostawyDoPrzyjecia.TabIndex = 0;
            this.dgvDostawyDoPrzyjecia.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDostawyDoPrzyjecia_CellMouseDoubleClick);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(13, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(775, 44);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Wybierz dostawę którą chcesz przyjąć.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrzyjmowanieDostaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvDostawyDoPrzyjecia);
            this.Name = "PrzyjmowanieDostaw";
            this.Text = "PrzyjmowanieDostaw";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrzyjmowanieDostaw_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostawyDoPrzyjecia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDostawyDoPrzyjecia;
        private System.Windows.Forms.Label lblInfo;
    }
}