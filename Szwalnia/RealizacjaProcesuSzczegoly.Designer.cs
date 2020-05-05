namespace Szwalnia
{
    partial class RealizacjaProcesuSzczegoly
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
            this.dgvRealizacjaProcesu = new System.Windows.Forms.DataGridView();
            this.numIDProcesuProdukcyjnego = new System.Windows.Forms.NumericUpDown();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealizacjaProcesu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIDProcesuProdukcyjnego)).BeginInit();
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
            // dgvRealizacjaProcesu
            // 
            this.dgvRealizacjaProcesu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRealizacjaProcesu.Location = new System.Drawing.Point(66, 111);
            this.dgvRealizacjaProcesu.Name = "dgvRealizacjaProcesu";
            this.dgvRealizacjaProcesu.RowHeadersWidth = 51;
            this.dgvRealizacjaProcesu.RowTemplate.Height = 24;
            this.dgvRealizacjaProcesu.Size = new System.Drawing.Size(792, 302);
            this.dgvRealizacjaProcesu.TabIndex = 2;
            // 
            // numIDProcesuProdukcyjnego
            // 
            this.numIDProcesuProdukcyjnego.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numIDProcesuProdukcyjnego.Location = new System.Drawing.Point(65, 59);
            this.numIDProcesuProdukcyjnego.Name = "numIDProcesuProdukcyjnego";
            this.numIDProcesuProdukcyjnego.Size = new System.Drawing.Size(228, 27);
            this.numIDProcesuProdukcyjnego.TabIndex = 3;
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
            // RealizacjaProcesuSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.numIDProcesuProdukcyjnego);
            this.Controls.Add(this.dgvRealizacjaProcesu);
            this.Controls.Add(this.btnRealizacjaProcesuSzczczegoly);
            this.Name = "RealizacjaProcesuSzczegoly";
            this.Text = "Realizacja_proc_szcz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealizacjaProcesu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIDProcesuProdukcyjnego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRealizacjaProcesuSzczczegoly;
        private System.Windows.Forms.DataGridView dgvRealizacjaProcesu;
        private System.Windows.Forms.NumericUpDown numIDProcesuProdukcyjnego;
        private System.Windows.Forms.Label lbl1;
    }
}