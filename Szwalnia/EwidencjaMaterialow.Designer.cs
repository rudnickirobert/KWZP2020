namespace Szwalnia
{
    partial class EwidencjaMaterialow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EwidencjaMaterialow));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvEwidencjaMatarialow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEwidencjaMatarialow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(345, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 31);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Ewidencja materiałów";
            // 
            // dgvEwidencjaMatarialow
            // 
            this.dgvEwidencjaMatarialow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEwidencjaMatarialow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEwidencjaMatarialow.Location = new System.Drawing.Point(12, 67);
            this.dgvEwidencjaMatarialow.Name = "dgvEwidencjaMatarialow";
            this.dgvEwidencjaMatarialow.Size = new System.Drawing.Size(916, 365);
            this.dgvEwidencjaMatarialow.TabIndex = 17;
            // 
            // EwidencjaMaterialow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 444);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvEwidencjaMatarialow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EwidencjaMaterialow";
            this.Text = "Ewidencja materiałów";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EwidencjaMaterialow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEwidencjaMatarialow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvEwidencjaMatarialow;
    }
}