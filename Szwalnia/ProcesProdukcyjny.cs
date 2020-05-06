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
    public partial class ProcesProdukcyjny : Form
    {
        public SzwalniaEntities db;
        public ProcesProdukcyjny(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnPrzegladProcesow_Click(object sender, EventArgs e)
        {
            PrzegladProcesowProdukcyjnych formularzPrzegladProcesowProdukcyjnych = new PrzegladProcesowProdukcyjnych(db);
            formularzPrzegladProcesowProdukcyjnych.Show();
        }

        private void btnNowyProces_Click(object sender, EventArgs e)
        {
            NowyProces nowyProces = new NowyProces(db);
            nowyProces.Show();
        }
    }
}
