namespace Szwalnia
{
    partial class PrzydzialZasobowRealizacja
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
            this.dgvPrzydzialZasobowRealizacja = new System.Windows.Forms.DataGridView();
            this.lblRealizacja = new System.Windows.Forms.Label();
            this.btnNowy = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnEdycja = new System.Windows.Forms.Button();
            this.mtbDataZakonczenia = new System.Windows.Forms.MaskedTextBox();
            this.btnDzisZakonczenie = new System.Windows.Forms.Button();
            this.mtbDataRozpoczecia = new System.Windows.Forms.MaskedTextBox();
            this.btnDzisRozpoczecie = new System.Windows.Forms.Button();
            this.lblDataZakonczenia = new System.Windows.Forms.Label();
            this.lblDataRozpoczecia = new System.Windows.Forms.Label();
            this.lblGwiazdka2 = new System.Windows.Forms.Label();
            this.lblGwiazdka = new System.Windows.Forms.Label();
            this.lblPracownik = new System.Windows.Forms.Label();
            this.lblMaszyna = new System.Windows.Forms.Label();
            this.lblOpisGwiazdki = new System.Windows.Forms.Label();
            this.tbMaszyna = new System.Windows.Forms.TextBox();
            this.tbPracownik = new System.Windows.Forms.TextBox();
            this.gbxEdycja = new System.Windows.Forms.GroupBox();
            this.lblOpis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzydzialZasobowRealizacja)).BeginInit();
            this.gbxEdycja.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrzydzialZasobowRealizacja
            // 
            this.dgvPrzydzialZasobowRealizacja.AllowUserToAddRows = false;
            this.dgvPrzydzialZasobowRealizacja.AllowUserToDeleteRows = false;
            this.dgvPrzydzialZasobowRealizacja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrzydzialZasobowRealizacja.Location = new System.Drawing.Point(45, 76);
            this.dgvPrzydzialZasobowRealizacja.Name = "dgvPrzydzialZasobowRealizacja";
            this.dgvPrzydzialZasobowRealizacja.ReadOnly = true;
            this.dgvPrzydzialZasobowRealizacja.RowHeadersWidth = 51;
            this.dgvPrzydzialZasobowRealizacja.Size = new System.Drawing.Size(775, 334);
            this.dgvPrzydzialZasobowRealizacja.TabIndex = 0;
            this.dgvPrzydzialZasobowRealizacja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrzydzialZasobowRealizacja_CellClick);
            // 
            // lblRealizacja
            // 
            this.lblRealizacja.AutoSize = true;
            this.lblRealizacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRealizacja.Location = new System.Drawing.Point(211, 34);
            this.lblRealizacja.Name = "lblRealizacja";
            this.lblRealizacja.Size = new System.Drawing.Size(51, 20);
            this.lblRealizacja.TabIndex = 2;
            this.lblRealizacja.Text = "label1";
            // 
            // btnNowy
            // 
            this.btnNowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNowy.Location = new System.Drawing.Point(295, 467);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Size = new System.Drawing.Size(80, 50);
            this.btnNowy.TabIndex = 9;
            this.btnNowy.Text = "Nowy";
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.Location = new System.Drawing.Point(417, 467);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(80, 50);
            this.btnAnuluj.TabIndex = 7;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnEdycja
            // 
            this.btnEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdycja.Location = new System.Drawing.Point(1027, 316);
            this.btnEdycja.Name = "btnEdycja";
            this.btnEdycja.Size = new System.Drawing.Size(80, 50);
            this.btnEdycja.TabIndex = 8;
            this.btnEdycja.Text = "Edytuj";
            this.btnEdycja.UseVisualStyleBackColor = true;
            this.btnEdycja.Click += new System.EventHandler(this.btnEdycja_Click);
            // 
            // mtbDataZakonczenia
            // 
            this.mtbDataZakonczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbDataZakonczenia.Location = new System.Drawing.Point(182, 121);
            this.mtbDataZakonczenia.Mask = "00/00/0000 00:00:00";
            this.mtbDataZakonczenia.Name = "mtbDataZakonczenia";
            this.mtbDataZakonczenia.Size = new System.Drawing.Size(149, 24);
            this.mtbDataZakonczenia.TabIndex = 45;
            // 
            // btnDzisZakonczenie
            // 
            this.btnDzisZakonczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzisZakonczenie.Location = new System.Drawing.Point(356, 121);
            this.btnDzisZakonczenie.Name = "btnDzisZakonczenie";
            this.btnDzisZakonczenie.Size = new System.Drawing.Size(43, 23);
            this.btnDzisZakonczenie.TabIndex = 44;
            this.btnDzisZakonczenie.Text = "Dziś";
            this.btnDzisZakonczenie.UseVisualStyleBackColor = true;
            this.btnDzisZakonczenie.Click += new System.EventHandler(this.btnDzisZakonczenie_Click);
            // 
            // mtbDataRozpoczecia
            // 
            this.mtbDataRozpoczecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbDataRozpoczecia.Location = new System.Drawing.Point(182, 91);
            this.mtbDataRozpoczecia.Mask = "00/00/0000 00:00:00";
            this.mtbDataRozpoczecia.Name = "mtbDataRozpoczecia";
            this.mtbDataRozpoczecia.Size = new System.Drawing.Size(149, 24);
            this.mtbDataRozpoczecia.TabIndex = 43;
            // 
            // btnDzisRozpoczecie
            // 
            this.btnDzisRozpoczecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzisRozpoczecie.Location = new System.Drawing.Point(356, 91);
            this.btnDzisRozpoczecie.Name = "btnDzisRozpoczecie";
            this.btnDzisRozpoczecie.Size = new System.Drawing.Size(43, 23);
            this.btnDzisRozpoczecie.TabIndex = 42;
            this.btnDzisRozpoczecie.Text = "Dziś";
            this.btnDzisRozpoczecie.UseVisualStyleBackColor = true;
            this.btnDzisRozpoczecie.Click += new System.EventHandler(this.btnDzisRozpoczecie_Click);
            // 
            // lblDataZakonczenia
            // 
            this.lblDataZakonczenia.AutoSize = true;
            this.lblDataZakonczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataZakonczenia.Location = new System.Drawing.Point(25, 123);
            this.lblDataZakonczenia.Name = "lblDataZakonczenia";
            this.lblDataZakonczenia.Size = new System.Drawing.Size(127, 18);
            this.lblDataZakonczenia.TabIndex = 40;
            this.lblDataZakonczenia.Text = "Data zakończenia";
            // 
            // lblDataRozpoczecia
            // 
            this.lblDataRozpoczecia.AutoSize = true;
            this.lblDataRozpoczecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataRozpoczecia.Location = new System.Drawing.Point(25, 94);
            this.lblDataRozpoczecia.Name = "lblDataRozpoczecia";
            this.lblDataRozpoczecia.Size = new System.Drawing.Size(125, 18);
            this.lblDataRozpoczecia.TabIndex = 41;
            this.lblDataRozpoczecia.Text = "Data rozpoczęcia";
            // 
            // lblGwiazdka2
            // 
            this.lblGwiazdka2.AutoSize = true;
            this.lblGwiazdka2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGwiazdka2.Location = new System.Drawing.Point(288, 61);
            this.lblGwiazdka2.Name = "lblGwiazdka2";
            this.lblGwiazdka2.Size = new System.Drawing.Size(14, 18);
            this.lblGwiazdka2.TabIndex = 56;
            this.lblGwiazdka2.Text = "*";
            // 
            // lblGwiazdka
            // 
            this.lblGwiazdka.AutoSize = true;
            this.lblGwiazdka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGwiazdka.Location = new System.Drawing.Point(288, 33);
            this.lblGwiazdka.Name = "lblGwiazdka";
            this.lblGwiazdka.Size = new System.Drawing.Size(14, 18);
            this.lblGwiazdka.TabIndex = 55;
            this.lblGwiazdka.Text = "*";
            // 
            // lblPracownik
            // 
            this.lblPracownik.AutoSize = true;
            this.lblPracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPracownik.Location = new System.Drawing.Point(25, 34);
            this.lblPracownik.Name = "lblPracownik";
            this.lblPracownik.Size = new System.Drawing.Size(78, 18);
            this.lblPracownik.TabIndex = 52;
            this.lblPracownik.Text = "Pracownik";
            // 
            // lblMaszyna
            // 
            this.lblMaszyna.AutoSize = true;
            this.lblMaszyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMaszyna.Location = new System.Drawing.Point(25, 64);
            this.lblMaszyna.Name = "lblMaszyna";
            this.lblMaszyna.Size = new System.Drawing.Size(68, 18);
            this.lblMaszyna.TabIndex = 51;
            this.lblMaszyna.Text = "Maszyna";
            // 
            // lblOpisGwiazdki
            // 
            this.lblOpisGwiazdki.AutoSize = true;
            this.lblOpisGwiazdki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisGwiazdki.Location = new System.Drawing.Point(25, 165);
            this.lblOpisGwiazdki.Name = "lblOpisGwiazdki";
            this.lblOpisGwiazdki.Size = new System.Drawing.Size(113, 16);
            this.lblOpisGwiazdki.TabIndex = 57;
            this.lblOpisGwiazdki.Text = "* Pole wymagane";
            // 
            // tbMaszyna
            // 
            this.tbMaszyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMaszyna.Location = new System.Drawing.Point(182, 61);
            this.tbMaszyna.Name = "tbMaszyna";
            this.tbMaszyna.Size = new System.Drawing.Size(100, 24);
            this.tbMaszyna.TabIndex = 58;
            // 
            // tbPracownik
            // 
            this.tbPracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPracownik.Location = new System.Drawing.Point(182, 31);
            this.tbPracownik.Name = "tbPracownik";
            this.tbPracownik.Size = new System.Drawing.Size(100, 24);
            this.tbPracownik.TabIndex = 59;
            // 
            // gbxEdycja
            // 
            this.gbxEdycja.Controls.Add(this.tbPracownik);
            this.gbxEdycja.Controls.Add(this.tbMaszyna);
            this.gbxEdycja.Controls.Add(this.lblOpisGwiazdki);
            this.gbxEdycja.Controls.Add(this.lblGwiazdka2);
            this.gbxEdycja.Controls.Add(this.lblGwiazdka);
            this.gbxEdycja.Controls.Add(this.lblPracownik);
            this.gbxEdycja.Controls.Add(this.lblMaszyna);
            this.gbxEdycja.Controls.Add(this.mtbDataZakonczenia);
            this.gbxEdycja.Controls.Add(this.btnDzisZakonczenie);
            this.gbxEdycja.Controls.Add(this.mtbDataRozpoczecia);
            this.gbxEdycja.Controls.Add(this.btnDzisRozpoczecie);
            this.gbxEdycja.Controls.Add(this.lblDataZakonczenia);
            this.gbxEdycja.Controls.Add(this.lblDataRozpoczecia);
            this.gbxEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbxEdycja.Location = new System.Drawing.Point(845, 99);
            this.gbxEdycja.Name = "gbxEdycja";
            this.gbxEdycja.Size = new System.Drawing.Size(426, 195);
            this.gbxEdycja.TabIndex = 60;
            this.gbxEdycja.TabStop = false;
            this.gbxEdycja.Text = "Edycja";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(42, 422);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(288, 18);
            this.lblOpis.TabIndex = 61;
            this.lblOpis.Text = "Kilknij na przydział, który chcesz edytować";
            // 
            // PrzydzialZasobowRealizacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1324, 546);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.gbxEdycja);
            this.Controls.Add(this.btnNowy);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnEdycja);
            this.Controls.Add(this.lblRealizacja);
            this.Controls.Add(this.dgvPrzydzialZasobowRealizacja);
            this.Name = "PrzydzialZasobowRealizacja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przydział zasobów";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzydzialZasobowRealizacja)).EndInit();
            this.gbxEdycja.ResumeLayout(false);
            this.gbxEdycja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrzydzialZasobowRealizacja;
        private System.Windows.Forms.Label lblRealizacja;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnEdycja;
        private System.Windows.Forms.MaskedTextBox mtbDataZakonczenia;
        private System.Windows.Forms.Button btnDzisZakonczenie;
        private System.Windows.Forms.MaskedTextBox mtbDataRozpoczecia;
        private System.Windows.Forms.Button btnDzisRozpoczecie;
        private System.Windows.Forms.Label lblDataZakonczenia;
        private System.Windows.Forms.Label lblDataRozpoczecia;
        private System.Windows.Forms.Label lblGwiazdka2;
        private System.Windows.Forms.Label lblGwiazdka;
        private System.Windows.Forms.Label lblPracownik;
        private System.Windows.Forms.Label lblMaszyna;
        private System.Windows.Forms.Label lblOpisGwiazdki;
        private System.Windows.Forms.TextBox tbMaszyna;
        private System.Windows.Forms.TextBox tbPracownik;
        private System.Windows.Forms.GroupBox gbxEdycja;
        private System.Windows.Forms.Label lblOpis;
    }
}