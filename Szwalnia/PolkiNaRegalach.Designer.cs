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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolkiNaRegalach));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOznaczenie = new System.Windows.Forms.ComboBox();
            this.lblOznaczenie = new System.Windows.Forms.Label();
            this.dgvPolkiNaRegale = new System.Windows.Forms.DataGridView();
            this.btnLupa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolkiNaRegale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Widok półek na regale";
            // 
            // cmbOznaczenie
            // 
            this.cmbOznaczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbOznaczenie.FormattingEnabled = true;
            this.cmbOznaczenie.Location = new System.Drawing.Point(162, 88);
            this.cmbOznaczenie.Name = "cmbOznaczenie";
            this.cmbOznaczenie.Size = new System.Drawing.Size(114, 28);
            this.cmbOznaczenie.TabIndex = 1;
            this.cmbOznaczenie.SelectedIndexChanged += new System.EventHandler(this.cmbOznaczenie_SelectedIndexChanged);
            // 
            // lblOznaczenie
            // 
            this.lblOznaczenie.AutoSize = true;
            this.lblOznaczenie.Location = new System.Drawing.Point(96, 96);
            this.lblOznaczenie.Name = "lblOznaczenie";
            this.lblOznaczenie.Size = new System.Drawing.Size(40, 13);
            this.lblOznaczenie.TabIndex = 16;
            this.lblOznaczenie.Text = "Regał:";
            // 
            // dgvPolkiNaRegale
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvPolkiNaRegale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPolkiNaRegale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPolkiNaRegale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPolkiNaRegale.Location = new System.Drawing.Point(48, 158);
            this.dgvPolkiNaRegale.MultiSelect = false;
            this.dgvPolkiNaRegale.Name = "dgvPolkiNaRegale";
            this.dgvPolkiNaRegale.Size = new System.Drawing.Size(323, 217);
            this.dgvPolkiNaRegale.TabIndex = 3;
            // 
            // btnLupa
            // 
            this.btnLupa.Image = global::Szwalnia.Properties.Resources.lupa2;
            this.btnLupa.Location = new System.Drawing.Point(307, 22);
            this.btnLupa.Name = "btnLupa";
            this.btnLupa.Size = new System.Drawing.Size(116, 124);
            this.btnLupa.TabIndex = 18;
            this.btnLupa.UseVisualStyleBackColor = true;
            // 
            // PolkiNaRegalach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 400);
            this.Controls.Add(this.btnLupa);
            this.Controls.Add(this.dgvPolkiNaRegale);
            this.Controls.Add(this.cmbOznaczenie);
            this.Controls.Add(this.lblOznaczenie);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PolkiNaRegalach";
            this.Text = "Półki na regale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PolkiNaRegalach_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolkiNaRegale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOznaczenie;
        private System.Windows.Forms.Label lblOznaczenie;
        private System.Windows.Forms.DataGridView dgvPolkiNaRegale;
        private System.Windows.Forms.Button btnLupa;
    }
}