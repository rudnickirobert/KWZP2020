namespace Szwalnia
{
    partial class EwidencjaDostawWewnetrznych
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EwidencjaDostawWewnetrznych));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvEwidencjaProduktow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEwidencjaProduktow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(331, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 31);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Ewidencja produktów";
            // 
            // dgvEwidencjaProduktow
            // 
            this.dgvEwidencjaProduktow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEwidencjaProduktow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEwidencjaProduktow.Location = new System.Drawing.Point(12, 76);
            this.dgvEwidencjaProduktow.Name = "dgvEwidencjaProduktow";
            this.dgvEwidencjaProduktow.Size = new System.Drawing.Size(907, 381);
            this.dgvEwidencjaProduktow.TabIndex = 15;
            // 
            // EwidencjaDostawWewnetrznych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 469);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvEwidencjaProduktow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EwidencjaDostawWewnetrznych";
            this.Text = "Ewidencja produktów";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EwidencjaDostawWewnetrznych_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEwidencjaProduktow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvEwidencjaProduktow;
    }
}