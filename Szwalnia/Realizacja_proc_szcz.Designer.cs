namespace Szwalnia
{
    partial class Realizacja_proc_szcz
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
            this.btnRealProcSzcz = new System.Windows.Forms.Button();
            this.dgvRealProc = new System.Windows.Forms.DataGridView();
            this.numIDProcP = new System.Windows.Forms.NumericUpDown();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIDProcP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRealProcSzcz
            // 
            this.btnRealProcSzcz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRealProcSzcz.Location = new System.Drawing.Point(309, 58);
            this.btnRealProcSzcz.Name = "btnRealProcSzcz";
            this.btnRealProcSzcz.Size = new System.Drawing.Size(174, 27);
            this.btnRealProcSzcz.TabIndex = 1;
            this.btnRealProcSzcz.Text = "Pokaż szczegóły";
            this.btnRealProcSzcz.UseVisualStyleBackColor = true;
            this.btnRealProcSzcz.Click += new System.EventHandler(this.btnRealProcSzcz_Click);
            // 
            // dgvRealProc
            // 
            this.dgvRealProc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRealProc.Location = new System.Drawing.Point(66, 111);
            this.dgvRealProc.Name = "dgvRealProc";
            this.dgvRealProc.RowHeadersWidth = 51;
            this.dgvRealProc.RowTemplate.Height = 24;
            this.dgvRealProc.Size = new System.Drawing.Size(792, 302);
            this.dgvRealProc.TabIndex = 2;
            // 
            // numIDProcP
            // 
            this.numIDProcP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numIDProcP.Location = new System.Drawing.Point(65, 59);
            this.numIDProcP.Name = "numIDProcP";
            this.numIDProcP.Size = new System.Drawing.Size(228, 27);
            this.numIDProcP.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(62, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(231, 20);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "ID Procesu Produkcyjnego";
            // 
            // Realizacja_proc_szcz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.numIDProcP);
            this.Controls.Add(this.dgvRealProc);
            this.Controls.Add(this.btnRealProcSzcz);
            this.Name = "Realizacja_proc_szcz";
            this.Text = "Realizacja_proc_szcz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIDProcP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRealProcSzcz;
        private System.Windows.Forms.DataGridView dgvRealProc;
        private System.Windows.Forms.NumericUpDown numIDProcP;
        private System.Windows.Forms.Label lbl1;
    }
}