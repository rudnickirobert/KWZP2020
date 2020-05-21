namespace Szwalnia
{
    partial class PolkiNaRegalach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolkiNaRegalach));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOznaczenie = new System.Windows.Forms.ComboBox();
            this.lblOznaczenie = new System.Windows.Forms.Label();
            this.dgvPolkiNaRegale = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolkiNaRegale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Widok półek na regale";
            this.label1.UseWaitCursor = true;
            // 
            // cmbOznaczenie
            // 
            this.cmbOznaczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbOznaczenie.FormattingEnabled = true;
            this.cmbOznaczenie.Location = new System.Drawing.Point(82, 75);
            this.cmbOznaczenie.Name = "cmbOznaczenie";
            this.cmbOznaczenie.Size = new System.Drawing.Size(104, 28);
            this.cmbOznaczenie.TabIndex = 1;
            this.cmbOznaczenie.SelectedIndexChanged += new System.EventHandler(this.cmbOznaczenie_SelectedIndexChanged);
            // 
            // lblOznaczenie
            // 
            this.lblOznaczenie.AutoSize = true;
            this.lblOznaczenie.Location = new System.Drawing.Point(23, 83);
            this.lblOznaczenie.Name = "lblOznaczenie";
            this.lblOznaczenie.Size = new System.Drawing.Size(40, 13);
            this.lblOznaczenie.TabIndex = 16;
            this.lblOznaczenie.Text = "Regał:";
            // 
            // dgvPolkiNaRegale
            // 
            this.dgvPolkiNaRegale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPolkiNaRegale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPolkiNaRegale.Location = new System.Drawing.Point(15, 156);
            this.dgvPolkiNaRegale.MultiSelect = false;
            this.dgvPolkiNaRegale.Name = "dgvPolkiNaRegale";
            this.dgvPolkiNaRegale.Size = new System.Drawing.Size(281, 217);
            this.dgvPolkiNaRegale.TabIndex = 3;
            this.dgvPolkiNaRegale.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolkiNaRegale_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 47);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.Location = new System.Drawing.Point(5, 120);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(301, 33);
            this.lblInfo.TabIndex = 25;
            this.lblInfo.Text = "Kliknij drukrotnie w zajętą półkę, aby zobaczyć jej zawartość";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PolkiNaRegalach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 387);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPolkiNaRegale);
            this.Controls.Add(this.cmbOznaczenie);
            this.Controls.Add(this.lblOznaczenie);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PolkiNaRegalach";
            this.Text = "Półki na regale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PolkiNaRegalach_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolkiNaRegale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOznaczenie;
        private System.Windows.Forms.Label lblOznaczenie;
        private System.Windows.Forms.DataGridView dgvPolkiNaRegale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInfo;
    }
}