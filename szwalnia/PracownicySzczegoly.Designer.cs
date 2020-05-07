namespace Szwalnia
{
    partial class PracownicySzczegoly
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
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.lblImie = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.dgvPracownicy = new System.Windows.Forms.DataGridView();
            this.lblTelefonPracownika = new System.Windows.Forms.Label();
            this.txtTelefonPracownika = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracownicy)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(130, 72);
            this.txtImie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(191, 22);
            this.txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(130, 98);
            this.txtNazwisko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(191, 22);
            this.txtNazwisko.TabIndex = 2;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Location = new System.Drawing.Point(12, 72);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(33, 17);
            this.lblImie.TabIndex = 7;
            this.lblImie.Text = "Imie";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Location = new System.Drawing.Point(12, 103);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(67, 17);
            this.lblNazwisko.TabIndex = 8;
            this.lblNazwisko.Text = "Nazwisko";
            // 
            // dgvPracownicy
            // 
            this.dgvPracownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracownicy.Location = new System.Drawing.Point(15, 135);
            this.dgvPracownicy.Name = "dgvPracownicy";
            this.dgvPracownicy.RowHeadersWidth = 51;
            this.dgvPracownicy.RowTemplate.Height = 24;
            this.dgvPracownicy.Size = new System.Drawing.Size(768, 195);
            this.dgvPracownicy.TabIndex = 9;
            // 
            // lblTelefonPracownika
            // 
            this.lblTelefonPracownika.AutoSize = true;
            this.lblTelefonPracownika.Location = new System.Drawing.Point(401, 72);
            this.lblTelefonPracownika.Name = "lblTelefonPracownika";
            this.lblTelefonPracownika.Size = new System.Drawing.Size(56, 17);
            this.lblTelefonPracownika.TabIndex = 10;
            this.lblTelefonPracownika.Text = "Telefon";
            // 
            // txtTelefonPracownika
            // 
            this.txtTelefonPracownika.Location = new System.Drawing.Point(463, 72);
            this.txtTelefonPracownika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonPracownika.Name = "txtTelefonPracownika";
            this.txtTelefonPracownika.Size = new System.Drawing.Size(147, 22);
            this.txtTelefonPracownika.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(282, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 17);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Nazwa firmy";
            // 
            // PracownicySzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTelefonPracownika);
            this.Controls.Add(this.lblTelefonPracownika);
            this.Controls.Add(this.dgvPracownicy);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.txtImie);
            this.Name = "PracownicySzczegoly";
            this.Text = "PracownicySzczegoly";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracownicy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.DataGridView dgvPracownicy;
        private System.Windows.Forms.Label lblTelefonPracownika;
        private System.Windows.Forms.TextBox txtTelefonPracownika;
        private System.Windows.Forms.Label lblTitle;
    }
}