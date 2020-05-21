using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        Typy_cechy_rejestr rejestrNew = new Typy_cechy_rejestr();
        public int IDElement;
        public int IDCechy;
        public int IDTyp;
        public DodoawanieCechElementowi(int numIDElementu)
        {
            InitializeComponent();
            db = Start.szwalnia;   
            
            dgvListaCech.DataSource = db.Elementy_Cechy_Slownik.ToList();
            dgvListaCech.Columns[2].Visible = false;
            dgvListaCech.Columns[3].Visible = false;
            dgvListaCech.ReadOnly = true;

            dgvListaJednostek.DataSource = db.Elementy_Jednostki.ToList();           
            dgvListaJednostek.Columns[2].Visible = false;
            dgvListaJednostek.Columns[3].Visible = false;
            dgvListaJednostek.Columns[4].Visible = false;
            dgvListaJednostek.ReadOnly = true;

            cechaElementuNew.ID_Element = numIDElementu;
            IDElement = numIDElementu;
            Elementy element = db.Elementy.Where(wybranyElement => wybranyElement.ID_Element == numIDElementu).First();
            txtNazwa.Text = element.Element_Nazwa;            
            IDTyp = Convert.ToInt32(element.ID_Element_Typ);
            Elementy_Typy typ = db.Elementy_Typy.Where(wybranyElement => wybranyElement.ID_Element_Typ == IDTyp).First();
            txtTyp.Text = typ.Typ;
        }

        private void dgvListaCech_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numIDCechy = Convert.ToInt32(dgvListaCech.CurrentRow.Cells[0].Value);
            Elementy_Cechy_Slownik cecha = db.Elementy_Cechy_Slownik.Where(wybranyCecha => wybranyCecha.ID_Cecha == numIDCechy).First();
            cechaElementuNew.ID_Cecha = numIDCechy;
            IDCechy = numIDCechy;
            txtCechy.Text = cecha.Cecha;
        }

        private void dgvListaJednostek_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numIDJednostki = Convert.ToInt32(dgvListaJednostek.CurrentRow.Cells[0].Value);
            Elementy_Jednostki jednostka = db.Elementy_Jednostki.Where(wybranaJednostka => wybranaJednostka.ID_jednostka == numIDJednostki).First();
            cechaElementuNew.ID_Jednostka = numIDJednostki;
            txtJednostka.Text = jednostka.Jednostka;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            List<Elementy_Cechy> listaCechy= db.Elementy_Cechy.Where(cecha => cecha.ID_Cecha == IDCechy && cecha.ID_Element==IDElement).ToList();
            if (listaCechy.Any())
            {
                MessageBox.Show("Ta cecha została już przypisana");
                return;
            }
     
            if (txtCechy.TextLength == 0)
            {MessageBox.Show("Dodaj cechy"); }
            else if (txtJednostka.TextLength == 0)
            {MessageBox.Show("Dodaj jednostkę");}
            else
            {
                if (txtSlowna.TextLength == 0)
                { cechaElementuNew.Wartosc_Cechy_Slowna = null; }
                else
                { cechaElementuNew.Wartosc_Cechy_Slowna = txtSlowna.Text; }

                if (numCecha.Value == 0)
                { cechaElementuNew.Wartosc_Cechy_Liczbowa = null; }
                else
                { cechaElementuNew.Wartosc_Cechy_Liczbowa = Decimal.ToInt32(numCecha.Value); }
                                
                db.Elementy_Cechy.Add(cechaElementuNew);
                db.SaveChanges();
                Start.DataBaseRefresh();
                MessageBox.Show("Pomyślnie dodano nowy rekord do bazy danych.");
            }
        }

        private void btnRejestr_Click(object sender, EventArgs e)
        {

            List<Typy_cechy_rejestr> listaTypy = db.Typy_cechy_rejestr.Where(typ => typ.ID_typ == IDTyp && typ.ID_cecha == IDCechy).ToList();
            if (listaTypy.Any())
            {
                MessageBox.Show("Takie przypianie juz istnieje");
                return;
            }
            else
            {
                rejestrNew.ID_typ = IDTyp;
                rejestrNew.ID_cecha = IDCechy;
                db.Typy_cechy_rejestr.Add(rejestrNew);
                db.SaveChanges();
                Start.DataBaseRefresh();
            }
        }
        private void DodawanieCechElementowi_FormClosed(object sender, FormClosedEventArgs e)
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
