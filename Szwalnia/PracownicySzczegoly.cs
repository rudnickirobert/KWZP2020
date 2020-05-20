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
    public partial class PracownicySzczegoly : Form
    {
        public PracownicySzczegoly(SzwalniaEntities db, int ID)
        {
            InitializeComponent();
            Pracownicy pracownicy = db.Pracownicy.Where(wybrane => wybrane.ID_Pracownika == ID).First();
            txtImie.Text = pracownicy.Imie;
            txtNazwisko.Text = pracownicy.Nazwisko;
            txtTelefonPracownika.Text = pracownicy.Telefon;

            dgvZatrudnienie.DataSource = db.vZatrudnieniePracownika.Where(zatrudnienie => zatrudnienie.ID_Pracownika == pracownicy.ID_Pracownika).ToList();
            dgvZatrudnienie.Columns[0].Visible = false;

            dgvJezyk.DataSource = db.vJezykiPracownika.Where(jezyk => jezyk.ID_Pracownika == pracownicy.ID_Pracownika).ToList();
            dgvJezyk.Columns[0].Visible = false;

            dgvUrlop.DataSource = db.vUrlopPracownika.Where(urlop => urlop.ID_Pracownika == pracownicy.ID_Pracownika).ToList();
            dgvUrlop.Columns[0].Visible = false;
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
