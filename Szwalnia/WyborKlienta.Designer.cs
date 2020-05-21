namespace Szwalnia
{
    partial class WyborKlienta
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
            this.LblWyborKlienta = new System.Windows.Forms.Label();
            this.dgvListaKlientow = new System.Windows.Forms.DataGridView();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKlientow)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWyborKlienta
            // 
            this.LblWyborKlienta.AutoSize = true;
            this.LblWyborKlienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblWyborKlienta.Location = new System.Drawing.Point(466, 25);
            this.LblWyborKlienta.Name = "LblWyborKlienta";
            this.LblWyborKlienta.Size = new System.Drawing.Size(331, 38);
            this.LblWyborKlienta.TabIndex = 0;
            this.LblWyborKlienta.Text = "Wybierz klienta z listy";
            // 
            // dgvListaKlientow
            // 
            this.dgvListaKlientow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaKlientow.Location = new System.Drawing.Point(12, 81);
            this.dgvListaKlientow.Name = "dgvListaKlientow";
            this.dgvListaKlientow.RowHeadersWidth = 51;
            this.dgvListaKlientow.RowTemplate.Height = 24;
            this.dgvListaKlientow.Size = new System.Drawing.Size(1305, 357);
            this.dgvListaKlientow.TabIndex = 1;
            this.dgvListaKlientow.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaKlientow_CellMouseDoubleClick);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(1208, 25);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(101, 45);
            this.btnZamknij.TabIndex = 3;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(1064, 25);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 45);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj klienta";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // WyborKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1332, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.dgvListaKlientow);
            this.Controls.Add(this.LblWyborKlienta);
            this.Name = "WyborKlienta";
            this.Text = "Wybór klienta";
            this.Activated += new System.EventHandler(this.WyborKlienta_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKlientow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblWyborKlienta;
        private System.Windows.Forms.DataGridView dgvListaKlientow;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnDodaj;
    }
}