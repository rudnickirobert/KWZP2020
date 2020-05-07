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
    public partial class NowaRealizacjaProcesu : Form
    {
        public SzwalniaEntities db;
        public int IdProcesu;
        public NowaRealizacjaProcesu(SzwalniaEntities db,int IdProcesu)
        {
            InitializeComponent();
            this.db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RodzajEtapu rodzaj = new RodzajEtapu(db);
            rodzaj.Show();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Realizacja_Procesu realizacjaProcesu = new Realizacja_Procesu();
            realizacjaProcesu.ID_Etapu = Convert.ToInt32(tbEtap.Text);
            db.Realizacja_Procesu.Add(realizacjaProcesu);
            db.SaveChanges();
            MessageBox.Show("Dodano nową realizację");

        }
    }
}
