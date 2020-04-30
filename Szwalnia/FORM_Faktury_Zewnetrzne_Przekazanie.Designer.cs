namespace Szwalnia
{
    partial class FORM_Faktury_Zewnetrzne_Przekazanie
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
            this.LBL_Faktury_Zewnetrzne_Wyszukaj = new System.Windows.Forms.Label();
            this.LBL_Wyszukaj = new System.Windows.Forms.Label();
            this.TXTBOX1 = new System.Windows.Forms.TextBox();
            this.BUTTON = new System.Windows.Forms.Button();
            this.LBL_NP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_Faktury_Zewnetrzne_Wyszukaj
            // 
            this.LBL_Faktury_Zewnetrzne_Wyszukaj.AutoSize = true;
            this.LBL_Faktury_Zewnetrzne_Wyszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.LBL_Faktury_Zewnetrzne_Wyszukaj.Location = new System.Drawing.Point(12, 18);
            this.LBL_Faktury_Zewnetrzne_Wyszukaj.Name = "LBL_Faktury_Zewnetrzne_Wyszukaj";
            this.LBL_Faktury_Zewnetrzne_Wyszukaj.Size = new System.Drawing.Size(417, 55);
            this.LBL_Faktury_Zewnetrzne_Wyszukaj.TabIndex = 0;
            this.LBL_Faktury_Zewnetrzne_Wyszukaj.Text = "Faktury zewntrzne";
            // 
            // LBL_Wyszukaj
            // 
            this.LBL_Wyszukaj.AutoSize = true;
            this.LBL_Wyszukaj.Location = new System.Drawing.Point(19, 103);
            this.LBL_Wyszukaj.Name = "LBL_Wyszukaj";
            this.LBL_Wyszukaj.Size = new System.Drawing.Size(118, 13);
            this.LBL_Wyszukaj.TabIndex = 0;
            this.LBL_Wyszukaj.Text = "Wyszukaj po nr faktury:";
            // 
            // TXTBOX1
            // 
            this.TXTBOX1.Location = new System.Drawing.Point(143, 100);
            this.TXTBOX1.Name = "TXTBOX1";
            this.TXTBOX1.Size = new System.Drawing.Size(286, 20);
            this.TXTBOX1.TabIndex = 1;
            this.TXTBOX1.Text = "Innogy";
            this.TXTBOX1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BUTTON
            // 
            this.BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BUTTON.Location = new System.Drawing.Point(22, 150);
            this.BUTTON.Name = "BUTTON";
            this.BUTTON.Size = new System.Drawing.Size(407, 73);
            this.BUTTON.TabIndex = 2;
            this.BUTTON.Text = "Wyszukaj";
            this.BUTTON.UseVisualStyleBackColor = true;
            this.BUTTON.Click += new System.EventHandler(this.BUTTON_Click);
            this.BUTTON.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BUTTON_MouseClick);
            // 
            // LBL_NP
            // 
            this.LBL_NP.AutoSize = true;
            this.LBL_NP.Location = new System.Drawing.Point(240, 123);
            this.LBL_NP.Name = "LBL_NP";
            this.LBL_NP.Size = new System.Drawing.Size(59, 13);
            this.LBL_NP.TabIndex = 3;
            this.LBL_NP.Text = "Np. Innogy";
            this.LBL_NP.Click += new System.EventHandler(this.LBL_NP_Click);
            // 
            // FORM_Faktury_Zewnetrzne_Przekazanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 253);
            this.Controls.Add(this.LBL_NP);
            this.Controls.Add(this.BUTTON);
            this.Controls.Add(this.TXTBOX1);
            this.Controls.Add(this.LBL_Wyszukaj);
            this.Controls.Add(this.LBL_Faktury_Zewnetrzne_Wyszukaj);
            this.Name = "FORM_Faktury_Zewnetrzne_Przekazanie";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FORM_Faktury_Zewnetrzne_Przekazanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Faktury_Zewnetrzne_Wyszukaj;
        private System.Windows.Forms.Label LBL_Wyszukaj;
        private System.Windows.Forms.TextBox TXTBOX1;
        private System.Windows.Forms.Button BUTTON;
        private System.Windows.Forms.Label LBL_NP;
    }
}