﻿namespace Szwalnia
{
    partial class ZarzadzanieForm
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
            this.btnKlienciForm = new System.Windows.Forms.Button();
            this.btnPracownicy = new System.Windows.Forms.Button();
            this.btnFakturyZewnetrzne = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKlienciForm
            // 
            this.btnKlienciForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKlienciForm.Location = new System.Drawing.Point(12, 12);
            this.btnKlienciForm.Name = "btnKlienciForm";
            this.btnKlienciForm.Size = new System.Drawing.Size(163, 52);
            this.btnKlienciForm.TabIndex = 0;
            this.btnKlienciForm.Text = "Klienci";
            this.btnKlienciForm.UseVisualStyleBackColor = true;
            this.btnKlienciForm.Click += new System.EventHandler(this.btnKlienciForm_Click);
            // 
            // btnPracownicy
            // 
            this.btnPracownicy.Location = new System.Drawing.Point(12, 70);
            this.btnPracownicy.Name = "btnPracownicy";
            this.btnPracownicy.Size = new System.Drawing.Size(163, 52);
            this.btnPracownicy.TabIndex = 1;
            this.btnPracownicy.Text = "Pracownicy";
            this.btnPracownicy.UseVisualStyleBackColor = true;
            this.btnPracownicy.Click += new System.EventHandler(this.btnPracownicy_Click);
            // 
            // btnFakturyZewnetrzne
            // 
            this.btnFakturyZewnetrzne.Location = new System.Drawing.Point(12, 128);
            this.btnFakturyZewnetrzne.Name = "btnFakturyZewnetrzne";
            this.btnFakturyZewnetrzne.Size = new System.Drawing.Size(163, 52);
            this.btnFakturyZewnetrzne.TabIndex = 2;
            this.btnFakturyZewnetrzne.Text = "Faktury Zewnętrzne";
            this.btnFakturyZewnetrzne.UseVisualStyleBackColor = true;
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(12, 186);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(163, 52);
            this.btnZamknij.TabIndex = 3;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            // 
            // ZarzadzanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 247);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnFakturyZewnetrzne);
            this.Controls.Add(this.btnPracownicy);
            this.Controls.Add(this.btnKlienciForm);
            this.Name = "ZarzadzanieForm";
            this.Text = "ZarzadzanieForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlienciForm;
        private System.Windows.Forms.Button btnPracownicy;
        private System.Windows.Forms.Button btnFakturyZewnetrzne;
        private System.Windows.Forms.Button btnZamknij;
    }
}