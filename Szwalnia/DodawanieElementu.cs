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
            dgvListaTypy.DataSource = db.Elementy_Typy.ToList();
            elementNew.Element_Nazwa = txtNazwa.Text;
            elementNew.Okres_Przydatnosci_Miesiace = Decimal.ToInt32(numOkres.Value);
        }

        private void dgvListaTypy_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numID = Convert.ToInt32(dgvListaTypy.CurrentRow.Cells[0].Value);
            elementNew.ID_Element_Typ = numID;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            db.Elementy.Add(elementNew);
        }

        private void DodawanieElementu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
