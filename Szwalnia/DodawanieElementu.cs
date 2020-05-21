using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class DodawanieElementu : Form
    {
        public SzwalniaEntities db;
        public Elementy elementNew = new Elementy();
        public bool czyProdukty;
        public bool czyMagazynUzywa=false;
        public DodawanieElementu()
        {
            InitializeComponent();
            db = Start.szwalnia;
            czyMagazynUzywa = true;
            cmbTyp.DataSource = db.Elementy_Typy.ToList();
            cmbTyp.ValueMember = "ID_Element_Typ";
            cmbTyp.DisplayMember = "Typ";
        }
        public DodawanieElementu(bool czyProdukty)
        {
            InitializeComponent();
            db = Start.szwalnia;
            this.czyProdukty = czyProdukty;
            if (czyProdukty==true)
            {
                //cmb typ daje tylko produkty "czy_wlasne 1"
                List<Elementy_Typy> produkty = db.Elementy_Typy.Where(typ => typ.Czy_wlasne == true).ToList();
                cmbTyp.DataSource = produkty.ToList();
                cmbTyp.ValueMember = "ID_Element_Typ";
                cmbTyp.DisplayMember = "Typ";                
            }
            else
            {
                //cmb typ daje wszystko oprocz produktow
                List<Elementy_Typy> nieProdukty = db.Elementy_Typy.Where(typ => typ.Czy_wlasne == false).ToList();
                cmbTyp.DataSource = nieProdukty.ToList();
                cmbTyp.ValueMember = "ID_Element_Typ";
                cmbTyp.DisplayMember = "Typ";
            }
        }


        private void chbOkres_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOkres.Checked == false)
            {
                numOkres.Enabled = true;
            }
            else
            {
                numOkres.Enabled = false;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtNazwa.TextLength == 0)
            {
                MessageBox.Show("Nazwa nie może być pusta");
            }
            else
            {
                List<Typy_cechy_rejestr> nazwa = db.Typy_cechy_rejestr.Where(typ => typ.ID_typ == cmbTyp.SelectedIndex).ToList();
                Elementy_Cechy nowaCecha = new Elementy_Cechy();
                foreach (Typy_cechy_rejestr wierszWybrany in nazwa)
                {
                    nowaCecha.ID_Cecha = wierszWybrany.ID_cecha;
                    db.Elementy_Cechy.Add(nowaCecha);
                    db.SaveChanges();
                    Start.DataBaseRefresh();               
                }
                elementNew.Element_Nazwa = txtNazwa.Text;           
                elementNew.ID_Element_Typ =Convert.ToInt32(cmbTyp.SelectedValue);
                if (chbOkres.Checked == false)
                {                    
                    elementNew.Okres_Przydatnosci_Miesiace = Decimal.ToInt32(numOkres.Value);
                }
                else
                {
                    elementNew.Okres_Przydatnosci_Miesiace = 0;
                }
                MessageBox.Show("Pomyślnie dodano nowy rekord do bazy danych.");
                db.Elementy.Add(elementNew);
                db.SaveChanges();
                Start.DataBaseRefresh();
            }
        }

        private void DodawanieElementu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (czyMagazynUzywa)
            {
                Start.GetForm.Show();
            }            
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            if (czyMagazynUzywa)
            {
                Application.OpenForms[typeof(ElementyForm).Name].Show();
                this.Hide();
            }
            else
            {
                this.Close();
            }    
        }

    }
}
