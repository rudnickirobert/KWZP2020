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
    public partial class WydawanieProduktowKurierowi : Form
    {
        public SzwalniaEntities db;
        public bool czyZainicjowane;
       
        public WydawanieProduktowKurierowi()
        {
            InitializeComponent();
            db = Start.szwalnia;
            dgvGotoweProdukty.ReadOnly = true;
            if (db.vZamowieniaKompletneNiewydaneNaPolkachCale.Any())
            {
                cmbZamowienie.DataSource = db.vZamowieniaKompletneNiewydaneNaPolkachCale.ToList();
                cmbZamowienie.DisplayMember = "ID_Zamowienia";
                cmbZamowienie.ValueMember = "ID_Zamowienia";
                int numerZamowienia = Convert.ToInt32(cmbZamowienie.SelectedValue);
                dgvGotoweProdukty.DataSource = db.vZamowieniaKompletneNiewydaneNaPolkachCale.Where(zamowienie => zamowienie.ID_Zamowienia == numerZamowienia).ToList();
                dgvGotoweProdukty.ReadOnly = true;
            }
            else
            {
                DataTable brakProduktow = new DataTable();
                brakProduktow.Columns.Add("Informacja");
                brakProduktow.Rows.Add("Brak produktów do przyjęcia");
                dgvGotoweProdukty.DataSource = brakProduktow;
                dgvGotoweProdukty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvGotoweProdukty.ReadOnly = true;
                cmbZamowienie.DataSource = brakProduktow;
                cmbZamowienie.DisplayMember = "Informacja";
                cmbZamowienie.ValueMember = "Informacja";
            }
            if (db.vPracownicyMagazynu.Any())
            {
                cmbPracownik.DataSource = db.vPracownicyMagazynu.ToList();
                cmbPracownik.DisplayMember = "Dane_osobowe";
                cmbPracownik.ValueMember = "ID_Pracownika";
            }
            else
            {

            }
            czyZainicjowane = true;
            btnWydajProdukty.Enabled = true;
        } 

        private void cmbZamowienie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (czyZainicjowane)
            {
                if (db.vZamowieniaKompletneNiewydaneNaPolkachCale.Any())
                {
                    int numerZamowienia = Convert.ToInt32(cmbZamowienie.SelectedValue);
                    dgvGotoweProdukty.DataSource = db.vZamowieniaKompletneNiewydaneNaPolkachCale.Where(zamowienie => zamowienie.ID_Zamowienia == numerZamowienia).ToList();
                    dgvGotoweProdukty.ReadOnly = true;
                }
                else
                {
                    DataTable brakProduktow = new DataTable();
                    brakProduktow.Columns.Add("Informacja");
                    brakProduktow.Rows.Add("Brak produktów do przyjęcia");
                    dgvGotoweProdukty.DataSource = brakProduktow;
                    dgvGotoweProdukty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvGotoweProdukty.ReadOnly = true;
                }

                btnWydajProdukty.Enabled = true;
            }
        }
        private void btnWydajProdukty_Click(object sender, EventArgs e)
        {
            if (db.vZamowieniaKompletneNiewydaneNaPolkachCale.Any())
            {
                int numerZamowienia = Convert.ToInt32(cmbZamowienie.SelectedValue);
                List<vZamowieniaKompletneNiewydaneNaPolkachCale> listaDoWydania = db.vZamowieniaKompletneNiewydaneNaPolkachCale.Where(wybraneDoWydania => wybraneDoWydania.ID_Zamowienia == numerZamowienia).ToList();
                Dostarczenia_Zewn noweWydanie = new Dostarczenia_Zewn();
                Miejsca wysylka = db.Miejsca.Where(miejsce => miejsce.Nazwa == "Wysylka").FirstOrDefault();
                int intIDMiejsca = wysylka.ID_Miejsca;

                foreach (vZamowieniaKompletneNiewydaneNaPolkachCale wierszWybrany in listaDoWydania)
                {
                    noweWydanie.ID_Pracownicy = Convert.ToInt32(cmbPracownik.SelectedValue);
                    noweWydanie.ID_Zamowienia = wierszWybrany.ID_Zamowienia;
                    noweWydanie.ID_element = wierszWybrany.ID_Element;
                    noweWydanie.ID_Miejsca = intIDMiejsca;
                    int intIDPolka = wierszWybrany.ID_Polka;
                    Zawartosc wybranaPolka = db.Zawartosc.Where(polkaWybrana => polkaWybrana.ID_Polka == intIDPolka).First();
                    noweWydanie.Ilosc_Dostarczona = wybranaPolka.Ilosc_Paczek;
                    noweWydanie.Data_Dostarczenia = Convert.ToString(DateTime.Now).Substring(0, 10);
                    db.Dostarczenia_Zewn.Add(noweWydanie);
                    db.Zawartosc.Remove(wybranaPolka);
                    db.SaveChanges();
                    Start.DataBaseRefresh();                    
                }
                MessageBox.Show("Pomyślnie wydano produkty kurierowi i usnięto z magazynu.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Brak produktów do wydania.");
            }   
        }

        private void WydawanieProduktowKurierowi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
