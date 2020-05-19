namespace Szwalnia
{
    partial class PrzegladProcesowProdukcyjnych
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
            this.btnWszystkieProcesy = new System.Windows.Forms.Button();
            this.btnRozpoczeteProcesy = new System.Windows.Forms.Button();
            this.dgvProcesyProdukcyjne = new System.Windows.Forms.DataGridView();
            this.lblProcesy = new System.Windows.Forms.Label();
            this.gbZaawansowane = new System.Windows.Forms.GroupBox();
            this.btnDataZakonczenia = new System.Windows.Forms.Button();
            this.btnDataRozpoczecia = new System.Windows.Forms.Button();
            this.btnIdZamowienieElement = new System.Windows.Forms.Button();
            this.btnIdZamowienia = new System.Windows.Forms.Button();
            this.btnIdProcesu = new System.Windows.Forms.Button();
            this.dtpDataZakonczenia = new System.Windows.Forms.DateTimePicker();
            this.dtpDataRozpoczecia = new System.Windows.Forms.DateTimePicker();
            this.nudNumerZamowienieElement = new System.Windows.Forms.NumericUpDown();
            this.nudNumerProcesu = new System.Windows.Forms.NumericUpDown();
            this.nudNumerZamowienia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrzedzialRozpoczecie = new System.Windows.Forms.Label();
            this.lblIdZamowienieElement = new System.Windows.Forms.Label();
            this.lblIdZamowienia = new System.Windows.Forms.Label();
            this.lblIdProcesu = new System.Windows.Forms.Label();
            this.gbPodstawowe = new System.Windows.Forms.GroupBox();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.lblOpis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesyProdukcyjne)).BeginInit();
            this.gbZaawansowane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerZamowienieElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerProcesu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerZamowienia)).BeginInit();
            this.gbPodstawowe.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWszystkieProcesy
            // 
            this.btnWszystkieProcesy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWszystkieProcesy.Location = new System.Drawing.Point(20, 59);
            this.btnWszystkieProcesy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWszystkieProcesy.Name = "btnWszystkieProcesy";
            this.btnWszystkieProcesy.Size = new System.Drawing.Size(173, 49);
            this.btnWszystkieProcesy.TabIndex = 0;
            this.btnWszystkieProcesy.Text = "Wszystkie";
            this.btnWszystkieProcesy.UseVisualStyleBackColor = true;
            this.btnWszystkieProcesy.Click += new System.EventHandler(this.btnWszystkieProcesy_Click);
            // 
            // btnRozpoczeteProcesy
            // 
            this.btnRozpoczeteProcesy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRozpoczeteProcesy.Location = new System.Drawing.Point(20, 135);
            this.btnRozpoczeteProcesy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRozpoczeteProcesy.Name = "btnRozpoczeteProcesy";
            this.btnRozpoczeteProcesy.Size = new System.Drawing.Size(173, 49);
            this.btnRozpoczeteProcesy.TabIndex = 0;
            this.btnRozpoczeteProcesy.Text = "Rozpoczęte";
            this.btnRozpoczeteProcesy.UseVisualStyleBackColor = true;
            this.btnRozpoczeteProcesy.Click += new System.EventHandler(this.btnRozpoczeteProcesy_Click);
            // 
            // dgvProcesyProdukcyjne
            // 
            this.dgvProcesyProdukcyjne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesyProdukcyjne.Location = new System.Drawing.Point(16, 337);
            this.dgvProcesyProdukcyjne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProcesyProdukcyjne.Name = "dgvProcesyProdukcyjne";
            this.dgvProcesyProdukcyjne.RowHeadersWidth = 51;
            this.dgvProcesyProdukcyjne.Size = new System.Drawing.Size(1157, 350);
            this.dgvProcesyProdukcyjne.TabIndex = 1;
            this.dgvProcesyProdukcyjne.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcesyProdukcyjne_CellDoubleClick);
            // 
            // lblProcesy
            // 
            this.lblProcesy.AutoSize = true;
            this.lblProcesy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProcesy.Location = new System.Drawing.Point(404, 27);
            this.lblProcesy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcesy.Name = "lblProcesy";
            this.lblProcesy.Size = new System.Drawing.Size(358, 25);
            this.lblProcesy.TabIndex = 4;
            this.lblProcesy.Text = "Wyszukiwanie procesów produkcyjnych";
            // 
            // gbZaawansowane
            // 
            this.gbZaawansowane.Controls.Add(this.btnDataZakonczenia);
            this.gbZaawansowane.Controls.Add(this.btnDataRozpoczecia);
            this.gbZaawansowane.Controls.Add(this.btnIdZamowienieElement);
            this.gbZaawansowane.Controls.Add(this.btnIdZamowienia);
            this.gbZaawansowane.Controls.Add(this.btnIdProcesu);
            this.gbZaawansowane.Controls.Add(this.dtpDataZakonczenia);
            this.gbZaawansowane.Controls.Add(this.dtpDataRozpoczecia);
            this.gbZaawansowane.Controls.Add(this.nudNumerZamowienieElement);
            this.gbZaawansowane.Controls.Add(this.nudNumerProcesu);
            this.gbZaawansowane.Controls.Add(this.nudNumerZamowienia);
            this.gbZaawansowane.Controls.Add(this.label2);
            this.gbZaawansowane.Controls.Add(this.lblPrzedzialRozpoczecie);
            this.gbZaawansowane.Controls.Add(this.lblIdZamowienieElement);
            this.gbZaawansowane.Controls.Add(this.lblIdZamowienia);
            this.gbZaawansowane.Controls.Add(this.lblIdProcesu);
            this.gbZaawansowane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbZaawansowane.Location = new System.Drawing.Point(563, 84);
            this.gbZaawansowane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbZaawansowane.Name = "gbZaawansowane";
            this.gbZaawansowane.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbZaawansowane.Size = new System.Drawing.Size(495, 229);
            this.gbZaawansowane.TabIndex = 5;
            this.gbZaawansowane.TabStop = false;
            this.gbZaawansowane.Text = "Zaawansowane";
            // 
            // btnDataZakonczenia
            // 
            this.btnDataZakonczenia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDataZakonczenia.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDataZakonczenia.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnDataZakonczenia.Location = new System.Drawing.Point(433, 180);
            this.btnDataZakonczenia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDataZakonczenia.Name = "btnDataZakonczenia";
            this.btnDataZakonczenia.Size = new System.Drawing.Size(48, 34);
            this.btnDataZakonczenia.TabIndex = 14;
            this.btnDataZakonczenia.UseVisualStyleBackColor = false;
            this.btnDataZakonczenia.Click += new System.EventHandler(this.btnDataZakonczenia_Click);
            // 
            // btnDataRozpoczecia
            // 
            this.btnDataRozpoczecia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDataRozpoczecia.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDataRozpoczecia.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnDataRozpoczecia.Location = new System.Drawing.Point(433, 144);
            this.btnDataRozpoczecia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDataRozpoczecia.Name = "btnDataRozpoczecia";
            this.btnDataRozpoczecia.Size = new System.Drawing.Size(48, 34);
            this.btnDataRozpoczecia.TabIndex = 13;
            this.btnDataRozpoczecia.UseVisualStyleBackColor = false;
            this.btnDataRozpoczecia.Click += new System.EventHandler(this.btnDataRozpoczecia_Click);
            // 
            // btnIdZamowienieElement
            // 
            this.btnIdZamowienieElement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIdZamowienieElement.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIdZamowienieElement.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnIdZamowienieElement.Location = new System.Drawing.Point(433, 108);
            this.btnIdZamowienieElement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIdZamowienieElement.Name = "btnIdZamowienieElement";
            this.btnIdZamowienieElement.Size = new System.Drawing.Size(48, 34);
            this.btnIdZamowienieElement.TabIndex = 12;
            this.btnIdZamowienieElement.UseVisualStyleBackColor = false;
            this.btnIdZamowienieElement.Click += new System.EventHandler(this.btnIdZamowienieElement_Click);
            // 
            // btnIdZamowienia
            // 
            this.btnIdZamowienia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIdZamowienia.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIdZamowienia.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnIdZamowienia.Location = new System.Drawing.Point(433, 74);
            this.btnIdZamowienia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIdZamowienia.Name = "btnIdZamowienia";
            this.btnIdZamowienia.Size = new System.Drawing.Size(48, 34);
            this.btnIdZamowienia.TabIndex = 11;
            this.btnIdZamowienia.UseVisualStyleBackColor = false;
            this.btnIdZamowienia.Click += new System.EventHandler(this.btnIdZamowienia_Click);
            // 
            // btnIdProcesu
            // 
            this.btnIdProcesu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIdProcesu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIdProcesu.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnIdProcesu.Location = new System.Drawing.Point(433, 37);
            this.btnIdProcesu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIdProcesu.Name = "btnIdProcesu";
            this.btnIdProcesu.Size = new System.Drawing.Size(48, 34);
            this.btnIdProcesu.TabIndex = 10;
            this.btnIdProcesu.UseVisualStyleBackColor = false;
            this.btnIdProcesu.Click += new System.EventHandler(this.btnIdProcesu_Click);
            // 
            // dtpDataZakonczenia
            // 
            this.dtpDataZakonczenia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDataZakonczenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataZakonczenia.Location = new System.Drawing.Point(281, 185);
            this.dtpDataZakonczenia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataZakonczenia.Name = "dtpDataZakonczenia";
            this.dtpDataZakonczenia.Size = new System.Drawing.Size(143, 26);
            this.dtpDataZakonczenia.TabIndex = 9;
            // 
            // dtpDataRozpoczecia
            // 
            this.dtpDataRozpoczecia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDataRozpoczecia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataRozpoczecia.Location = new System.Drawing.Point(281, 149);
            this.dtpDataRozpoczecia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataRozpoczecia.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpDataRozpoczecia.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDataRozpoczecia.Name = "dtpDataRozpoczecia";
            this.dtpDataRozpoczecia.Size = new System.Drawing.Size(143, 26);
            this.dtpDataRozpoczecia.TabIndex = 9;
            // 
            // nudNumerZamowienieElement
            // 
            this.nudNumerZamowienieElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudNumerZamowienieElement.Location = new System.Drawing.Point(281, 111);
            this.nudNumerZamowienieElement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudNumerZamowienieElement.Name = "nudNumerZamowienieElement";
            this.nudNumerZamowienieElement.Size = new System.Drawing.Size(144, 29);
            this.nudNumerZamowienieElement.TabIndex = 8;
            // 
            // nudNumerProcesu
            // 
            this.nudNumerProcesu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudNumerProcesu.Location = new System.Drawing.Point(281, 39);
            this.nudNumerProcesu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudNumerProcesu.Name = "nudNumerProcesu";
            this.nudNumerProcesu.Size = new System.Drawing.Size(144, 29);
            this.nudNumerProcesu.TabIndex = 7;
            // 
            // nudNumerZamowienia
            // 
            this.nudNumerZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudNumerZamowienia.Location = new System.Drawing.Point(281, 76);
            this.nudNumerZamowienia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudNumerZamowienia.Name = "nudNumerZamowienia";
            this.nudNumerZamowienia.Size = new System.Drawing.Size(144, 29);
            this.nudNumerZamowienia.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data zakończenia";
            // 
            // lblPrzedzialRozpoczecie
            // 
            this.lblPrzedzialRozpoczecie.AutoSize = true;
            this.lblPrzedzialRozpoczecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrzedzialRozpoczecie.Location = new System.Drawing.Point(9, 149);
            this.lblPrzedzialRozpoczecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrzedzialRozpoczecie.Name = "lblPrzedzialRozpoczecie";
            this.lblPrzedzialRozpoczecie.Size = new System.Drawing.Size(154, 24);
            this.lblPrzedzialRozpoczecie.TabIndex = 4;
            this.lblPrzedzialRozpoczecie.Text = "Data rozpoczęcia";
            // 
            // lblIdZamowienieElement
            // 
            this.lblIdZamowienieElement.AutoSize = true;
            this.lblIdZamowienieElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdZamowienieElement.Location = new System.Drawing.Point(8, 113);
            this.lblIdZamowienieElement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdZamowienieElement.Name = "lblIdZamowienieElement";
            this.lblIdZamowienieElement.Size = new System.Drawing.Size(216, 24);
            this.lblIdZamowienieElement.TabIndex = 3;
            this.lblIdZamowienieElement.Text = "ID zamówienia elementu";
            // 
            // lblIdZamowienia
            // 
            this.lblIdZamowienia.AutoSize = true;
            this.lblIdZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdZamowienia.Location = new System.Drawing.Point(8, 78);
            this.lblIdZamowienia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdZamowienia.Name = "lblIdZamowienia";
            this.lblIdZamowienia.Size = new System.Drawing.Size(132, 24);
            this.lblIdZamowienia.TabIndex = 2;
            this.lblIdZamowienia.Text = "ID zamówienia";
            // 
            // lblIdProcesu
            // 
            this.lblIdProcesu.AutoSize = true;
            this.lblIdProcesu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdProcesu.Location = new System.Drawing.Point(9, 42);
            this.lblIdProcesu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProcesu.Name = "lblIdProcesu";
            this.lblIdProcesu.Size = new System.Drawing.Size(101, 24);
            this.lblIdProcesu.TabIndex = 1;
            this.lblIdProcesu.Text = "ID procesu";
            // 
            // gbPodstawowe
            // 
            this.gbPodstawowe.Controls.Add(this.btnWszystkieProcesy);
            this.gbPodstawowe.Controls.Add(this.btnRozpoczeteProcesy);
            this.gbPodstawowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPodstawowe.Location = new System.Drawing.Point(296, 84);
            this.gbPodstawowe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPodstawowe.Name = "gbPodstawowe";
            this.gbPodstawowe.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPodstawowe.Size = new System.Drawing.Size(213, 229);
            this.gbPodstawowe.TabIndex = 6;
            this.gbPodstawowe.TabStop = false;
            this.gbPodstawowe.Text = "Podstawowe";
            // 
            // btnWstecz
            // 
            this.btnWstecz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWstecz.Location = new System.Drawing.Point(16, 15);
            this.btnWstecz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(100, 37);
            this.btnWstecz.TabIndex = 7;
            this.btnWstecz.Text = "wstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(253, 706);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(634, 24);
            this.lblOpis.TabIndex = 8;
            this.lblOpis.Text = "Kliknij dwukrotnie na procesie, którego szczegóły mają zostać wyświetlone";
            // 
            // PrzegladProcesowProdukcyjnych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 740);
            this.Controls.Add(this.gbZaawansowane);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.gbPodstawowe);
            this.Controls.Add(this.lblProcesy);
            this.Controls.Add(this.dgvProcesyProdukcyjne);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PrzegladProcesowProdukcyjnych";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przegląd procesów produkcyjnych";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesyProdukcyjne)).EndInit();
            this.gbZaawansowane.ResumeLayout(false);
            this.gbZaawansowane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerZamowienieElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerProcesu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerZamowienia)).EndInit();
            this.gbPodstawowe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWszystkieProcesy;
        private System.Windows.Forms.Button btnRozpoczeteProcesy;
        private System.Windows.Forms.DataGridView dgvProcesyProdukcyjne;
        private System.Windows.Forms.Label lblProcesy;
        private System.Windows.Forms.GroupBox gbZaawansowane;
        private System.Windows.Forms.Label lblIdProcesu;
        private System.Windows.Forms.GroupBox gbPodstawowe;
        private System.Windows.Forms.Label lblIdZamowienia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrzedzialRozpoczecie;
        private System.Windows.Forms.Label lblIdZamowienieElement;
        private System.Windows.Forms.Button btnDataZakonczenia;
        private System.Windows.Forms.Button btnDataRozpoczecia;
        private System.Windows.Forms.Button btnIdZamowienieElement;
        private System.Windows.Forms.Button btnIdZamowienia;
        private System.Windows.Forms.Button btnIdProcesu;
        private System.Windows.Forms.DateTimePicker dtpDataZakonczenia;
        private System.Windows.Forms.DateTimePicker dtpDataRozpoczecia;
        private System.Windows.Forms.NumericUpDown nudNumerZamowienieElement;
        private System.Windows.Forms.NumericUpDown nudNumerProcesu;
        private System.Windows.Forms.NumericUpDown nudNumerZamowienia;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.Label lblOpis;
    }
}