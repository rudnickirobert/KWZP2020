namespace Szwalnia
{
    partial class NowyRozmiarPolki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NowyRozmiarPolki));
            this.lbSzerokosc = new System.Windows.Forms.Label();
            this.btnDodajRozmiar = new System.Windows.Forms.Button();
            this.lblWysokosc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGlebokosc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtWysokosc = new System.Windows.Forms.MaskedTextBox();
            this.mtxtGlebokosc = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSzerokosc = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbSzerokosc
            // 
            this.lbSzerokosc.AutoSize = true;
            this.lbSzerokosc.Location = new System.Drawing.Point(103, 112);
            this.lbSzerokosc.Name = "lbSzerokosc";
            this.lbSzerokosc.Size = new System.Drawing.Size(60, 13);
            this.lbSzerokosc.TabIndex = 28;
            this.lbSzerokosc.Text = "Szerokość:";
            // 
            // btnDodajRozmiar
            // 
            this.btnDodajRozmiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDodajRozmiar.Location = new System.Drawing.Point(144, 176);
            this.btnDodajRozmiar.Name = "btnDodajRozmiar";
            this.btnDodajRozmiar.Size = new System.Drawing.Size(86, 32);
            this.btnDodajRozmiar.TabIndex = 23;
            this.btnDodajRozmiar.Text = "Dodaj";
            this.btnDodajRozmiar.UseVisualStyleBackColor = true;
            this.btnDodajRozmiar.Click += new System.EventHandler(this.btnDodajRozmiar_Click);
            // 
            // lblWysokosc
            // 
            this.lblWysokosc.AutoSize = true;
            this.lblWysokosc.Location = new System.Drawing.Point(103, 83);
            this.lblWysokosc.Name = "lblWysokosc";
            this.lblWysokosc.Size = new System.Drawing.Size(60, 13);
            this.lblWysokosc.TabIndex = 22;
            this.lblWysokosc.Text = "Wysokość:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(29, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(316, 31);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Dodaj nowy rozmiar półki";
            // 
            // lblGlebokosc
            // 
            this.lblGlebokosc.AutoSize = true;
            this.lblGlebokosc.Location = new System.Drawing.Point(100, 141);
            this.lblGlebokosc.Name = "lblGlebokosc";
            this.lblGlebokosc.Size = new System.Drawing.Size(63, 13);
            this.lblGlebokosc.TabIndex = 33;
            this.lblGlebokosc.Text = "Głębokość:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "cm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "cm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "cm";
            // 
            // mtxtWysokosc
            // 
            this.mtxtWysokosc.Location = new System.Drawing.Point(171, 79);
            this.mtxtWysokosc.Mask = "000";
            this.mtxtWysokosc.Name = "mtxtWysokosc";
            this.mtxtWysokosc.Size = new System.Drawing.Size(75, 20);
            this.mtxtWysokosc.TabIndex = 1;
            // 
            // mtxtGlebokosc
            // 
            this.mtxtGlebokosc.Location = new System.Drawing.Point(171, 137);
            this.mtxtGlebokosc.Mask = "000";
            this.mtxtGlebokosc.Name = "mtxtGlebokosc";
            this.mtxtGlebokosc.Size = new System.Drawing.Size(75, 20);
            this.mtxtGlebokosc.TabIndex = 3;
            // 
            // mtxtSzerokosc
            // 
            this.mtxtSzerokosc.Location = new System.Drawing.Point(171, 108);
            this.mtxtSzerokosc.Mask = "000";
            this.mtxtSzerokosc.Name = "mtxtSzerokosc";
            this.mtxtSzerokosc.Size = new System.Drawing.Size(75, 20);
            this.mtxtSzerokosc.TabIndex = 2;
            // 
            // NowyRozmiarPolki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 225);
            this.Controls.Add(this.mtxtSzerokosc);
            this.Controls.Add(this.mtxtGlebokosc);
            this.Controls.Add(this.mtxtWysokosc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGlebokosc);
            this.Controls.Add(this.lbSzerokosc);
            this.Controls.Add(this.btnDodajRozmiar);
            this.Controls.Add(this.lblWysokosc);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NowyRozmiarPolki";
            this.Text = "Dodaj rozmiar półki";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NowyRozmiarPolki_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSzerokosc;
        private System.Windows.Forms.Button btnDodajRozmiar;
        private System.Windows.Forms.Label lblWysokosc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGlebokosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtWysokosc;
        private System.Windows.Forms.MaskedTextBox mtxtGlebokosc;
        private System.Windows.Forms.MaskedTextBox mtxtSzerokosc;
    }
}