namespace Szwalnia
{
    partial class SredniaIloscMaszyPokaz
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
            this.dgvSredniaIloscMaszyn = new System.Windows.Forms.DataGridView();
            this.lblTytul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSredniaIloscMaszyn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSredniaIloscMaszyn
            // 
            this.dgvSredniaIloscMaszyn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSredniaIloscMaszyn.Location = new System.Drawing.Point(13, 41);
            this.dgvSredniaIloscMaszyn.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSredniaIloscMaszyn.Name = "dgvSredniaIloscMaszyn";
            this.dgvSredniaIloscMaszyn.RowHeadersWidth = 51;
            this.dgvSredniaIloscMaszyn.Size = new System.Drawing.Size(340, 154);
            this.dgvSredniaIloscMaszyn.TabIndex = 3;
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTytul.Location = new System.Drawing.Point(8, 9);
            this.lblTytul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(239, 29);
            this.lblTytul.TabIndex = 2;
            this.lblTytul.Text = "Srednia ilosc maszyn";
            // 
            // SredniaIloscMaszyPokaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 208);
            this.Controls.Add(this.dgvSredniaIloscMaszyn);
            this.Controls.Add(this.lblTytul);
            this.Name = "SredniaIloscMaszyPokaz";
            this.Text = "Srednia_Il_Maszyn_Pokaz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSredniaIloscMaszyn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSredniaIloscMaszyn;
        private System.Windows.Forms.Label lblTytul;
    }
}