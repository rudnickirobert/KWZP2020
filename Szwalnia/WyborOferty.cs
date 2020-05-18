using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class WyborOferty : Form
    {
        private static bool zamknieciePrzezInnyFormularz;
        public static bool czyZamknietyPrzezInny {
            get
            {
                return zamknieciePrzezInnyFormularz;
            }
            set
            {
                if (zamknieciePrzezInnyFormularz != value)
                    zamknieciePrzezInnyFormularz = value;
            }
        }
        public int intIlosc;
        public int intElement;
        public int intZamowienie;
        public int intIloscPaczek;
        public SzwalniaEntities db;
        public WyborOferty(int intZamowienie, int intElement, int intIlosc)
        {
            InitializeComponent();
            zamknieciePrzezInnyFormularz = false;
            this.intIlosc = intIlosc;
            this.intElement = intElement;
            this.intZamowienie = intZamowienie;

            db = Start.szwalnia;
            if (db.Oferta.Where(element => element.ID_Element == intElement).Any() == true)
            {
                dgvListaOfert.DataSource = db.vOferta.Where(element => element.ID_Element == intElement).ToList();
                dgvListaOfert.Columns[0].Visible = false;
                dgvListaOfert.Columns[1].Visible = false;
                dgvListaOfert.Columns[2].Visible = false;
            }
            else
            {
                DataTable informacjaOBrakuOfert = new DataTable();
                informacjaOBrakuOfert.Columns.Add("Informacja");
                informacjaOBrakuOfert.Rows.Add("Brak ofert dla tego materiału");
                dgvListaOfert.DataSource = informacjaOBrakuOfert;
            }
            //petla dla drugiego dgv
            if (db.vZawartoscMagazynuDoPrzydzialu.Where(element => element.ID_Element == intElement).Any() == true)
            {
                dgvMagazynZawartosc.DataSource = db.vZawartoscMagazynuDoPrzydzialu.Where(element => element.ID_Element == intElement).ToList();
                dgvMagazynZawartosc.Columns[0].Visible = false;
                dgvMagazynZawartosc.Columns[1].Visible = false;
                dgvMagazynZawartosc.Columns[2].Visible = false;
            }
            else
            {
                DataTable informacjaOBrakuNaMagazynie = new DataTable();
                informacjaOBrakuNaMagazynie.Columns.Add("Informacja");
                informacjaOBrakuNaMagazynie.Rows.Add("Na magazynie nie ma produktów spełniających wymagania");
                dgvMagazynZawartosc.DataSource = informacjaOBrakuNaMagazynie;
            }





        }

        private void WyborOferty_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!zamknieciePrzezInnyFormularz)
            {
                Start.GetForm.Show();
            }

            DodawanieDostaw.czyZamknietyPrzezInny = true;
            Application.OpenForms["DodawanieDostaw"].Close();
        }

        private void dgvListaOfert_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (db.Oferta.Where(element => element.ID_Element == intElement).Any() == true)
            {
                double ilosc = Convert.ToDouble(Math.Abs(intIlosc));
                double iloscWPaczce = Convert.ToDouble(dgvListaOfert.CurrentRow.Cells[5].Value);
                int intIloscPaczek = Convert.ToInt32(Math.Ceiling(ilosc / iloscWPaczce));
                int intDostawca = Convert.ToInt32(dgvListaOfert.CurrentRow.Cells[2].Value);
                int intOferta = Convert.ToInt32(dgvListaOfert.CurrentRow.Cells[1].Value);
                int intElementID = Convert.ToInt32(dgvListaOfert.CurrentRow.Cells[0].Value);
                PopupAcceptDeny popupAkceptujOdrzuc = new PopupAcceptDeny(true, intDostawca, intZamowienie, intIloscPaczek, intOferta, intElementID);
                popupAkceptujOdrzuc.Show();
                this.Hide();
            }
        }

        private void dgvMagazynZawartosc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (db.vZawartoscMagazynuDoPrzydzialu.Where(element => element.ID_Element == intElement).Any() == true)
            {
                int intPolka = Convert.ToInt32(dgvMagazynZawartosc.CurrentRow.Cells[0].Value);
                int intDostawa = Convert.ToInt32(dgvMagazynZawartosc.CurrentRow.Cells[2].Value);
                int intElement = Convert.ToInt32(dgvMagazynZawartosc.CurrentRow.Cells[1].Value);
                int intIlosc = Convert.ToInt32(dgvMagazynZawartosc.CurrentRow.Cells[3].Value);
                PopupAcceptDeny popupAkceptujOdrzuc = new PopupAcceptDeny(intPolka, intDostawa, intElement, intIlosc, intZamowienie);
                popupAkceptujOdrzuc.Show();
                this.Hide();
            }
        }
    }
}
