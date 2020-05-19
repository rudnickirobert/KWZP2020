namespace Szwalnia
{
    partial class PanelPracownika
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
            this.btnPracownicy = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnNowyPracownik = new System.Windows.Forms.Button();
            this.btnZatrudnienie = new System.Windows.Forms.Button();
            this.btnJezyk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPracownicy
            // 
            this.btnPracownicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPracownicy.Location = new System.Drawing.Point(15, 29);
            this.btnPracownicy.Name = "btnPracownicy";
            this.btnPracownicy.Size = new System.Drawing.Size(194, 89);
            this.btnPracownicy.TabIndex = 0;
            this.btnPracownicy.Text = "Pracownicy";
            this.btnPracownicy.UseVisualStyleBackColor = true;
            this.btnPracownicy.Click += new System.EventHandler(this.btnPracownicy_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(332, 273);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(105, 42);
            this.btnZamknij.TabIndex = 1;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnNowyPracownik
            // 
            this.btnNowyPracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNowyPracownik.Location = new System.Drawing.Point(240, 29);
            this.btnNowyPracownik.Name = "btnNowyPracownik";
            this.btnNowyPracownik.Size = new System.Drawing.Size(197, 89);
            this.btnNowyPracownik.TabIndex = 2;
            this.btnNowyPracownik.Text = "Nowy Pracownik";
            this.btnNowyPracownik.UseVisualStyleBackColor = true;
            this.btnNowyPracownik.Click += new System.EventHandler(this.btnNowyPracownik_Click);
            // 
            // btnZatrudnienie
            // 
            this.btnZatrudnienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatrudnienie.Location = new System.Drawing.Point(240, 148);
            this.btnZatrudnienie.Name = "btnZatrudnienie";
            this.btnZatrudnienie.Size = new System.Drawing.Size(194, 89);
            this.btnZatrudnienie.TabIndex = 3;
            this.btnZatrudnienie.Text = "Zmiana Zatrudnienia";
            this.btnZatrudnienie.UseVisualStyleBackColor = true;
            this.btnZatrudnienie.Click += new System.EventHandler(this.btnZatrudnienie_Click);
            // 
            // btnJezyk
            // 
            this.btnJezyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJezyk.Location = new System.Drawing.Point(15, 148);
            this.btnJezyk.Name = "btnJezyk";
            this.btnJezyk.Size = new System.Drawing.Size(197, 89);
            this.btnJezyk.TabIndex = 4;
            this.btnJezyk.Text = "Znajomość języków";
            this.btnJezyk.UseVisualStyleBackColor = true;
            this.btnJezyk.Click += new System.EventHandler(this.btnJezyk_Click);
            // 
            // PanelPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(448, 333);
            this.Controls.Add(this.btnJezyk);
            this.Controls.Add(this.btnZatrudnienie);
            this.Controls.Add(this.btnNowyPracownik);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnPracownicy);
            this.Name = "PanelPracownika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Pracownika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPracownicy;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnNowyPracownik;
        private System.Windows.Forms.Button btnZatrudnienie;
        private System.Windows.Forms.Button btnJezyk;
    }
}