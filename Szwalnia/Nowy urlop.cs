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
    public partial class NowyUrlop : Form
    {
        public SzwalniaEntities db;
        public NowyUrlop(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;

            cbPracownik.DataSource = db.vImieNazwiskoPracownika.ToList();
            cbPracownik.ValueMember = "ID_Pracownika";
            cbPracownik.DisplayMember = "Imie i nazwisko pracownika";

            cbRodzaj.DataSource = db.Rodzaj_Urlopu.ToList();
            cbRodzaj.ValueMember = "ID_Rodzaj_Urlopu";
            cbRodzaj.DisplayMember = "Nazwa";
            cbRodzaj.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Urlop urlop = new Urlop();
            urlop.ID_Pracownika = Convert.ToInt32(cbPracownik.SelectedValue);
            urlop.ID_Rodzaj_Urlopu = Convert.ToInt32(cbRodzaj.SelectedValue);
            urlop.Data_rozpoczecia = Convert.ToDateTime(dtpRozpoczecie.Value);
            urlop.Data_zakonczenia = Convert.ToDateTime(dtpZakonczenie.Value);
            db.Urlop.Add(urlop);
            db.SaveChanges();
            MessageBox.Show("Dodano nowe urlop pracownikowi");
            this.Close();
        }
    }
}