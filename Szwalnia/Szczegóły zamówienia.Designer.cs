namespace Szwalnia
{
    partial class SzczegolyZamowienia
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
            this.lblOpis = new System.Windows.Forms.Label();
            this.btnZamknij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegoly)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSzczegoly
            // 
            this.dgvSzczegoly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzczegoly.Location = new System.Drawing.Point(12, 99);
            this.dgvSzczegoly.Name = "dgvSzczegoly";
            this.dgvSzczegoly.RowHeadersWidth = 51;
            this.dgvSzczegoly.RowTemplate.Height = 24;
            this.dgvSzczegoly.Size = new System.Drawing.Size(776, 339);
            this.dgvSzczegoly.TabIndex = 0;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(12, 44);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(93, 32);
            this.lblOpis.TabIndex = 1;
            this.lblOpis.Text = "label1";
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(687, 31);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(101, 45);
            this.btnZamknij.TabIndex = 3;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // SzczegolyZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.dgvSzczegoly);
            this.Name = "SzczegolyZamowienia";
            this.Text = "Szczegóły zamówienia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegoly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSzczegoly;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button btnZamknij;
    }
}