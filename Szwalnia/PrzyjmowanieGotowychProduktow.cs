using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Szwalnia
{
    public partial class PrzyjmowanieGotowychProduktow : Form
    {
        public SzwalniaEntities db;
        public PrzyjmowanieGotowychProduktow()
        {
            InitializeComponent();
            db = Start.szwalnia;
            if (db.vOdbior_Gotowych_Produktow.Any())
            {
                dgvGotoweProdukty.DataSource = db.vOdbior_Gotowych_Produktow.ToList();
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
            btnPrzyjmijProdukty.Enabled = false;
        }

        private void btnPrzyjmijProdukty_Click(object sender, EventArgs e)
        {
            Dostarczenia_Zewn dostarczenia = new Dostarczenia_Zewn();

            dostarczenia.ID_Pracownicy = Convert.ToInt32(cmbPracownik.SelectedValue);
            dostarczenia.ID_Zamowienia = Convert.ToInt32(dgvGotoweProdukty.CurrentRow.Cells[0].Value);
            dostarczenia.ID_element = Convert.ToInt32(dgvGotoweProdukty.CurrentRow.Cells[3].Value);
            dostarczenia.Ilosc_Dostarczona = Convert.ToInt32(dgvGotoweProdukty.CurrentRow.Cells[4].Value);

            Miejsca produkcja = db.Miejsca.Where(miejsce => miejsce.Nazwa == "Produkcja").FirstOrDefault();
            dostarczenia.ID_Miejsca = produkcja.ID_Miejsca;
            string dataDzis = Convert.ToString(DateTime.Now).Substring(0, 10);
            dostarczenia.Data_Dostarczenia = dataDzis;
            db.Dostarczenia_Zewn.Add(dostarczenia);
            db.SaveChanges();
            Start.DataBaseRefresh();
            MessageBox.Show("Pomyślnie przyjęto produkty z działu produkcji.");
            this.Close();
        }

        private void dgvGotoweProdukty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (db.vOdbior_Gotowych_Produktow.Any())
                btnPrzyjmijProdukty.Enabled = true;
        }

        private void PrzyjmowanieGotowychProduktow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

        private void dgvGotoweProdukty_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (db.vOdbior_Gotowych_Produktow.Where(doOdebrania => doOdebrania.Ilosc > 0).Any())
            {
                int intZamowienieID = Convert.ToInt32(dgvGotoweProdukty.CurrentRow.Cells[0].Value);
                int intElementID = Convert.ToInt32(dgvGotoweProdukty.CurrentRow.Cells[3].Value);
                int intIloscSztuk = Convert.ToInt32(dgvGotoweProdukty.CurrentRow.Cells[4].Value);
                WyborPolkiDoOdlozenia wybieraniePolkiDoOdlozeniaElementu = new WyborPolkiDoOdlozenia("przyjecieGotowychProduktow", intZamowienieID, intElementID, intIloscSztuk);
                wybieraniePolkiDoOdlozeniaElementu.Show();
                this.Hide();
            }
        }
    }
}
