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
    public partial class DodoawanieCechElementowi : Form
    {
        public SzwalniaEntities db;
        Elementy_Cechy cechaElementuNew = new Elementy_Cechy();
        public DodoawanieCechElementowi(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            db = szwalnia;
            dgvListaElementow.DataSource = szwalnia.Elementy.ToList();
            dgvListaCech.DataSource = szwalnia.Elementy_Cechy_Slownik.ToList();
            dgvListaJednostek.DataSource = szwalnia.Elementy_Jednostki.ToList();
            cechaElementuNew.Wartosc_Cechy_Slowna = txtSlowna.Text;
            if (numCecha.Value == 0)
            { cechaElementuNew.Wartosc_Cechy_Liczbowa = Decimal.ToInt32(numCecha.Value); }
            else
            { cechaElementuNew.Wartosc_Cechy_Liczbowa = null; }            
        }

        private void dgvListaElementow_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numIDElementu = Convert.ToInt32(dgvListaElementow.CurrentRow.Cells[0].Value);
            Elementy element = db.Elementy.Where(wybranyElement => wybranyElement.ID_Element == numIDElementu).First();
            cechaElementuNew.ID_Element = numIDElementu;
            txtNazwa.Text = element.Element_Nazwa;
        }

        private void dgvListaCech_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numIDCechy = Convert.ToInt32(dgvListaElementow.CurrentRow.Cells[0].Value);
            Elementy_Cechy_Slownik cecha = db.Elementy_Cechy_Slownik.Where(wybranyCecha => wybranyCecha.ID_Cecha == numIDCechy).First();
            cechaElementuNew.ID_Cecha = numIDCechy;
            txtCechy.Text = cecha.Cecha;
        }

        private void dgvListaJednostek_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numIDJednostki = Convert.ToInt32(dgvListaElementow.CurrentRow.Cells[0].Value);
            Elementy_Jednostki jednostka = db.Elementy_Jednostki.Where(wybranaJednostka => wybranaJednostka.ID_jednostka == numIDJednostki).First();
            cechaElementuNew.ID_Jednostka = numIDJednostki;
            txtJednostka.Text = jednostka.Jednostka;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            db.Elementy_Cechy.Add(cechaElementuNew);
        }
    }
}
