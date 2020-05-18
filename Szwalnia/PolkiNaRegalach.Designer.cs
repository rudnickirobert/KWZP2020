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
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolkiNaRegale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Widok półek na regale";
            // 
            // cmbOznaczenie
            // 
            this.cmbOznaczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbOznaczenie.FormattingEnabled = true;
            this.cmbOznaczenie.Location = new System.Drawing.Point(82, 73);
            this.cmbOznaczenie.Name = "cmbOznaczenie";
            this.cmbOznaczenie.Size = new System.Drawing.Size(104, 28);
            this.cmbOznaczenie.TabIndex = 1;
            // 
            // lblOznaczenie
            // 
            this.lblOznaczenie.AutoSize = true;
            this.lblOznaczenie.Location = new System.Drawing.Point(23, 81);
            this.lblOznaczenie.Name = "lblOznaczenie";
            this.lblOznaczenie.Size = new System.Drawing.Size(40, 13);
            this.lblOznaczenie.TabIndex = 16;
            this.lblOznaczenie.Text = "Regał:";
            // 
            // dgvPolkiNaRegale
            // 
            this.dgvPolkiNaRegale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPolkiNaRegale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPolkiNaRegale.Location = new System.Drawing.Point(22, 157);
            this.dgvPolkiNaRegale.MultiSelect = false;
            this.dgvPolkiNaRegale.Name = "dgvPolkiNaRegale";
            this.dgvPolkiNaRegale.Size = new System.Drawing.Size(266, 217);
            this.dgvPolkiNaRegale.TabIndex = 3;
            this.dgvPolkiNaRegale.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolkiNaRegale_CellDoubleClick);
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSzukaj.Location = new System.Drawing.Point(82, 109);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(104, 33);
            this.btnSzukaj.TabIndex = 18;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Szwalnia.Properties.Resources.Legenda;
            this.pictureBox1.Location = new System.Drawing.Point(193, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 78);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // PolkiNaRegalach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSzukaj);
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
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}