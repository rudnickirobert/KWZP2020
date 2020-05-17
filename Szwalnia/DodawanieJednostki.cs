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
            jednostkaNew.Jednostka = txtNazwa.Text;           
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pomyślnie dodano nowy rekord do bazy danych.");
            db.Elementy_Jednostki.Add(jednostkaNew);
            db.SaveChanges();
        }

        private void DodawanieJednostki_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms["ElementyForm"].Show();
            this.Hide();
        }
    }
}
