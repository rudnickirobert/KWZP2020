namespace Szwalnia
{
    partial class UrlopyPracownikow
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvUrlopy = new System.Windows.Forms.DataGridView();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.dtpPierwszaDataRozpoczecia = new System.Windows.Forms.DateTimePicker();
            this.dtpDrugaDataRozpoczecia = new System.Windows.Forms.DateTimePicker();
            this.dtpPierwszaDataZakonczenia = new System.Windows.Forms.DateTimePicker();
            this.dtpDrugaDataZakonczenia = new System.Windows.Forms.DateTimePicker();
            this.btnSzukaj2 = new System.Windows.Forms.Button();
            this.btnWszystkie = new System.Windows.Forms.Button();
            this.lblPrzedzialRozpoczecie = new System.Windows.Forms.Label();
            this.lblPrzedzialZakonczenie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrlopy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(582, 21);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(99, 45);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvUrlopy
            // 
            this.dgvUrlopy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrlopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrlopy.Location = new System.Drawing.Point(12, 266);
            this.dgvUrlopy.Name = "dgvUrlopy";
            this.dgvUrlopy.RowHeadersWidth = 51;
            this.dgvUrlopy.RowTemplate.Height = 24;
            this.dgvUrlopy.Size = new System.Drawing.Size(776, 352);
            this.dgvUrlopy.TabIndex = 1;
            // 
            // btnZamknij
            // 
            this.btnZamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZamknij.Location = new System.Drawing.Point(687, 21);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(101, 45);
            this.btnZamknij.TabIndex = 2;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(156, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Urlopy Pracowników";
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukaj.Location = new System.Drawing.Point(498, 122);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(99, 31);
            this.btnSzukaj.TabIndex = 4;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // dtpPierwszaDataRozpoczecia
            // 
            this.dtpPierwszaDataRozpoczecia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpPierwszaDataRozpoczecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpPierwszaDataRozpoczecia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPierwszaDataRozpoczecia.Location = new System.Drawing.Point(100, 124);
            this.dtpPierwszaDataRozpoczecia.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPierwszaDataRozpoczecia.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpPierwszaDataRozpoczecia.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpPierwszaDataRozpoczecia.Name = "dtpPierwszaDataRozpoczecia";
            this.dtpPierwszaDataRozpoczecia.Size = new System.Drawing.Size(143, 30);
            this.dtpPierwszaDataRozpoczecia.TabIndex = 12;
            // 
            // dtpDrugaDataRozpoczecia
            // 
            this.dtpDrugaDataRozpoczecia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDrugaDataRozpoczecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDrugaDataRozpoczecia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDrugaDataRozpoczecia.Location = new System.Drawing.Point(296, 124);
            this.dtpDrugaDataRozpoczecia.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDrugaDataRozpoczecia.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpDrugaDataRozpoczecia.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDrugaDataRozpoczecia.Name = "dtpDrugaDataRozpoczecia";
            this.dtpDrugaDataRozpoczecia.Size = new System.Drawing.Size(143, 30);
            this.dtpDrugaDataRozpoczecia.TabIndex = 13;
            // 
            // dtpPierwszaDataZakonczenia
            // 
            this.dtpPierwszaDataZakonczenia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpPierwszaDataZakonczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpPierwszaDataZakonczenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPierwszaDataZakonczenia.Location = new System.Drawing.Point(100, 186);
            this.dtpPierwszaDataZakonczenia.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPierwszaDataZakonczenia.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpPierwszaDataZakonczenia.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpPierwszaDataZakonczenia.Name = "dtpPierwszaDataZakonczenia";
            this.dtpPierwszaDataZakonczenia.Size = new System.Drawing.Size(143, 30);
            this.dtpPierwszaDataZakonczenia.TabIndex = 14;
            // 
            // dtpDrugaDataZakonczenia
            // 
            this.dtpDrugaDataZakonczenia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDrugaDataZakonczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDrugaDataZakonczenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDrugaDataZakonczenia.Location = new System.Drawing.Point(296, 186);
            this.dtpDrugaDataZakonczenia.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDrugaDataZakonczenia.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpDrugaDataZakonczenia.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDrugaDataZakonczenia.Name = "dtpDrugaDataZakonczenia";
            this.dtpDrugaDataZakonczenia.Size = new System.Drawing.Size(143, 30);
            this.dtpDrugaDataZakonczenia.TabIndex = 15;
            // 
            // btnSzukaj2
            // 
            this.btnSzukaj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukaj2.Location = new System.Drawing.Point(498, 184);
            this.btnSzukaj2.Name = "btnSzukaj2";
            this.btnSzukaj2.Size = new System.Drawing.Size(99, 31);
            this.btnSzukaj2.TabIndex = 16;
            this.btnSzukaj2.Text = "Szukaj";
            this.btnSzukaj2.UseVisualStyleBackColor = true;
            this.btnSzukaj2.Click += new System.EventHandler(this.btnSzukaj2_Click);
            // 
            // btnWszystkie
            // 
            this.btnWszystkie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWszystkie.Location = new System.Drawing.Point(625, 149);
            this.btnWszystkie.Margin = new System.Windows.Forms.Padding(4);
            this.btnWszystkie.Name = "btnWszystkie";
            this.btnWszystkie.Size = new System.Drawing.Size(134, 37);
            this.btnWszystkie.TabIndex = 24;
            this.btnWszystkie.Text = "Wszystkie urlopy";
            this.btnWszystkie.UseVisualStyleBackColor = true;
            this.btnWszystkie.Click += new System.EventHandler(this.btnWszystkie_Click);
            // 
            // lblPrzedzialRozpoczecie
            // 
            this.lblPrzedzialRozpoczecie.AutoSize = true;
            this.lblPrzedzialRozpoczecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrzedzialRozpoczecie.Location = new System.Drawing.Point(8, 96);
            this.lblPrzedzialRozpoczecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrzedzialRozpoczecie.Name = "lblPrzedzialRozpoczecie";
            this.lblPrzedzialRozpoczecie.Size = new System.Drawing.Size(154, 24);
            this.lblPrzedzialRozpoczecie.TabIndex = 25;
            this.lblPrzedzialRozpoczecie.Text = "Data rozpoczęcia";
            // 
            // lblPrzedzialZakonczenie
            // 
            this.lblPrzedzialZakonczenie.AutoSize = true;
            this.lblPrzedzialZakonczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrzedzialZakonczenie.Location = new System.Drawing.Point(5, 162);
            this.lblPrzedzialZakonczenie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrzedzialZakonczenie.Name = "lblPrzedzialZakonczenie";
            this.lblPrzedzialZakonczenie.Size = new System.Drawing.Size(157, 24);
            this.lblPrzedzialZakonczenie.TabIndex = 26;
            this.lblPrzedzialZakonczenie.Text = "Data zakończenia";
            // 
            // UrlopyPracownikow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.lblPrzedzialZakonczenie);
            this.Controls.Add(this.lblPrzedzialRozpoczecie);
            this.Controls.Add(this.btnWszystkie);
            this.Controls.Add(this.btnSzukaj2);
            this.Controls.Add(this.dtpDrugaDataZakonczenia);
            this.Controls.Add(this.dtpPierwszaDataZakonczenia);
            this.Controls.Add(this.dtpDrugaDataRozpoczecia);
            this.Controls.Add(this.dtpPierwszaDataRozpoczecia);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.dgvUrlopy);
            this.Controls.Add(this.btnDodaj);
            this.Name = "UrlopyPracownikow";
            this.Text = "Urlopy pracowników";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrlopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvUrlopy;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.DateTimePicker dtpPierwszaDataRozpoczecia;
        private System.Windows.Forms.DateTimePicker dtpDrugaDataRozpoczecia;
        private System.Windows.Forms.DateTimePicker dtpPierwszaDataZakonczenia;
        private System.Windows.Forms.DateTimePicker dtpDrugaDataZakonczenia;
        private System.Windows.Forms.Button btnSzukaj2;
        private System.Windows.Forms.Button btnWszystkie;
        private System.Windows.Forms.Label lblPrzedzialRozpoczecie;
        private System.Windows.Forms.Label lblPrzedzialZakonczenie;
    }
}