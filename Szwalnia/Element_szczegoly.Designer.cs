namespace Szwalnia
{
    partial class Element_szczegoly
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
            this.dgvSzczegoly = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblElement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegoly)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSzczegoly
            // 
            this.dgvSzczegoly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzczegoly.Location = new System.Drawing.Point(12, 137);
            this.dgvSzczegoly.Name = "dgvSzczegoly";
            this.dgvSzczegoly.Size = new System.Drawing.Size(776, 301);
            this.dgvSzczegoly.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblElement.Location = new System.Drawing.Point(13, 13);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(86, 31);
            this.lblElement.TabIndex = 3;
            this.lblElement.Text = "label1";
            // 
            // Element_szczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblElement);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvSzczegoly);
            this.Name = "Element_szczegoly";
            this.Text = "Okno szczegolow elementow";
            this.Load += new System.EventHandler(this.Element_szczegoly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegoly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSzczegoly;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblElement;
    }
}