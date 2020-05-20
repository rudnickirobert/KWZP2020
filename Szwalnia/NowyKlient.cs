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
    public partial class NowyKlient : Form
    {
        public SzwalniaEntities db;
        public int ostatniNumerKlienta;
        public NowyKlient(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            dgvUkryty.DataSource = db.Klienci.ToList();
            int numerOstatniegoKlienta = dgvUkryty.Rows.Count;
            lblNumerKlienta.Text = (numerOstatniegoKlienta + 1).ToString();
        }
        private void btnWyzeruj_Click(object sender, EventArgs e)
        {
            txtImie.Text = "";
            txtNazwisko.Text = "";
            txtNazwaFirmy.Text = "";
            txtNIP.Text = "";
            txtAdres.Text = "";
            txtOdleglosc.Text = "";
            txtTelefon.Text = "";
            txtEmail.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Klienci klienci = new Klienci();
            klienci.Imie = txtImie.Text;
            klienci.Nazwisko = txtNazwisko.Text;
            klienci.Nazwa_Firmy = txtNazwaFirmy.Text;
            klienci.NIP = txtNIP.Text;
            klienci.Adres = txtAdres.Text;
            klienci.Odleglosc_km = txtOdleglosc.Text;
            klienci.Telefon = txtTelefon.Text;
            klienci.E_Mail = txtEmail.Text;
            db.Klienci.Add(klienci);
            db.SaveChanges();
            MessageBox.Show("Dodano nowego klienta");
            this.Close();
        }
    }
}
