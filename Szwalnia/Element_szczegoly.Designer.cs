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
            // Element_szczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSzczegoly);
            this.Name = "Element_szczegoly";
            this.Text = "Okno szczegolow elementow";
            this.Load += new System.EventHandler(this.Element_szczegoly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegoly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSzczegoly;
    }
}