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
    public partial class GdzieLezaElementy : Form
    {
        public SzwalniaEntities db;
        public GdzieLezaElementy(int idElement)
        {
            InitializeComponent();
            db = Start.szwalnia;
            Elementy thing = db.Elementy.Where(element => element.ID_Element == idElement).FirstOrDefault();
            lblTitle.Text = "Lokalizacje elementu: " + thing.Element_Nazwa + ", ID: " + thing.ID_Element.ToString();

            dgvLokalizacjeElementu.DataSource = db.vStan_magazynowy_polki.Where(stan => stan.Nr_elementu == idElement).ToList();
            dgvLokalizacjeElementu.Columns[0].Visible = false;
            dgvLokalizacjeElementu.Columns[3].Visible = false;
            dgvLokalizacjeElementu.Columns[4].Visible = false;
            dgvLokalizacjeElementu.Columns[7].Visible = false;
        }
    }
}
