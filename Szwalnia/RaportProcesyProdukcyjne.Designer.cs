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
            this.btnSzukajRozpoczecie = new System.Windows.Forms.Button();
            this.lblRaport = new System.Windows.Forms.Label();
            this.gbProcesy = new System.Windows.Forms.GroupBox();
            this.btnWszystkie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesy)).BeginInit();
            this.gbProcesy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProcesy
            // 
            this.dgvProcesy.AllowUserToAddRows = false;
            this.dgvProcesy.AllowUserToDeleteRows = false;
            this.dgvProcesy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesy.Location = new System.Drawing.Point(69, 242);
            this.dgvProcesy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProcesy.Name = "dgvProcesy";
            this.dgvProcesy.ReadOnly = true;
            this.dgvProcesy.RowHeadersWidth = 51;
            this.dgvProcesy.Size = new System.Drawing.Size(1115, 297);
            this.dgvProcesy.TabIndex = 0;
            // 
            // dtpPierwszaDataRozpoczecia
            // 
            this.dtpPierwszaDataRozpoczecia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpPierwszaDataRozpoczecia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPierwszaDataRozpoczecia.Location = new System.Drawing.Point(334, 34);
            this.dtpPierwszaDataRozpoczecia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpPierwszaDataRozpoczecia.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpPierwszaDataRozpoczecia.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpPierwszaDataRozpoczecia.Name = "dtpPierwszaDataRozpoczecia";
            this.dtpPierwszaDataRozpoczecia.Size = new System.Drawing.Size(143, 24);
            this.dtpPierwszaDataRozpoczecia.TabIndex = 11;
            // 
            // lblPrzedzialRozpoczecie
            // 
            this.lblPrzedzialRozpoczecie.AutoSize = true;
            this.lblPrzedzialRozpoczecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrzedzialRozpoczecie.Location = new System.Drawing.Point(62, 34);
            this.lblPrzedzialRozpoczecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrzedzialRozpoczecie.Name = "lblPrzedzialRozpoczecie";
            this.lblPrzedzialRozpoczecie.Size = new System.Drawing.Size(154, 24);
            this.lblPrzedzialRozpoczecie.TabIndex = 10;
            this.lblPrzedzialRozpoczecie.Text = "Data rozpoczęcia";
            // 
            // dtpDrugaDataRozpoczecia
            // 
            this.dtpDrugaDataRozpoczecia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDrugaDataRozpoczecia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDrugaDataRozpoczecia.Location = new System.Drawing.Point(516, 34);
            this.dtpDrugaDataRozpoczecia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDrugaDataRozpoczecia.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpDrugaDataRozpoczecia.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDrugaDataRozpoczecia.Name = "dtpDrugaDataRozpoczecia";
            this.dtpDrugaDataRozpoczecia.Size = new System.Drawing.Size(143, 24);
            this.dtpDrugaDataRozpoczecia.TabIndex = 12;
            // 
            // dtpPierwszaDataZakonczenia
            // 
            this.dtpPierwszaDataZakonczenia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpPierwszaDataZakonczenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPierwszaDataZakonczenia.Location = new System.Drawing.Point(334, 79);
            this.dtpPierwszaDataZakonczenia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpPierwszaDataZakonczenia.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpPierwszaDataZakonczenia.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpPierwszaDataZakonczenia.Name = "dtpPierwszaDataZakonczenia";
            this.dtpPierwszaDataZakonczenia.Size = new System.Drawing.Size(143, 24);
            this.dtpPierwszaDataZakonczenia.TabIndex = 13;
            // 
            // dtpDrugaDataZakonczenia
            // 
            this.dtpDrugaDataZakonczenia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDrugaDataZakonczenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDrugaDataZakonczenia.Location = new System.Drawing.Point(516, 79);
            this.dtpDrugaDataZakonczenia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDrugaDataZakonczenia.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpDrugaDataZakonczenia.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDrugaDataZakonczenia.Name = "dtpDrugaDataZakonczenia";
            this.dtpDrugaDataZakonczenia.Size = new System.Drawing.Size(143, 24);
            this.dtpDrugaDataZakonczenia.TabIndex = 14;
            // 
            // lblPrzedzialZakonczenie
            // 
            this.lblPrzedzialZakonczenie.AutoSize = true;
            this.lblPrzedzialZakonczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrzedzialZakonczenie.Location = new System.Drawing.Point(62, 81);
            this.lblPrzedzialZakonczenie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrzedzialZakonczenie.Name = "lblPrzedzialZakonczenie";
            this.lblPrzedzialZakonczenie.Size = new System.Drawing.Size(157, 24);
            this.lblPrzedzialZakonczenie.TabIndex = 15;
            this.lblPrzedzialZakonczenie.Text = "Data zakończenia";
            // 
            // lblMyslnikRozpoczecie
            // 
            this.lblMyslnikRozpoczecie.AutoSize = true;
            this.lblMyslnikRozpoczecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMyslnikRozpoczecie.Location = new System.Drawing.Point(490, 37);
            this.lblMyslnikRozpoczecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMyslnikRozpoczecie.Name = "lblMyslnikRozpoczecie";
            this.lblMyslnikRozpoczecie.Size = new System.Drawing.Size(16, 24);
            this.lblMyslnikRozpoczecie.TabIndex = 16;
            this.lblMyslnikRozpoczecie.Text = "-";
            // 
            // lblMyslnikZakonczenie
            // 
            this.lblMyslnikZakonczenie.AutoSize = true;
            this.lblMyslnikZakonczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMyslnikZakonczenie.Location = new System.Drawing.Point(490, 79);
            this.lblMyslnikZakonczenie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMyslnikZakonczenie.Name = "lblMyslnikZakonczenie";
            this.lblMyslnikZakonczenie.Size = new System.Drawing.Size(16, 24);
            this.lblMyslnikZakonczenie.TabIndex = 17;
            this.lblMyslnikZakonczenie.Text = "-";
            // 
            // btnSzukajZakonczenie
            // 
            this.btnSzukajZakonczenie.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnSzukajZakonczenie.Location = new System.Drawing.Point(710, 75);
            this.btnSzukajZakonczenie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSzukajZakonczenie.Name = "btnSzukajZakonczenie";
            this.btnSzukajZakonczenie.Size = new System.Drawing.Size(53, 28);
            this.btnSzukajZakonczenie.TabIndex = 19;
            this.btnSzukajZakonczenie.UseVisualStyleBackColor = true;
            this.btnSzukajZakonczenie.Click += new System.EventHandler(this.btnSzukajZakonczenie_Click);
            // 
            // btnSzukajRozpoczecie
            // 
            this.btnSzukajRozpoczecie.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnSzukajRozpoczecie.Location = new System.Drawing.Point(710, 33);
            this.btnSzukajRozpoczecie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSzukajRozpoczecie.Name = "btnSzukajRozpoczecie";
            this.btnSzukajRozpoczecie.Size = new System.Drawing.Size(53, 28);
            this.btnSzukajRozpoczecie.TabIndex = 18;
            this.btnSzukajRozpoczecie.UseVisualStyleBackColor = true;
            this.btnSzukajRozpoczecie.Click += new System.EventHandler(this.btnSzukajRozpoczecie_Click);
            // 
            // lblRaport
            // 
            this.lblRaport.AutoSize = true;
            this.lblRaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRaport.Location = new System.Drawing.Point(512, 11);
            this.lblRaport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaport.Name = "lblRaport";
            this.lblRaport.Size = new System.Drawing.Size(194, 25);
            this.lblRaport.TabIndex = 21;
            this.lblRaport.Text = "Procesy produkcyjne";
            // 
            // gbProcesy
            // 
            this.gbProcesy.Controls.Add(this.btnWszystkie);
            this.gbProcesy.Controls.Add(this.dtpDrugaDataZakonczenia);
            this.gbProcesy.Controls.Add(this.lblPrzedzialRozpoczecie);
            this.gbProcesy.Controls.Add(this.btnSzukajZakonczenie);
            this.gbProcesy.Controls.Add(this.dtpPierwszaDataRozpoczecia);
            this.gbProcesy.Controls.Add(this.btnSzukajRozpoczecie);
            this.gbProcesy.Controls.Add(this.dtpDrugaDataRozpoczecia);
            this.gbProcesy.Controls.Add(this.lblMyslnikZakonczenie);
            this.gbProcesy.Controls.Add(this.dtpPierwszaDataZakonczenia);
            this.gbProcesy.Controls.Add(this.lblMyslnikRozpoczecie);
            this.gbProcesy.Controls.Add(this.lblPrzedzialZakonczenie);
            this.gbProcesy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbProcesy.Location = new System.Drawing.Point(164, 65);
            this.gbProcesy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbProcesy.Name = "gbProcesy";
            this.gbProcesy.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbProcesy.Size = new System.Drawing.Size(912, 169);
            this.gbProcesy.TabIndex = 22;
            this.gbProcesy.TabStop = false;
            this.gbProcesy.Text = "Przedział";
            // 
            // btnWszystkie
            // 
            this.btnWszystkie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWszystkie.Location = new System.Drawing.Point(66, 124);
            this.btnWszystkie.Margin = new System.Windows.Forms.Padding(4);
            this.btnWszystkie.Name = "btnWszystkie";
            this.btnWszystkie.Size = new System.Drawing.Size(134, 37);
            this.btnWszystkie.TabIndex = 23;
            this.btnWszystkie.Text = "Wszystko";
            this.btnWszystkie.UseVisualStyleBackColor = true;
            this.btnWszystkie.Click += new System.EventHandler(this.btnWszystkie_Click);
            // 
            // RaportProcesyProdukcyjne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1255, 554);
            this.Controls.Add(this.gbProcesy);
            this.Controls.Add(this.lblRaport);
            this.Controls.Add(this.dgvProcesy);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RaportProcesyProdukcyjne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raport procesy produkcyjne";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesy)).EndInit();
            this.gbProcesy.ResumeLayout(false);
            this.gbProcesy.PerformLayout();
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
        private System.Windows.Forms.Button btnSzukajRozpoczecie;
        private System.Windows.Forms.Label lblRaport;
        private System.Windows.Forms.GroupBox gbProcesy;
        private System.Windows.Forms.Button btnWszystkie;
    }
}