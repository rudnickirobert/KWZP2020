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
            if (czyProdukty)
            {
                //cmb typ daje tylko produkty 
                List<Elementy_Typy> produkty = db.Elementy_Typy.Where(typ => typ.Czy_wlasne == true).ToList();
                cmbTyp.DataSource = produkty.ToList();
                cmbTyp.ValueMember = "ID_Element_Typ";
                cmbTyp.DisplayMember = "Typ";
                chbOkres.Checked = true;
                numOkres.Enabled = false;

            }
            else
            {
                //cmb typ daje wszystko oprocz produktow
                List<Elementy_Typy> nieProdukty = db.Elementy_Typy.Where(typ => typ.Czy_wlasne == false).ToList();
                cmbTyp.DataSource = nieProdukty.ToList();
                cmbTyp.ValueMember = "ID_Element_Typ";
                cmbTyp.DisplayMember = "Typ";
                chbOkres.Checked = true;
                numOkres.Enabled = false;
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
            List<Elementy> powtorzenie = db.Elementy.Where(nazwa => nazwa.Element_Nazwa.ToLower() == txtNazwa.Text).ToList();
            bool blad=powtorzenie.Any();

            if (txtNazwa.TextLength == 0)
            {
                MessageBox.Show("Nazwa nie może być pusta");
            }
            else if(blad)
            { MessageBox.Show("Już istnieje taki element"); }
            else
            {
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
            else
            { this.Hide(); }
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
