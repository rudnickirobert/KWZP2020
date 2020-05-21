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
    public partial class NoweZamowienie : Form
    {
        public SzwalniaEntities db;
        public int ostatniNumerZamowienia;
        public NoweZamowienie(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            dgvUkryty.DataSource = db.Zamowienia.ToList();
            int numerOstatniegoZamowienia = dgvUkryty.Rows.Count;
            lblNumerZamowienia.Text = (numerOstatniegoZamowienia + 1).ToString();
            
            
            cbNazwa.DataSource = db.Klienci.ToList();
            cbNazwa.ValueMember = "ID_Klienta";
            cbNazwa.DisplayMember = "Nazwa_Firmy";

            cbPracownik.DataSource = db.vWolniPracownicyZarzadzanie.ToList();
            cbPracownik.ValueMember = "ID_Pracownika";
            cbPracownik.DisplayMember = "Pracownik";
            cbPracownik.Refresh();
           
            
        }
        private void btnDalej_Click(object sender, EventArgs e)
        {
            Zamowienia zamowienia = new Zamowienia();
            zamowienia.Data_Zlozenia = Convert.ToDateTime(dtpZlozenie.Value);
            zamowienia.Umowa = Convert.ToBoolean(chbUmowa.Checked);
            zamowienia.ID_Klienta = Convert.ToInt32(cbNazwa.SelectedValue);
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
