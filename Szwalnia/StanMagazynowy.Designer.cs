namespace Szwalnia
{
    partial class StanMagazynowy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StanMagazynowy));
            this.btnPustePolki = new System.Windows.Forms.Button();
            this.btnWgElementow = new System.Windows.Forms.Button();
            this.btnCalkowity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPustePolki
            // 
            this.btnPustePolki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPustePolki.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPustePolki.Location = new System.Drawing.Point(91, 152);
            this.btnPustePolki.Name = "btnPustePolki";
            this.btnPustePolki.Size = new System.Drawing.Size(135, 33);
            this.btnPustePolki.TabIndex = 9;
            this.btnPustePolki.Text = "Puste półki";
            this.btnPustePolki.UseVisualStyleBackColor = true;
            this.btnPustePolki.Click += new System.EventHandler(this.btnPustePolki_Click);
            // 
            // btnWgElementow
            // 
            this.btnWgElementow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnWgElementow.Location = new System.Drawing.Point(91, 113);
            this.btnWgElementow.Name = "btnWgElementow";
            this.btnWgElementow.Size = new System.Drawing.Size(135, 33);
            this.btnWgElementow.TabIndex = 8;
            this.btnWgElementow.Text = "Według elementów";
            this.btnWgElementow.UseVisualStyleBackColor = true;
            this.btnWgElementow.Click += new System.EventHandler(this.btnWgElementow_Click);
            // 
            // btnCalkowity
            // 
            this.btnCalkowity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCalkowity.Location = new System.Drawing.Point(91, 74);
            this.btnCalkowity.Name = "btnCalkowity";
            this.btnCalkowity.Size = new System.Drawing.Size(135, 33);
            this.btnCalkowity.TabIndex = 7;
            this.btnCalkowity.Text = "Całkowity";
            this.btnCalkowity.UseVisualStyleBackColor = true;
            this.btnCalkowity.Click += new System.EventHandler(this.btnCalkowity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Stan magazynowy";
            // 
            // StanMagazynowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPustePolki);
            this.Controls.Add(this.btnWgElementow);
            this.Controls.Add(this.btnCalkowity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StanMagazynowy";
            this.Text = "Stan Magazynowy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StanMagazynowy_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPustePolki;
        private System.Windows.Forms.Button btnWgElementow;
        private System.Windows.Forms.Button btnCalkowity;
        private System.Windows.Forms.Label label1;
    }
}