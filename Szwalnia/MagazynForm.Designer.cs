namespace Szwalnia
{
    partial class MagazynForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazynForm));
            this.btnElementy = new System.Windows.Forms.Button();
            this.btnObslugaDostaw = new System.Windows.Forms.Button();
            this.btnObslugaZamowien = new System.Windows.Forms.Button();
            this.btnUkladMagazynu = new System.Windows.Forms.Button();
            this.btnStanMagazynowy = new System.Windows.Forms.Button();
            this.btnKontrahenci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElementy
            // 
            this.btnElementy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElementy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnElementy.Location = new System.Drawing.Point(392, 328);
            this.btnElementy.Name = "btnElementy";
            this.btnElementy.Size = new System.Drawing.Size(159, 78);
            this.btnElementy.TabIndex = 5;
            this.btnElementy.Text = "Elementy";
            this.btnElementy.UseVisualStyleBackColor = false;
            this.btnElementy.Click += new System.EventHandler(this.btnElementyForm_Click);
            // 
            // btnObslugaDostaw
            // 
            this.btnObslugaDostaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObslugaDostaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObslugaDostaw.Location = new System.Drawing.Point(162, 208);
            this.btnObslugaDostaw.Name = "btnObslugaDostaw";
            this.btnObslugaDostaw.Size = new System.Drawing.Size(275, 67);
            this.btnObslugaDostaw.TabIndex = 2;
            this.btnObslugaDostaw.Text = "Obsługa dostaw";
            this.btnObslugaDostaw.UseVisualStyleBackColor = false;
            this.btnObslugaDostaw.Click += new System.EventHandler(this.btnObslugaDostaw_Click);
            // 
            // btnObslugaZamowien
            // 
            this.btnObslugaZamowien.AutoSize = true;
            this.btnObslugaZamowien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObslugaZamowien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObslugaZamowien.Location = new System.Drawing.Point(162, 135);
            this.btnObslugaZamowien.Name = "btnObslugaZamowien";
            this.btnObslugaZamowien.Size = new System.Drawing.Size(275, 67);
            this.btnObslugaZamowien.TabIndex = 1;
            this.btnObslugaZamowien.Text = "Obsługa zamówień";
            this.btnObslugaZamowien.UseVisualStyleBackColor = false;
            this.btnObslugaZamowien.Click += new System.EventHandler(this.btnObslugaZamowien_Click);
            // 
            // btnUkladMagazynu
            // 
            this.btnUkladMagazynu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUkladMagazynu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUkladMagazynu.Location = new System.Drawing.Point(44, 328);
            this.btnUkladMagazynu.Name = "btnUkladMagazynu";
            this.btnUkladMagazynu.Size = new System.Drawing.Size(159, 78);
            this.btnUkladMagazynu.TabIndex = 3;
            this.btnUkladMagazynu.Text = "Układ Magazynu";
            this.btnUkladMagazynu.UseVisualStyleBackColor = false;
            this.btnUkladMagazynu.Click += new System.EventHandler(this.btnUkladMagazynu_Click);
            // 
            // btnStanMagazynowy
            // 
            this.btnStanMagazynowy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStanMagazynowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStanMagazynowy.Location = new System.Drawing.Point(162, 29);
            this.btnStanMagazynowy.Name = "btnStanMagazynowy";
            this.btnStanMagazynowy.Size = new System.Drawing.Size(275, 75);
            this.btnStanMagazynowy.TabIndex = 0;
            this.btnStanMagazynowy.Text = "Stan magazynowy";
            this.btnStanMagazynowy.UseVisualStyleBackColor = false;
            this.btnStanMagazynowy.Click += new System.EventHandler(this.btnStanMagazynowy_Click);
            // 
            // btnKontrahenci
            // 
            this.btnKontrahenci.AutoSize = true;
            this.btnKontrahenci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKontrahenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKontrahenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKontrahenci.Location = new System.Drawing.Point(218, 328);
            this.btnKontrahenci.Name = "btnKontrahenci";
            this.btnKontrahenci.Size = new System.Drawing.Size(159, 78);
            this.btnKontrahenci.TabIndex = 4;
            this.btnKontrahenci.Text = "Kontrahenci";
            this.btnKontrahenci.UseVisualStyleBackColor = false;
            this.btnKontrahenci.Click += new System.EventHandler(this.btnKontrahenci_Click);
            // 
            // MagazynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(606, 436);
            this.Controls.Add(this.btnUkladMagazynu);
            this.Controls.Add(this.btnObslugaDostaw);
            this.Controls.Add(this.btnKontrahenci);
            this.Controls.Add(this.btnObslugaZamowien);
            this.Controls.Add(this.btnElementy);
            this.Controls.Add(this.btnStanMagazynowy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MagazynForm";
            this.Text = "Moduł magazynowy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MagazynForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnElementy;
        private System.Windows.Forms.Button btnObslugaDostaw;
        private System.Windows.Forms.Button btnObslugaZamowien;
        private System.Windows.Forms.Button btnUkladMagazynu;
        private System.Windows.Forms.Button btnStanMagazynowy;
        private System.Windows.Forms.Button btnKontrahenci;
    }
}