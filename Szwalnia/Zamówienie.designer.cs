﻿namespace Szwalnia
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
            this.btnDodajElementy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStare
            // 
            this.btnStare.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStare.Location = new System.Drawing.Point(23, 26);
            this.btnStare.Name = "btnStare";
            this.btnStare.Size = new System.Drawing.Size(215, 109);
            this.btnStare.TabIndex = 0;
            this.btnStare.Text = "Podgląd zamówień";
            this.btnStare.UseVisualStyleBackColor = true;
            this.btnStare.Click += new System.EventHandler(this.btnStare_Click);
            // 
            // btnNowe
            // 
            this.btnNowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNowe.Location = new System.Drawing.Point(281, 26);
            this.btnNowe.Name = "btnNowe";
            this.btnNowe.Size = new System.Drawing.Size(215, 109);
            this.btnNowe.TabIndex = 6;
            this.btnNowe.Text = "Nowe Zamówienie";
            this.btnNowe.UseVisualStyleBackColor = true;
            this.btnNowe.Click += new System.EventHandler(this.btnNowe_Click);
            // 
            // btnKoniecZamowienia
            // 
            this.btnKoniecZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKoniecZamowienia.Location = new System.Drawing.Point(281, 198);
            this.btnKoniecZamowienia.Name = "btnKoniecZamowienia";
            this.btnKoniecZamowienia.Size = new System.Drawing.Size(215, 109);
            this.btnKoniecZamowienia.TabIndex = 7;
            this.btnKoniecZamowienia.Text = "Zakończ zamówienie";
            this.btnKoniecZamowienia.UseVisualStyleBackColor = true;
            this.btnKoniecZamowienia.Click += new System.EventHandler(this.btnKoniecZamowienia_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(378, 381);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(118, 54);
            this.btnZamknij.TabIndex = 8;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnDodajElementy
            // 
            this.btnDodajElementy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajElementy.Location = new System.Drawing.Point(23, 198);
            this.btnDodajElementy.Name = "btnDodajElementy";
            this.btnDodajElementy.Size = new System.Drawing.Size(215, 109);
            this.btnDodajElementy.TabIndex = 9;
            this.btnDodajElementy.Text = "Dodaj elementy do istniejącego zamówienia";
            this.btnDodajElementy.UseVisualStyleBackColor = true;
            this.btnDodajElementy.Click += new System.EventHandler(this.btnDodajElementy_Click);
            // 
            // Zamowienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(517, 462);
            this.Controls.Add(this.btnDodajElementy);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnKoniecZamowienia);
            this.Controls.Add(this.btnNowe);
            this.Controls.Add(this.btnStare);
            this.Name = "Zamowienie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamówienie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStare;
        private System.Windows.Forms.Button btnNowe;
        private System.Windows.Forms.Button btnKoniecZamowienia;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnDodajElementy;
    }
}