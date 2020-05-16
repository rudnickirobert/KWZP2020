namespace Szwalnia
{
    partial class RaportProcesyProdukcyjne
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
            this.dgvProcesy = new System.Windows.Forms.DataGridView();
            this.dtpPierwszaDataRozpoczecia = new System.Windows.Forms.DateTimePicker();
            this.lblPrzedzialRozpoczecie = new System.Windows.Forms.Label();
            this.dtpDrugaDataRozpoczecia = new System.Windows.Forms.DateTimePicker();
            this.dtpPierwszaDataZakonczenia = new System.Windows.Forms.DateTimePicker();
            this.dtpDrugaDataZakonczenia = new System.Windows.Forms.DateTimePicker();
            this.lblPrzedzialZakonczenie = new System.Windows.Forms.Label();
            this.lblMyslnikRozpoczecie = new System.Windows.Forms.Label();
            this.lblMyslnikZakonczenie = new System.Windows.Forms.Label();
            this.btnSzukajZakonczenie = new System.Windows.Forms.Button();
            this.lblOpis = new System.Windows.Forms.Label();
            this.btnSzukajRozpoczecie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProcesy
            // 
            this.dgvProcesy.AllowUserToAddRows = false;
            this.dgvProcesy.AllowUserToDeleteRows = false;
            this.dgvProcesy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesy.Location = new System.Drawing.Point(52, 182);
            this.dgvProcesy.Name = "dgvProcesy";
            this.dgvProcesy.ReadOnly = true;
            this.dgvProcesy.Size = new System.Drawing.Size(707, 241);
            this.dgvProcesy.TabIndex = 0;
            // 
            // dtpPierwszaDataRozpoczecia
            // 
            this.dtpPierwszaDataRozpoczecia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpPierwszaDataRozpoczecia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPierwszaDataRozpoczecia.Location = new System.Drawing.Point(303, 79);
            this.dtpPierwszaDataRozpoczecia.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpPierwszaDataRozpoczecia.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpPierwszaDataRozpoczecia.Name = "dtpPierwszaDataRozpoczecia";
            this.dtpPierwszaDataRozpoczecia.Size = new System.Drawing.Size(108, 20);
            this.dtpPierwszaDataRozpoczecia.TabIndex = 11;
            // 
            // lblPrzedzialRozpoczecie
            // 
            this.lblPrzedzialRozpoczecie.AutoSize = true;
            this.lblPrzedzialRozpoczecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrzedzialRozpoczecie.Location = new System.Drawing.Point(99, 79);
            this.lblPrzedzialRozpoczecie.Name = "lblPrzedzialRozpoczecie";
            this.lblPrzedzialRozpoczecie.Size = new System.Drawing.Size(125, 18);
            this.lblPrzedzialRozpoczecie.TabIndex = 10;
            this.lblPrzedzialRozpoczecie.Text = "Data rozpoczęcia";
            // 
            // dtpDrugaDataRozpoczecia
            // 
            this.dtpDrugaDataRozpoczecia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDrugaDataRozpoczecia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDrugaDataRozpoczecia.Location = new System.Drawing.Point(439, 79);
            this.dtpDrugaDataRozpoczecia.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpDrugaDataRozpoczecia.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDrugaDataRozpoczecia.Name = "dtpDrugaDataRozpoczecia";
            this.dtpDrugaDataRozpoczecia.Size = new System.Drawing.Size(108, 20);
            this.dtpDrugaDataRozpoczecia.TabIndex = 12;
            // 
            // dtpPierwszaDataZakonczenia
            // 
            this.dtpPierwszaDataZakonczenia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpPierwszaDataZakonczenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPierwszaDataZakonczenia.Location = new System.Drawing.Point(303, 115);
            this.dtpPierwszaDataZakonczenia.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpPierwszaDataZakonczenia.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpPierwszaDataZakonczenia.Name = "dtpPierwszaDataZakonczenia";
            this.dtpPierwszaDataZakonczenia.Size = new System.Drawing.Size(108, 20);
            this.dtpPierwszaDataZakonczenia.TabIndex = 13;
            // 
            // dtpDrugaDataZakonczenia
            // 
            this.dtpDrugaDataZakonczenia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDrugaDataZakonczenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDrugaDataZakonczenia.Location = new System.Drawing.Point(439, 115);
            this.dtpDrugaDataZakonczenia.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpDrugaDataZakonczenia.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDrugaDataZakonczenia.Name = "dtpDrugaDataZakonczenia";
            this.dtpDrugaDataZakonczenia.Size = new System.Drawing.Size(108, 20);
            this.dtpDrugaDataZakonczenia.TabIndex = 14;
            // 
            // lblPrzedzialZakonczenie
            // 
            this.lblPrzedzialZakonczenie.AutoSize = true;
            this.lblPrzedzialZakonczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrzedzialZakonczenie.Location = new System.Drawing.Point(99, 117);
            this.lblPrzedzialZakonczenie.Name = "lblPrzedzialZakonczenie";
            this.lblPrzedzialZakonczenie.Size = new System.Drawing.Size(127, 18);
            this.lblPrzedzialZakonczenie.TabIndex = 15;
            this.lblPrzedzialZakonczenie.Text = "Data zakończenia";
            // 
            // lblMyslnikRozpoczecie
            // 
            this.lblMyslnikRozpoczecie.AutoSize = true;
            this.lblMyslnikRozpoczecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMyslnikRozpoczecie.Location = new System.Drawing.Point(420, 81);
            this.lblMyslnikRozpoczecie.Name = "lblMyslnikRozpoczecie";
            this.lblMyslnikRozpoczecie.Size = new System.Drawing.Size(13, 18);
            this.lblMyslnikRozpoczecie.TabIndex = 16;
            this.lblMyslnikRozpoczecie.Text = "-";
            // 
            // lblMyslnikZakonczenie
            // 
            this.lblMyslnikZakonczenie.AutoSize = true;
            this.lblMyslnikZakonczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMyslnikZakonczenie.Location = new System.Drawing.Point(420, 115);
            this.lblMyslnikZakonczenie.Name = "lblMyslnikZakonczenie";
            this.lblMyslnikZakonczenie.Size = new System.Drawing.Size(13, 18);
            this.lblMyslnikZakonczenie.TabIndex = 17;
            this.lblMyslnikZakonczenie.Text = "-";
            // 
            // btnSzukajZakonczenie
            // 
            this.btnSzukajZakonczenie.Location = new System.Drawing.Point(585, 112);
            this.btnSzukajZakonczenie.Name = "btnSzukajZakonczenie";
            this.btnSzukajZakonczenie.Size = new System.Drawing.Size(75, 23);
            this.btnSzukajZakonczenie.TabIndex = 19;
            this.btnSzukajZakonczenie.Text = "szukaj";
            this.btnSzukajZakonczenie.UseVisualStyleBackColor = true;
            this.btnSzukajZakonczenie.Click += new System.EventHandler(this.btnSzukajZakonczenie_Click);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(310, 31);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(164, 20);
            this.lblOpis.TabIndex = 20;
            this.lblOpis.Text = "Wybierz przedział dat:";
            // 
            // btnSzukajRozpoczecie
            // 
            this.btnSzukajRozpoczecie.Location = new System.Drawing.Point(585, 78);
            this.btnSzukajRozpoczecie.Name = "btnSzukajRozpoczecie";
            this.btnSzukajRozpoczecie.Size = new System.Drawing.Size(75, 23);
            this.btnSzukajRozpoczecie.TabIndex = 18;
            this.btnSzukajRozpoczecie.Text = "szukaj";
            this.btnSzukajRozpoczecie.UseVisualStyleBackColor = true;
            this.btnSzukajRozpoczecie.Click += new System.EventHandler(this.btnSzukajRozpoczecie_Click);
            // 
            // RaportProcesyProdukcyjne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.btnSzukajZakonczenie);
            this.Controls.Add(this.btnSzukajRozpoczecie);
            this.Controls.Add(this.lblMyslnikZakonczenie);
            this.Controls.Add(this.lblMyslnikRozpoczecie);
            this.Controls.Add(this.lblPrzedzialZakonczenie);
            this.Controls.Add(this.dtpDrugaDataZakonczenia);
            this.Controls.Add(this.dtpPierwszaDataZakonczenia);
            this.Controls.Add(this.dtpDrugaDataRozpoczecia);
            this.Controls.Add(this.dtpPierwszaDataRozpoczecia);
            this.Controls.Add(this.lblPrzedzialRozpoczecie);
            this.Controls.Add(this.dgvProcesy);
            this.Name = "RaportProcesyProdukcyjne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raport procesy produkcyjne";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcesy;
        private System.Windows.Forms.DateTimePicker dtpPierwszaDataRozpoczecia;
        private System.Windows.Forms.Label lblPrzedzialRozpoczecie;
        private System.Windows.Forms.DateTimePicker dtpDrugaDataRozpoczecia;
        private System.Windows.Forms.DateTimePicker dtpPierwszaDataZakonczenia;
        private System.Windows.Forms.DateTimePicker dtpDrugaDataZakonczenia;
        private System.Windows.Forms.Label lblPrzedzialZakonczenie;
        private System.Windows.Forms.Label lblMyslnikRozpoczecie;
        private System.Windows.Forms.Label lblMyslnikZakonczenie;
        private System.Windows.Forms.Button btnSzukajZakonczenie;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button btnSzukajRozpoczecie;
    }
}