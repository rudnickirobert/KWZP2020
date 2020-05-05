namespace Szwalnia
{
    partial class ObslugaZrobione
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
            this.dgvObsluga = new System.Windows.Forms.DataGridView();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtPracownik = new System.Windows.Forms.TextBox();
            this.txtMaszyna = new System.Windows.Forms.TextBox();
            this.txtRodzaj = new System.Windows.Forms.TextBox();
            this.lblDataWykoania = new System.Windows.Forms.Label();
            this.lblPracownik = new System.Windows.Forms.Label();
            this.lblMaszyna = new System.Windows.Forms.Label();
            this.lblRodzaj = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObsluga)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObsluga
            // 
            this.dgvObsluga.AllowUserToAddRows = false;
            this.dgvObsluga.AllowUserToDeleteRows = false;
            this.dgvObsluga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObsluga.Location = new System.Drawing.Point(12, 268);
            this.dgvObsluga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvObsluga.Name = "dgvObsluga";
            this.dgvObsluga.ReadOnly = true;
            this.dgvObsluga.RowHeadersWidth = 51;
            this.dgvObsluga.RowTemplate.Height = 24;
            this.dgvObsluga.Size = new System.Drawing.Size(836, 231);
            this.dgvObsluga.TabIndex = 39;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(126, 222);
            this.txtData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(296, 22);
            this.txtData.TabIndex = 38;
            // 
            // txtPracownik
            // 
            this.txtPracownik.Location = new System.Drawing.Point(126, 193);
            this.txtPracownik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPracownik.Name = "txtPracownik";
            this.txtPracownik.Size = new System.Drawing.Size(296, 22);
            this.txtPracownik.TabIndex = 37;
            // 
            // txtMaszyna
            // 
            this.txtMaszyna.Location = new System.Drawing.Point(126, 158);
            this.txtMaszyna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaszyna.Name = "txtMaszyna";
            this.txtMaszyna.Size = new System.Drawing.Size(296, 22);
            this.txtMaszyna.TabIndex = 36;
            // 
            // txtRodzaj
            // 
            this.txtRodzaj.Location = new System.Drawing.Point(126, 126);
            this.txtRodzaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRodzaj.Name = "txtRodzaj";
            this.txtRodzaj.Size = new System.Drawing.Size(296, 22);
            this.txtRodzaj.TabIndex = 35;
            // 
            // lblDataWykoania
            // 
            this.lblDataWykoania.AutoSize = true;
            this.lblDataWykoania.Location = new System.Drawing.Point(9, 222);
            this.lblDataWykoania.Name = "lblDataWykoania";
            this.lblDataWykoania.Size = new System.Drawing.Size(112, 17);
            this.lblDataWykoania.TabIndex = 34;
            this.lblDataWykoania.Text = "Data Wykonania";
            // 
            // lblPracownik
            // 
            this.lblPracownik.AutoSize = true;
            this.lblPracownik.Location = new System.Drawing.Point(9, 193);
            this.lblPracownik.Name = "lblPracownik";
            this.lblPracownik.Size = new System.Drawing.Size(72, 17);
            this.lblPracownik.TabIndex = 33;
            this.lblPracownik.Text = "Pracownik";
            // 
            // lblMaszyna
            // 
            this.lblMaszyna.AutoSize = true;
            this.lblMaszyna.Location = new System.Drawing.Point(9, 158);
            this.lblMaszyna.Name = "lblMaszyna";
            this.lblMaszyna.Size = new System.Drawing.Size(64, 17);
            this.lblMaszyna.TabIndex = 32;
            this.lblMaszyna.Text = "Maszyna";
            // 
            // lblRodzaj
            // 
            this.lblRodzaj.AutoSize = true;
            this.lblRodzaj.Location = new System.Drawing.Point(9, 126);
            this.lblRodzaj.Name = "lblRodzaj";
            this.lblRodzaj.Size = new System.Drawing.Size(52, 17);
            this.lblRodzaj.TabIndex = 31;
            this.lblRodzaj.Text = "Rodzaj";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(28, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 36);
            this.lblTitle.TabIndex = 30;
            // 
            // ObslugaZrobione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 514);
            this.Controls.Add(this.dgvObsluga);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtPracownik);
            this.Controls.Add(this.txtMaszyna);
            this.Controls.Add(this.txtRodzaj);
            this.Controls.Add(this.lblDataWykoania);
            this.Controls.Add(this.lblPracownik);
            this.Controls.Add(this.lblMaszyna);
            this.Controls.Add(this.lblRodzaj);
            this.Controls.Add(this.lblTitle);
            this.Name = "ObslugaZrobione";
            this.Text = "Obsluga_done";            ((System.ComponentModel.ISupportInitialize)(this.dgvObsluga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObsluga;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtPracownik;
        private System.Windows.Forms.TextBox txtMaszyna;
        private System.Windows.Forms.TextBox txtRodzaj;
        private System.Windows.Forms.Label lblDataWykoania;
        private System.Windows.Forms.Label lblPracownik;
        private System.Windows.Forms.Label lblMaszyna;
        private System.Windows.Forms.Label lblRodzaj;
        private System.Windows.Forms.Label lblTitle;
    }
}