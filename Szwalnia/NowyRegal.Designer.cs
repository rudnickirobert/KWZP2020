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
            this.label1 = new System.Windows.Forms.Label();
            this.lblOznaczenie = new System.Windows.Forms.Label();
            this.txtOznaczenie = new System.Windows.Forms.TextBox();
            this.btnDodajRegal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dodaj nowy regał";
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
            this.btnDodajRegal.Location = new System.Drawing.Point(108, 134);
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
            this.ClientSize = new System.Drawing.Size(313, 192);
            this.Controls.Add(this.btnDodajRegal);
            this.Controls.Add(this.txtOznaczenie);
            this.Controls.Add(this.lblOznaczenie);
            this.Controls.Add(this.label1);
            this.Name = "NowyRegal";
            this.Text = "Dodaj regał";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOznaczenie;
        private System.Windows.Forms.TextBox txtOznaczenie;
        private System.Windows.Forms.Button btnDodajRegal;
    }
}