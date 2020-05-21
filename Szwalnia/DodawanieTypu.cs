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
    public partial class DodawanieTypu : Form
    {
        public SzwalniaEntities db;
        public Elementy_Typy typNew = new Elementy_Typy();
        public DodawanieTypu()
        {
            InitializeComponent();
            db = Start.szwalnia;
            typNew.Typ = txtNazwa.Text;
            if (chBoxWlasny.Checked == true)
            { typNew.Czy_wlasne = true; }
            else { typNew.Czy_wlasne = false; }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            List<Elementy_Typy> powtorzenie = db.Elementy_Typy.Where(nazwa => nazwa.Typ == txtNazwa.Text).ToList();
            bool blad = false;
            if (powtorzenie.Any())
            { blad = true; }

            if (blad)
            { MessageBox.Show("Już istnieje taki typ"); }
            else
            {
                typNew.Typ = txtNazwa.Text;
                typNew.Czy_wlasne = chBoxWlasny.Checked;
                MessageBox.Show("Pomyślnie dodano nowy rekord do bazy danych.");
                db.Elementy_Typy.Add(typNew);
                db.SaveChanges();
                Start.DataBaseRefresh();
            }
        }

        private void DodawanieTypu_FormClosed(object sender, FormClosedEventArgs e)
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
