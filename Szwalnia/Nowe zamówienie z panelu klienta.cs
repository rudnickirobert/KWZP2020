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
    public partial class NoweZamowienieZPaneluKlienta : Form
    {
        public SzwalniaEntities db;
        public int ostatniNumerZamowienia;
        public int idKlienta;
        public NoweZamowienieZPaneluKlienta(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            dgvUkryty.DataSource = db.Zamowienia.ToList();
            int numerOstatniegoZamowienia = dgvUkryty.Rows.Count;
            lblNumerZamowienia.Text = (numerOstatniegoZamowienia + 1).ToString();

            cbPracownik.ValueMember = "ID_Pracownika";
            cbPracownik.DisplayMember = "Imie_i_nazwisko_pracownika";
            cbPracownik.DataSource = db.vImieNazwiskoPracownika.ToList();
        }
        private void btnDalej_Click(object sender, EventArgs e)
        {
            Zamowienia zamowienia = new Zamowienia();
            zamowienia.Data_Zlozenia = Convert.ToDateTime(dtpZlozenie.Value);
            zamowienia.Umowa = Convert.ToBoolean(chbUmowa.Checked);
            zamowienia.ID_Klienta = Convert.ToInt32(lblNazwa);
            zamowienia.ID_Pracownika = Convert.ToInt32(cbPracownik.SelectedValue);
            db.Zamowienia.Add(zamowienia);
            db.SaveChanges();
            MessageBox.Show("Dodano nowe zamówienie, wybierz elementy zamówienia");
            this.Close();

            ElementyZamowienia elementyZamowienia = new ElementyZamowienia(db);
            elementyZamowienia.Show();
        }
    }
}
