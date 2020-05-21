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
    public partial class DodawanieElementu : Form
    {
        public SzwalniaEntities db;
        public Elementy elementNew = new Elementy();
        public DodawanieElementu()
        {
            InitializeComponent();
            db = Start.szwalnia;
            cmbTyp.DataSource = db.Elementy_Typy.ToList();
            cmbTyp.ValueMember = "Typ";
            cmbTyp.DisplayMember = "Typ";
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
                elementNew.Element_Nazwa = txtNazwa.Text;
                elementNew.ID_Element_Typ = cmbTyp.SelectedIndex;
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
            }
        }

        private void DodawanieElementu_FormClosed(object sender, FormClosedEventArgs e)
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
