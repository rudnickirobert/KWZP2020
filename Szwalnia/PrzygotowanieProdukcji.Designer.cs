namespace Szwalnia
{
    partial class PrzygotowanieProdukcji
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_Proces_technologiczny = new System.Windows.Forms.TabControl();
            this.tabpProcesTechnologiczny = new System.Windows.Forms.TabPage();
            this.tabcWyszukajObsluge = new System.Windows.Forms.TabControl();
            this.tabSerwis_maszyn = new System.Windows.Forms.TabPage();
            this.tabZnajdz_dodaj_obsluge = new System.Windows.Forms.TabPage();
            this.dgvObsluga = new System.Windows.Forms.DataGridView();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtPracownik = new System.Windows.Forms.TextBox();
            this.txtMaszyna = new System.Windows.Forms.TextBox();
            this.txtRodzaj = new System.Windows.Forms.TextBox();
            this.lblDataWykoania = new System.Windows.Forms.Label();
            this.lblPracownik = new System.Windows.Forms.Label();
            this.lblMaszyna = new System.Windows.Forms.Label();
            this.lblRodzaj = new System.Windows.Forms.Label();
            this.cmbRodzajObslugi = new System.Windows.Forms.ComboBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.tabDodaj_nowa_maszyne = new System.Windows.Forms.TabPage();
            this.tabpZarzadzanieParkiemMaszynowym = new System.Windows.Forms.TabPage();
            this.dgvProcesy = new System.Windows.Forms.DataGridView();
            this.btnSzukajZamowienie = new System.Windows.Forms.Button();
            this.nudNumerZamowienia = new System.Windows.Forms.NumericUpDown();
            this.lblNapis = new System.Windows.Forms.Label();
            this.tabcZamowienia = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvZamowienia = new System.Windows.Forms.DataGridView();
            this.tabZnajdz_dodaj_proces_technologiczny = new System.Windows.Forms.TabPage();
            this.tabZnajdz_dodaj_dokumentacje = new System.Windows.Forms.TabPage();
            this.tabDokumentacje_w_procesie_technologicznym = new System.Windows.Forms.TabPage();
            this.tabDodaj_etap = new System.Windows.Forms.TabPage();
            this.tabDodaj_elementy = new System.Windows.Forms.TabPage();
            this.tabDodaj_maszyne = new System.Windows.Forms.TabPage();
            this.tabPrzypisz_proces_do_zamowienia = new System.Windows.Forms.TabPage();
            this.tabZatwierdzenie_procesu = new System.Windows.Forms.TabPage();
            this.dgvProcesy2 = new System.Windows.Forms.DataGridView();
            this.btnSzukajProces = new System.Windows.Forms.Button();
            this.nudNumerProcesu = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOpisNumer = new System.Windows.Forms.Label();
            this.lblNazwaProcesu = new System.Windows.Forms.Label();
            this.lblCzasTrwania = new System.Windows.Forms.Label();
            this.tbProponowanaData = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnWyzeruj = new System.Windows.Forms.Button();
            this.lblNumerProcesu = new System.Windows.Forms.Label();
            this.cmbProcesy = new System.Windows.Forms.ComboBox();
            this.tab_Proces_technologiczny.SuspendLayout();
            this.tabpProcesTechnologiczny.SuspendLayout();
            this.tabcWyszukajObsluge.SuspendLayout();
            this.tabZnajdz_dodaj_obsluge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObsluga)).BeginInit();
            this.tabpZarzadzanieParkiemMaszynowym.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerZamowienia)).BeginInit();
            this.tabcZamowienia.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).BeginInit();
            this.tabZnajdz_dodaj_proces_technologiczny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerProcesu)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Proces_technologiczny
            // 
            this.tab_Proces_technologiczny.Controls.Add(this.tabpProcesTechnologiczny);
            this.tab_Proces_technologiczny.Controls.Add(this.tabpZarzadzanieParkiemMaszynowym);
            this.tab_Proces_technologiczny.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tab_Proces_technologiczny.Location = new System.Drawing.Point(12, 12);
            this.tab_Proces_technologiczny.Name = "tab_Proces_technologiczny";
            this.tab_Proces_technologiczny.Padding = new System.Drawing.Point(30, 15);
            this.tab_Proces_technologiczny.SelectedIndex = 0;
            this.tab_Proces_technologiczny.Size = new System.Drawing.Size(1452, 698);
            this.tab_Proces_technologiczny.TabIndex = 11;
            this.tab_Proces_technologiczny.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tab_Proces_technologiczny_MouseClick);
            // 
            // tabpProcesTechnologiczny
            // 
            this.tabpProcesTechnologiczny.BackColor = System.Drawing.Color.Transparent;
            this.tabpProcesTechnologiczny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabpProcesTechnologiczny.Controls.Add(this.tabcWyszukajObsluge);
            this.tabpProcesTechnologiczny.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabpProcesTechnologiczny.Location = new System.Drawing.Point(4, 64);
            this.tabpProcesTechnologiczny.Margin = new System.Windows.Forms.Padding(6);
            this.tabpProcesTechnologiczny.Name = "tabpProcesTechnologiczny";
            this.tabpProcesTechnologiczny.Padding = new System.Windows.Forms.Padding(6);
            this.tabpProcesTechnologiczny.Size = new System.Drawing.Size(1444, 630);
            this.tabpProcesTechnologiczny.TabIndex = 1;
            this.tabpProcesTechnologiczny.Text = "Zarządzanie parkiem maszynowym";
            // 
            // tabcWyszukajObsluge
            // 
            this.tabcWyszukajObsluge.Controls.Add(this.tabSerwis_maszyn);
            this.tabcWyszukajObsluge.Controls.Add(this.tabZnajdz_dodaj_obsluge);
            this.tabcWyszukajObsluge.Controls.Add(this.tabDodaj_nowa_maszyne);
            this.tabcWyszukajObsluge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabcWyszukajObsluge.Location = new System.Drawing.Point(-1, 2);
            this.tabcWyszukajObsluge.Margin = new System.Windows.Forms.Padding(10);
            this.tabcWyszukajObsluge.Name = "tabcWyszukajObsluge";
            this.tabcWyszukajObsluge.Padding = new System.Drawing.Point(10, 10);
            this.tabcWyszukajObsluge.SelectedIndex = 0;
            this.tabcWyszukajObsluge.Size = new System.Drawing.Size(1217, 662);
            this.tabcWyszukajObsluge.TabIndex = 11;
            // 
            // tabSerwis_maszyn
            // 
            this.tabSerwis_maszyn.Location = new System.Drawing.Point(4, 47);
            this.tabSerwis_maszyn.Name = "tabSerwis_maszyn";
            this.tabSerwis_maszyn.Padding = new System.Windows.Forms.Padding(3);
            this.tabSerwis_maszyn.Size = new System.Drawing.Size(1209, 611);
            this.tabSerwis_maszyn.TabIndex = 1;
            this.tabSerwis_maszyn.Text = "Serwis maszyn";
            this.tabSerwis_maszyn.UseVisualStyleBackColor = true;
            // 
            // tabZnajdz_dodaj_obsluge
            // 
            this.tabZnajdz_dodaj_obsluge.Controls.Add(this.dgvObsluga);
            this.tabZnajdz_dodaj_obsluge.Controls.Add(this.txtData);
            this.tabZnajdz_dodaj_obsluge.Controls.Add(this.txtPracownik);
            this.tabZnajdz_dodaj_obsluge.Controls.Add(this.txtMaszyna);
            this.tabZnajdz_dodaj_obsluge.Controls.Add(this.txtRodzaj);
            this.tabZnajdz_dodaj_obsluge.Controls.Add(this.lblDataWykoania);
            this.tabZnajdz_dodaj_obsluge.Controls.Add(this.lblPracownik);
            this.tabZnajdz_dodaj_obsluge.Controls.Add(this.lblMaszyna);
            this.tabZnajdz_dodaj_obsluge.Controls.Add(this.lblRodzaj);
            this.tabZnajdz_dodaj_obsluge.Controls.Add(this.cmbRodzajObslugi);
            this.tabZnajdz_dodaj_obsluge.Controls.Add(this.lblOpis);
            this.tabZnajdz_dodaj_obsluge.Controls.Add(this.btnSzukaj);
            this.tabZnajdz_dodaj_obsluge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabZnajdz_dodaj_obsluge.Location = new System.Drawing.Point(4, 47);
            this.tabZnajdz_dodaj_obsluge.Name = "tabZnajdz_dodaj_obsluge";
            this.tabZnajdz_dodaj_obsluge.Padding = new System.Windows.Forms.Padding(3);
            this.tabZnajdz_dodaj_obsluge.Size = new System.Drawing.Size(1209, 611);
            this.tabZnajdz_dodaj_obsluge.TabIndex = 0;
            this.tabZnajdz_dodaj_obsluge.Text = "Znajdź / dodaj obsługę";
            this.tabZnajdz_dodaj_obsluge.UseVisualStyleBackColor = true;
            // 
            // dgvObsluga
            // 
            this.dgvObsluga.AllowUserToAddRows = false;
            this.dgvObsluga.AllowUserToDeleteRows = false;
            this.dgvObsluga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObsluga.Location = new System.Drawing.Point(29, 259);
            this.dgvObsluga.Margin = new System.Windows.Forms.Padding(2);
            this.dgvObsluga.Name = "dgvObsluga";
            this.dgvObsluga.ReadOnly = true;
            this.dgvObsluga.RowHeadersWidth = 51;
            this.dgvObsluga.RowTemplate.Height = 24;
            this.dgvObsluga.Size = new System.Drawing.Size(1110, 236);
            this.dgvObsluga.TabIndex = 48;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(248, 203);
            this.txtData.Margin = new System.Windows.Forms.Padding(2);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(213, 24);
            this.txtData.TabIndex = 47;
            // 
            // txtPracownik
            // 
            this.txtPracownik.Location = new System.Drawing.Point(248, 180);
            this.txtPracownik.Margin = new System.Windows.Forms.Padding(2);
            this.txtPracownik.Name = "txtPracownik";
            this.txtPracownik.Size = new System.Drawing.Size(213, 24);
            this.txtPracownik.TabIndex = 46;
            // 
            // txtMaszyna
            // 
            this.txtMaszyna.Location = new System.Drawing.Point(248, 151);
            this.txtMaszyna.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaszyna.Name = "txtMaszyna";
            this.txtMaszyna.Size = new System.Drawing.Size(213, 24);
            this.txtMaszyna.TabIndex = 45;
            // 
            // txtRodzaj
            // 
            this.txtRodzaj.Location = new System.Drawing.Point(248, 125);
            this.txtRodzaj.Margin = new System.Windows.Forms.Padding(2);
            this.txtRodzaj.Name = "txtRodzaj";
            this.txtRodzaj.Size = new System.Drawing.Size(213, 24);
            this.txtRodzaj.TabIndex = 44;
            // 
            // lblDataWykoania
            // 
            this.lblDataWykoania.AutoSize = true;
            this.lblDataWykoania.Location = new System.Drawing.Point(42, 203);
            this.lblDataWykoania.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataWykoania.Name = "lblDataWykoania";
            this.lblDataWykoania.Size = new System.Drawing.Size(117, 18);
            this.lblDataWykoania.TabIndex = 43;
            this.lblDataWykoania.Text = "Data Wykonania";
            // 
            // lblPracownik
            // 
            this.lblPracownik.AutoSize = true;
            this.lblPracownik.Location = new System.Drawing.Point(42, 180);
            this.lblPracownik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPracownik.Name = "lblPracownik";
            this.lblPracownik.Size = new System.Drawing.Size(78, 18);
            this.lblPracownik.TabIndex = 42;
            this.lblPracownik.Text = "Pracownik";
            // 
            // lblMaszyna
            // 
            this.lblMaszyna.AutoSize = true;
            this.lblMaszyna.Location = new System.Drawing.Point(42, 151);
            this.lblMaszyna.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaszyna.Name = "lblMaszyna";
            this.lblMaszyna.Size = new System.Drawing.Size(68, 18);
            this.lblMaszyna.TabIndex = 41;
            this.lblMaszyna.Text = "Maszyna";
            // 
            // lblRodzaj
            // 
            this.lblRodzaj.AutoSize = true;
            this.lblRodzaj.Location = new System.Drawing.Point(42, 125);
            this.lblRodzaj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRodzaj.Name = "lblRodzaj";
            this.lblRodzaj.Size = new System.Drawing.Size(55, 18);
            this.lblRodzaj.TabIndex = 40;
            this.lblRodzaj.Text = "Rodzaj";
            // 
            // cmbRodzajObslugi
            // 
            this.cmbRodzajObslugi.FormattingEnabled = true;
            this.cmbRodzajObslugi.Location = new System.Drawing.Point(426, 36);
            this.cmbRodzajObslugi.Name = "cmbRodzajObslugi";
            this.cmbRodzajObslugi.Size = new System.Drawing.Size(170, 26);
            this.cmbRodzajObslugi.TabIndex = 22;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(24, 36);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(248, 18);
            this.lblOpis.TabIndex = 21;
            this.lblOpis.Text = "Wybierz rodzaj osbługi jaki szukasz ";
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(658, 36);
            this.btnSzukaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(183, 33);
            this.btnSzukaj.TabIndex = 18;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // tabDodaj_nowa_maszyne
            // 
            this.tabDodaj_nowa_maszyne.Location = new System.Drawing.Point(4, 47);
            this.tabDodaj_nowa_maszyne.Name = "tabDodaj_nowa_maszyne";
            this.tabDodaj_nowa_maszyne.Size = new System.Drawing.Size(1209, 611);
            this.tabDodaj_nowa_maszyne.TabIndex = 2;
            this.tabDodaj_nowa_maszyne.Text = "Dodaj nową maszynę";
            this.tabDodaj_nowa_maszyne.UseVisualStyleBackColor = true;
            // 
            // tabpZarzadzanieParkiemMaszynowym
            // 
            this.tabpZarzadzanieParkiemMaszynowym.Controls.Add(this.dgvProcesy);
            this.tabpZarzadzanieParkiemMaszynowym.Controls.Add(this.btnSzukajZamowienie);
            this.tabpZarzadzanieParkiemMaszynowym.Controls.Add(this.nudNumerZamowienia);
            this.tabpZarzadzanieParkiemMaszynowym.Controls.Add(this.lblNapis);
            this.tabpZarzadzanieParkiemMaszynowym.Controls.Add(this.tabcZamowienia);
            this.tabpZarzadzanieParkiemMaszynowym.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabpZarzadzanieParkiemMaszynowym.Location = new System.Drawing.Point(4, 64);
            this.tabpZarzadzanieParkiemMaszynowym.Name = "tabpZarzadzanieParkiemMaszynowym";
            this.tabpZarzadzanieParkiemMaszynowym.Padding = new System.Windows.Forms.Padding(3);
            this.tabpZarzadzanieParkiemMaszynowym.Size = new System.Drawing.Size(1444, 630);
            this.tabpZarzadzanieParkiemMaszynowym.TabIndex = 2;
            this.tabpZarzadzanieParkiemMaszynowym.Text = "Proces technologiczny";
            this.tabpZarzadzanieParkiemMaszynowym.UseVisualStyleBackColor = true;
            // 
            // dgvProcesy
            // 
            this.dgvProcesy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcesy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcesy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcesy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesy.Location = new System.Drawing.Point(9, 47);
            this.dgvProcesy.Name = "dgvProcesy";
            this.dgvProcesy.RowTemplate.Height = 30;
            this.dgvProcesy.Size = new System.Drawing.Size(1379, 95);
            this.dgvProcesy.TabIndex = 7;
            // 
            // btnSzukajZamowienie
            // 
            this.btnSzukajZamowienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukajZamowienie.Location = new System.Drawing.Point(412, 11);
            this.btnSzukajZamowienie.Name = "btnSzukajZamowienie";
            this.btnSzukajZamowienie.Size = new System.Drawing.Size(92, 30);
            this.btnSzukajZamowienie.TabIndex = 6;
            this.btnSzukajZamowienie.Text = "SZUKAJ";
            this.btnSzukajZamowienie.UseVisualStyleBackColor = true;
            this.btnSzukajZamowienie.Click += new System.EventHandler(this.btnSzukajZamowienie_Click);
            // 
            // nudNumerZamowienia
            // 
            this.nudNumerZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudNumerZamowienia.Location = new System.Drawing.Point(285, 14);
            this.nudNumerZamowienia.Name = "nudNumerZamowienia";
            this.nudNumerZamowienia.Size = new System.Drawing.Size(99, 22);
            this.nudNumerZamowienia.TabIndex = 5;
            // 
            // lblNapis
            // 
            this.lblNapis.AutoSize = true;
            this.lblNapis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNapis.Location = new System.Drawing.Point(29, 16);
            this.lblNapis.Name = "lblNapis";
            this.lblNapis.Size = new System.Drawing.Size(220, 20);
            this.lblNapis.TabIndex = 4;
            this.lblNapis.Text = "Wprowadź numer zamówienia";
            // 
            // tabcZamowienia
            // 
            this.tabcZamowienia.Controls.Add(this.tabPage1);
            this.tabcZamowienia.Controls.Add(this.tabZnajdz_dodaj_proces_technologiczny);
            this.tabcZamowienia.Controls.Add(this.tabZnajdz_dodaj_dokumentacje);
            this.tabcZamowienia.Controls.Add(this.tabDokumentacje_w_procesie_technologicznym);
            this.tabcZamowienia.Controls.Add(this.tabDodaj_etap);
            this.tabcZamowienia.Controls.Add(this.tabDodaj_elementy);
            this.tabcZamowienia.Controls.Add(this.tabDodaj_maszyne);
            this.tabcZamowienia.Controls.Add(this.tabPrzypisz_proces_do_zamowienia);
            this.tabcZamowienia.Controls.Add(this.tabZatwierdzenie_procesu);
            this.tabcZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabcZamowienia.Location = new System.Drawing.Point(0, 145);
            this.tabcZamowienia.Margin = new System.Windows.Forms.Padding(6);
            this.tabcZamowienia.Name = "tabcZamowienia";
            this.tabcZamowienia.Padding = new System.Drawing.Point(8, 8);
            this.tabcZamowienia.SelectedIndex = 0;
            this.tabcZamowienia.Size = new System.Drawing.Size(1439, 479);
            this.tabcZamowienia.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvZamowienia);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1431, 436);
            this.tabPage1.TabIndex = 8;
            this.tabPage1.Text = "Zamówienia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvZamowienia
            // 
            this.dgvZamowienia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZamowienia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamowienia.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvZamowienia.Location = new System.Drawing.Point(3, 3);
            this.dgvZamowienia.Margin = new System.Windows.Forms.Padding(6);
            this.dgvZamowienia.Name = "dgvZamowienia";
            this.dgvZamowienia.RowTemplate.Height = 30;
            this.dgvZamowienia.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZamowienia.Size = new System.Drawing.Size(1381, 434);
            this.dgvZamowienia.TabIndex = 0;
            // 
            // tabZnajdz_dodaj_proces_technologiczny
            // 
            this.tabZnajdz_dodaj_proces_technologiczny.Controls.Add(this.cmbProcesy);
            this.tabZnajdz_dodaj_proces_technologiczny.Controls.Add(this.lblNumerProcesu);
            this.tabZnajdz_dodaj_proces_technologiczny.Controls.Add(this.btnWyzeruj);
            this.tabZnajdz_dodaj_proces_technologiczny.Controls.Add(this.btnZapisz);
            this.tabZnajdz_dodaj_proces_technologiczny.Controls.Add(this.tbProponowanaData);
            this.tabZnajdz_dodaj_proces_technologiczny.Controls.Add(this.lblCzasTrwania);
            this.tabZnajdz_dodaj_proces_technologiczny.Controls.Add(this.lblNazwaProcesu);
            this.tabZnajdz_dodaj_proces_technologiczny.Controls.Add(this.lblOpisNumer);
            this.tabZnajdz_dodaj_proces_technologiczny.Controls.Add(this.btnSzukajProces);
            this.tabZnajdz_dodaj_proces_technologiczny.Controls.Add(this.nudNumerProcesu);
            this.tabZnajdz_dodaj_proces_technologiczny.Controls.Add(this.label1);
            this.tabZnajdz_dodaj_proces_technologiczny.Controls.Add(this.dgvProcesy2);
            this.tabZnajdz_dodaj_proces_technologiczny.Location = new System.Drawing.Point(4, 39);
            this.tabZnajdz_dodaj_proces_technologiczny.Name = "tabZnajdz_dodaj_proces_technologiczny";
            this.tabZnajdz_dodaj_proces_technologiczny.Padding = new System.Windows.Forms.Padding(6);
            this.tabZnajdz_dodaj_proces_technologiczny.Size = new System.Drawing.Size(1431, 436);
            this.tabZnajdz_dodaj_proces_technologiczny.TabIndex = 0;
            this.tabZnajdz_dodaj_proces_technologiczny.Text = "Znajdź/dodaj proces technologiczny";
            this.tabZnajdz_dodaj_proces_technologiczny.UseVisualStyleBackColor = true;
            // 
            // tabZnajdz_dodaj_dokumentacje
            // 
            this.tabZnajdz_dodaj_dokumentacje.Location = new System.Drawing.Point(4, 39);
            this.tabZnajdz_dodaj_dokumentacje.Name = "tabZnajdz_dodaj_dokumentacje";
            this.tabZnajdz_dodaj_dokumentacje.Padding = new System.Windows.Forms.Padding(3);
            this.tabZnajdz_dodaj_dokumentacje.Size = new System.Drawing.Size(1431, 436);
            this.tabZnajdz_dodaj_dokumentacje.TabIndex = 1;
            this.tabZnajdz_dodaj_dokumentacje.Text = "Znajdź/dodaj dokumentację ";
            this.tabZnajdz_dodaj_dokumentacje.UseVisualStyleBackColor = true;
            // 
            // tabDokumentacje_w_procesie_technologicznym
            // 
            this.tabDokumentacje_w_procesie_technologicznym.Location = new System.Drawing.Point(4, 39);
            this.tabDokumentacje_w_procesie_technologicznym.Name = "tabDokumentacje_w_procesie_technologicznym";
            this.tabDokumentacje_w_procesie_technologicznym.Size = new System.Drawing.Size(1431, 436);
            this.tabDokumentacje_w_procesie_technologicznym.TabIndex = 2;
            this.tabDokumentacje_w_procesie_technologicznym.Text = "Dokumentacja";
            this.tabDokumentacje_w_procesie_technologicznym.UseVisualStyleBackColor = true;
            // 
            // tabDodaj_etap
            // 
            this.tabDodaj_etap.Location = new System.Drawing.Point(4, 39);
            this.tabDodaj_etap.Name = "tabDodaj_etap";
            this.tabDodaj_etap.Size = new System.Drawing.Size(1431, 436);
            this.tabDodaj_etap.TabIndex = 3;
            this.tabDodaj_etap.Text = "Dodaj etap";
            this.tabDodaj_etap.UseVisualStyleBackColor = true;
            // 
            // tabDodaj_elementy
            // 
            this.tabDodaj_elementy.Location = new System.Drawing.Point(4, 39);
            this.tabDodaj_elementy.Name = "tabDodaj_elementy";
            this.tabDodaj_elementy.Size = new System.Drawing.Size(1431, 436);
            this.tabDodaj_elementy.TabIndex = 4;
            this.tabDodaj_elementy.Text = "Dodaj elementy";
            this.tabDodaj_elementy.UseVisualStyleBackColor = true;
            // 
            // tabDodaj_maszyne
            // 
            this.tabDodaj_maszyne.Location = new System.Drawing.Point(4, 39);
            this.tabDodaj_maszyne.Name = "tabDodaj_maszyne";
            this.tabDodaj_maszyne.Size = new System.Drawing.Size(1431, 436);
            this.tabDodaj_maszyne.TabIndex = 5;
            this.tabDodaj_maszyne.Text = "Dodaj maszynę";
            this.tabDodaj_maszyne.UseVisualStyleBackColor = true;
            // 
            // tabPrzypisz_proces_do_zamowienia
            // 
            this.tabPrzypisz_proces_do_zamowienia.Location = new System.Drawing.Point(4, 39);
            this.tabPrzypisz_proces_do_zamowienia.Name = "tabPrzypisz_proces_do_zamowienia";
            this.tabPrzypisz_proces_do_zamowienia.Size = new System.Drawing.Size(1431, 436);
            this.tabPrzypisz_proces_do_zamowienia.TabIndex = 6;
            this.tabPrzypisz_proces_do_zamowienia.Text = "Przypisz proces do zamówienia";
            this.tabPrzypisz_proces_do_zamowienia.UseVisualStyleBackColor = true;
            // 
            // tabZatwierdzenie_procesu
            // 
            this.tabZatwierdzenie_procesu.Location = new System.Drawing.Point(4, 39);
            this.tabZatwierdzenie_procesu.Name = "tabZatwierdzenie_procesu";
            this.tabZatwierdzenie_procesu.Size = new System.Drawing.Size(1431, 436);
            this.tabZatwierdzenie_procesu.TabIndex = 7;
            this.tabZatwierdzenie_procesu.Text = "Zatwierdzenie procesu";
            this.tabZatwierdzenie_procesu.UseVisualStyleBackColor = true;
            // 
            // dgvProcesy2
            // 
            this.dgvProcesy2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesy2.Location = new System.Drawing.Point(9, 78);
            this.dgvProcesy2.Name = "dgvProcesy2";
            this.dgvProcesy2.Size = new System.Drawing.Size(641, 349);
            this.dgvProcesy2.TabIndex = 0;
            // 
            // btnSzukajProces
            // 
            this.btnSzukajProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukajProces.Location = new System.Drawing.Point(408, 25);
            this.btnSzukajProces.Name = "btnSzukajProces";
            this.btnSzukajProces.Size = new System.Drawing.Size(92, 30);
            this.btnSzukajProces.TabIndex = 9;
            this.btnSzukajProces.Text = "SZUKAJ";
            this.btnSzukajProces.UseVisualStyleBackColor = true;
            this.btnSzukajProces.Click += new System.EventHandler(this.btnSzukajProces_Click);
            // 
            // nudNumerProcesu
            // 
            this.nudNumerProcesu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudNumerProcesu.Location = new System.Drawing.Point(281, 28);
            this.nudNumerProcesu.Name = "nudNumerProcesu";
            this.nudNumerProcesu.Size = new System.Drawing.Size(99, 22);
            this.nudNumerProcesu.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wprowadź numer procesu";
            // 
            // lblOpisNumer
            // 
            this.lblOpisNumer.AutoSize = true;
            this.lblOpisNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisNumer.Location = new System.Drawing.Point(765, 94);
            this.lblOpisNumer.Name = "lblOpisNumer";
            this.lblOpisNumer.Size = new System.Drawing.Size(200, 24);
            this.lblOpisNumer.TabIndex = 10;
            this.lblOpisNumer.Text = "ID nowego procesu to:";
            // 
            // lblNazwaProcesu
            // 
            this.lblNazwaProcesu.AutoSize = true;
            this.lblNazwaProcesu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaProcesu.Location = new System.Drawing.Point(750, 157);
            this.lblNazwaProcesu.Name = "lblNazwaProcesu";
            this.lblNazwaProcesu.Size = new System.Drawing.Size(114, 18);
            this.lblNazwaProcesu.TabIndex = 15;
            this.lblNazwaProcesu.Text = "Nazwa Procesu";
            // 
            // lblCzasTrwania
            // 
            this.lblCzasTrwania.AutoSize = true;
            this.lblCzasTrwania.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzasTrwania.Location = new System.Drawing.Point(750, 183);
            this.lblCzasTrwania.Name = "lblCzasTrwania";
            this.lblCzasTrwania.Size = new System.Drawing.Size(159, 18);
            this.lblCzasTrwania.TabIndex = 14;
            this.lblCzasTrwania.Text = "Czas trwania (godziny)";
            this.lblCzasTrwania.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbProponowanaData
            // 
            this.tbProponowanaData.Location = new System.Drawing.Point(1020, 181);
            this.tbProponowanaData.Name = "tbProponowanaData";
            this.tbProponowanaData.Size = new System.Drawing.Size(189, 27);
            this.tbProponowanaData.TabIndex = 19;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.Location = new System.Drawing.Point(903, 331);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(80, 50);
            this.btnZapisz.TabIndex = 23;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            // 
            // btnWyzeruj
            // 
            this.btnWyzeruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyzeruj.Location = new System.Drawing.Point(1034, 331);
            this.btnWyzeruj.Name = "btnWyzeruj";
            this.btnWyzeruj.Size = new System.Drawing.Size(80, 50);
            this.btnWyzeruj.TabIndex = 21;
            this.btnWyzeruj.Text = "Wyzeruj";
            this.btnWyzeruj.UseVisualStyleBackColor = true;
            // 
            // lblNumerProcesu
            // 
            this.lblNumerProcesu.AutoSize = true;
            this.lblNumerProcesu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumerProcesu.Location = new System.Drawing.Point(1030, 98);
            this.lblNumerProcesu.Name = "lblNumerProcesu";
            this.lblNumerProcesu.Size = new System.Drawing.Size(51, 20);
            this.lblNumerProcesu.TabIndex = 24;
            this.lblNumerProcesu.Text = "label1";
            // 
            // cmbProcesy
            // 
            this.cmbProcesy.FormattingEnabled = true;
            this.cmbProcesy.Location = new System.Drawing.Point(1020, 146);
            this.cmbProcesy.Name = "cmbProcesy";
            this.cmbProcesy.Size = new System.Drawing.Size(189, 28);
            this.cmbProcesy.TabIndex = 25;
           
            // 
            // PrzygotowanieProdukcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 743);
            this.Controls.Add(this.tab_Proces_technologiczny);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PrzygotowanieProdukcji";
            this.Text = "Przygotowanie_Produkcji";
            this.tab_Proces_technologiczny.ResumeLayout(false);
            this.tabpProcesTechnologiczny.ResumeLayout(false);
            this.tabcWyszukajObsluge.ResumeLayout(false);
            this.tabZnajdz_dodaj_obsluge.ResumeLayout(false);
            this.tabZnajdz_dodaj_obsluge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObsluga)).EndInit();
            this.tabpZarzadzanieParkiemMaszynowym.ResumeLayout(false);
            this.tabpZarzadzanieParkiemMaszynowym.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerZamowienia)).EndInit();
            this.tabcZamowienia.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamowienia)).EndInit();
            this.tabZnajdz_dodaj_proces_technologiczny.ResumeLayout(false);
            this.tabZnajdz_dodaj_proces_technologiczny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerProcesu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tab_Proces_technologiczny;
        private System.Windows.Forms.TabPage tabpProcesTechnologiczny;
        private System.Windows.Forms.TabControl tabcWyszukajObsluge;
        private System.Windows.Forms.TabPage tabSerwis_maszyn;
        private System.Windows.Forms.TabPage tabZnajdz_dodaj_obsluge;
        private System.Windows.Forms.DataGridView dgvObsluga;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtPracownik;
        private System.Windows.Forms.TextBox txtMaszyna;
        private System.Windows.Forms.TextBox txtRodzaj;
        private System.Windows.Forms.Label lblDataWykoania;
        private System.Windows.Forms.Label lblPracownik;
        private System.Windows.Forms.Label lblMaszyna;
        private System.Windows.Forms.Label lblRodzaj;
        private System.Windows.Forms.ComboBox cmbRodzajObslugi;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.TabPage tabpZarzadzanieParkiemMaszynowym;
        private System.Windows.Forms.TabPage tabDodaj_nowa_maszyne;
        private System.Windows.Forms.TabControl tabcZamowienia;
        private System.Windows.Forms.TabPage tabZnajdz_dodaj_proces_technologiczny;
        private System.Windows.Forms.TabPage tabZnajdz_dodaj_dokumentacje;
        private System.Windows.Forms.TabPage tabDokumentacje_w_procesie_technologicznym;
        private System.Windows.Forms.TabPage tabDodaj_etap;
        private System.Windows.Forms.TabPage tabDodaj_elementy;
        private System.Windows.Forms.TabPage tabDodaj_maszyne;
        private System.Windows.Forms.TabPage tabPrzypisz_proces_do_zamowienia;
        private System.Windows.Forms.TabPage tabZatwierdzenie_procesu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvZamowienia;
        private System.Windows.Forms.Button btnSzukajZamowienie;
        private System.Windows.Forms.NumericUpDown nudNumerZamowienia;
        private System.Windows.Forms.Label lblNapis;
        private System.Windows.Forms.DataGridView dgvProcesy;
        private System.Windows.Forms.DataGridView dgvProcesy2;
        private System.Windows.Forms.Button btnSzukajProces;
        private System.Windows.Forms.NumericUpDown nudNumerProcesu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProcesy;
        private System.Windows.Forms.Label lblNumerProcesu;
        private System.Windows.Forms.Button btnWyzeruj;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.TextBox tbProponowanaData;
        private System.Windows.Forms.Label lblCzasTrwania;
        private System.Windows.Forms.Label lblNazwaProcesu;
        private System.Windows.Forms.Label lblOpisNumer;
    }
}