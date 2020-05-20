namespace Szwalnia
{
    partial class RealizacjaProcesu
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
            this.dgvRealizacjaProcesu = new System.Windows.Forms.DataGridView();
            this.lblProces = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnNowa = new System.Windows.Forms.Button();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblGwiazdkaEdycja = new System.Windows.Forms.Label();
            this.mtbDataZakonczeniaEdycja = new System.Windows.Forms.MaskedTextBox();
            this.btnDzisZakonczenieEdycja = new System.Windows.Forms.Button();
            this.mtbDataRozpoczeciaEdycja = new System.Windows.Forms.MaskedTextBox();
            this.btnDzisRozpoczecieEdycja = new System.Windows.Forms.Button();
            this.lblDataZakonczeniaEdycja = new System.Windows.Forms.Label();
            this.lblDataRozpoczeciaEdycja = new System.Windows.Forms.Label();
            this.cbxEtapEdycja = new System.Windows.Forms.ComboBox();
            this.lblEtapEdycja = new System.Windows.Forms.Label();
            this.gbxEdycja = new System.Windows.Forms.GroupBox();
            this.gbxNowa = new System.Windows.Forms.GroupBox();
            this.lblOpisGwiazdkiNowa = new System.Windows.Forms.Label();
            this.lblGwiazdkaNowa = new System.Windows.Forms.Label();
            this.mtbDataZakonczeniaNowa = new System.Windows.Forms.MaskedTextBox();
            this.btnDataZakonczeniaNowa = new System.Windows.Forms.Button();
            this.mtbDataRozpoczeciaNowa = new System.Windows.Forms.MaskedTextBox();
            this.btnDataRozpoczeciaNowa = new System.Windows.Forms.Button();
            this.lblDataZakonczeniaNowa = new System.Windows.Forms.Label();
            this.lblDataRozpoczeciaNowa = new System.Windows.Forms.Label();
            this.cbxEtapNowa = new System.Windows.Forms.ComboBox();
            this.lblEtapNowa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbDataKontroliNowa = new System.Windows.Forms.MaskedTextBox();
            this.btnDzisKontrolaNowa = new System.Windows.Forms.Button();
            this.lblDataKontroliNowa = new System.Windows.Forms.Label();
            this.tbUwagiKontrolaNowa = new System.Windows.Forms.TextBox();
            this.lblUwagiNowa = new System.Windows.Forms.Label();
            this.lblKontrolaEdycja = new System.Windows.Forms.Label();
            this.tbUwagiKontrolaEdycja = new System.Windows.Forms.TextBox();
            this.mtbDataKontroliEdycja = new System.Windows.Forms.MaskedTextBox();
            this.btnDzisKontrolaEdycja = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOpisGwiazdkiEdycja = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealizacjaProcesu)).BeginInit();
            this.gbxEdycja.SuspendLayout();
            this.gbxNowa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRealizacjaProcesu
            // 
            this.dgvRealizacjaProcesu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRealizacjaProcesu.Location = new System.Drawing.Point(30, 123);
            this.dgvRealizacjaProcesu.Name = "dgvRealizacjaProcesu";
            this.dgvRealizacjaProcesu.RowHeadersWidth = 51;
            this.dgvRealizacjaProcesu.Size = new System.Drawing.Size(737, 274);
            this.dgvRealizacjaProcesu.TabIndex = 0;
            this.dgvRealizacjaProcesu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRealizacjaProcesu_CellClick);
            this.dgvRealizacjaProcesu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRealizacjaProcesu_CellDoubleClick);
            // 
            // lblProces
            // 
            this.lblProces.AutoSize = true;
            this.lblProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProces.Location = new System.Drawing.Point(92, 39);
            this.lblProces.Name = "lblProces";
            this.lblProces.Size = new System.Drawing.Size(51, 20);
            this.lblProces.TabIndex = 1;
            this.lblProces.Text = "label1";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.Location = new System.Drawing.Point(977, 645);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(102, 50);
            this.btnZapisz.TabIndex = 5;
            this.btnZapisz.Text = "Edytuj";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnNowa
            // 
            this.btnNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNowa.Location = new System.Drawing.Point(967, 317);
            this.btnNowa.Name = "btnNowa";
            this.btnNowa.Size = new System.Drawing.Size(112, 50);
            this.btnNowa.TabIndex = 6;
            this.btnNowa.Text = "Utwórz nową";
            this.btnNowa.UseVisualStyleBackColor = true;
            this.btnNowa.Click += new System.EventHandler(this.btnNowa_Click);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(27, 476);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(466, 18);
            this.lblOpis.TabIndex = 9;
            this.lblOpis.Text = "Kliknij dwukrotnie na realizację, aby zmodyfikować przydział zasobów";
            // 
            // lblGwiazdkaEdycja
            // 
            this.lblGwiazdkaEdycja.AutoSize = true;
            this.lblGwiazdkaEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGwiazdkaEdycja.Location = new System.Drawing.Point(343, 43);
            this.lblGwiazdkaEdycja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGwiazdkaEdycja.Name = "lblGwiazdkaEdycja";
            this.lblGwiazdkaEdycja.Size = new System.Drawing.Size(13, 17);
            this.lblGwiazdkaEdycja.TabIndex = 47;
            this.lblGwiazdkaEdycja.Text = "*";
            // 
            // mtbDataZakonczeniaEdycja
            // 
            this.mtbDataZakonczeniaEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbDataZakonczeniaEdycja.Location = new System.Drawing.Point(167, 101);
            this.mtbDataZakonczeniaEdycja.Mask = "00/00/0000 00:00:00";
            this.mtbDataZakonczeniaEdycja.Name = "mtbDataZakonczeniaEdycja";
            this.mtbDataZakonczeniaEdycja.Size = new System.Drawing.Size(158, 24);
            this.mtbDataZakonczeniaEdycja.TabIndex = 46;
            // 
            // btnDzisZakonczenieEdycja
            // 
            this.btnDzisZakonczenieEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzisZakonczenieEdycja.Location = new System.Drawing.Point(342, 103);
            this.btnDzisZakonczenieEdycja.Name = "btnDzisZakonczenieEdycja";
            this.btnDzisZakonczenieEdycja.Size = new System.Drawing.Size(43, 23);
            this.btnDzisZakonczenieEdycja.TabIndex = 45;
            this.btnDzisZakonczenieEdycja.Text = "Dziś";
            this.btnDzisZakonczenieEdycja.UseVisualStyleBackColor = true;
            this.btnDzisZakonczenieEdycja.Click += new System.EventHandler(this.btnDzisZakonczenieEdycja_Click);
            // 
            // mtbDataRozpoczeciaEdycja
            // 
            this.mtbDataRozpoczeciaEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbDataRozpoczeciaEdycja.Location = new System.Drawing.Point(167, 72);
            this.mtbDataRozpoczeciaEdycja.Mask = "00/00/0000 00:00:00";
            this.mtbDataRozpoczeciaEdycja.Name = "mtbDataRozpoczeciaEdycja";
            this.mtbDataRozpoczeciaEdycja.Size = new System.Drawing.Size(158, 24);
            this.mtbDataRozpoczeciaEdycja.TabIndex = 44;
            // 
            // btnDzisRozpoczecieEdycja
            // 
            this.btnDzisRozpoczecieEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzisRozpoczecieEdycja.Location = new System.Drawing.Point(342, 72);
            this.btnDzisRozpoczecieEdycja.Name = "btnDzisRozpoczecieEdycja";
            this.btnDzisRozpoczecieEdycja.Size = new System.Drawing.Size(43, 23);
            this.btnDzisRozpoczecieEdycja.TabIndex = 43;
            this.btnDzisRozpoczecieEdycja.Text = "Dziś";
            this.btnDzisRozpoczecieEdycja.UseVisualStyleBackColor = true;
            this.btnDzisRozpoczecieEdycja.Click += new System.EventHandler(this.btnDzisRozpoczecieEdycja_Click);
            // 
            // lblDataZakonczeniaEdycja
            // 
            this.lblDataZakonczeniaEdycja.AutoSize = true;
            this.lblDataZakonczeniaEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataZakonczeniaEdycja.Location = new System.Drawing.Point(23, 104);
            this.lblDataZakonczeniaEdycja.Name = "lblDataZakonczeniaEdycja";
            this.lblDataZakonczeniaEdycja.Size = new System.Drawing.Size(127, 18);
            this.lblDataZakonczeniaEdycja.TabIndex = 41;
            this.lblDataZakonczeniaEdycja.Text = "Data zakończenia";
            // 
            // lblDataRozpoczeciaEdycja
            // 
            this.lblDataRozpoczeciaEdycja.AutoSize = true;
            this.lblDataRozpoczeciaEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataRozpoczeciaEdycja.Location = new System.Drawing.Point(23, 75);
            this.lblDataRozpoczeciaEdycja.Name = "lblDataRozpoczeciaEdycja";
            this.lblDataRozpoczeciaEdycja.Size = new System.Drawing.Size(125, 18);
            this.lblDataRozpoczeciaEdycja.TabIndex = 42;
            this.lblDataRozpoczeciaEdycja.Text = "Data rozpoczęcia";
            // 
            // cbxEtapEdycja
            // 
            this.cbxEtapEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxEtapEdycja.FormattingEnabled = true;
            this.cbxEtapEdycja.Location = new System.Drawing.Point(167, 40);
            this.cbxEtapEdycja.Name = "cbxEtapEdycja";
            this.cbxEtapEdycja.Size = new System.Drawing.Size(158, 25);
            this.cbxEtapEdycja.TabIndex = 40;
            // 
            // lblEtapEdycja
            // 
            this.lblEtapEdycja.AutoSize = true;
            this.lblEtapEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEtapEdycja.Location = new System.Drawing.Point(23, 40);
            this.lblEtapEdycja.Name = "lblEtapEdycja";
            this.lblEtapEdycja.Size = new System.Drawing.Size(94, 18);
            this.lblEtapEdycja.TabIndex = 39;
            this.lblEtapEdycja.Text = "Nazwa etapu";
            // 
            // gbxEdycja
            // 
            this.gbxEdycja.Controls.Add(this.lblKontrolaEdycja);
            this.gbxEdycja.Controls.Add(this.tbUwagiKontrolaEdycja);
            this.gbxEdycja.Controls.Add(this.mtbDataKontroliEdycja);
            this.gbxEdycja.Controls.Add(this.btnDzisKontrolaEdycja);
            this.gbxEdycja.Controls.Add(this.label3);
            this.gbxEdycja.Controls.Add(this.lblOpisGwiazdkiEdycja);
            this.gbxEdycja.Controls.Add(this.lblGwiazdkaEdycja);
            this.gbxEdycja.Controls.Add(this.mtbDataZakonczeniaEdycja);
            this.gbxEdycja.Controls.Add(this.btnDzisZakonczenieEdycja);
            this.gbxEdycja.Controls.Add(this.mtbDataRozpoczeciaEdycja);
            this.gbxEdycja.Controls.Add(this.btnDzisRozpoczecieEdycja);
            this.gbxEdycja.Controls.Add(this.lblDataZakonczeniaEdycja);
            this.gbxEdycja.Controls.Add(this.lblDataRozpoczeciaEdycja);
            this.gbxEdycja.Controls.Add(this.cbxEtapEdycja);
            this.gbxEdycja.Controls.Add(this.lblEtapEdycja);
            this.gbxEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbxEdycja.Location = new System.Drawing.Point(810, 373);
            this.gbxEdycja.Name = "gbxEdycja";
            this.gbxEdycja.Size = new System.Drawing.Size(419, 255);
            this.gbxEdycja.TabIndex = 49;
            this.gbxEdycja.TabStop = false;
            this.gbxEdycja.Text = "Edycja realizacji";
            // 
            // gbxNowa
            // 
            this.gbxNowa.Controls.Add(this.lblUwagiNowa);
            this.gbxNowa.Controls.Add(this.tbUwagiKontrolaNowa);
            this.gbxNowa.Controls.Add(this.mtbDataKontroliNowa);
            this.gbxNowa.Controls.Add(this.btnDzisKontrolaNowa);
            this.gbxNowa.Controls.Add(this.lblDataKontroliNowa);
            this.gbxNowa.Controls.Add(this.lblOpisGwiazdkiNowa);
            this.gbxNowa.Controls.Add(this.lblGwiazdkaNowa);
            this.gbxNowa.Controls.Add(this.mtbDataZakonczeniaNowa);
            this.gbxNowa.Controls.Add(this.btnDataZakonczeniaNowa);
            this.gbxNowa.Controls.Add(this.mtbDataRozpoczeciaNowa);
            this.gbxNowa.Controls.Add(this.btnDataRozpoczeciaNowa);
            this.gbxNowa.Controls.Add(this.lblDataZakonczeniaNowa);
            this.gbxNowa.Controls.Add(this.lblDataRozpoczeciaNowa);
            this.gbxNowa.Controls.Add(this.cbxEtapNowa);
            this.gbxNowa.Controls.Add(this.lblEtapNowa);
            this.gbxNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbxNowa.Location = new System.Drawing.Point(810, 55);
            this.gbxNowa.Name = "gbxNowa";
            this.gbxNowa.Size = new System.Drawing.Size(419, 256);
            this.gbxNowa.TabIndex = 50;
            this.gbxNowa.TabStop = false;
            this.gbxNowa.Text = "Nowa realizacja";
            // 
            // lblOpisGwiazdkiNowa
            // 
            this.lblOpisGwiazdkiNowa.AutoSize = true;
            this.lblOpisGwiazdkiNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisGwiazdkiNowa.Location = new System.Drawing.Point(23, 226);
            this.lblOpisGwiazdkiNowa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpisGwiazdkiNowa.Name = "lblOpisGwiazdkiNowa";
            this.lblOpisGwiazdkiNowa.Size = new System.Drawing.Size(116, 17);
            this.lblOpisGwiazdkiNowa.TabIndex = 48;
            this.lblOpisGwiazdkiNowa.Text = "* Pole wymagane";
            // 
            // lblGwiazdkaNowa
            // 
            this.lblGwiazdkaNowa.AutoSize = true;
            this.lblGwiazdkaNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGwiazdkaNowa.Location = new System.Drawing.Point(343, 43);
            this.lblGwiazdkaNowa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGwiazdkaNowa.Name = "lblGwiazdkaNowa";
            this.lblGwiazdkaNowa.Size = new System.Drawing.Size(13, 17);
            this.lblGwiazdkaNowa.TabIndex = 47;
            this.lblGwiazdkaNowa.Text = "*";
            // 
            // mtbDataZakonczeniaNowa
            // 
            this.mtbDataZakonczeniaNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbDataZakonczeniaNowa.Location = new System.Drawing.Point(167, 101);
            this.mtbDataZakonczeniaNowa.Mask = "00/00/0000 00:00:00";
            this.mtbDataZakonczeniaNowa.Name = "mtbDataZakonczeniaNowa";
            this.mtbDataZakonczeniaNowa.Size = new System.Drawing.Size(158, 24);
            this.mtbDataZakonczeniaNowa.TabIndex = 46;
            // 
            // btnDataZakonczeniaNowa
            // 
            this.btnDataZakonczeniaNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDataZakonczeniaNowa.Location = new System.Drawing.Point(342, 103);
            this.btnDataZakonczeniaNowa.Name = "btnDataZakonczeniaNowa";
            this.btnDataZakonczeniaNowa.Size = new System.Drawing.Size(43, 23);
            this.btnDataZakonczeniaNowa.TabIndex = 45;
            this.btnDataZakonczeniaNowa.Text = "Dziś";
            this.btnDataZakonczeniaNowa.UseVisualStyleBackColor = true;
            this.btnDataZakonczeniaNowa.Click += new System.EventHandler(this.btnDataZakonczeniaNowa_Click);
            // 
            // mtbDataRozpoczeciaNowa
            // 
            this.mtbDataRozpoczeciaNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbDataRozpoczeciaNowa.Location = new System.Drawing.Point(167, 72);
            this.mtbDataRozpoczeciaNowa.Mask = "00/00/0000 00:00:00";
            this.mtbDataRozpoczeciaNowa.Name = "mtbDataRozpoczeciaNowa";
            this.mtbDataRozpoczeciaNowa.Size = new System.Drawing.Size(158, 24);
            this.mtbDataRozpoczeciaNowa.TabIndex = 44;
            // 
            // btnDataRozpoczeciaNowa
            // 
            this.btnDataRozpoczeciaNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDataRozpoczeciaNowa.Location = new System.Drawing.Point(342, 72);
            this.btnDataRozpoczeciaNowa.Name = "btnDataRozpoczeciaNowa";
            this.btnDataRozpoczeciaNowa.Size = new System.Drawing.Size(43, 23);
            this.btnDataRozpoczeciaNowa.TabIndex = 43;
            this.btnDataRozpoczeciaNowa.Text = "Dziś";
            this.btnDataRozpoczeciaNowa.UseVisualStyleBackColor = true;
            this.btnDataRozpoczeciaNowa.Click += new System.EventHandler(this.btnDataRozpoczeciaNowa_Click);
            // 
            // lblDataZakonczeniaNowa
            // 
            this.lblDataZakonczeniaNowa.AutoSize = true;
            this.lblDataZakonczeniaNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataZakonczeniaNowa.Location = new System.Drawing.Point(23, 104);
            this.lblDataZakonczeniaNowa.Name = "lblDataZakonczeniaNowa";
            this.lblDataZakonczeniaNowa.Size = new System.Drawing.Size(127, 18);
            this.lblDataZakonczeniaNowa.TabIndex = 41;
            this.lblDataZakonczeniaNowa.Text = "Data zakończenia";
            // 
            // lblDataRozpoczeciaNowa
            // 
            this.lblDataRozpoczeciaNowa.AutoSize = true;
            this.lblDataRozpoczeciaNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataRozpoczeciaNowa.Location = new System.Drawing.Point(23, 75);
            this.lblDataRozpoczeciaNowa.Name = "lblDataRozpoczeciaNowa";
            this.lblDataRozpoczeciaNowa.Size = new System.Drawing.Size(125, 18);
            this.lblDataRozpoczeciaNowa.TabIndex = 42;
            this.lblDataRozpoczeciaNowa.Text = "Data rozpoczęcia";
            // 
            // cbxEtapNowa
            // 
            this.cbxEtapNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxEtapNowa.FormattingEnabled = true;
            this.cbxEtapNowa.Location = new System.Drawing.Point(167, 40);
            this.cbxEtapNowa.Name = "cbxEtapNowa";
            this.cbxEtapNowa.Size = new System.Drawing.Size(158, 25);
            this.cbxEtapNowa.TabIndex = 40;
            // 
            // lblEtapNowa
            // 
            this.lblEtapNowa.AutoSize = true;
            this.lblEtapNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEtapNowa.Location = new System.Drawing.Point(23, 40);
            this.lblEtapNowa.Name = "lblEtapNowa";
            this.lblEtapNowa.Size = new System.Drawing.Size(94, 18);
            this.lblEtapNowa.TabIndex = 39;
            this.lblEtapNowa.Text = "Nazwa etapu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Kliknij na realizację, aby ją edytować";
            // 
            // mtbDataKontroliNowa
            // 
            this.mtbDataKontroliNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbDataKontroliNowa.Location = new System.Drawing.Point(167, 134);
            this.mtbDataKontroliNowa.Mask = "00/00/0000 00:00:00";
            this.mtbDataKontroliNowa.Name = "mtbDataKontroliNowa";
            this.mtbDataKontroliNowa.Size = new System.Drawing.Size(158, 24);
            this.mtbDataKontroliNowa.TabIndex = 51;
            // 
            // btnDzisKontrolaNowa
            // 
            this.btnDzisKontrolaNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzisKontrolaNowa.Location = new System.Drawing.Point(342, 136);
            this.btnDzisKontrolaNowa.Name = "btnDzisKontrolaNowa";
            this.btnDzisKontrolaNowa.Size = new System.Drawing.Size(43, 23);
            this.btnDzisKontrolaNowa.TabIndex = 50;
            this.btnDzisKontrolaNowa.Text = "Dziś";
            this.btnDzisKontrolaNowa.UseVisualStyleBackColor = true;
            this.btnDzisKontrolaNowa.Click += new System.EventHandler(this.btnDzisKontrolaNowa_Click);
            // 
            // lblDataKontroliNowa
            // 
            this.lblDataKontroliNowa.AutoSize = true;
            this.lblDataKontroliNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataKontroliNowa.Location = new System.Drawing.Point(23, 137);
            this.lblDataKontroliNowa.Name = "lblDataKontroliNowa";
            this.lblDataKontroliNowa.Size = new System.Drawing.Size(92, 18);
            this.lblDataKontroliNowa.TabIndex = 49;
            this.lblDataKontroliNowa.Text = "Data kontroli";
            // 
            // tbUwagiKontrolaNowa
            // 
            this.tbUwagiKontrolaNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUwagiKontrolaNowa.Location = new System.Drawing.Point(167, 171);
            this.tbUwagiKontrolaNowa.Multiline = true;
            this.tbUwagiKontrolaNowa.Name = "tbUwagiKontrolaNowa";
            this.tbUwagiKontrolaNowa.Size = new System.Drawing.Size(216, 50);
            this.tbUwagiKontrolaNowa.TabIndex = 52;
            // 
            // lblUwagiNowa
            // 
            this.lblUwagiNowa.AutoSize = true;
            this.lblUwagiNowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUwagiNowa.Location = new System.Drawing.Point(23, 171);
            this.lblUwagiNowa.Name = "lblUwagiNowa";
            this.lblUwagiNowa.Size = new System.Drawing.Size(123, 18);
            this.lblUwagiNowa.TabIndex = 53;
            this.lblUwagiNowa.Text = "Uwagi do kontroli";
            // 
            // lblKontrolaEdycja
            // 
            this.lblKontrolaEdycja.AutoSize = true;
            this.lblKontrolaEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKontrolaEdycja.Location = new System.Drawing.Point(23, 172);
            this.lblKontrolaEdycja.Name = "lblKontrolaEdycja";
            this.lblKontrolaEdycja.Size = new System.Drawing.Size(123, 18);
            this.lblKontrolaEdycja.TabIndex = 59;
            this.lblKontrolaEdycja.Text = "Uwagi do kontroli";
            // 
            // tbUwagiKontrolaEdycja
            // 
            this.tbUwagiKontrolaEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUwagiKontrolaEdycja.Location = new System.Drawing.Point(167, 172);
            this.tbUwagiKontrolaEdycja.Multiline = true;
            this.tbUwagiKontrolaEdycja.Name = "tbUwagiKontrolaEdycja";
            this.tbUwagiKontrolaEdycja.Size = new System.Drawing.Size(216, 50);
            this.tbUwagiKontrolaEdycja.TabIndex = 58;
            // 
            // mtbDataKontroliEdycja
            // 
            this.mtbDataKontroliEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbDataKontroliEdycja.Location = new System.Drawing.Point(167, 135);
            this.mtbDataKontroliEdycja.Mask = "00/00/0000 00:00:00";
            this.mtbDataKontroliEdycja.Name = "mtbDataKontroliEdycja";
            this.mtbDataKontroliEdycja.Size = new System.Drawing.Size(158, 24);
            this.mtbDataKontroliEdycja.TabIndex = 57;
            // 
            // btnDzisKontrolaEdycja
            // 
            this.btnDzisKontrolaEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzisKontrolaEdycja.Location = new System.Drawing.Point(342, 137);
            this.btnDzisKontrolaEdycja.Name = "btnDzisKontrolaEdycja";
            this.btnDzisKontrolaEdycja.Size = new System.Drawing.Size(43, 23);
            this.btnDzisKontrolaEdycja.TabIndex = 56;
            this.btnDzisKontrolaEdycja.Text = "Dziś";
            this.btnDzisKontrolaEdycja.UseVisualStyleBackColor = true;
            this.btnDzisKontrolaEdycja.Click += new System.EventHandler(this.btnDzisKontrolaEdycja_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Data kontroli";
            // 
            // lblOpisGwiazdkiEdycja
            // 
            this.lblOpisGwiazdkiEdycja.AutoSize = true;
            this.lblOpisGwiazdkiEdycja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisGwiazdkiEdycja.Location = new System.Drawing.Point(23, 227);
            this.lblOpisGwiazdkiEdycja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpisGwiazdkiEdycja.Name = "lblOpisGwiazdkiEdycja";
            this.lblOpisGwiazdkiEdycja.Size = new System.Drawing.Size(116, 17);
            this.lblOpisGwiazdkiEdycja.TabIndex = 54;
            this.lblOpisGwiazdkiEdycja.Text = "* Pole wymagane";
            // 
            // RealizacjaProcesu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1255, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxNowa);
            this.Controls.Add(this.gbxEdycja);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.btnNowa);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.lblProces);
            this.Controls.Add(this.dgvRealizacjaProcesu);
            this.Name = "RealizacjaProcesu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizacja procesu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealizacjaProcesu)).EndInit();
            this.gbxEdycja.ResumeLayout(false);
            this.gbxEdycja.PerformLayout();
            this.gbxNowa.ResumeLayout(false);
            this.gbxNowa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRealizacjaProcesu;
        private System.Windows.Forms.Label lblProces;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnNowa;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblGwiazdkaEdycja;
        private System.Windows.Forms.MaskedTextBox mtbDataZakonczeniaEdycja;
        private System.Windows.Forms.Button btnDzisZakonczenieEdycja;
        private System.Windows.Forms.MaskedTextBox mtbDataRozpoczeciaEdycja;
        private System.Windows.Forms.Button btnDzisRozpoczecieEdycja;
        private System.Windows.Forms.Label lblDataZakonczeniaEdycja;
        private System.Windows.Forms.Label lblDataRozpoczeciaEdycja;
        private System.Windows.Forms.ComboBox cbxEtapEdycja;
        private System.Windows.Forms.Label lblEtapEdycja;
        private System.Windows.Forms.GroupBox gbxEdycja;
        private System.Windows.Forms.GroupBox gbxNowa;
        private System.Windows.Forms.Label lblOpisGwiazdkiNowa;
        private System.Windows.Forms.Label lblGwiazdkaNowa;
        private System.Windows.Forms.MaskedTextBox mtbDataZakonczeniaNowa;
        private System.Windows.Forms.Button btnDataZakonczeniaNowa;
        private System.Windows.Forms.MaskedTextBox mtbDataRozpoczeciaNowa;
        private System.Windows.Forms.Button btnDataRozpoczeciaNowa;
        private System.Windows.Forms.Label lblDataZakonczeniaNowa;
        private System.Windows.Forms.Label lblDataRozpoczeciaNowa;
        private System.Windows.Forms.ComboBox cbxEtapNowa;
        private System.Windows.Forms.Label lblEtapNowa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKontrolaEdycja;
        private System.Windows.Forms.TextBox tbUwagiKontrolaEdycja;
        private System.Windows.Forms.MaskedTextBox mtbDataKontroliEdycja;
        private System.Windows.Forms.Button btnDzisKontrolaEdycja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOpisGwiazdkiEdycja;
        private System.Windows.Forms.Label lblUwagiNowa;
        private System.Windows.Forms.TextBox tbUwagiKontrolaNowa;
        private System.Windows.Forms.MaskedTextBox mtbDataKontroliNowa;
        private System.Windows.Forms.Button btnDzisKontrolaNowa;
        private System.Windows.Forms.Label lblDataKontroliNowa;
    }
}