﻿namespace Szwalnia
{
    partial class NoweZamowienie
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
            this.lblOpisNumer = new System.Windows.Forms.Label();
            this.lblNumerZamowienia = new System.Windows.Forms.Label();
            this.chbUmowa = new System.Windows.Forms.CheckBox();
            this.cbNazwa = new System.Windows.Forms.ComboBox();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.lblNazwaFirmy = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblUmowa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvUkryty = new System.Windows.Forms.DataGridView();
            this.btnWroc = new System.Windows.Forms.Button();
            this.btnWyzeruj = new System.Windows.Forms.Button();
            this.btnDalej = new System.Windows.Forms.Button();
            this.dtpZlozenie = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUkryty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpisNumer
            // 
            this.lblOpisNumer.AutoSize = true;
            this.lblOpisNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisNumer.Location = new System.Drawing.Point(17, 41);
            this.lblOpisNumer.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblOpisNumer.Name = "lblOpisNumer";
            this.lblOpisNumer.Size = new System.Drawing.Size(315, 32);
            this.lblOpisNumer.TabIndex = 1;
            this.lblOpisNumer.Text = "ID nowego zamówienia:";
            // 
            // lblNumerZamowienia
            // 
            this.lblNumerZamowienia.AutoSize = true;
            this.lblNumerZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumerZamowienia.Location = new System.Drawing.Point(348, 41);
            this.lblNumerZamowienia.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblNumerZamowienia.Name = "lblNumerZamowienia";
            this.lblNumerZamowienia.Size = new System.Drawing.Size(93, 32);
            this.lblNumerZamowienia.TabIndex = 5;
            this.lblNumerZamowienia.Text = "label1";
            // 
            // chbUmowa
            // 
            this.chbUmowa.AutoSize = true;
            this.chbUmowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbUmowa.Location = new System.Drawing.Point(214, 316);
            this.chbUmowa.Margin = new System.Windows.Forms.Padding(6);
            this.chbUmowa.Name = "chbUmowa";
            this.chbUmowa.Size = new System.Drawing.Size(18, 17);
            this.chbUmowa.TabIndex = 8;
            this.chbUmowa.UseVisualStyleBackColor = true;
            // 
            // cbNazwa
            // 
            this.cbNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbNazwa.FormattingEnabled = true;
            this.cbNazwa.Location = new System.Drawing.Point(214, 146);
            this.cbNazwa.Margin = new System.Windows.Forms.Padding(6);
            this.cbNazwa.Name = "cbNazwa";
            this.cbNazwa.Size = new System.Drawing.Size(498, 39);
            this.cbNazwa.TabIndex = 9;
            // 
            // cbPracownik
            // 
            this.cbPracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(214, 374);
            this.cbPracownik.Margin = new System.Windows.Forms.Padding(6);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(498, 39);
            this.cbPracownik.TabIndex = 10;
            // 
            // lblNazwaFirmy
            // 
            this.lblNazwaFirmy.AutoSize = true;
            this.lblNazwaFirmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaFirmy.Location = new System.Drawing.Point(17, 149);
            this.lblNazwaFirmy.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblNazwaFirmy.Name = "lblNazwaFirmy";
            this.lblNazwaFirmy.Size = new System.Drawing.Size(178, 32);
            this.lblNazwaFirmy.TabIndex = 11;
            this.lblNazwaFirmy.Text = "Nazwa Firmy";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblData.Location = new System.Drawing.Point(17, 221);
            this.lblData.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(188, 32);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data złożenia";
            // 
            // lblUmowa
            // 
            this.lblUmowa.AutoSize = true;
            this.lblUmowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUmowa.Location = new System.Drawing.Point(17, 301);
            this.lblUmowa.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUmowa.Name = "lblUmowa";
            this.lblUmowa.Size = new System.Drawing.Size(110, 32);
            this.lblUmowa.TabIndex = 14;
            this.lblUmowa.Text = "Umowa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(17, 377);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pracownik";
            // 
            // dgvUkryty
            // 
            this.dgvUkryty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUkryty.Location = new System.Drawing.Point(751, 28);
            this.dgvUkryty.Margin = new System.Windows.Forms.Padding(8);
            this.dgvUkryty.Name = "dgvUkryty";
            this.dgvUkryty.RowHeadersWidth = 51;
            this.dgvUkryty.Size = new System.Drawing.Size(47, 45);
            this.dgvUkryty.TabIndex = 23;
            this.dgvUkryty.Visible = false;
            // 
            // btnWroc
            // 
            this.btnWroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWroc.Location = new System.Drawing.Point(15, 516);
            this.btnWroc.Margin = new System.Windows.Forms.Padding(6);
            this.btnWroc.Name = "btnWroc";
            this.btnWroc.Size = new System.Drawing.Size(132, 56);
            this.btnWroc.TabIndex = 24;
            this.btnWroc.Text = "Wróć ";
            this.btnWroc.UseVisualStyleBackColor = true;
            // 
            // btnWyzeruj
            // 
            this.btnWyzeruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyzeruj.Location = new System.Drawing.Point(395, 516);
            this.btnWyzeruj.Margin = new System.Windows.Forms.Padding(6);
            this.btnWyzeruj.Name = "btnWyzeruj";
            this.btnWyzeruj.Size = new System.Drawing.Size(132, 56);
            this.btnWyzeruj.TabIndex = 25;
            this.btnWyzeruj.Text = "Wyzeruj";
            this.btnWyzeruj.UseVisualStyleBackColor = true;
            // 
            // btnDalej
            // 
            this.btnDalej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDalej.Location = new System.Drawing.Point(666, 516);
            this.btnDalej.Margin = new System.Windows.Forms.Padding(6);
            this.btnDalej.Name = "btnDalej";
            this.btnDalej.Size = new System.Drawing.Size(132, 56);
            this.btnDalej.TabIndex = 26;
            this.btnDalej.Text = "Dalej";
            this.btnDalej.UseVisualStyleBackColor = true;
            this.btnDalej.Click += new System.EventHandler(this.btnDalej_Click);
            // 
            // dtpZlozenie
            // 
            this.dtpZlozenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpZlozenie.Location = new System.Drawing.Point(214, 215);
            this.dtpZlozenie.Margin = new System.Windows.Forms.Padding(6);
            this.dtpZlozenie.Name = "dtpZlozenie";
            this.dtpZlozenie.Size = new System.Drawing.Size(498, 38);
            this.dtpZlozenie.TabIndex = 27;
            // 
            // NoweZamowienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(806, 582);
            this.Controls.Add(this.dtpZlozenie);
            this.Controls.Add(this.btnDalej);
            this.Controls.Add(this.btnWyzeruj);
            this.Controls.Add(this.btnWroc);
            this.Controls.Add(this.dgvUkryty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUmowa);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNazwaFirmy);
            this.Controls.Add(this.cbPracownik);
            this.Controls.Add(this.cbNazwa);
            this.Controls.Add(this.chbUmowa);
            this.Controls.Add(this.lblNumerZamowienia);
            this.Controls.Add(this.lblOpisNumer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NoweZamowienie";
            this.Text = "Nowe_zamówienie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUkryty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpisNumer;
        private System.Windows.Forms.Label lblNumerZamowienia;
        private System.Windows.Forms.CheckBox chbUmowa;
        private System.Windows.Forms.ComboBox cbNazwa;
        private System.Windows.Forms.ComboBox cbPracownik;
        private System.Windows.Forms.Label lblNazwaFirmy;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblUmowa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvUkryty;
        private System.Windows.Forms.Button btnWroc;
        private System.Windows.Forms.Button btnWyzeruj;
        private System.Windows.Forms.Button btnDalej;
        private System.Windows.Forms.DateTimePicker dtpZlozenie;
    }
}