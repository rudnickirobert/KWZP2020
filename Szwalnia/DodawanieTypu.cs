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
            typNew.Czy_wlasne = chBoxWlasny.Checked;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pomyślnie dodano nowy rekord do bazy danych.");
            db.Elementy_Typy.Add(typNew);
            db.SaveChanges();
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
