namespace Szwalnia
{
    partial class PustePolki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PustePolki));
            this.dgvPustePolki = new System.Windows.Forms.DataGridView();
            this.lblPustePolki = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPustePolki)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPustePolki
            // 
            this.dgvPustePolki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPustePolki.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPustePolki.Location = new System.Drawing.Point(12, 61);
            this.dgvPustePolki.MultiSelect = false;
            this.dgvPustePolki.Name = "dgvPustePolki";
            this.dgvPustePolki.Size = new System.Drawing.Size(368, 440);
            this.dgvPustePolki.TabIndex = 13;
            // 
            // lblPustePolki
            // 
            this.lblPustePolki.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPustePolki.Location = new System.Drawing.Point(12, 9);
            this.lblPustePolki.Name = "lblPustePolki";
            this.lblPustePolki.Size = new System.Drawing.Size(368, 44);
            this.lblPustePolki.TabIndex = 15;
            this.lblPustePolki.Text = "Puste półki: ";
            this.lblPustePolki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PustePolki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 516);
            this.Controls.Add(this.lblPustePolki);
            this.Controls.Add(this.dgvPustePolki);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PustePolki";
            this.Text = "Lista pustych półek";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PustePolki_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPustePolki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPustePolki;
        private System.Windows.Forms.Label lblPustePolki;
    }
}