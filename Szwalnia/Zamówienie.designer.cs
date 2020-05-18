namespace Szwalnia
{
    partial class Zamowienie
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
            this.btnStare = new System.Windows.Forms.Button();
            this.btnNowe = new System.Windows.Forms.Button();
            this.btnKoniecZamowienia = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStare
            // 
            this.btnStare.Location = new System.Drawing.Point(23, 26);
            this.btnStare.Name = "btnStare";
            this.btnStare.Size = new System.Drawing.Size(163, 60);
            this.btnStare.TabIndex = 0;
            this.btnStare.Text = "Zamówienia";
            this.btnStare.UseVisualStyleBackColor = true;
            this.btnStare.Click += new System.EventHandler(this.btnStare_Click);
            // 
            // btnNowe
            // 
            this.btnNowe.Location = new System.Drawing.Point(23, 120);
            this.btnNowe.Name = "btnNowe";
            this.btnNowe.Size = new System.Drawing.Size(163, 52);
            this.btnNowe.TabIndex = 6;
            this.btnNowe.Text = "Nowe Zamówienie";
            this.btnNowe.UseVisualStyleBackColor = true;
            this.btnNowe.Click += new System.EventHandler(this.btnNowe_Click);
            // 
            // btnKoniecZamowienia
            // 
            this.btnKoniecZamowienia.Location = new System.Drawing.Point(23, 217);
            this.btnKoniecZamowienia.Name = "btnKoniecZamowienia";
            this.btnKoniecZamowienia.Size = new System.Drawing.Size(163, 52);
            this.btnKoniecZamowienia.TabIndex = 7;
            this.btnKoniecZamowienia.Text = "Zakończ zamówienie";
            this.btnKoniecZamowienia.UseVisualStyleBackColor = true;
            this.btnKoniecZamowienia.Click += new System.EventHandler(this.btnKoniecZamowienia_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(23, 353);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(163, 52);
            this.btnZamknij.TabIndex = 8;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // Zamowienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 462);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnKoniecZamowienia);
            this.Controls.Add(this.btnNowe);
            this.Controls.Add(this.btnStare);
            this.Name = "Zamowienie";
            this.Text = "Zamówienie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStare;
        private System.Windows.Forms.Button btnNowe;
        private System.Windows.Forms.Button btnKoniecZamowienia;
        private System.Windows.Forms.Button btnZamknij;
    }
}