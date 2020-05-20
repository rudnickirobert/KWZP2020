namespace Szwalnia
{
    partial class StanMagazynowyElementy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StanMagazynowyElementy));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStanMagazynowyElementy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanMagazynowyElementy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(59, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Stan magazynowy wg elementów";
            // 
            // dgvStanMagazynowyElementy
            // 
            this.dgvStanMagazynowyElementy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStanMagazynowyElementy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanMagazynowyElementy.Location = new System.Drawing.Point(17, 70);
            this.dgvStanMagazynowyElementy.Name = "dgvStanMagazynowyElementy";
            this.dgvStanMagazynowyElementy.Size = new System.Drawing.Size(485, 255);
            this.dgvStanMagazynowyElementy.TabIndex = 13;
            this.dgvStanMagazynowyElementy.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStanMagazynowyElementy_CellDoubleClick);
            // 
            // StanMagazynowyElementy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStanMagazynowyElementy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StanMagazynowyElementy";
            this.Text = "Stan magazynowy według elementów";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StanMagazynowyElementy_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanMagazynowyElementy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStanMagazynowyElementy;
    }
}