namespace Szwalnia
{
    partial class ObslugaZamowien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObslugaZamowien));
            this.btnAddWorkersDeliverers = new System.Windows.Forms.Button();
            this.btnPrzyjmijProdukty = new System.Windows.Forms.Button();
            this.btnWydajKurierowi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddWorkersDeliverers
            // 
            this.btnAddWorkersDeliverers.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddWorkersDeliverers.Location = new System.Drawing.Point(13, 12);
            this.btnAddWorkersDeliverers.Name = "btnAddWorkersDeliverers";
            this.btnAddWorkersDeliverers.Size = new System.Drawing.Size(256, 111);
            this.btnAddWorkersDeliverers.TabIndex = 1;
            this.btnAddWorkersDeliverers.Text = "Przypisz pracowników i kurierów";
            this.btnAddWorkersDeliverers.UseVisualStyleBackColor = false;
            this.btnAddWorkersDeliverers.Click += new System.EventHandler(this.btnAddWorkersDeliverers_Click);
            // 
            // btnPrzyjmijProdukty
            // 
            this.btnPrzyjmijProdukty.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrzyjmijProdukty.Location = new System.Drawing.Point(13, 129);
            this.btnPrzyjmijProdukty.Name = "btnPrzyjmijProdukty";
            this.btnPrzyjmijProdukty.Size = new System.Drawing.Size(256, 111);
            this.btnPrzyjmijProdukty.TabIndex = 2;
            this.btnPrzyjmijProdukty.Text = "Przyjmij gotowe produkty z produkcji";
            this.btnPrzyjmijProdukty.UseVisualStyleBackColor = false;
            this.btnPrzyjmijProdukty.Click += new System.EventHandler(this.btnPrzyjmijProdukty_Click);
            // 
            // btnWydajKurierowi
            // 
            this.btnWydajKurierowi.BackColor = System.Drawing.SystemColors.Control;
            this.btnWydajKurierowi.Location = new System.Drawing.Point(12, 246);
            this.btnWydajKurierowi.Name = "btnWydajKurierowi";
            this.btnWydajKurierowi.Size = new System.Drawing.Size(256, 111);
            this.btnWydajKurierowi.TabIndex = 3;
            this.btnWydajKurierowi.Text = "Wydaj zamówienie kurierowi";
            this.btnWydajKurierowi.UseVisualStyleBackColor = false;
            this.btnWydajKurierowi.Click += new System.EventHandler(this.btnWydajKurierowi_Click);
            // 
            // ObslugaZamowien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 369);
            this.Controls.Add(this.btnWydajKurierowi);
            this.Controls.Add(this.btnPrzyjmijProdukty);
            this.Controls.Add(this.btnAddWorkersDeliverers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ObslugaZamowien";
            this.Text = "ObslugaZamowien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ObslugaZamowien_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddWorkersDeliverers;
        private System.Windows.Forms.Button btnPrzyjmijProdukty;
        private System.Windows.Forms.Button btnWydajKurierowi;
    }
}