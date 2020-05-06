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
    public partial class NowyRodzajEtapu : Form
    {
        public SzwalniaEntities db;
        public NowyRodzajEtapu(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnWyzerujEtap_Click(object sender, EventArgs e)
        {
            tbNazwaEtapu.Text = "";
        }

        private void btnAnulujEtap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
