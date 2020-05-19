namespace Szwalnia
{
    partial class WydawanieProduktowKurierowi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WydawanieProduktowKurierowi));
            this.cmbPracownik = new System.Windows.Forms.ComboBox();
            this.btnWydajProdukty = new System.Windows.Forms.Button();
            this.lblPracownik = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvGotoweProdukty = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGotoweProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPracownik
            // 
            this.cmbPracownik.FormattingEnabled = true;
            this.cmbPracownik.Location = new System.Drawing.Point(260, 77);
            this.cmbPracownik.Name = "cmbPracownik";
            this.cmbPracownik.Size = new System.Drawing.Size(183, 21);
            this.cmbPracownik.TabIndex = 24;
            // 
            // btnWydajProdukty
            // 
            this.btnWydajProdukty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnWydajProdukty.Location = new System.Drawing.Point(225, 271);
            this.btnWydajProdukty.Name = "btnWydajProdukty";
            this.btnWydajProdukty.Size = new System.Drawing.Size(162, 32);
            this.btnWydajProdukty.TabIndex = 23;
            this.btnWydajProdukty.Text = "Wydaj produkty";
            this.btnWydajProdukty.UseVisualStyleBackColor = true;
            // 
            // lblPracownik
            // 
            this.lblPracownik.AutoSize = true;
            this.lblPracownik.Location = new System.Drawing.Point(183, 80);
            this.lblPracownik.Name = "lblPracownik";
            this.lblPracownik.Size = new System.Drawing.Size(60, 13);
            this.lblPracownik.TabIndex = 22;
            this.lblPracownik.Text = "Pracownik:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(109, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(399, 31);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Wydawanie zamówień kurierowi";
            // 
            // dgvGotoweProdukty
            // 
            this.dgvGotoweProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGotoweProdukty.Location = new System.Drawing.Point(20, 113);
            this.dgvGotoweProdukty.Name = "dgvGotoweProdukty";
            this.dgvGotoweProdukty.Size = new System.Drawing.Size(570, 150);
            this.dgvGotoweProdukty.TabIndex = 20;
            // 
            // WydawanieProduktowKurierowi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 313);
            this.Controls.Add(this.cmbPracownik);
            this.Controls.Add(this.btnWydajProdukty);
            this.Controls.Add(this.lblPracownik);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvGotoweProdukty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WydawanieProduktowKurierowi";
            this.Text = "Wydawanie zamówień kurierowi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGotoweProdukty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPracownik;
        private System.Windows.Forms.Button btnWydajProdukty;
        private System.Windows.Forms.Label lblPracownik;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvGotoweProdukty;
    }
}