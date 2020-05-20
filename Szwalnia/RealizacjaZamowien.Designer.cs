namespace Szwalnia
{
    partial class RealizacjaZamowien
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
            this.btnNext = new System.Windows.Forms.Button();
            this.dgvDostarczenia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCzyDostepne = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostarczenia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(608, 251);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Dalej";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // dgvDostarczenia
            // 
            this.dgvDostarczenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDostarczenia.Location = new System.Drawing.Point(12, 77);
            this.dgvDostarczenia.Name = "dgvDostarczenia";
            this.dgvDostarczenia.Size = new System.Drawing.Size(748, 150);
            this.dgvDostarczenia.TabIndex = 1;
            this.dgvDostarczenia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDostarczenia_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Które zamówienie chcesz zrealizować?";
            // 
            // lblCzyDostepne
            // 
            this.lblCzyDostepne.AutoSize = true;
            this.lblCzyDostepne.Location = new System.Drawing.Point(156, 256);
            this.lblCzyDostepne.Name = "lblCzyDostepne";
            this.lblCzyDostepne.Size = new System.Drawing.Size(0, 13);
            this.lblCzyDostepne.TabIndex = 3;
            // 
            // RealizacjaZamowien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCzyDostepne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDostarczenia);
            this.Controls.Add(this.btnNext);
            this.Name = "RealizacjaZamowien";
            this.Text = "Wybó zamówienia do realizacji";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RealizacjaZamowien_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostarczenia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgvDostarczenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCzyDostepne;
    }
}