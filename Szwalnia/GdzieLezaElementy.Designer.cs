namespace Szwalnia
{
    partial class GdzieLezaElementy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GdzieLezaElementy));
            this.dgvLokalizacjeElementu = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokalizacjeElementu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLokalizacjeElementu
            // 
            this.dgvLokalizacjeElementu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLokalizacjeElementu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLokalizacjeElementu.Location = new System.Drawing.Point(14, 74);
            this.dgvLokalizacjeElementu.Name = "dgvLokalizacjeElementu";
            this.dgvLokalizacjeElementu.Size = new System.Drawing.Size(835, 192);
            this.dgvLokalizacjeElementu.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(14, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(837, 44);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Lokalizacje elementu:           , ID:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GdzieLezaElementy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 278);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvLokalizacjeElementu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GdzieLezaElementy";
            this.Text = "Lokalizacja elementów";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokalizacjeElementu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLokalizacjeElementu;
        private System.Windows.Forms.Label lblTitle;
    }
}