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
    public partial class ElementSzczegoly : Form
    {
        public SzwalniaEntities db;
        public int numID;
        public ElementSzczegoly(int ID)
        {
            InitializeComponent();
            db = Start.szwalnia;
            numID = ID;
            Elementy element = db.Elementy.Where(wybrany => wybrany.ID_Element == ID).First();
            txtNazwa.Text = element.Element_Nazwa;
            lblElement.Text = "Elementu: " + element.Element_Nazwa + " (ID = " + element.ID_Element + ")";
            
            if (element.Okres_Przydatnosci_Miesiace == 0)
            {
                txtOkres.Text = "Nie dotyczy";
            }
            else
            {
                txtOkres.Text = element.Okres_Przydatnosci_Miesiace.ToString();
            }
            dgvSzczegol.DataSource = db.vCechyElementu.Where(details => details.ID_Element == element.ID_Element).ToList();
            dgvSzczegol.Columns[0].Visible = false; 
        }

        private void ElementSzczegoly_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms[typeof(WyborElementu).Name].Show();
            this.Hide();
        }

        private void btnDodawanieCech_Click(object sender, EventArgs e)
        {
            DodoawanieCechElementowi cechyElementu = new DodoawanieCechElementowi(numID);
            cechyElementu.Show();
            this.Hide();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Elementy elementUsun = db.Elementy.Where(wybrany => wybrany.ID_Element == numID).First();
            db.Elementy.Remove(elementUsun);
            db.SaveChanges();
            MessageBox.Show("Pomyślnie usunięto element");
            Application.OpenForms[typeof(ElementyForm).Name].Show();
            this.Hide();
        }
    }
}
