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
        public WydawanieProduktowKurierowi()
        {
            InitializeComponent();
            db = Start.szwalnia;


            cmbZamowienie.DataSource

            
            if (db.vWydawanie_Zamowien_Kurierowi.Any())
            {
                dgvGotoweProdukty.DataSource = db.vWydawanie_Zamowien_Kurierowi.ToList();
                dgvGotoweProdukty.Columns[0].Width = 100;
                dgvGotoweProdukty.Columns[1].Width = 100;
                dgvGotoweProdukty.Columns[2].Width = 160;
                dgvGotoweProdukty.Columns[3].Width = 80;
                dgvGotoweProdukty.Columns[4].Width = 70;
            }
            else
            {
                DataTable brakProduktow = new DataTable();
                brakProduktow.Columns.Add("Informacja");
                brakProduktow.Rows.Add("Brak produktów do przyjęcia");
                dgvGotoweProdukty.DataSource = brakProduktow;
                dgvGotoweProdukty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            cmbPracownik.DataSource = db.vPracownicyMagazynu.ToList();
            cmbPracownik.DisplayMember = "Dane_osobowe";
            cmbPracownik.ValueMember = "ID_Pracownika";
            btnWydajProdukty.Enabled = false;
        }

        private void btnWydajProdukty_Click(object sender, EventArgs e)
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
            MessageBox.Show("Pomyślnie wydano produkty kurierowi.");
            this.Close();
        }

        private void dgvGotoweProdukty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (db.vWydawanie_Zamowien_Kurierowi.Any())
                btnWydajProdukty.Enabled = true;
        }

        private void WydawanieProduktowKurierowi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
