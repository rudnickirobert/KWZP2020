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
    public partial class ZamowDostawe : Form
    {
        public int intDostawaID;
        public int intCzasDostawyWGodzinach;
        public SzwalniaEntities db;
        public ZamowDostawe(int intDostawaID)
        {
            InitializeComponent();
            db = Start.szwalnia;
            this.intDostawaID = intDostawaID;
            lblInfo.Text = "Lista materiałów do zamówienia w dostawie nr " + Convert.ToString(intDostawaID) + ".";
            if (db.vDostawyZawartoscInformacjeDostawcy.Any())
            {
                dgvZawartoscDostawy.DataSource = db.vDostawyZawartoscInformacjeDostawcy.Where(wybrany => wybrany.ID_Dostawy == intDostawaID).ToList();
                dgvZawartoscDostawy.Columns[0].Visible = false;
                dgvZawartoscDostawy.Columns[1].Visible = false;
                dgvZawartoscDostawy.Columns[5].Visible = false;
                dgvZawartoscDostawy.Columns[6].Visible = false;
                dgvZawartoscDostawy.Columns[7].Visible = false;
                //dgvZawartoscDostawy.Columns[8].Visible = false;
                vDostawyZawartoscInformacjeDostawcy dowolnyWierszZDanymi = db.vDostawyZawartoscInformacjeDostawcy.Where(wybrany => wybrany.ID_Dostawy == intDostawaID).First();
                txtNazwa.Text = dowolnyWierszZDanymi.Nazwa;
                txtNumerTelefonu.Text = Convert.ToString(dowolnyWierszZDanymi.Telefon_1);
                txtEmail.Text = dowolnyWierszZDanymi.Email;
                intCzasDostawyWGodzinach = Convert.ToInt32(dowolnyWierszZDanymi.Deklarowany_czas_dostawy);
            }
            else
            {
                DataTable brakZawartosci = new DataTable();
                brakZawartosci.Columns.Add("Informacja");
                brakZawartosci.Rows.Add("Ta dostawa nie posiada zawartości do zamówienia");
                txtNazwa.Text = "Brak informacji";
                txtNumerTelefonu.Text = "Brak informacji";
                txtEmail.Text = "Brak informacji";
            }

        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            Zamowienia_Dostawy zaakceptowaneZamowienie = db.Zamowienia_Dostawy.Where(wybrany => wybrany.ID_Dostawy == intDostawaID).First();
            zaakceptowaneZamowienie.Data_Dostawy_Planowana = DateTime.Now.AddHours(intCzasDostawyWGodzinach);
            db.SaveChanges();
            Start.DataBaseRefresh();
            this.Close();
        }

        private void btnOdrzuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZamowDostawe_FormClosed(object sender, FormClosedEventArgs e)
        {
            WybierzZamowienie wybierzKolejne = new WybierzZamowienie();
            wybierzKolejne.Show();
        }
    }
}
