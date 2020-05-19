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
            this.cmbZamowienia = new System.Windows.Forms.ComboBox();
            this.lblWybierzZamowienia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurierzy)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPracownicy
            // 
            this.cmbPracownicy.FormattingEnabled = true;
            this.cmbPracownicy.Location = new System.Drawing.Point(342, 62);
            this.cmbPracownicy.Name = "cmbPracownicy";
            this.cmbPracownicy.Size = new System.Drawing.Size(234, 21);
            this.cmbPracownicy.TabIndex = 0;
            // 
            // dgvKurierzy
            // 
            this.dgvKurierzy.AllowUserToAddRows = false;
            this.dgvKurierzy.AllowUserToDeleteRows = false;
            this.dgvKurierzy.AllowUserToResizeColumns = false;
            this.dgvKurierzy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKurierzy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKurierzy.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvKurierzy.Location = new System.Drawing.Point(12, 121);
            this.dgvKurierzy.Name = "dgvKurierzy";
            this.dgvKurierzy.Size = new System.Drawing.Size(778, 324);
            this.dgvKurierzy.TabIndex = 1;
            this.dgvKurierzy.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKurierzy_CellDoubleClick);
            // 
            // lblPracownikDane
            // 
            this.lblPracownikDane.Location = new System.Drawing.Point(207, 60);
            this.lblPracownikDane.Name = "lblPracownikDane";
            this.lblPracownikDane.Size = new System.Drawing.Size(129, 23);
            this.lblPracownikDane.TabIndex = 2;
            this.lblPracownikDane.Text = "Wybierz pracownika";
            this.lblPracownikDane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKurierzyDane
            // 
            this.lblKurierzyDane.Location = new System.Drawing.Point(12, 95);
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
            // cmbZamowienia
            // 
            this.cmbZamowienia.FormattingEnabled = true;
            this.cmbZamowienia.Location = new System.Drawing.Point(342, 34);
            this.cmbZamowienia.Name = "cmbZamowienia";
            this.cmbZamowienia.Size = new System.Drawing.Size(234, 21);
            this.cmbZamowienia.TabIndex = 0;
            this.cmbZamowienia.SelectedIndexChanged += new System.EventHandler(this.cmbZamowienia_SelectedIndexChanged);
            // 
            // lblWybierzZamowienia
            // 
            this.lblWybierzZamowienia.Location = new System.Drawing.Point(207, 32);
            this.lblWybierzZamowienia.Name = "lblWybierzZamowienia";
            this.lblWybierzZamowienia.Size = new System.Drawing.Size(129, 23);
            this.lblWybierzZamowienia.TabIndex = 2;
            this.lblWybierzZamowienia.Text = "Wybierz zamówienie";
            this.lblWybierzZamowienia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrzypiszPracownikaKuriera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.lblKurierzyDane);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblWybierzZamowienia);
            this.Controls.Add(this.lblPracownikDane);
            this.Controls.Add(this.dgvKurierzy);
            this.Controls.Add(this.cmbZamowienia);
            this.Controls.Add(this.cmbPracownicy);
            this.Name = "PrzypiszPracownikaKuriera";
            this.Text = "PrzypiszPracownikaKuriera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrzypiszPracownikaKuriera_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrzypiszPracownikaKuriera_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurierzy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPracownicy;
        private System.Windows.Forms.DataGridView dgvKurierzy;
        private System.Windows.Forms.Label lblPracownikDane;
        private System.Windows.Forms.Label lblKurierzyDane;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cmbZamowienia;
        private System.Windows.Forms.Label lblWybierzZamowienia;
    }
}