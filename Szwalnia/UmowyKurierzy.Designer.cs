namespace Szwalnia
{
    partial class UmowyKurierzy
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
            this.dgvUmowy = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWstecz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUmowy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUmowy
            // 
            this.dgvUmowy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUmowy.Location = new System.Drawing.Point(29, 105);
            this.dgvUmowy.Name = "dgvUmowy";
            this.dgvUmowy.Size = new System.Drawing.Size(656, 320);
            this.dgvUmowy.TabIndex = 0;
            this.dgvUmowy.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUmowy_CellDoubleClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(433, 45);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(121, 29);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj nową umowę";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz umowę z listy.";
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(318, 45);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(60, 29);
            this.btnWstecz.TabIndex = 3;
            this.btnWstecz.Text = "Powrót";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // UmowyKurierzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvUmowy);
            this.Name = "UmowyKurierzy";
            this.Text = "Umowy z kurierami";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UmowyKurierzy_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUmowy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUmowy;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWstecz;
    }
}