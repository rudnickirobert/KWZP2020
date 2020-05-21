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
            this.cmbZamowienie = new System.Windows.Forms.ComboBox();
            this.lblZamowienieInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGotoweProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPracownik
            // 
            this.cmbPracownik.FormattingEnabled = true;
            this.cmbPracownik.Location = new System.Drawing.Point(214, 220);
            this.cmbPracownik.Name = "cmbPracownik";
            this.cmbPracownik.Size = new System.Drawing.Size(183, 21);
            this.cmbPracownik.TabIndex = 24;
            // 
            // btnWydajProdukty
            // 
            this.btnWydajProdukty.Enabled = false;
            this.btnWydajProdukty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnWydajProdukty.Location = new System.Drawing.Point(184, 256);
            this.btnWydajProdukty.Name = "btnWydajProdukty";
            this.btnWydajProdukty.Size = new System.Drawing.Size(162, 32);
            this.btnWydajProdukty.TabIndex = 23;
            this.btnWydajProdukty.Text = "Wydaj produkty";
            this.btnWydajProdukty.UseVisualStyleBackColor = true;
            this.btnWydajProdukty.Click += new System.EventHandler(this.btnWydajProdukty_Click);
            // 
            // lblPracownik
            // 
            this.lblPracownik.AutoSize = true;
            this.lblPracownik.Location = new System.Drawing.Point(137, 223);
            this.lblPracownik.Name = "lblPracownik";
            this.lblPracownik.Size = new System.Drawing.Size(60, 13);
            this.lblPracownik.TabIndex = 22;
            this.lblPracownik.Text = "Pracownik:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(70, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(399, 31);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Wydawanie zamówień kurierowi";
            // 
            // dgvGotoweProdukty
            // 
            this.dgvGotoweProdukty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGotoweProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGotoweProdukty.Location = new System.Drawing.Point(12, 117);
            this.dgvGotoweProdukty.Name = "dgvGotoweProdukty";
            this.dgvGotoweProdukty.Size = new System.Drawing.Size(501, 84);
            this.dgvGotoweProdukty.TabIndex = 20;
            // 
            // cmbZamowienie
            // 
            this.cmbZamowienie.FormattingEnabled = true;
            this.cmbZamowienie.Location = new System.Drawing.Point(250, 81);
            this.cmbZamowienie.Name = "cmbZamowienie";
            this.cmbZamowienie.Size = new System.Drawing.Size(160, 21);
            this.cmbZamowienie.TabIndex = 26;
            this.cmbZamowienie.SelectedIndexChanged += new System.EventHandler(this.cmbZamowienie_SelectedIndexChanged);
            // 
            // lblZamowienieInfo
            // 
            this.lblZamowienieInfo.AutoSize = true;
            this.lblZamowienieInfo.Location = new System.Drawing.Point(75, 84);
            this.lblZamowienieInfo.Name = "lblZamowienieInfo";
            this.lblZamowienieInfo.Size = new System.Drawing.Size(160, 13);
            this.lblZamowienieInfo.TabIndex = 25;
            this.lblZamowienieInfo.Text = "Wybierz zamówienie do wydania";
            // 
            // WydawanieProduktowKurierowi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 302);
            this.Controls.Add(this.cmbZamowienie);
            this.Controls.Add(this.lblZamowienieInfo);
            this.Controls.Add(this.cmbPracownik);
            this.Controls.Add(this.btnWydajProdukty);
            this.Controls.Add(this.lblPracownik);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvGotoweProdukty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WydawanieProduktowKurierowi";
            this.Text = "Wydawanie zamówień kurierowi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WydawanieProduktowKurierowi_FormClosed);
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
        private System.Windows.Forms.ComboBox cmbZamowienie;
        private System.Windows.Forms.Label lblZamowienieInfo;
    }
}