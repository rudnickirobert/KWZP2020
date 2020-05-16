namespace Szwalnia
{
    partial class NowaRealizacjaProcesu
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
            this.lblOpis = new System.Windows.Forms.Label();
            this.cbxEtap = new System.Windows.Forms.ComboBox();
            this.btnWyzeruj = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.mtbDataZakonczenia = new System.Windows.Forms.MaskedTextBox();
            this.btnDzisZakonczenie = new System.Windows.Forms.Button();
            this.mtbDataRozpoczecia = new System.Windows.Forms.MaskedTextBox();
            this.btnDzisRozpoczecie = new System.Windows.Forms.Button();
            this.lblDataZakonczenia = new System.Windows.Forms.Label();
            this.lblDataRozpoczecia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(33, 58);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(94, 18);
            this.lblOpis.TabIndex = 1;
            this.lblOpis.Text = "Nazwa etapu";
            // 
            // cbxEtap
            // 
            this.cbxEtap.FormattingEnabled = true;
            this.cbxEtap.Location = new System.Drawing.Point(233, 59);
            this.cbxEtap.Name = "cbxEtap";
            this.cbxEtap.Size = new System.Drawing.Size(121, 21);
            this.cbxEtap.TabIndex = 2;
            // 
            // btnWyzeruj
            // 
            this.btnWyzeruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyzeruj.Location = new System.Drawing.Point(350, 178);
            this.btnWyzeruj.Name = "btnWyzeruj";
            this.btnWyzeruj.Size = new System.Drawing.Size(80, 50);
            this.btnWyzeruj.TabIndex = 7;
            this.btnWyzeruj.Text = "Wyzeruj";
            this.btnWyzeruj.UseVisualStyleBackColor = true;
            this.btnWyzeruj.Click += new System.EventHandler(this.btnWyzeruj_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.Location = new System.Drawing.Point(242, 178);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(80, 50);
            this.btnAnuluj.TabIndex = 8;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click_1);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.Location = new System.Drawing.Point(123, 178);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(80, 50);
            this.btnZapisz.TabIndex = 9;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // mtbDataZakonczenia
            // 
            this.mtbDataZakonczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbDataZakonczenia.Location = new System.Drawing.Point(231, 120);
            this.mtbDataZakonczenia.Mask = "00/00/0000 00:00:00";
            this.mtbDataZakonczenia.Name = "mtbDataZakonczenia";
            this.mtbDataZakonczenia.Size = new System.Drawing.Size(189, 24);
            this.mtbDataZakonczenia.TabIndex = 36;
            // 
            // btnDzisZakonczenie
            // 
            this.btnDzisZakonczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzisZakonczenie.Location = new System.Drawing.Point(426, 122);
            this.btnDzisZakonczenie.Name = "btnDzisZakonczenie";
            this.btnDzisZakonczenie.Size = new System.Drawing.Size(43, 23);
            this.btnDzisZakonczenie.TabIndex = 35;
            this.btnDzisZakonczenie.Text = "Dziś";
            this.btnDzisZakonczenie.UseVisualStyleBackColor = true;
            this.btnDzisZakonczenie.Click += new System.EventHandler(this.btnDzisZakonczenie_Click);
            // 
            // mtbDataRozpoczecia
            // 
            this.mtbDataRozpoczecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbDataRozpoczecia.Location = new System.Drawing.Point(231, 91);
            this.mtbDataRozpoczecia.Mask = "00/00/0000 00:00:00";
            this.mtbDataRozpoczecia.Name = "mtbDataRozpoczecia";
            this.mtbDataRozpoczecia.Size = new System.Drawing.Size(189, 24);
            this.mtbDataRozpoczecia.TabIndex = 34;
            // 
            // btnDzisRozpoczecie
            // 
            this.btnDzisRozpoczecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzisRozpoczecie.Location = new System.Drawing.Point(426, 93);
            this.btnDzisRozpoczecie.Name = "btnDzisRozpoczecie";
            this.btnDzisRozpoczecie.Size = new System.Drawing.Size(43, 23);
            this.btnDzisRozpoczecie.TabIndex = 33;
            this.btnDzisRozpoczecie.Text = "Dziś";
            this.btnDzisRozpoczecie.UseVisualStyleBackColor = true;
            this.btnDzisRozpoczecie.Click += new System.EventHandler(this.btnDzisRozpoczecie_Click);
            // 
            // lblDataZakonczenia
            // 
            this.lblDataZakonczenia.AutoSize = true;
            this.lblDataZakonczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataZakonczenia.Location = new System.Drawing.Point(33, 122);
            this.lblDataZakonczenia.Name = "lblDataZakonczenia";
            this.lblDataZakonczenia.Size = new System.Drawing.Size(127, 18);
            this.lblDataZakonczenia.TabIndex = 31;
            this.lblDataZakonczenia.Text = "Data zakończenia";
            // 
            // lblDataRozpoczecia
            // 
            this.lblDataRozpoczecia.AutoSize = true;
            this.lblDataRozpoczecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataRozpoczecia.Location = new System.Drawing.Point(33, 93);
            this.lblDataRozpoczecia.Name = "lblDataRozpoczecia";
            this.lblDataRozpoczecia.Size = new System.Drawing.Size(125, 18);
            this.lblDataRozpoczecia.TabIndex = 32;
            this.lblDataRozpoczecia.Text = "Data rozpoczęcia";
            // 
            // NowaRealizacjaProcesu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(524, 262);
            this.Controls.Add(this.mtbDataZakonczenia);
            this.Controls.Add(this.btnDzisZakonczenie);
            this.Controls.Add(this.mtbDataRozpoczecia);
            this.Controls.Add(this.btnDzisRozpoczecie);
            this.Controls.Add(this.lblDataZakonczenia);
            this.Controls.Add(this.lblDataRozpoczecia);
            this.Controls.Add(this.btnWyzeruj);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.cbxEtap);
            this.Controls.Add(this.lblOpis);
            this.Name = "NowaRealizacjaProcesu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nowa Realizacja Procesu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.ComboBox cbxEtap;
        private System.Windows.Forms.Button btnWyzeruj;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.MaskedTextBox mtbDataZakonczenia;
        private System.Windows.Forms.Button btnDzisZakonczenie;
        private System.Windows.Forms.MaskedTextBox mtbDataRozpoczecia;
        private System.Windows.Forms.Button btnDzisRozpoczecie;
        private System.Windows.Forms.Label lblDataZakonczenia;
        private System.Windows.Forms.Label lblDataRozpoczecia;
    }
}