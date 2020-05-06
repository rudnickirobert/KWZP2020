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
    public partial class PrzegladProcesowProdukcyjnych : Form
    {
        public SzwalniaEntities db;
        public PrzegladProcesowProdukcyjnych(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnNumerZamowienia_Click(object sender, EventArgs e)
        {
            ZamowienieProcesyProdukcyjne zamowienieProcesyProdukcyjne = new ZamowienieProcesyProdukcyjne(db);
            zamowienieProcesyProdukcyjne.Show();
        }
    }
}
