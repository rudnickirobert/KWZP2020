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
            this.tab_LiczbaMaszynWProcesie = new System.Windows.Forms.TabControl();
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
            this.tabpZarzadzanieParkiemMaszynowym = new System.Windows.Forms.TabPage();
            this.tabDodaj_nowa_maszyne = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabZnajdz_dodaj_proces_technologiczny = new System.Windows.Forms.TabPage();
            this.tabZnajdz_dodaj_dokumentacje = new System.Windows.Forms.TabPage();
            this.tabDokumentacje_w_procesie_technologicznym = new System.Windows.Forms.TabPage();
            this.tabDodaj_etap = new System.Windows.Forms.TabPage();
            this.tabDodaj_elementy = new System.Windows.Forms.TabPage();
            this.tabDodaj_maszyne = new System.Windows.Forms.TabPage();
            this.tabPrzypisz_proces_do_zamowienia = new System.Windows.Forms.TabPage();
            this.tab_LiczbaMaszynWProcesie.SuspendLayout();
            this.tabpProcesTechnologiczny.SuspendLayout();
            this.tabcWyszukajObsluge.SuspendLayout();
            this.tabZnajdz_dodaj_obsluge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObsluga)).BeginInit();
            this.tabpZarzadzanieParkiemMaszynowym.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_LiczbaMaszynWProcesie
            // 
            this.tab_LiczbaMaszynWProcesie.Controls.Add(this.tabpProcesTechnologiczny);
            this.tab_LiczbaMaszynWProcesie.Controls.Add(this.tabpZarzadzanieParkiemMaszynowym);
            this.tab_LiczbaMaszynWProcesie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tab_LiczbaMaszynWProcesie.Location = new System.Drawing.Point(12, 12);
            this.tab_LiczbaMaszynWProcesie.Name = "tab_LiczbaMaszynWProcesie";
            this.tab_LiczbaMaszynWProcesie.Padding = new System.Drawing.Point(30, 15);
            this.tab_LiczbaMaszynWProcesie.SelectedIndex = 0;
            this.tab_LiczbaMaszynWProcesie.Size = new System.Drawing.Size(1324, 698);
            this.tab_LiczbaMaszynWProcesie.TabIndex = 11;
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
            this.tabpProcesTechnologiczny.Size = new System.Drawing.Size(1316, 630);
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
            // tabpZarzadzanieParkiemMaszynowym
            // 
            this.tabpZarzadzanieParkiemMaszynowym.Controls.Add(this.tabControl1);
            this.tabpZarzadzanieParkiemMaszynowym.Location = new System.Drawing.Point(4, 64);
            this.tabpZarzadzanieParkiemMaszynowym.Name = "tabpZarzadzanieParkiemMaszynowym";
            this.tabpZarzadzanieParkiemMaszynowym.Padding = new System.Windows.Forms.Padding(3);
            this.tabpZarzadzanieParkiemMaszynowym.Size = new System.Drawing.Size(1316, 630);
            this.tabpZarzadzanieParkiemMaszynowym.TabIndex = 2;
            this.tabpZarzadzanieParkiemMaszynowym.Text = "Proces technologiczny";
            this.tabpZarzadzanieParkiemMaszynowym.UseVisualStyleBackColor = true;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabZnajdz_dodaj_proces_technologiczny);
            this.tabControl1.Controls.Add(this.tabZnajdz_dodaj_dokumentacje);
            this.tabControl1.Controls.Add(this.tabDokumentacje_w_procesie_technologicznym);
            this.tabControl1.Controls.Add(this.tabDodaj_etap);
            this.tabControl1.Controls.Add(this.tabDodaj_elementy);
            this.tabControl1.Controls.Add(this.tabDodaj_maszyne);
            this.tabControl1.Controls.Add(this.tabPrzypisz_proces_do_zamowienia);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(12, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1333, 627);
            this.tabControl1.TabIndex = 0;
            // 
            // tabZnajdz_dodaj_proces_technologiczny
            // 
            this.tabZnajdz_dodaj_proces_technologiczny.Location = new System.Drawing.Point(4, 39);
            this.tabZnajdz_dodaj_proces_technologiczny.Name = "tabZnajdz_dodaj_proces_technologiczny";
            this.tabZnajdz_dodaj_proces_technologiczny.Padding = new System.Windows.Forms.Padding(6);
            this.tabZnajdz_dodaj_proces_technologiczny.Size = new System.Drawing.Size(1325, 584);
            this.tabZnajdz_dodaj_proces_technologiczny.TabIndex = 0;
            this.tabZnajdz_dodaj_proces_technologiczny.Text = "Znajdź / dodaj proces technologiczny";
            this.tabZnajdz_dodaj_proces_technologiczny.UseVisualStyleBackColor = true;
            // 
            // tabZnajdz_dodaj_dokumentacje
            // 
            this.tabZnajdz_dodaj_dokumentacje.Location = new System.Drawing.Point(4, 39);
            this.tabZnajdz_dodaj_dokumentacje.Name = "tabZnajdz_dodaj_dokumentacje";
            this.tabZnajdz_dodaj_dokumentacje.Padding = new System.Windows.Forms.Padding(3);
            this.tabZnajdz_dodaj_dokumentacje.Size = new System.Drawing.Size(1325, 584);
            this.tabZnajdz_dodaj_dokumentacje.TabIndex = 1;
            this.tabZnajdz_dodaj_dokumentacje.Text = "Znajdź / dodaj dokumentację ";
            this.tabZnajdz_dodaj_dokumentacje.UseVisualStyleBackColor = true;
            // 
            // tabDokumentacje_w_procesie_technologicznym
            // 
            this.tabDokumentacje_w_procesie_technologicznym.Location = new System.Drawing.Point(4, 39);
            this.tabDokumentacje_w_procesie_technologicznym.Name = "tabDokumentacje_w_procesie_technologicznym";
            this.tabDokumentacje_w_procesie_technologicznym.Size = new System.Drawing.Size(1325, 584);
            this.tabDokumentacje_w_procesie_technologicznym.TabIndex = 2;
            this.tabDokumentacje_w_procesie_technologicznym.Text = "Dokumentacja";
            this.tabDokumentacje_w_procesie_technologicznym.UseVisualStyleBackColor = true;
            // 
            // tabDodaj_etap
            // 
            this.tabDodaj_etap.Location = new System.Drawing.Point(4, 39);
            this.tabDodaj_etap.Name = "tabDodaj_etap";
            this.tabDodaj_etap.Size = new System.Drawing.Size(1325, 584);
            this.tabDodaj_etap.TabIndex = 3;
            this.tabDodaj_etap.Text = "Dodaj etap";
            this.tabDodaj_etap.UseVisualStyleBackColor = true;
            // 
            // tabDodaj_elementy
            // 
            this.tabDodaj_elementy.Location = new System.Drawing.Point(4, 39);
            this.tabDodaj_elementy.Name = "tabDodaj_elementy";
            this.tabDodaj_elementy.Size = new System.Drawing.Size(1325, 584);
            this.tabDodaj_elementy.TabIndex = 4;
            this.tabDodaj_elementy.Text = "Dodaj elementy";
            this.tabDodaj_elementy.UseVisualStyleBackColor = true;
            // 
            // tabDodaj_maszyne
            // 
            this.tabDodaj_maszyne.Location = new System.Drawing.Point(4, 39);
            this.tabDodaj_maszyne.Name = "tabDodaj_maszyne";
            this.tabDodaj_maszyne.Size = new System.Drawing.Size(1325, 584);
            this.tabDodaj_maszyne.TabIndex = 5;
            this.tabDodaj_maszyne.Text = "Dodaj maszynę";
            this.tabDodaj_maszyne.UseVisualStyleBackColor = true;
            // 
            // tabPrzypisz_proces_do_zamowienia
            // 
            this.tabPrzypisz_proces_do_zamowienia.Location = new System.Drawing.Point(4, 39);
            this.tabPrzypisz_proces_do_zamowienia.Name = "tabPrzypisz_proces_do_zamowienia";
            this.tabPrzypisz_proces_do_zamowienia.Size = new System.Drawing.Size(1325, 584);
            this.tabPrzypisz_proces_do_zamowienia.TabIndex = 6;
            this.tabPrzypisz_proces_do_zamowienia.Text = "Przypisz proces do zamówienia";
            this.tabPrzypisz_proces_do_zamowienia.UseVisualStyleBackColor = true;
            // 
            // PrzygotowanieProdukcji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 743);
            this.Controls.Add(this.tab_LiczbaMaszynWProcesie);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrzygotowanieProdukcji";
            this.Text = "Przygotowanie_Produkcji";
            this.tab_LiczbaMaszynWProcesie.ResumeLayout(false);
            this.tabpProcesTechnologiczny.ResumeLayout(false);
            this.tabcWyszukajObsluge.ResumeLayout(false);
            this.tabZnajdz_dodaj_obsluge.ResumeLayout(false);
            this.tabZnajdz_dodaj_obsluge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObsluga)).EndInit();
            this.tabpZarzadzanieParkiemMaszynowym.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tab_LiczbaMaszynWProcesie;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabZnajdz_dodaj_proces_technologiczny;
        private System.Windows.Forms.TabPage tabZnajdz_dodaj_dokumentacje;
        private System.Windows.Forms.TabPage tabDokumentacje_w_procesie_technologicznym;
        private System.Windows.Forms.TabPage tabDodaj_etap;
        private System.Windows.Forms.TabPage tabDodaj_elementy;
        private System.Windows.Forms.TabPage tabDodaj_maszyne;
        private System.Windows.Forms.TabPage tabPrzypisz_proces_do_zamowienia;
    }
}