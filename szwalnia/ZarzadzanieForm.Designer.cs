namespace Szwalnia
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
            this.btnWroc = new System.Windows.Forms.Button();
            this.btnFakturyZewnetrzne = new System.Windows.Forms.Button();
            this.btnPracownicy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKlienciForm
            // 
            this.btnKlienciForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKlienciForm.Location = new System.Drawing.Point(29, 34);
            this.btnKlienciForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKlienciForm.Name = "btnKlienciForm";
            this.btnKlienciForm.Size = new System.Drawing.Size(189, 64);
            this.btnKlienciForm.TabIndex = 0;
            this.btnKlienciForm.Text = "Klienci";
            this.btnKlienciForm.UseVisualStyleBackColor = true;
            this.btnKlienciForm.Click += new System.EventHandler(this.btnKlienciForm_Click);
            // 
            // btnWroc
            // 
            this.btnWroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWroc.Location = new System.Drawing.Point(29, 345);
            this.btnWroc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWroc.Name = "btnWroc";
            this.btnWroc.Size = new System.Drawing.Size(189, 64);
            this.btnWroc.TabIndex = 0;
            this.btnWroc.Text = "Zamknij";
            this.btnWroc.UseVisualStyleBackColor = true;
            this.btnWroc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnZamknij_MouseClick);
            // 
            // btnFakturyZewnetrzne
            // 
            this.btnFakturyZewnetrzne.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnFakturyZewnetrzne.Location = new System.Drawing.Point(29, 274);
            this.btnFakturyZewnetrzne.Margin = new System.Windows.Forms.Padding(4);
            this.btnFakturyZewnetrzne.Name = "btnFakturyZewnetrzne";
            this.btnFakturyZewnetrzne.Size = new System.Drawing.Size(189, 64);
            this.btnFakturyZewnetrzne.TabIndex = 1;
            this.btnFakturyZewnetrzne.Text = "Faktury Zewnętrzne";
            this.btnFakturyZewnetrzne.UseVisualStyleBackColor = true;
            this.btnFakturyZewnetrzne.Click += new System.EventHandler(this.btnFakturyZewnetrzne_Click);
            // 
            // btnPracownicy
            // 
            this.btnPracownicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPracownicy.Location = new System.Drawing.Point(29, 121);
            this.btnPracownicy.Name = "btnPracownicy";
            this.btnPracownicy.Size = new System.Drawing.Size(189, 66);
            this.btnPracownicy.TabIndex = 2;
            this.btnPracownicy.Text = "Pracownicy";
            this.btnPracownicy.UseVisualStyleBackColor = true;
            this.btnPracownicy.Click += new System.EventHandler(this.btnPracownicy_Click);
            // 
            // ZarzadzanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPracownicy);
            this.Controls.Add(this.btnFakturyZewnetrzne);
            this.Controls.Add(this.btnWroc);
            this.Controls.Add(this.btnKlienciForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ZarzadzanieForm";
            this.Text = "Moduł Zarządzanie";
            this.Load += new System.EventHandler(this.ZarzadzanieForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlienciForm;
        private System.Windows.Forms.Button btnWroc;
        private System.Windows.Forms.Button btnFakturyZewnetrzne;
        private System.Windows.Forms.Button btnPracownicy;
    }
}