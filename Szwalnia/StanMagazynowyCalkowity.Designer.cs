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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StanMagazynowyCalkowity));
            this.dgvStanMagazynowyCalosciowy = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanMagazynowyCalosciowy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStanMagazynowyCalosciowy
            // 
            this.dgvStanMagazynowyCalosciowy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStanMagazynowyCalosciowy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanMagazynowyCalosciowy.Location = new System.Drawing.Point(12, 75);
            this.dgvStanMagazynowyCalosciowy.Name = "dgvStanMagazynowyCalosciowy";
            this.dgvStanMagazynowyCalosciowy.Size = new System.Drawing.Size(837, 326);
            this.dgvStanMagazynowyCalosciowy.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(837, 44);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Stan magazynowy całkowity";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StanMagazynowyCalkowity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 413);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvStanMagazynowyCalosciowy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StanMagazynowyCalkowity";
            this.Text = "Stan magazynowy całkowity";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StanMagazynowyCalkowity_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanMagazynowyCalosciowy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStanMagazynowyCalosciowy;
        private System.Windows.Forms.Label lblTitle;
    }
}