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
    public partial class DodoawanieCechElementu : Form
    {
        public SzwalniaEntities szwalniaPassed;
        public Elementy_Cechy elemnetCechaNew = new Elementy_Cechy();
        public DodoawanieCechElementu()
        {
            InitializeComponent();
            
            
        }

        private void DodoawanieCechElementu_Load(object sender, EventArgs e)
        {            
            this.elementy_Cechy_SlownikTableAdapter.Fill(this.szwalniaDataSet2.Elementy_Cechy_Slownik);            
            this.elementyTableAdapter.Fill(this.szwalniaDataSet1.Elementy);            
            this.elementy_JednostkiTableAdapter.Fill(this.szwalniaDataSet.Elementy_Jednostki);
        }

        private void dgvListaElementy_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numIDElementu = Convert.ToInt32(dgvListaElementy.CurrentRow.Cells[0].Value);
            elemnetCechaNew.ID_Element = numIDElementu;
            txtIDElment.Text = numIDElementu.ToString();                   
        }

        private void dgvListaCecha_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numIDCechy = Convert.ToInt32(dgvListaCecha.CurrentRow.Cells[0].Value);
            elemnetCechaNew.ID_Cecha = numIDCechy;
            txtIDCechy.Text = numIDCechy.ToString();
        }

        private void dgvListaJednostek_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numIDJednostki = Convert.ToInt32(dgvListaJednostek.CurrentRow.Cells[0].Value);
            elemnetCechaNew.ID_Jednostka = numIDJednostki;
            txtIDJednostka.Text = numIDJednostki.ToString();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            szwalniaPassed.Elementy.Add(elemnetCechaNew);
        }
    }
}
