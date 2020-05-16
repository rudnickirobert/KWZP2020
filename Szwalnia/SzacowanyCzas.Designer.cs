namespace Szwalnia
{
    partial class SzacowanyCzas
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
            this.txtSzacowanaData = new System.Windows.Forms.TextBox();
            this.cmbNazwaProduktu = new System.Windows.Forms.ComboBox();
            this.btnObliczDate = new System.Windows.Forms.Button();
            this.numLiczbaSztuk = new System.Windows.Forms.NumericUpDown();
            this.lblOpis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numLiczbaSztuk)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSzacowanaData
            // 
            this.txtSzacowanaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSzacowanaData.Location = new System.Drawing.Point(101, 228);
            this.txtSzacowanaData.Margin = new System.Windows.Forms.Padding(2);
            this.txtSzacowanaData.Name = "txtSzacowanaData";
            this.txtSzacowanaData.ReadOnly = true;
            this.txtSzacowanaData.Size = new System.Drawing.Size(175, 24);
            this.txtSzacowanaData.TabIndex = 0;
            // 
            // cmbNazwaProduktu
            // 
            this.cmbNazwaProduktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbNazwaProduktu.FormattingEnabled = true;
            this.cmbNazwaProduktu.Location = new System.Drawing.Point(101, 75);
            this.cmbNazwaProduktu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNazwaProduktu.Name = "cmbNazwaProduktu";
            this.cmbNazwaProduktu.Size = new System.Drawing.Size(175, 26);
            this.cmbNazwaProduktu.TabIndex = 1;
            // 
            // btnObliczDate
            // 
            this.btnObliczDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObliczDate.Location = new System.Drawing.Point(145, 173);
            this.btnObliczDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnObliczDate.Name = "btnObliczDate";
            this.btnObliczDate.Size = new System.Drawing.Size(85, 29);
            this.btnObliczDate.TabIndex = 3;
            this.btnObliczDate.Text = "Oblicz";
            this.btnObliczDate.UseVisualStyleBackColor = true;
            this.btnObliczDate.Click += new System.EventHandler(this.btnObliczDate_Click);
            // 
            // numLiczbaSztuk
            // 
            this.numLiczbaSztuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numLiczbaSztuk.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numLiczbaSztuk.Location = new System.Drawing.Point(101, 118);
            this.numLiczbaSztuk.Margin = new System.Windows.Forms.Padding(2);
            this.numLiczbaSztuk.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numLiczbaSztuk.Name = "numLiczbaSztuk";
            this.numLiczbaSztuk.Size = new System.Drawing.Size(175, 24);
            this.numLiczbaSztuk.TabIndex = 4;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(12, 21);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(344, 18);
            this.lblOpis.TabIndex = 5;
            this.lblOpis.Text = "Szacowany czas wykonania produktu wg produkcji";
            // 
            // SzacowanyCzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 292);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.numLiczbaSztuk);
            this.Controls.Add(this.btnObliczDate);
            this.Controls.Add(this.cmbNazwaProduktu);
            this.Controls.Add(this.txtSzacowanaData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SzacowanyCzas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szacowany czas produkcji";
            ((System.ComponentModel.ISupportInitialize)(this.numLiczbaSztuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSzacowanaData;
        private System.Windows.Forms.ComboBox cmbNazwaProduktu;
        private System.Windows.Forms.Button btnObliczDate;
        private System.Windows.Forms.NumericUpDown numLiczbaSztuk;
        private System.Windows.Forms.Label lblOpis;
    }
}