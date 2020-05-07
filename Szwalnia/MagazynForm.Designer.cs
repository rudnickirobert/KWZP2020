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
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnElementy.Location = new System.Drawing.Point(387, 437);
            this.btnElementy.Name = "btnElementy";
            this.btnElementy.Size = new System.Drawing.Size(159, 78);
            this.btnElementy.TabIndex = 0;
            this.btnElementy.Text = "Elementy";
            this.btnElementy.UseVisualStyleBackColor = true;
            this.btnElementy.Click += new System.EventHandler(this.btnElementyForm_Click);
            // 
            // btnObslugaDostaw
            // 
            this.btnObslugaDostaw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnObslugaDostaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObslugaDostaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObslugaDostaw.Location = new System.Drawing.Point(162, 314);
            this.btnObslugaDostaw.Name = "btnObslugaDostaw";
            this.btnObslugaDostaw.Size = new System.Drawing.Size(275, 67);
            this.btnObslugaDostaw.TabIndex = 3;
            this.btnObslugaDostaw.Text = "Obsługa dostaw";
            this.btnObslugaDostaw.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(218, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 56);
            this.label1.TabIndex = 6;
            this.label1.Text = "Magazyn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnObslugaZamowien
            // 
            this.btnObslugaZamowien.AutoSize = true;
            this.btnObslugaZamowien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObslugaZamowien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObslugaZamowien.Location = new System.Drawing.Point(162, 213);
            this.btnObslugaZamowien.Name = "btnObslugaZamowien";
            this.btnObslugaZamowien.Size = new System.Drawing.Size(275, 67);
            this.btnObslugaZamowien.TabIndex = 5;
            this.btnObslugaZamowien.Text = "Obsługa zamówień";
            this.btnObslugaZamowien.UseVisualStyleBackColor = true;
            this.btnObslugaZamowien.Click += new System.EventHandler(this.btnObslugaZamowien_Click);
            // 
            // btnUkladMagazynu
            // 
            this.btnUkladMagazynu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUkladMagazynu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUkladMagazynu.Location = new System.Drawing.Point(41, 437);
            this.btnUkladMagazynu.Name = "btnUkladMagazynu";
            this.btnUkladMagazynu.Size = new System.Drawing.Size(159, 78);
            this.btnUkladMagazynu.TabIndex = 1;
            this.btnUkladMagazynu.Text = "Układ Magazynu";
            this.btnUkladMagazynu.UseVisualStyleBackColor = true;
            this.btnUkladMagazynu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStanMagazynowy
            // 
            this.btnStanMagazynowy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStanMagazynowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStanMagazynowy.Location = new System.Drawing.Point(183, 106);
            this.btnStanMagazynowy.Name = "btnStanMagazynowy";
            this.btnStanMagazynowy.Size = new System.Drawing.Size(224, 67);
            this.btnStanMagazynowy.TabIndex = 2;
            this.btnStanMagazynowy.Text = "Stan magazynowy";
            this.btnStanMagazynowy.UseVisualStyleBackColor = true;
            this.btnStanMagazynowy.Click += new System.EventHandler(this.btnStanMagazynowy_Click);
            // 
            // btnKontrahenci
            // 
            this.btnKontrahenci.AutoSize = true;
            this.btnKontrahenci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKontrahenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKontrahenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKontrahenci.Location = new System.Drawing.Point(214, 437);
            this.btnKontrahenci.Name = "btnKontrahenci";
            this.btnKontrahenci.Size = new System.Drawing.Size(159, 78);
            this.btnKontrahenci.TabIndex = 4;
            this.btnKontrahenci.Text = "Kontrahenci";
            this.btnKontrahenci.UseVisualStyleBackColor = true;
            // 
            // MagazynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(597, 574);
            this.Controls.Add(this.btnUkladMagazynu);
            this.Controls.Add(this.btnObslugaDostaw);
            this.Controls.Add(this.btnKontrahenci);
            this.Controls.Add(this.btnObslugaZamowien);
            this.Controls.Add(this.btnElementy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStanMagazynowy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MagazynForm";
            this.Text = "Moduł magazynowy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnElementy;
        private System.Windows.Forms.Button btnObslugaDostaw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObslugaZamowien;
        private System.Windows.Forms.Button btnUkladMagazynu;
        private System.Windows.Forms.Button btnStanMagazynowy;
        private System.Windows.Forms.Button btnKontrahenci;
    }
}