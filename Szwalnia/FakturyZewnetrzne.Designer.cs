namespace Szwalnia
{
    partial class FakturyZewnetrzne
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
            this.btnFaktury = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFaktury
            // 
            this.btnFaktury.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFaktury.Location = new System.Drawing.Point(12, 45);
            this.btnFaktury.Name = "btnFaktury";
            this.btnFaktury.Size = new System.Drawing.Size(201, 81);
            this.btnFaktury.TabIndex = 3;
            this.btnFaktury.Text = "Faktury  zewnętrzne";
            this.btnFaktury.UseVisualStyleBackColor = true;
            this.btnFaktury.Click += new System.EventHandler(this.btnFaktury_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(240, 45);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(201, 81);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj nową fakturę ";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(343, 158);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(98, 33);
            this.btnZamknij.TabIndex = 5;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // FakturyZewnetrzne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 209);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnFaktury);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FakturyZewnetrzne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faktury Zewnetrzne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFaktury;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnZamknij;
    }
}