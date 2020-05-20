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

            cmbZamowienie.DataSource = db.vZamowienia_Do_Wydania_Kompletne.ToList();
            cmbZamowienie.DisplayMember = "ID_Zamowienia";
            cmbZamowienie.ValueMember = "ID_Zamowienia";

            cmbPracownik.DataSource = db.vPracownicyMagazynu.ToList();
            cmbPracownik.DisplayMember = "Dane_osobowe";
            cmbPracownik.ValueMember = "ID_Pracownika";
            czyZainicjowane = true;
            btnWydajProdukty.Enabled = true;
        } 

        private void cmbZamowienie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (czyZainicjowane)
            {
                if (db.vWydawanie_Zamowien_Kurierowi.Any())
                {
                    int numerZamowienia = Convert.ToInt32(cmbZamowienie.SelectedValue);
                    dgvGotoweProdukty.DataSource = db.vWydawanie_Zamowien_Kurierowi.Where(zamowienie => zamowienie.ID_Zamowienia == numerZamowienia).ToList();
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
            int numerZamowienia = Convert.ToInt32(cmbZamowienie.SelectedValue);
            for (int i = 1; i <= db.vWydawanie_Zamowien_Kurierowi.Where(zamowienie => zamowienie.ID_Zamowienia == numerZamowienia).Count(); i++)
            {
                Dostarczenia_Zewn dostarczenia = new Dostarczenia_Zewn();

                dostarczenia.ID_Pracownicy = Convert.ToInt32(cmbPracownik.SelectedValue);
                dostarczenia.ID_Zamowienia = Convert.ToInt32(dgvGotoweProdukty.CurrentRow.Cells[0].Value);
                dostarczenia.ID_element = Convert.ToInt32(dgvGotoweProdukty.CurrentRow.Cells[3].Value);
                dostarczenia.Ilosc_Dostarczona = -Convert.ToInt32(dgvGotoweProdukty.CurrentRow.Cells[4].Value);

                Miejsca wysylka = db.Miejsca.Where(miejsce => miejsce.Nazwa == "Wysylka").FirstOrDefault();
                dostarczenia.ID_Miejsca = wysylka.ID_Miejsca;
                string dataDzis = Convert.ToString(DateTime.Now).Substring(0, 10);
                dostarczenia.Data_Dostarczenia = dataDzis;
                db.Dostarczenia_Zewn.Add(dostarczenia);
                db.SaveChanges();
                Start.DataBaseRefresh();

                Zawartosc polkaDoWyczyszczenia = db.Zawartosc.Where(polka => polka.ID_Zamowienia == dostarczenia.ID_Zamowienia).First();
                db.Zawartosc.Remove(polkaDoWyczyszczenia);

                MessageBox.Show("Pomyślnie wydano produkty kurierowi.");
            }
            this.Close();
        }

        private void WydawanieProduktowKurierowi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
