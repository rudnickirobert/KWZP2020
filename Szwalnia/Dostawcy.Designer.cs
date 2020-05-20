namespace Szwalnia
{
    partial class Dostawcy
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvDostawcy = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWstecz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostawcy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(405, 22);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(139, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj nowego dostawcę";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvDostawcy
            // 
            this.dgvDostawcy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDostawcy.Location = new System.Drawing.Point(12, 70);
            this.dgvDostawcy.Name = "dgvDostawcy";
            this.dgvDostawcy.Size = new System.Drawing.Size(548, 368);
            this.dgvDostawcy.TabIndex = 1;
            this.dgvDostawcy.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDostawcy_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz dostawcę z listy.";
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(290, 22);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(75, 23);
            this.btnWstecz.TabIndex = 3;
            this.btnWstecz.Text = "Powrót";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // Dostawcy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDostawcy);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Dostawcy";
            this.Text = "Dostawcy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dostawcy_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostawcy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvDostawcy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWstecz;
    }
}