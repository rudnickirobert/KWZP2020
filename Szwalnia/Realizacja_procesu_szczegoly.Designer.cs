namespace Szwalnia
{
    partial class Realizacja_procesu_szczegoly
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
            this.btnRealizacjaProcesuSzczczegoly = new System.Windows.Forms.Button();
            this.dgvRealProc = new System.Windows.Forms.DataGridView();
            this.numIDProcP = new System.Windows.Forms.NumericUpDown();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIDProcP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRealizacjaProcesuSzczczegoly
            // 
            this.btnRealizacjaProcesuSzczczegoly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRealizacjaProcesuSzczczegoly.Location = new System.Drawing.Point(309, 58);
            this.btnRealizacjaProcesuSzczczegoly.Name = "btnRealizacjaProcesuSzczczegoly";
            this.btnRealizacjaProcesuSzczczegoly.Size = new System.Drawing.Size(174, 27);
            this.btnRealizacjaProcesuSzczczegoly.TabIndex = 1;
            this.btnRealizacjaProcesuSzczczegoly.Text = "Pokaż szczegóły";
            this.btnRealizacjaProcesuSzczczegoly.UseVisualStyleBackColor = true;
            this.btnRealizacjaProcesuSzczczegoly.Click += new System.EventHandler(this.btnRealizacjaProcesuSzczegoly_Click);
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
            // Realizacja_procesu_szczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.numIDProcP);
            this.Controls.Add(this.dgvRealProc);
            this.Controls.Add(this.btnRealizacjaProcesuSzczczegoly);
            this.Name = "Realizacja_procesu_szczegoly";
            this.Text = "Realizacja_proc_szcz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIDProcP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRealizacjaProcesuSzczczegoly;
        private System.Windows.Forms.DataGridView dgvRealProc;
        private System.Windows.Forms.NumericUpDown numIDProcP;
        private System.Windows.Forms.Label lbl1;
    }
}