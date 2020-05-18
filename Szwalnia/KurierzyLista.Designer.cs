namespace Szwalnia
{
    partial class KurierzyLista
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKurierzy = new System.Windows.Forms.DataGridView();
            this.btnDodajKuriera = new System.Windows.Forms.Button();
            this.btnWstecz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurierzy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz kuriera z listy.";
            // 
            // dgvKurierzy
            // 
            this.dgvKurierzy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKurierzy.Location = new System.Drawing.Point(63, 84);
            this.dgvKurierzy.Name = "dgvKurierzy";
            this.dgvKurierzy.Size = new System.Drawing.Size(548, 328);
            this.dgvKurierzy.TabIndex = 1;
            this.dgvKurierzy.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKurierzy_CellDoubleClick);
            // 
            // btnDodajKuriera
            // 
            this.btnDodajKuriera.Location = new System.Drawing.Point(393, 45);
            this.btnDodajKuriera.Name = "btnDodajKuriera";
            this.btnDodajKuriera.Size = new System.Drawing.Size(133, 24);
            this.btnDodajKuriera.TabIndex = 2;
            this.btnDodajKuriera.Text = "Dodaj nowego kuriera";
            this.btnDodajKuriera.UseVisualStyleBackColor = true;
            this.btnDodajKuriera.Click += new System.EventHandler(this.btnDodajKuriera_Click);
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(247, 40);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(75, 23);
            this.btnWstecz.TabIndex = 3;
            this.btnWstecz.Text = "button1";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // KurierzyLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.btnDodajKuriera);
            this.Controls.Add(this.dgvKurierzy);
            this.Controls.Add(this.label1);
            this.Name = "KurierzyLista";
            this.Text = "Kurierzy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KurierzyLista_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurierzy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKurierzy;
        private System.Windows.Forms.Button btnDodajKuriera;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}