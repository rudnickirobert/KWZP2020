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
    public partial class NowyPracownik : Form
    {
        public SzwalniaEntities db;
        public int ostatniNumerPracownika;
        public NowyPracownik (SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            dgvUkryty.DataSource = db.Pracownicy.ToList();
            int numerOstatniegoPracownika = dgvUkryty.Rows.Count;
            lblNumerPracownika.Text = (numerOstatniegoPracownika + 1).ToString();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWyzeruj_Click(object sender, EventArgs e)
        {
            txtImie.Text = "";
            txtNazwisko.Text = "";
            txtPesel.Text = "";
            txtAdres.Text = "";
            txtTelefon.Text = "";
        }

        private void btnDalej_Click(object sender, EventArgs e)
        {
            Pracownicy pracownicy = new Pracownicy();
            pracownicy.Imie = txtImie.Text;
            pracownicy.Nazwisko = txtNazwisko.Text;
            pracownicy.Pesel = txtPesel.Text;
            pracownicy.Adres = txtAdres.Text;
            pracownicy.Telefon = txtTelefon.Text;
            db.Pracownicy.Add(pracownicy);
            db.SaveChanges();
            MessageBox.Show("Dodano nowego pracownika - usupełnij dane o zatrudnieniu");

            InformacjeOZatrudnieniu informacjeOZatrudnieniu = new InformacjeOZatrudnieniu(db);
            informacjeOZatrudnieniu.Show();
            this.Close();



        }
    }
}
