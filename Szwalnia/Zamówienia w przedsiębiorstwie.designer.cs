namespace Szwalnia
{
    partial class ZamówieniaWPrzedsiębiorstwie
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
            this.dgvZamowienia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZamknij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZamowienia
            // 
            this.dgvZamowienia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienia.Location = new System.Drawing.Point(22, 97);
            this.dgvZamowienia.Name = "dgvZamowienia";
            this.dgvZamowienia.RowHeadersWidth = 51;
            this.dgvZamowienia.RowTemplate.Height = 24;
            this.dgvZamowienia.Size = new System.Drawing.Size(1472, 331);
            this.dgvZamowienia.TabIndex = 0;
            this.dgvZamowienia.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvZamowienia_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(565, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zamówienia w przedsiębiorstwie";
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(1393, 31);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(101, 45);
            this.btnZamknij.TabIndex = 2;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // ZamówieniaWPrzedsiębiorstwie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1501, 450);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvZamowienia);
            this.Name = "ZamówieniaWPrzedsiębiorstwie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamówienia w przedsiębiorstwie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZamowienia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZamknij;
    }
}