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
        public ElementSzczegoly(int ID)
        {
            InitializeComponent();
            db = Start.szwalnia;
            Elementy element = db.Elementy.Where(wybrany => wybrany.ID_Element == ID).First();
            lblElement.Text = "Szczegoly elementu o ID: " + element.ID_Element;
            txtNazwa.Text = element.Element_Nazwa;
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
    }
}
