namespace Szwalnia
{
    partial class PrzypiszPracownikaKuriera
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
            this.cmbPracownicy = new System.Windows.Forms.ComboBox();
            this.dgvKurierzy = new System.Windows.Forms.DataGridView();
            this.lblPracownikDane = new System.Windows.Forms.Label();
            this.lblKurierzyDane = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurierzy)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPracownicy
            // 
            this.cmbPracownicy.FormattingEnabled = true;
            this.cmbPracownicy.Location = new System.Drawing.Point(403, 42);
            this.cmbPracownicy.Name = "cmbPracownicy";
            this.cmbPracownicy.Size = new System.Drawing.Size(169, 21);
            this.cmbPracownicy.TabIndex = 0;
            // 
            // dgvKurierzy
            // 
            this.dgvKurierzy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKurierzy.Location = new System.Drawing.Point(10, 114);
            this.dgvKurierzy.Name = "dgvKurierzy";
            this.dgvKurierzy.Size = new System.Drawing.Size(778, 324);
            this.dgvKurierzy.TabIndex = 1;
            // 
            // lblPracownikDane
            // 
            this.lblPracownikDane.Location = new System.Drawing.Point(268, 42);
            this.lblPracownikDane.Name = "lblPracownikDane";
            this.lblPracownikDane.Size = new System.Drawing.Size(129, 23);
            this.lblPracownikDane.TabIndex = 2;
            this.lblPracownikDane.Text = "Wybierz pracownika";
            this.lblPracownikDane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKurierzyDane
            // 
            this.lblKurierzyDane.Location = new System.Drawing.Point(7, 88);
            this.lblKurierzyDane.Name = "lblKurierzyDane";
            this.lblKurierzyDane.Size = new System.Drawing.Size(781, 23);
            this.lblKurierzyDane.TabIndex = 2;
            this.lblKurierzyDane.Text = "Wybierz z poniższej listy kuriera za pomocą dwukrotnego kliknięcia w komórkę";
            this.lblKurierzyDane.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(776, 23);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Wybierz pracownika obsługującego zamówienie oraz wybierz kuriera dostarczającego " +
    "zamówienie";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrzypiszPracownikaKuriera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKurierzyDane);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPracownikDane);
            this.Controls.Add(this.dgvKurierzy);
            this.Controls.Add(this.cmbPracownicy);
            this.Name = "PrzypiszPracownikaKuriera";
            this.Text = "PrzypiszPracownikaKuriera";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurierzy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPracownicy;
        private System.Windows.Forms.DataGridView dgvKurierzy;
        private System.Windows.Forms.Label lblPracownikDane;
        private System.Windows.Forms.Label lblKurierzyDane;
        private System.Windows.Forms.Label lblInfo;
    }
}