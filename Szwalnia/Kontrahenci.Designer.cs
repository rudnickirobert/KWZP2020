namespace Szwalnia
{
    partial class Kontrahenci
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
            this.btnOferty = new System.Windows.Forms.Button();
            this.btnDostawcy = new System.Windows.Forms.Button();
            this.btnUmowyKur = new System.Windows.Forms.Button();
            this.btnKurierzy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOferty
            // 
            this.btnOferty.Location = new System.Drawing.Point(71, 12);
            this.btnOferty.Name = "btnOferty";
            this.btnOferty.Size = new System.Drawing.Size(147, 55);
            this.btnOferty.TabIndex = 0;
            this.btnOferty.Text = "Oferty";
            this.btnOferty.UseVisualStyleBackColor = true;
            this.btnOferty.Click += new System.EventHandler(this.btnOferty_Click);
            // 
            // btnDostawcy
            // 
            this.btnDostawcy.Location = new System.Drawing.Point(71, 78);
            this.btnDostawcy.Name = "btnDostawcy";
            this.btnDostawcy.Size = new System.Drawing.Size(147, 55);
            this.btnDostawcy.TabIndex = 1;
            this.btnDostawcy.Text = "Dostawcy";
            this.btnDostawcy.UseVisualStyleBackColor = true;
            this.btnDostawcy.Click += new System.EventHandler(this.btnDostawcy_Click);
            // 
            // btnUmowyKur
            // 
            this.btnUmowyKur.Location = new System.Drawing.Point(71, 148);
            this.btnUmowyKur.Name = "btnUmowyKur";
            this.btnUmowyKur.Size = new System.Drawing.Size(147, 55);
            this.btnUmowyKur.TabIndex = 2;
            this.btnUmowyKur.Text = "Umowy z kurierami";
            this.btnUmowyKur.UseVisualStyleBackColor = true;
            this.btnUmowyKur.Click += new System.EventHandler(this.btnUmowyKur_Click);
            // 
            // btnKurierzy
            // 
            this.btnKurierzy.Location = new System.Drawing.Point(71, 220);
            this.btnKurierzy.Name = "btnKurierzy";
            this.btnKurierzy.Size = new System.Drawing.Size(147, 55);
            this.btnKurierzy.TabIndex = 3;
            this.btnKurierzy.Text = "Kurierzy";
            this.btnKurierzy.UseVisualStyleBackColor = true;
            this.btnKurierzy.Click += new System.EventHandler(this.btnKurierzy_Click);
            // 
            // Kontrahenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 306);
            this.Controls.Add(this.btnKurierzy);
            this.Controls.Add(this.btnUmowyKur);
            this.Controls.Add(this.btnDostawcy);
            this.Controls.Add(this.btnOferty);
            this.Name = "Kontrahenci";
            this.Text = "Kontrahenci";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kontrahenci_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOferty;
        private System.Windows.Forms.Button btnDostawcy;
        private System.Windows.Forms.Button btnUmowyKur;
        private System.Windows.Forms.Button btnKurierzy;
    }
}