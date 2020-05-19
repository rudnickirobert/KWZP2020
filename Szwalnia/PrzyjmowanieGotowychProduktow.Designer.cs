namespace Szwalnia
{
    partial class PrzyjmowanieGotowychProduktow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrzyjmowanieGotowychProduktow));
            this.dgvGotoweProdukty = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPrzyjmijProdukty = new System.Windows.Forms.Button();
            this.lblPracownik = new System.Windows.Forms.Label();
            this.cmbPracownik = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGotoweProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGotoweProdukty
            // 
            this.dgvGotoweProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGotoweProdukty.Location = new System.Drawing.Point(18, 111);
            this.dgvGotoweProdukty.Name = "dgvGotoweProdukty";
            this.dgvGotoweProdukty.Size = new System.Drawing.Size(570, 150);
            this.dgvGotoweProdukty.TabIndex = 0;
            this.dgvGotoweProdukty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGotoweProdukty_CellClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(576, 31);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Przyjmowanie gotowych produktów z produkcji";
            // 
            // btnPrzyjmijProdukty
            // 
            this.btnPrzyjmijProdukty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrzyjmijProdukty.Location = new System.Drawing.Point(225, 270);
            this.btnPrzyjmijProdukty.Name = "btnPrzyjmijProdukty";
            this.btnPrzyjmijProdukty.Size = new System.Drawing.Size(162, 32);
            this.btnPrzyjmijProdukty.TabIndex = 18;
            this.btnPrzyjmijProdukty.Text = "Przyjmij produkty";
            this.btnPrzyjmijProdukty.UseVisualStyleBackColor = true;
            this.btnPrzyjmijProdukty.Click += new System.EventHandler(this.btnPrzyjmijProdukty_Click);
            // 
            // lblPracownik
            // 
            this.lblPracownik.AutoSize = true;
            this.lblPracownik.Location = new System.Drawing.Point(183, 78);
            this.lblPracownik.Name = "lblPracownik";
            this.lblPracownik.Size = new System.Drawing.Size(60, 13);
            this.lblPracownik.TabIndex = 16;
            this.lblPracownik.Text = "Pracownik:";
            // 
            // cmbPracownik
            // 
            this.cmbPracownik.FormattingEnabled = true;
            this.cmbPracownik.Location = new System.Drawing.Point(260, 75);
            this.cmbPracownik.Name = "cmbPracownik";
            this.cmbPracownik.Size = new System.Drawing.Size(183, 21);
            this.cmbPracownik.TabIndex = 19;
            // 
            // PrzyjmowanieGotowychProduktow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 314);
            this.Controls.Add(this.cmbPracownik);
            this.Controls.Add(this.btnPrzyjmijProdukty);
            this.Controls.Add(this.lblPracownik);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvGotoweProdukty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrzyjmowanieGotowychProduktow";
            this.Text = "Przyjmowanie gotowych produktów z produkcji";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrzyjmowanieGotowychProduktow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGotoweProdukty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGotoweProdukty;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPrzyjmijProdukty;
        private System.Windows.Forms.Label lblPracownik;
        private System.Windows.Forms.ComboBox cmbPracownik;
    }
}