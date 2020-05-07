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
            this.dgvZatrudnienie = new System.Windows.Forms.DataGridView();
            this.lblImie = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTelefonPracownika = new System.Windows.Forms.TextBox();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.btnZamknij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZatrudnienie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZatrudnienie
            // 
            this.dgvZatrudnienie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZatrudnienie.Location = new System.Drawing.Point(7, 121);
            this.dgvZatrudnienie.Name = "dgvZatrudnienie";
            this.dgvZatrudnienie.RowHeadersWidth = 51;
            this.dgvZatrudnienie.RowTemplate.Height = 24;
            this.dgvZatrudnienie.Size = new System.Drawing.Size(777, 265);
            this.dgvZatrudnienie.TabIndex = 0;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Location = new System.Drawing.Point(12, 53);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(33, 17);
            this.lblImie.TabIndex = 1;
            this.lblImie.Text = "Imie";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Location = new System.Drawing.Point(12, 86);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(67, 17);
            this.lblNazwisko.TabIndex = 2;
            this.lblNazwisko.Text = "Nazwisko";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(394, 53);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 17);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(278, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 17);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "label1";
            // 
            // txtTelefonPracownika
            // 
            this.txtTelefonPracownika.Location = new System.Drawing.Point(456, 50);
            this.txtTelefonPracownika.Name = "txtTelefonPracownika";
            this.txtTelefonPracownika.Size = new System.Drawing.Size(129, 22);
            this.txtTelefonPracownika.TabIndex = 5;
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(85, 53);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(190, 22);
            this.txtImie.TabIndex = 7;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(85, 86);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(190, 22);
            this.txtNazwisko.TabIndex = 8;
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(662, 80);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(122, 35);
            this.btnZamknij.TabIndex = 9;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // PracownicySzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.txtTelefonPracownika);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.dgvZatrudnienie);
            this.Name = "PracownicySzczegoly";
            this.Text = "PracownicySzczegoly";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZatrudnienie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZatrudnienie;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTelefonPracownika;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Button btnZamknij;
    }
}