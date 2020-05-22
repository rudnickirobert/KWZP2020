namespace Szwalnia
{
    partial class FaktoryWystawiane
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
            this.dgvFakturyWystawione = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFakturyWystawione)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFakturyWystawione
            // 
            this.dgvFakturyWystawione.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFakturyWystawione.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFakturyWystawione.Location = new System.Drawing.Point(11, 94);
            this.dgvFakturyWystawione.Name = "dgvFakturyWystawione";
            this.dgvFakturyWystawione.RowHeadersWidth = 51;
            this.dgvFakturyWystawione.RowTemplate.Height = 24;
            this.dgvFakturyWystawione.Size = new System.Drawing.Size(1119, 265);
            this.dgvFakturyWystawione.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(380, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 32);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Faktury wystawione klientom";
            // 
            // FaktoryWystawiane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1142, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvFakturyWystawione);
            this.Name = "FaktoryWystawiane";
            this.Text = "Faktury wystawiane";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFakturyWystawione)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFakturyWystawione;
        private System.Windows.Forms.Label lblTitle;
    }
}