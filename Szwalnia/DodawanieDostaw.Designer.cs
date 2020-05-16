namespace Szwalnia
{
    partial class DodawanieDostaw
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
            this.dgvListaMaterialow = new System.Windows.Forms.DataGridView();
            this.lblInfoText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMaterialow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaMaterialow
            // 
            this.dgvListaMaterialow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMaterialow.Location = new System.Drawing.Point(12, 12);
            this.dgvListaMaterialow.Name = "dgvListaMaterialow";
            this.dgvListaMaterialow.Size = new System.Drawing.Size(776, 426);
            this.dgvListaMaterialow.TabIndex = 0;
            // 
            // lblInfoText
            // 
            this.lblInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfoText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInfoText.Location = new System.Drawing.Point(-1, -1);
            this.lblInfoText.Name = "lblInfoText";
            this.lblInfoText.Size = new System.Drawing.Size(800, 454);
            this.lblInfoText.TabIndex = 1;
            this.lblInfoText.Text = "WSZYSTKIE WYMAGANE MATERIAŁY ZOSTAŁY ZAMÓWIONE";
            this.lblInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DodawanieDostaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListaMaterialow);
            this.Controls.Add(this.lblInfoText);
            this.Name = "DodawanieDostaw";
            this.Text = "DodawanieDostaw";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DodawanieDostaw_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMaterialow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaMaterialow;
        private System.Windows.Forms.Label lblInfoText;
    }
}