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
     public partial class DodawanieCechy : Form
    {
        public SzwalniaEntities db;
        public DodawanieCechy()
        {
            InitializeComponent();
            db = Start.szwalnia;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            List<Elementy_Cechy_Slownik> powtorzenie = db.Elementy_Cechy_Slownik.Where(nazwa => nazwa.Cecha == txtNazwa.Text).ToList();
            bool blad = false;
            if (powtorzenie.Any())
            { blad = true; }

            if (blad)
            { MessageBox.Show("Już istnieje taka cecha"); }
            else
            {
                Elementy_Cechy_Slownik cechaNew = new Elementy_Cechy_Slownik();
                cechaNew.Cecha = txtNazwa.Text;
                MessageBox.Show("Pomyślnie dodano nowy rekord do bazy danych.");
                db.Elementy_Cechy_Slownik.Add(cechaNew);
                db.SaveChanges();
                Start.DataBaseRefresh();
            }
        }

        private void DodawanieCechy_FormClosed(object sender, FormClosedEventArgs e)
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
