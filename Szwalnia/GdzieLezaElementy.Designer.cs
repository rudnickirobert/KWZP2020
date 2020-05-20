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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvLokalizacjeElementu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokalizacjeElementu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(48, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(403, 31);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Lokalizacje elementu:           , ID:";
            // 
            // dgvLokalizacjeElementu
            // 
            this.dgvLokalizacjeElementu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLokalizacjeElementu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLokalizacjeElementu.Location = new System.Drawing.Point(23, 82);
            this.dgvLokalizacjeElementu.Name = "dgvLokalizacjeElementu";
            this.dgvLokalizacjeElementu.Size = new System.Drawing.Size(510, 277);
            this.dgvLokalizacjeElementu.TabIndex = 13;
            // 
            // GdzieLezaElementy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 392);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvLokalizacjeElementu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GdzieLezaElementy";
            this.Text = "Lokalizacja elementów";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokalizacjeElementu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvLokalizacjeElementu;
    }
}