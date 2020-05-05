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
    public partial class PolkiNaRegaleForm : Form
    {
        public SzwalniaEntities db;
        public PolkiNaRegaleForm(SzwalniaEntities szwalnia_passed, string oznaczenie)
        {
            InitializeComponent();
        }
        private void dgvRegaly_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }    
}
