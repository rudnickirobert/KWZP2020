namespace Szwalnia
{
    partial class NowyRegal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NowyRegal));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOznaczenie = new System.Windows.Forms.Label();
            this.txtOznaczenie = new System.Windows.Forms.TextBox();
            this.btnDodajRegal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(49, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 31);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Dodaj nowy regał";
            // 
            // lblOznaczenie
            // 
            this.lblOznaczenie.AutoSize = true;
            this.lblOznaczenie.Location = new System.Drawing.Point(40, 87);
            this.lblOznaczenie.Name = "lblOznaczenie";
            this.lblOznaczenie.Size = new System.Drawing.Size(63, 13);
            this.lblOznaczenie.TabIndex = 6;
            this.lblOznaczenie.Text = "Oznaczenie";
            // 
            // txtOznaczenie
            // 
            this.txtOznaczenie.Location = new System.Drawing.Point(132, 84);
            this.txtOznaczenie.Name = "txtOznaczenie";
            this.txtOznaczenie.Size = new System.Drawing.Size(149, 20);
            this.txtOznaczenie.TabIndex = 7;
            this.txtOznaczenie.TextChanged += new System.EventHandler(this.txtOznaczenie_TextChanged);
            // 
            // btnDodajRegal
            // 
            this.btnDodajRegal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDodajRegal.Location = new System.Drawing.Point(117, 134);
            this.btnDodajRegal.Name = "btnDodajRegal";
            this.btnDodajRegal.Size = new System.Drawing.Size(86, 32);
            this.btnDodajRegal.TabIndex = 8;
            this.btnDodajRegal.Text = "Dodaj";
            this.btnDodajRegal.UseVisualStyleBackColor = true;
            this.btnDodajRegal.Click += new System.EventHandler(this.btnDodajRegal_Click);
            // 
            // NowyRegal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 187);
            this.Controls.Add(this.btnDodajRegal);
            this.Controls.Add(this.txtOznaczenie);
            this.Controls.Add(this.lblOznaczenie);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NowyRegal";
            this.Text = "Dodaj regał";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NowyRegal_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOznaczenie;
        private System.Windows.Forms.TextBox txtOznaczenie;
        private System.Windows.Forms.Button btnDodajRegal;
    }
}