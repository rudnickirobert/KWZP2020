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
        public DodawanieJednostki()
        {
            InitializeComponent();
            db = Start.szwalnia;                    
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            List<Elementy_Jednostki> powtorzenie = db.Elementy_Jednostki.Where(nazwa => nazwa.Jednostka.ToLower() == txtNazwa.Text).ToList();
            bool blad = false;
            if (powtorzenie.Any())
            { blad = true; }

            if (blad)
            {
                MessageBox.Show("Już istnieje taka jednostka");
            }
            else
            {
                jednostkaNew.Jednostka = txtNazwa.Text;
                MessageBox.Show("Pomyślnie dodano nowy rekord do bazy danych.");
                db.Elementy_Jednostki.Add(jednostkaNew);
                db.SaveChanges();
                Start.DataBaseRefresh();
            }
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
