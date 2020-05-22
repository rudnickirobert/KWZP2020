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
        public bool czyZamowienie;
        public bool czyWracacDoStart;

        private bool isUnique()
        {
            return !db.Elementy_Typy.Where(nazwa => nazwa.Typ == txtNazwa.Text).Any();
        }
        public DodawanieTypu()
        {
            InitializeComponent();
            db = Start.szwalnia;
            typNew.Typ = txtNazwa.Text;
            czyWracacDoStart = true;
            typNew.Czy_wlasne = chBoxWlasny.Checked;
        }
        public DodawanieTypu(bool czyZamowienie)
        {
            InitializeComponent();
            db = Start.szwalnia;
            typNew.Typ = txtNazwa.Text;
            czyWracacDoStart = false;
            if (chBoxWlasny.Checked == true)
                typNew.Czy_wlasne = true;
            else 
                typNew.Czy_wlasne = false;  
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (isUnique())
            { 
                typNew.Typ = txtNazwa.Text;
                typNew.Czy_wlasne = chBoxWlasny.Checked;
                MessageBox.Show("Pomyślnie dodano nowy rekord do bazy danych.");
                db.Elementy_Typy.Add(typNew);
                db.SaveChanges();
                Start.DataBaseRefresh();
            }
            else
                MessageBox.Show("Już istnieje typ o takiej nazwie");
        }

        private void DodawanieTypu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (czyWracacDoStart)
                Start.GetForm.Show();
            else 
                this.Hide();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            if (czyWracacDoStart)
            {
                Application.OpenForms[typeof(ElementyForm).Name].Show();
                this.Hide();
            }
            else 
                this.Close();
        }

        private void txtNazwa_TextChanged(object sender, EventArgs e)
        {
            btnDodaj.Enabled = txtNazwa.TextLength > 0;
        }
    }
}
