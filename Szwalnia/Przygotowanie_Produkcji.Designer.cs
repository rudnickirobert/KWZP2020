namespace Szwalnia
{
    partial class Przygotowanie_Produkcji
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_MaszynyProces_Szukaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(58, 316);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 57);
            this.button4.TabIndex = 9;
            this.button4.Text = "Obsluga_Maszyn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(58, 252);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 55);
            this.button3.TabIndex = 8;
            this.button3.Text = "Maszyny_Serwis";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 188);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "Srednia_Il_Maszyn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Suma_Czasu_Proces";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_MaszynyProces_Szukaj
            // 
            this.btn_MaszynyProces_Szukaj.Location = new System.Drawing.Point(57, 61);
            this.btn_MaszynyProces_Szukaj.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MaszynyProces_Szukaj.Name = "btn_MaszynyProces_Szukaj";
            this.btn_MaszynyProces_Szukaj.Size = new System.Drawing.Size(197, 55);
            this.btn_MaszynyProces_Szukaj.TabIndex = 5;
            this.btn_MaszynyProces_Szukaj.Text = "Maszyny_Proces_Liczba";
            this.btn_MaszynyProces_Szukaj.UseVisualStyleBackColor = true;
            this.btn_MaszynyProces_Szukaj.Click += new System.EventHandler(this.btn_MaszynyProces_Szukaj_Click_1);
            // 
            // Przygotowanie_Produkcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_MaszynyProces_Szukaj);
            this.Name = "Przygotowanie_Produkcji";
            this.Text = "Przygotowanie_Produkcji";
            this.Load += new System.EventHandler(this.Przygotowanie_Produkcji_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_MaszynyProces_Szukaj;
    }
}