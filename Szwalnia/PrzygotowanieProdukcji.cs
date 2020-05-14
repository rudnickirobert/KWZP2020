using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class PrzygotowanieProdukcji : Form
    {
       
        private SzwalniaEntities szwalnia;
        public int ostatniNumerZamowienia;
        public int ostatniNumerProcesu;
        public PrzygotowanieProdukcji(SzwalniaEntities db)

        {
            InitializeComponent();
            szwalnia = db;
            
            
            cmbRodzajObslugi.DataSource = db.Rodzaj_Obslugi.ToList();
            cmbRodzajObslugi.DisplayMember = "Nazwa";
            cmbRodzajObslugi.ValueMember = "Nazwa";

            dgvProcesy.DataSource = szwalnia.vProces_technologiczny.ToList();
            dgvZamowienia.DataSource = szwalnia.vProces_technologiczny.ToList();
            dgvProcesy2.DataSource = szwalnia.vProcesy.ToList();
            dgvProcesy3.DataSource = szwalnia.vElementy_proces.ToList();
            dgvProcesy4.DataSource = szwalnia.vDokumentacja_proces.ToList();
            

            int ostatniNumer = dgvProcesy.Rows.Cast<DataGridViewRow>().Max(wartosc => Convert.ToInt32(wartosc.Cells["Numer_zamówienia"].Value));
            ostatniNumerZamowienia = ostatniNumer;

            int ostatniNumerP = dgvProcesy2.Rows.Cast<DataGridViewRow>().Max(wartosc => Convert.ToInt32(wartosc.Cells["ID_Proces_Technologiczny"].Value));
            ostatniNumerProcesu = ostatniNumerP;

            cmbTechnolodzy.DataSource = szwalnia.Rodzaj_Etapu.ToList();
            cmbTechnolodzy.DisplayMember = "Nazwa";
            cmbTechnolodzy.ValueMember = "Nazwa";

            cmbRodzaj_Obslugi.ValueMember = "ID_Rodzaj_Obslugi";
            cmbRodzaj_Obslugi.DisplayMember = "Nazwa";
            cmbRodzaj_Obslugi.DataSource = szwalnia.Rodzaj_Obslugi.Distinct().ToList();
            cmbRodzaj_Obslugi.Invalidate();

            cmbPracownik.ValueMember = "ID_Pracownika";
            cmbPracownik.DisplayMember = "Nazwisko";   //zmienic na pełne imie (nie ma w widoku)
            cmbPracownik.DataSource = szwalnia.Pracownicy.Distinct().ToList(); //Widok gdzie jest pelne imie
            cmbPracownik.Invalidate();

            cmbID_Maszyny.ValueMember = "ID_Maszyny";
            cmbID_Maszyny.DisplayMember = "ID_Maszyny"; // zmienic na pelna (nie ma widoku)
            cmbID_Maszyny.DataSource = szwalnia.Maszyny.Distinct().ToList(); //tutaj wstawiamy widok ID_Maszyny+NrSeryjny
            cmbID_Maszyny.Invalidate();

            cmbTechnolodzy.DataSource = szwalnia.vTechnolodzy.ToList();
            cmbTechnolodzy.ValueMember = "ID_Pracownika";
            cmbTechnolodzy.DisplayMember = "Autor";

            cmbTechnolodzy2.DataSource = szwalnia.vTechnolodzy.ToList();
            cmbTechnolodzy2.ValueMember = "ID_Pracownika";
            cmbTechnolodzy2.DisplayMember = "Autor";

            cmbRodzaj_Maszyny.DataSource = szwalnia.Rodzaj_Maszyny.ToList();
            cmbRodzaj_Maszyny.ValueMember = "ID_Rodzaj_Maszyny";
            cmbRodzaj_Maszyny.DisplayMember = "Rodzaj_Maszyny";
            

            cmbDzial.ValueMember = "ID_Dzialu";
            cmbDzial.DisplayMember = "Nazwa_dzialu";
            cmbDzial.DataSource = szwalnia.Dzialy.Distinct().ToList();
            cmbDzial.Invalidate();

            cmbRodzaj_Dokumentacji.ValueMember = "ID_Rodzaj_Dokumentacji";
            cmbRodzaj_Dokumentacji.DisplayMember = "Nazwa";
            cmbRodzaj_Dokumentacji.DataSource = szwalnia.Rodzaj_Dokumentacji.Distinct().ToList();
            cmbRodzaj_Dokumentacji.Invalidate();

            cmbNazwa_Etapu.ValueMember = "ID_Etapu";
            cmbNazwa_Etapu.DisplayMember = "Nazwa";
            cmbNazwa_Etapu.DataSource = szwalnia.Rodzaj_Etapu.Distinct().ToList();
            cmbNazwa_Etapu.Invalidate();

            cmbRodzaj_Maszyny2.ValueMember = "ID_Rodzaj_Maszyny";
            cmbRodzaj_Maszyny2.DisplayMember = "Rodzaj_Maszyny";
            cmbRodzaj_Maszyny2.DataSource = szwalnia.Rodzaj_Maszyny.Distinct().ToList();
            cmbRodzaj_Maszyny2.Invalidate();



            dgvUkryty.DataSource = szwalnia.Proces_Produkcyjny.ToList();
            int numerOstatniegoProcesu = dgvUkryty.Rows.Count;
            lblNumer_Procesu.Text = (numerOstatniegoProcesu + 1).ToString();
        }

        private void btnWyszukaj_Obsluge_Click(object sender, EventArgs e)
        {
           
            dgvObsluga.DataSource = szwalnia.vObsluga.Where(nazwa => nazwa.Rodzaj_obsługi == cmbRodzajObslugi.Text).ToList();
            
        }

        private void btnSzukajZamowienie_Click(object sender, EventArgs e)
           
        {
            if (nudNumerZamowienia.Value > 0)
            {
                if (nudNumerZamowienia.Value <= ostatniNumerZamowienia)
                {
                    dgvProcesy.DataSource = szwalnia.vProces_technologiczny.Where(zamowienie => zamowienie.Numer_zamówienia == nudNumerZamowienia.Value).ToList();
                    
                }
                else
                    MessageBox.Show("Nie istnieje takie ID Zamowienia!");
            }
            else
                MessageBox.Show("Wprowadź poprawne ID Zamowienia (wieksze od zera)!");

        }

        private void tab_Proces_technologiczny_MouseClick(object sender, MouseEventArgs e)
        {
            nudNumerZamowienia.Value = ostatniNumerZamowienia;
            if (nudNumerZamowienia.Value > 0)
            {
                if (nudNumerZamowienia.Value <= ostatniNumerZamowienia)
                {
                    dgvProcesy.DataSource = szwalnia.vProces_technologiczny.Where(zamowienie => zamowienie.Numer_zamówienia == nudNumerZamowienia.Value).ToList();

                }
                else
                    MessageBox.Show("Nie istnieje takie ID Zamowienia!");
            }
            else
                MessageBox.Show("Wprowadź poprawne ID Zamowienia (wieksze od zera)!");

            nudNumerProcesu.Value = ostatniNumerProcesu;
            dgvProcesy2.Columns["ID_Proces_Technologiczny"].Visible = false;

            if (nudNumerProcesu.Value > 0)
            {
                if (nudNumerProcesu.Value <= ostatniNumerProcesu)
                {
                    dgvProcesy2.DataSource = szwalnia.vProcesy.Where(zamowienie => zamowienie.ID_Proces_Technologiczny == nudNumerProcesu.Value).ToList();
                    dgvProcesy3.DataSource = szwalnia.vElementy_proces.Where(zamowienie => zamowienie.Numer_procesu == nudNumerProcesu.Value).ToList();
                    dgvProcesy4.DataSource = szwalnia.vDokumentacja_proces.Where(zamowienie => zamowienie.Numer_procesu == nudNumerProcesu.Value).ToList();
                    dgvProcesy5.DataSource = szwalnia.vMaszyny_proces.Where(zamowienie => zamowienie.Numer_procesu == nudNumerProcesu.Value).ToList();

                }
                else
                    MessageBox.Show("Nie istnieje takie ID Zamowienia!");
            }
            else
                MessageBox.Show("Wprowadź poprawne ID Zamowienia (wieksze od zera)!");
        }

        private void btnSzukajProces_Click(object sender, EventArgs e)
        {
            if (nudNumerProcesu.Value > 0)
            {
                if (nudNumerProcesu.Value <= ostatniNumerProcesu)
                {
                    dgvProcesy2.DataSource = szwalnia.vProcesy.Where(zamowienie => zamowienie.ID_Proces_Technologiczny == nudNumerProcesu.Value).ToList();
                    dgvProcesy3.DataSource = szwalnia.vElementy_proces.Where(zamowienie1 => zamowienie1.Numer_procesu == nudNumerProcesu.Value).ToList();
                    dgvProcesy4.DataSource = szwalnia.vDokumentacja_proces.Where(zamowienie => zamowienie.Numer_procesu == nudNumerProcesu.Value).ToList();
                    dgvProcesy5.DataSource = szwalnia.vMaszyny_proces.Where(zamowienie => zamowienie.Numer_procesu == nudNumerProcesu.Value).ToList();

                }
                else
                    MessageBox.Show("Nie istnieje takie ID Zamowienia!");
            }
            else
                MessageBox.Show("Wprowadź poprawne ID Zamowienia (wieksze od zera)!");
        }
        void populateDataGridView()
        {
            dgvObsluga.AutoGenerateColumns = false;
            dgvObsluga.DataSource = szwalnia.vObsluga.ToList<vObsluga>();
        }

       

        private void btnDodaj_Obsluge_Click(object sender, EventArgs e)
        {
          
            
            Obsluga_Techniczna obsluga_Techniczna = new Obsluga_Techniczna();
            obsluga_Techniczna.ID_Maszyny = Convert.ToInt32(cmbID_Maszyny.SelectedValue);
            obsluga_Techniczna.ID_Rodzaj_Obslugi = Convert.ToInt32(cmbRodzaj_Obslugi.SelectedValue);
            obsluga_Techniczna.Data_Rozpoczecia = dtpData_Rozpoczecia.Value;
            obsluga_Techniczna.Data_Zakonczenia = dtpData_Zakonczenia.Value;
            obsluga_Techniczna.ID_Pracownika = Convert.ToInt32(cmbPracownik.SelectedValue);
            szwalnia.Obsluga_Techniczna.Add(obsluga_Techniczna);
            szwalnia.SaveChanges();
            MessageBox.Show("Zmiany wprowadzone pomyślnie");
            populateDataGridView();
            

        }

        private void btnZapisz_Nowy_Proces_Click(object sender, EventArgs e)
        {
            Proces_Technologiczny proces = new Proces_Technologiczny();
            proces.ID_Pracownika = Convert.ToInt32(cmbTechnolodzy.SelectedValue);
            szwalnia.Proces_Technologiczny.Add(proces);
            szwalnia.SaveChanges();
            MessageBox.Show("Dodano nowy proces technologiczny");
        }

        private void PrzygotowanieProdukcji_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet.vObsluga' . Możesz go przenieść lub usunąć.
            this.vObslugaTableAdapter.Fill(this.szwalniaDataSet.vObsluga);

        }

        private void btnDodaj_Maszyne_Click(object sender, EventArgs e)
        {
            Maszyny maszyny = new Maszyny();
            maszyny.ID_Rodzaj_Maszyny = Convert.ToInt32(cmbRodzaj_Maszyny.SelectedValue);
            maszyny.Resurs_Rbh = Convert.ToInt32(txtResurs_Rbh.Text);
            maszyny.Serwis_Co_Ile = Convert.ToInt32(txtSerwis.Text);
           

            Srodki_Trwale srodki_Trwale = new Srodki_Trwale();
            srodki_Trwale.Nazwa = cmbRodzaj_Maszyny.DisplayMember;
            srodki_Trwale.Producent = txtProducent.Text;
            srodki_Trwale.Numer_seryjny = txtNumer_Seryjny.Text;
            srodki_Trwale.ID_Dzialu = Convert.ToInt32(cmbDzial.SelectedValue);
            srodki_Trwale.Koszt_zakupu = txtKoszt_Zakupu.Text;
            srodki_Trwale.Roczny_stopien_amortyzacji = txtAmortyzacja.Text;
            srodki_Trwale.Gwarancja = dtpGwarancja.Value;
           // srodki_Trwale.Zamortyzowane = Convert.ToByte(txtZamortyzowane.Text); // tutaj nie bardzo wiem jak to ugryźć
            szwalnia.Maszyny.Add(maszyny);

            szwalnia.Srodki_Trwale.Add(srodki_Trwale);
            szwalnia.SaveChanges();
            MessageBox.Show("Zmiany wprowadzone pomyślnie");
        }

        private void btnDodaj_Dokumentacja_Click(object sender, EventArgs e)
        {
            Dokumentacje dokumentacje = new Dokumentacje();
            dokumentacje.ID_Rodzaj_Dokumentacji = Convert.ToInt32(cmbRodzaj_Dokumentacji.SelectedValue);
            dokumentacje.ID_Pracownika = Convert.ToInt32(cmbTechnolodzy2.SelectedValue);
            dokumentacje.Data_Wykonania = dtpData_Wykonania_Dokumentacja.Value;
            dokumentacje.Plik = txtLokalizacja.Text;
            szwalnia.Dokumentacje.Add(dokumentacje);
            szwalnia.SaveChanges();
            MessageBox.Show("Dokumentacja dodana do bazy");
    
        }

        private void btnDodaj_Etap_Click(object sender, EventArgs e)
        {
            Etapy_W_Procesie etapy_W_Procesie = new Etapy_W_Procesie();
            etapy_W_Procesie.ID_Proces_Technologiczny = Convert.ToInt32(nudDodaj_Etap.Value);
            etapy_W_Procesie.ID_Etapu = Convert.ToInt32(cmbNazwa_Etapu.SelectedValue);
            etapy_W_Procesie.Czas = Convert.ToInt32(txtCzas_Etapu.Text);
            szwalnia.Etapy_W_Procesie.Add(etapy_W_Procesie);
            szwalnia.SaveChanges();
            MessageBox.Show("Dodano nowy etap");
        }

        private void btnDodaj_Maszyne_Proces_Click(object sender, EventArgs e)
        {
            Maszyny_Proces maszyny_proces = new Maszyny_Proces();
            maszyny_proces.ID_Proces_Technologiczny = Convert.ToInt32(nudDodaj_Maszyne.Value);
            maszyny_proces.ID_Rodzaj_Maszyny = Convert.ToInt32(cmbRodzaj_Maszyny2.SelectedValue);
            maszyny_proces.Liczba_Maszyn = Convert.ToInt32(txtLiczba_Maszyn.Text);
            maszyny_proces.Liczba_Rbh_Maszyna = Convert.ToInt32(txtLiczba_Rbh_Maszyn.Text);
            szwalnia.Maszyny_Proces.Add(maszyny_proces);
            szwalnia.SaveChanges();
            MessageBox.Show("Dodano maszynę do procesu");
        }

        private void btn_Szukaj_Dokumentacja_Click(object sender, EventArgs e)
        {

        }

        private void btnPrzypisz_Dokumentacja_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Element_Click(object sender, EventArgs e)
        {

        }

        private void btnUtworz_Element_Click(object sender, EventArgs e)
        {

        }

        private void btnPrzypisz_Proces_Zamowienie_Click(object sender, EventArgs e)
        {

        }
    }
   
}
