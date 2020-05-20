﻿namespace Szwalnia
{
    partial class ElementyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementyForm));
            this.btnWyborElementu = new System.Windows.Forms.Button();
            this.btnElement = new System.Windows.Forms.Button();
            this.btnTyp = new System.Windows.Forms.Button();
            this.btnCecha = new System.Windows.Forms.Button();
            this.btnJednostka = new System.Windows.Forms.Button();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.btnWyborTypu = new System.Windows.Forms.Button();
            this.btnWyborCechy = new System.Windows.Forms.Button();
            this.btnWyborJednostki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWyborElementu
            // 
            this.btnWyborElementu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyborElementu.Location = new System.Drawing.Point(213, 9);
            this.btnWyborElementu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWyborElementu.Name = "btnWyborElementu";
            this.btnWyborElementu.Size = new System.Drawing.Size(187, 50);
            this.btnWyborElementu.TabIndex = 1;
            this.btnWyborElementu.Text = "Przeglądaj elementy";
            this.btnWyborElementu.UseVisualStyleBackColor = true;
            this.btnWyborElementu.Click += new System.EventHandler(this.btnWybor_Click);
            // 
            // btnElement
            // 
            this.btnElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnElement.Location = new System.Drawing.Point(9, 9);
            this.btnElement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnElement.Name = "btnElement";
            this.btnElement.Size = new System.Drawing.Size(187, 50);
            this.btnElement.TabIndex = 0;
            this.btnElement.Text = "Dodaj element";
            this.btnElement.UseVisualStyleBackColor = true;
            this.btnElement.Click += new System.EventHandler(this.btnElement_Click);
            // 
            // btnTyp
            // 
            this.btnTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTyp.Location = new System.Drawing.Point(9, 63);
            this.btnTyp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTyp.Name = "btnTyp";
            this.btnTyp.Size = new System.Drawing.Size(187, 50);
            this.btnTyp.TabIndex = 2;
            this.btnTyp.Text = "Dodaj typ elementu";
            this.btnTyp.UseVisualStyleBackColor = true;
            this.btnTyp.Click += new System.EventHandler(this.btnTyp_Click);
            // 
            // btnCecha
            // 
            this.btnCecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCecha.Location = new System.Drawing.Point(9, 118);
            this.btnCecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCecha.Name = "btnCecha";
            this.btnCecha.Size = new System.Drawing.Size(187, 50);
            this.btnCecha.TabIndex = 4;
            this.btnCecha.Text = "Dodaj cechę elementu";
            this.btnCecha.UseVisualStyleBackColor = true;
            this.btnCecha.Click += new System.EventHandler(this.btnCecha_Click);
            // 
            // btnJednostka
            // 
            this.btnJednostka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJednostka.Location = new System.Drawing.Point(8, 172);
            this.btnJednostka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJednostka.Name = "btnJednostka";
            this.btnJednostka.Size = new System.Drawing.Size(187, 50);
            this.btnJednostka.TabIndex = 6;
            this.btnJednostka.Text = "Dodaj jednostkę miary";
            this.btnJednostka.UseVisualStyleBackColor = true;
            this.btnJednostka.Click += new System.EventHandler(this.btnJednostka_Click);
            // 
            // btnWstecz
            // 
            this.btnWstecz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWstecz.Location = new System.Drawing.Point(321, 246);
            this.btnWstecz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(79, 31);
            this.btnWstecz.TabIndex = 8;
            this.btnWstecz.Text = "Wstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // btnWyborTypu
            // 
            this.btnWyborTypu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyborTypu.Location = new System.Drawing.Point(213, 63);
            this.btnWyborTypu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWyborTypu.Name = "btnWyborTypu";
            this.btnWyborTypu.Size = new System.Drawing.Size(187, 50);
            this.btnWyborTypu.TabIndex = 3;
            this.btnWyborTypu.Text = "Przeglądaj typy elementów";
            this.btnWyborTypu.UseVisualStyleBackColor = true;
            this.btnWyborTypu.Click += new System.EventHandler(this.btnWyborTypu_Click);
            // 
            // btnWyborCechy
            // 
            this.btnWyborCechy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyborCechy.Location = new System.Drawing.Point(213, 118);
            this.btnWyborCechy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWyborCechy.Name = "btnWyborCechy";
            this.btnWyborCechy.Size = new System.Drawing.Size(187, 50);
            this.btnWyborCechy.TabIndex = 5;
            this.btnWyborCechy.Text = "Przeglądaj cechy elementów";
            this.btnWyborCechy.UseVisualStyleBackColor = true;
            this.btnWyborCechy.Click += new System.EventHandler(this.btnWyborCechy_Click);
            // 
            // btnWyborJednostki
            // 
            this.btnWyborJednostki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyborJednostki.Location = new System.Drawing.Point(213, 172);
            this.btnWyborJednostki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWyborJednostki.Name = "btnWyborJednostki";
            this.btnWyborJednostki.Size = new System.Drawing.Size(187, 50);
            this.btnWyborJednostki.TabIndex = 7;
            this.btnWyborJednostki.Text = "Przeglądaj jednostki miary";
            this.btnWyborJednostki.UseVisualStyleBackColor = true;
            this.btnWyborJednostki.Click += new System.EventHandler(this.btnWyborJednostki_Click);
            // 
            // ElementyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 289);
            this.Controls.Add(this.btnWyborJednostki);
            this.Controls.Add(this.btnWyborCechy);
            this.Controls.Add(this.btnWyborTypu);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.btnJednostka);
            this.Controls.Add(this.btnCecha);
            this.Controls.Add(this.btnTyp);
            this.Controls.Add(this.btnElement);
            this.Controls.Add(this.btnWyborElementu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ElementyForm";
            this.Text = "Elementy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ElementyForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWyborElementu;
        private System.Windows.Forms.Button btnElement;
        private System.Windows.Forms.Button btnTyp;
        private System.Windows.Forms.Button btnCecha;
        private System.Windows.Forms.Button btnJednostka;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.Button btnWyborTypu;
        private System.Windows.Forms.Button btnWyborCechy;
        private System.Windows.Forms.Button btnWyborJednostki;
    }
}