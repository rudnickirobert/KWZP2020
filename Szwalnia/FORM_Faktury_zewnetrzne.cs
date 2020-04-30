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
    public partial class FORM_Faktury_Zewnetrzne : Form
    {
        public SzwalniaEntities db;
        public FORM_Faktury_Zewnetrzne(SzwalniaEntities db, string firma_nazwa)
        {

            InitializeComponent();
            // Widok utworzony i pobierany poprawnie| blad bazy
            //Faktury_Zewnetrzne faktura = db.Faktury_Zewnetrzne.Where(f => f.Nazwa_Firmy == firma_nazwa).First();
            //string s = (faktura.Nr_Faktury).ToString();
            //TXTBOX1.Text = s;
            //TXTBOX2.Text = faktura.Nazwa_Firmy;
            //string x = (faktura.Netto).ToString();
            //TXTBOX3.Text = x;
            //string z = (faktura.Brutto).ToString();
            //TXTBOX4.Text = z;
            
        }

        private void FORM_Faktury_Zewnetrzne_Load(object sender, EventArgs e)
        {   
            this.vFakturyZewnetrzneTableAdapter.Fill(this.szwalniaDataSet1.vFakturyZewnetrzne);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LBL1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
