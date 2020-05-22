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
    public partial class DodawanieJednostki : Form
    {
        public SzwalniaEntities db;
        public Elementy_Jednostki jednostkaNew = new Elementy_Jednostki();

        private bool isNotEmpty()
        {
            return txtNazwa.TextLength > 0;
        }

        private bool isUnique()
        {
            return !db.Elementy_Jednostki.Where(nazwa => nazwa.Jednostka == txtNazwa.Text).Any();
        }

        private void txtNazwa_TextChanged(object sender, EventArgs e)
        {
            if (isNotEmpty())
                btnDodaj.Enabled = true;
            else
                btnDodaj.Enabled = false;
        }

        public DodawanieJednostki()
        {
            InitializeComponent();
            db = Start.szwalnia;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            txtNazwa.Text = txtNazwa.Text.ToLower();

            if (isUnique())
            {
                jednostkaNew.Jednostka = txtNazwa.Text;
                db.Elementy_Jednostki.Add(jednostkaNew);
                db.SaveChanges();
                Start.DataBaseRefresh();
                MessageBox.Show("Pomyślnie dodano nowy rekord do bazy danych.");
            }
            else
                MessageBox.Show("Już istnieje taka jednostka");
        }

        private void DodawanieJednostki_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms[typeof(ElementyForm).Name].Show();
            this.Hide();
        }
    }
}
