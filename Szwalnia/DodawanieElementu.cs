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
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class DodawanieElementu : Form
    {
        public SzwalniaEntities db;
        public Elementy elementNew = new Elementy();
        public bool czyProdukty;
        public bool czyMagazynUzywa;

        private bool isUnique()
        {
            return !db.Elementy.Where(nazwa => nazwa.Element_Nazwa == txtNazwa.Text).Any();
        }

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
            czyMagazynUzywa = false;
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
                numOkres.Enabled = true;
            else
                numOkres.Enabled = false;
        }

        private void txtNazwa_TextChanged(object sender, EventArgs e)
        {
            if (txtNazwa.TextLength > 0)
                btnDodaj.Enabled = true;
            else
                btnDodaj.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {            
            if (isUnique())
            {
                elementNew.Element_Nazwa = txtNazwa.Text;
                elementNew.ID_Element_Typ = Convert.ToInt32(cmbTyp.SelectedValue);

                if (chbOkres.Checked == false)
                    elementNew.Okres_Przydatnosci_Miesiace = Convert.ToInt32(numOkres.Value);
                else
                    elementNew.Okres_Przydatnosci_Miesiace = 0;

                MessageBox.Show("Pomyślnie dodano nowy rekord do bazy danych.");
                db.Elementy.Add(elementNew);
                db.SaveChanges();
                Start.DataBaseRefresh();
            }
            else
                MessageBox.Show("Już istnieje element o takiej nazwie!");

        }

        private void DodawanieElementu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (czyMagazynUzywa)
                Start.GetForm.Show(); 
            else
                this.Hide();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            if (czyMagazynUzywa)
            {
                Application.OpenForms[typeof(ElementyForm).Name].Show();
                this.Hide();
            }
            else
                this.Close();  
        }
    }
}
