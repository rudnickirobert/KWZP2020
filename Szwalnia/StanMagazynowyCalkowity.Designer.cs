namespace Szwalnia
{
    partial class StanMagazynowyCalkowity
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
            this.dgvStanMagazynowyCalosciowy = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanMagazynowyCalosciowy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStanMagazynowyCalosciowy
            // 
            this.dgvStanMagazynowyCalosciowy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStanMagazynowyCalosciowy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanMagazynowyCalosciowy.Location = new System.Drawing.Point(12, 81);
            this.dgvStanMagazynowyCalosciowy.Name = "dgvStanMagazynowyCalosciowy";
            this.dgvStanMagazynowyCalosciowy.Size = new System.Drawing.Size(855, 255);
            this.dgvStanMagazynowyCalosciowy.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(264, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Stan magazynowy całkowity";
            // 
            // StanMagazynowyCalkowity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStanMagazynowyCalosciowy);
            this.Name = "StanMagazynowyCalkowity";
            this.Text = "Stan magazynowy całkowity";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanMagazynowyCalosciowy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStanMagazynowyCalosciowy;
        private System.Windows.Forms.Label label1;
    }
}