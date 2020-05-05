namespace Szwalnia
{
    partial class Szczegoly
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvPrzydzialZasobow = new System.Windows.Forms.DataGridView();
            this.lblTytul = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzydzialZasobow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(367, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 17);
            this.lblTitle.TabIndex = 0;
            // 
            // dgvPrzydzialZasobow
            // 
            this.dgvPrzydzialZasobow.AllowUserToAddRows = false;
            this.dgvPrzydzialZasobow.AllowUserToDeleteRows = false;
            this.dgvPrzydzialZasobow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrzydzialZasobow.Location = new System.Drawing.Point(12, 76);
            this.dgvPrzydzialZasobow.Name = "dgvPrzydzialZasobow";
            this.dgvPrzydzialZasobow.ReadOnly = true;
            this.dgvPrzydzialZasobow.RowHeadersWidth = 51;
            this.dgvPrzydzialZasobow.RowTemplate.Height = 24;
            this.dgvPrzydzialZasobow.Size = new System.Drawing.Size(1087, 399);
            this.dgvPrzydzialZasobow.TabIndex = 13;
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTytul.Location = new System.Drawing.Point(448, 9);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(193, 25);
            this.lblTytul.TabIndex = 14;
            this.lblTytul.Text = "Przydział Zasobów";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Szczegóły dla ID Procesu Produkcyjnego:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblId.Location = new System.Drawing.Point(420, 41);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 25);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "Id";
            // 
            // Szczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1111, 516);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTytul);
            this.Controls.Add(this.dgvPrzydzialZasobow);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Szczegoly";
            this.Text = "Szczegoly";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzydzialZasobow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvPrzydzialZasobow;
        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
    }
}