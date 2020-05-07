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
        public SzwalniaEntities szwalniaPassed;
        public Elementy elemnetNew = new Elementy();
        public DodawanieElementu()
        {
            InitializeComponent();            
            dgvListaTypy.DataSource = szwalniaPassed.Elementy_Typy.ToList();
            elemnetNew.Element_Nazwa = txtNazwa.Text;
            elemnetNew.Okres_Przydatnosci_Miesiace = Decimal.ToInt32(numOkres.Value);
        }

        private void dgvListaTypy_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numID = Convert.ToInt32(dgvListaTypy.CurrentRow.Cells[0].Value);
            elemnetNew.ID_Element_Typ = numID;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            szwalniaPassed.Elementy.Add(elemnetNew);
            //szwalniaPassed.SaveChanges();
        }
    }
}
