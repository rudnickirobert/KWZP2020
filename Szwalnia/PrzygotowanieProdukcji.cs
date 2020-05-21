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
            dgvProcesy66.DataSource = szwalnia.vProces_technologicznyy.ToList();
            dgvProcesy66.Columns["ID_zamowienia"].Visible = false;
            dgvZamowienia.DataSource = szwalnia.vProces_technologiczny.ToList();
            dgvProcesy2.DataSource = szwalnia.vProcesy.ToList();
            dgvProcesy3.DataSource = szwalnia.vElementy_proces.ToList();
            dgvProcesy3.Columns["Numer_procesu"].Visible = false;
            dgvProcesy4.DataSource = szwalnia.vDokumentacja_proces.ToList();
            dgvProcesy4.Columns["Numer_procesu"].Visible = false;
            dgvProcesy5.DataSource = szwalnia.vMaszyny_proces.ToList();
            dgvProcesy5.Columns["Numer_procesu"].Visible = false;

            int ostatniNumer = dgvProcesy.Rows.Cast<DataGridViewRow>().Max(wartosc => Convert.ToInt32(wartosc.Cells["Numer_zamówienia"].Value));
            ostatniNumerZamowienia = ostatniNumer;

            int ostatniNumer66 = dgvProcesy66.Rows.Cast<DataGridViewRow>().Max(wartosc => Convert.ToInt32(wartosc.Cells["ID_zamowienia"].Value));
            ostatniNumerZamowienia = ostatniNumer66;

            int ostatniNumerP = dgvProcesy2.Rows.Cast<DataGridViewRow>().Max(wartosc => Convert.ToInt32(wartosc.Cells["ID_Proces_Technologiczny"].Value));
            ostatniNumerProcesu = ostatniNumerP;

            cmbRodzaj_Obslugi.ValueMember = "ID_Rodzaj_Obslugi";
            cmbRodzaj_Obslugi.DisplayMember = "Nazwa";
            cmbRodzaj_Obslugi.DataSource = szwalnia.Rodzaj_Obslugi.Distinct().ToList();
            cmbRodzaj_Obslugi.Invalidate();

            cmbPracownik.ValueMember = "ID_Pracownika";
            cmbPracownik.DisplayMember = "Imię_i_nazwisko";
            cmbPracownik.DataSource = szwalnia.vMechanicy.Distinct().ToList();
            cmbPracownik.Invalidate();

            cmbID_Maszyny.ValueMember = "ID_Maszyny";
            cmbID_Maszyny.DisplayMember = "Suma";
            cmbID_Maszyny.DataSource = szwalnia.vMaszyny_numer_seryjny.Distinct().ToList();
            cmbID_Maszyny.Invalidate();

            cmbTechnolodzy.DataSource = szwalnia.vTechnolodzy.ToList();
            cmbTechnolodzy.ValueMember = "ID_Pracownika";
            cmbTechnolodzy.DisplayMember = "Autor";

            cmbTechnolodzy2.DataSource = szwalnia.vTechnolodzy.ToList();
            cmbTechnolodzy2.ValueMember = "ID_Pracownika";
            cmbTechnolodzy2.DisplayMember = "Autor";

            cmbRodzaj_Maszyny.DataSource = szwalnia.vRodzaj_Maszyny.Distinct().ToList();
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

            cmbRodzaj_Maszyny2.DataSource = szwalnia.vRodzaj_Maszyny.ToList();
            cmbRodzaj_Maszyny2.ValueMember = "ID_Rodzaj_Maszyny";
            cmbRodzaj_Maszyny2.DisplayMember = "Rodzaj_Maszyny";
            cmbRodzaj_Maszyny2.Invalidate();

            cmbID_Proces_Technologiczny.DataSource = szwalnia.Proces_Technologiczny.Distinct().ToList();
            cmbID_Proces_Technologiczny.ValueMember = "ID_Proces_Technologiczny";
            cmbID_Proces_Technologiczny.DisplayMember = "ID_Proces_Technologiczny";
            cmbID_Proces_Technologiczny.Invalidate();

            cmbTyp_Elementu.ValueMember = "Numer_elementu";
            cmbTyp_Elementu.DisplayMember = "Nazwa_elementu";
            cmbTyp_Elementu.DataSource = szwalnia.vMaterialy.Distinct().ToList();
            cmbTyp_Elementu.Invalidate();

            cmbJednostka.ValueMember = "ID_Jednostka";
            cmbJednostka.DisplayMember = "Jednostka";
            cmbJednostka.DataSource = szwalnia.Elementy_Jednostki.Distinct().ToList();
            cmbJednostka.Invalidate();

            cmbID_Proces_Technologiczny3.DataSource = szwalnia.Proces_Technologiczny.Distinct().ToList();
            cmbID_Proces_Technologiczny3.DisplayMember = "ID_Proces_Technologiczny";
            cmbID_Proces_Technologiczny3.ValueMember = "ID_Proces_Technologiczny";
            cmbID_Proces_Technologiczny3.Invalidate();

            dgvUkryty.DataSource = szwalnia.Proces_Technologiczny.ToList();
            int numerOstatniegoProcesu = dgvUkryty.Rows.Count;
            lblNumer_Procesu.Text = (numerOstatniegoProcesu + 1).ToString();

            dgvUkryty2.DataSource = szwalnia.Dokumentacje.ToList();
            int numerOstatniejDokumentacji = dgvUkryty2.Rows.Count;
            lblNumerDokumentacji.Text = (numerOstatniejDokumentacji + 1).ToString();

            dgvDokumentacja.DataSource = szwalnia.vDokumentacja_info.ToList();

            dgvWszystkie_Maszyny.DataSource = szwalnia.vWszystkie_Maszyny.ToList();
        }

        private void btnWyszukaj_Obsluge_Click(object sender, EventArgs e)
        {
           
            dgvObsluga.DataSource = szwalnia.vObsluga.Where(nazwa => nazwa.Rodzaj_obsługi == cmbRodzajObslugi.Text).ToList();
            
        }

        private void tab_Proces_technologiczny_MouseClick(object sender, MouseEventArgs e)
        {
            nudNumerZamowienia.Value = ostatniNumerZamowienia;
            if (nudNumerZamowienia.Value > 0)
            {
                if (nudNumerZamowienia.Value <= ostatniNumerZamowienia)
                {
                    dgvProcesy.DataSource = szwalnia.vProces_technologiczny.Where(zamowienie => zamowienie.Numer_zamówienia == nudNumerZamowienia.Value).ToList();
                    dgvProcesy66.DataSource = szwalnia.vProces_technologicznyy.Where(cx => cx.ID_Zamowienia == nudNumerZamowienia.Value).ToList();
                }
                else
                    MessageBox.Show("Nie istnieje takie ID Zamowienia!");
            }
            else
                MessageBox.Show("Wprowadź poprawne ID Zamowienia (wieksze od zera)!");

            

            nudNumerProcesu.Value = ostatniNumerProcesu;
            dgvProcesy2.Columns["ID_Proces_Technologiczny"].Visible = false;

                if (nudNumerProcesu.Value <= ostatniNumerProcesu && nudNumerProcesu.Value > 0)
                {
                    dgvProcesy2.DataSource = szwalnia.vProcesy.Where(zamowienie => zamowienie.ID_Proces_Technologiczny == nudNumerProcesu.Value).ToList();
                    dgvProcesy3.DataSource = szwalnia.vElementy_proces.Where(zamowienie => zamowienie.Numer_procesu == nudNumerProcesu.Value).ToList();
                    dgvProcesy4.DataSource = szwalnia.vDokumentacja_proces.Where(zamowienie => zamowienie.Numer_procesu == nudNumerProcesu.Value).ToList();
                    dgvProcesy5.DataSource = szwalnia.vMaszyny_proces.Where(zamowienie => zamowienie.Numer_procesu == nudNumerProcesu.Value).ToList();

                }
                else
                
                    MessageBox.Show("Nie istnieje takie ID Zamowienia!");
        }

        private void btnSzukajProces_Click(object sender, EventArgs e)
        {
            int max = szwalnia.Proces_Technologiczny.Max(xd => xd.ID_Proces_Technologiczny);
                if (nudNumerProcesu.Value <= max && nudNumerProcesu.Value > 0)
                {
                    dgvProcesy2.DataSource = szwalnia.vProcesy.Where(zamowienie => zamowienie.ID_Proces_Technologiczny == nudNumerProcesu.Value).ToList();
                    dgvProcesy3.DataSource = szwalnia.vElementy_proces.Where(zamowienie1 => zamowienie1.Numer_procesu == nudNumerProcesu.Value).ToList();
                    dgvProcesy4.DataSource = szwalnia.vDokumentacja_proces.Where(zamowienie => zamowienie.Numer_procesu == nudNumerProcesu.Value).ToList();
                    dgvProcesy5.DataSource = szwalnia.vMaszyny_proces.Where(zamowienie => zamowienie.Numer_procesu == nudNumerProcesu.Value).ToList();
            }
                else
                    MessageBox.Show("Nie istnieje taki numer procesu!");
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
            dgvObsluga.DataSource = szwalnia.vObsluga.Where(nazwa => nazwa.Rodzaj_obsługi == cmbRodzajObslugi.Text).ToList();
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
            szwalnia.Maszyny.Add(maszyny);

            szwalnia.Srodki_Trwale.Add(srodki_Trwale);
            szwalnia.SaveChanges();
            MessageBox.Show("Zmiany wprowadzone pomyślnie");
            dgvWszystkie_Maszyny.DataSource = szwalnia.vWszystkie_Maszyny.ToList();
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
            dgvUkryty2.DataSource = szwalnia.Dokumentacje.ToList();
            int numerOstatniejDokumentacji = dgvUkryty2.Rows.Count;
            lblNumerDokumentacji.Text = (numerOstatniejDokumentacji + 1).ToString();
            dgvDokumentacja.DataSource = szwalnia.vDokumentacja_info.ToList();
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
            dgvEtapy_proces.DataSource = szwalnia.vProces_Etapy.Where(etap => etap.ID_Proces_Technologiczny == nudDodaj_Etap.Value).ToList();
            dgvEtapy_proces.Columns["ID_Proces_Technologiczny"].Visible = false;
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
            dgvMaszyny_Proces.DataSource = szwalnia.vMaszynownia.Where(maszyna => maszyna.Numer_procesu_technologicznego == nudDodaj_Maszyne.Value).ToList();
            dgvMaszyny_Proces.Columns["Numer_procesu_technologicznego"].Visible = false;
        }

  

        private void btnPrzypisz_Dokumentacja_Click(object sender, EventArgs e)
        {
            Dokumentacja_Proces dokumentacja_Proces = new Dokumentacja_Proces();
            dokumentacja_Proces.ID_Dokumentacji = Convert.ToInt32(nud_Numer_Dokumentacji.Value);
            dokumentacja_Proces.ID_Proces_Technologiczny = Convert.ToInt32(cmbID_Proces_Technologiczny.SelectedValue);
            szwalnia.Dokumentacja_Proces.Add(dokumentacja_Proces);
            szwalnia.SaveChanges();
            MessageBox.Show("Przypisano dokumentację do procesu");

        }

        private void btnDodaj_Element_Click(object sender, EventArgs e)
        {
            Elementy_Proces elementy_Proces = new Elementy_Proces();
            elementy_Proces.ID_Proces_Technologiczny = Convert.ToInt32(nudNumerProcesu2.Value);
            elementy_Proces.ID_Element = Convert.ToInt32(cmbTyp_Elementu.SelectedValue);
            elementy_Proces.Liczba = Convert.ToInt32(txtLiczba_Elementow.Text);
            elementy_Proces.ID_jednostka = Convert.ToInt32(cmbJednostka.SelectedValue);
            szwalnia.Elementy_Proces.Add(elementy_Proces);
            szwalnia.SaveChanges();
            MessageBox.Show("Dodano element do procesu");
            dgvWszystkie_Elementy.DataSource = szwalnia.vElemntyy.Where(kx => kx.Numer_procesu == nudNumerProcesu2.Value).ToList();
        }

        private void btnUtworz_Element_Click(object sender, EventArgs e)
        {
            DodawanieElementu element = new DodawanieElementu();
            element.Show();
        }

        private void btnPrzypisz_Proces_Zamowienie_Click(object sender, EventArgs e)
        {
            Proces_Zamowienie proces_Zamowienie = new Proces_Zamowienie();
            proces_Zamowienie.ID_Zamowienie_Element = Convert.ToInt32(lblNumerZamowieniaElement.Text);
            proces_Zamowienie.ID_Proces_Technologiczny = Convert.ToInt32(cmbID_Proces_Technologiczny3.SelectedValue);
            szwalnia.Proces_Zamowienie.Add(proces_Zamowienie);
            szwalnia.SaveChanges();
            MessageBox.Show("Przypisano proces technologiczny do zamówienia");
            tabcZamowienia.SelectTab(2);
            dgvProcesy.DataSource = null;
            dgvProcesy66.DataSource = null;
            dgvProcesy.DataSource = szwalnia.vProces_technologiczny.Where(zamowienie => zamowienie.Numer_zamówienia == nudNumerZamowienia.Value).ToList();
            dgvProcesy66.DataSource = szwalnia.vProces_technologicznyy.Where(cx => cx.ID_Zamowienia == nudNumerZamowienia.Value).ToList();
        }

        private void tab_Proces_technologiczny_Click(object sender, EventArgs e)
        {
            dgvSerwis.DataSource = szwalnia.vCzas_do_serwisu.ToList();
            dgvResursMaszyny.DataSource = szwalnia.vResurs.ToList();
        }

        private void btnOdswiez_Ogolny_Click(object sender, EventArgs e)
        {
            dgvProcesy.DataSource = szwalnia.vProces_technologiczny.Where(zamowienie => zamowienie.Numer_zamówienia == nudNumerZamowienia.Value).ToList();
            dgvZamowienia.DataSource = szwalnia.vProces_technologiczny.ToList();
            dgvProcesy66.DataSource = szwalnia.vProces_technologicznyy.Where(cx => cx.ID_Zamowienia == nudNumerZamowienia.Value).ToList();
        }

        private void btnOdswiez_Znajdz_Click(object sender, EventArgs e)
        {
            dgvProcesy2.DataSource = szwalnia.vProcesy.Where(zamowienie => zamowienie.ID_Proces_Technologiczny == nudNumerProcesu.Value).ToList();

            dgvProcesy3.DataSource = szwalnia.vElementy_proces.Where(zamowienie => zamowienie.Numer_procesu == nudNumerProcesu.Value).ToList();

            dgvProcesy4.DataSource = szwalnia.vDokumentacja_proces.Where(zamowienie => zamowienie.Numer_procesu == nudNumerProcesu.Value).ToList();

            dgvProcesy5.DataSource = szwalnia.vMaszyny_proces.Where(zamowienie => zamowienie.Numer_procesu == nudNumerProcesu.Value).ToList();
        }

        private void btn_Szukaj_Dokumentacja_Click(object sender, EventArgs e)
        {
            dgvDokumentacja.DataSource = szwalnia.vDokumentacja_info.Where(dokumentacja=>dokumentacja.Numer_dokumetacji==numericUpDown4.Value).ToList();
        }

        private void btnUtworz_Proces_Click(object sender, EventArgs e)
        {
            Proces_Technologiczny proces_Technologiczny = new Proces_Technologiczny();
            proces_Technologiczny.ID_Pracownika = Convert.ToInt32(cmbTechnolodzy.SelectedValue);
            szwalnia.Proces_Technologiczny.Add(proces_Technologiczny);
            szwalnia.SaveChanges();
            MessageBox.Show("Utworzono nowy proces technologiczny");
            dgvUkryty.DataSource = szwalnia.Proces_Technologiczny.ToList();
            int numerOstatniegoProcesu1 = dgvUkryty.Rows.Count;
            lblNumer_Procesu.Text = (numerOstatniegoProcesu1 + 1).ToString();
            cmbID_Proces_Technologiczny3.DataSource = szwalnia.Proces_Technologiczny.Distinct().ToList();
            cmbID_Proces_Technologiczny3.SelectedValue = szwalnia.Proces_Technologiczny.Max(xv => xv.ID_Proces_Technologiczny);
            cmbID_Proces_Technologiczny.DataSource = szwalnia.Proces_Technologiczny.Distinct().ToList();
            cmbID_Proces_Technologiczny.SelectedValue = szwalnia.Proces_Technologiczny.Max(xz => xz.ID_Proces_Technologiczny);
            nudDodaj_Etap.Value = szwalnia.Proces_Technologiczny.Max(xb => xb.ID_Proces_Technologiczny);
            nudDodaj_Maszyne.Value = szwalnia.Proces_Technologiczny.Max(xf => xf.ID_Proces_Technologiczny);
            nudNumerProcesu2.Value = szwalnia.Proces_Technologiczny.Max(xg => xg.ID_Proces_Technologiczny);
            nudNumerProcesu.Value = szwalnia.Proces_Technologiczny.Max(xh => xh.ID_Proces_Technologiczny);
        }
        private void btnKompletny_Proces_Click(object sender, EventArgs e)
        {
            Proces_Zamowienie proces_Zamowienie = szwalnia.Proces_Zamowienie.Where(xd=>xd.ID_Proces_Technologiczny==(int)nudNumerProcesu.Value).SingleOrDefault();
            if (proces_Zamowienie == null)
            {
                MessageBox.Show("Nie ma takiego procesu","BŁĄD",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            proces_Zamowienie.Kompletny_Proces = chbKompletny_Proces.Checked;
            szwalnia.SaveChanges();
            MessageBox.Show("Zatwierdzono proces");
            dgvProcesy66.DataSource = szwalnia.vProces_technologicznyy.Where(cx => cx.ID_Zamowienia == nudNumerZamowienia.Value).ToList();
        }

        private void dgvProcesy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProcesy.CurrentCell.Selected = true;
            lblNumerZamowieniaElement.Text = dgvProcesy.CurrentCell.Value.ToString();
        }

     
    }
   
}
