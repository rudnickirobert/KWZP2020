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
    public partial class RegalyPolkiForm : Form
    {
        public SzwalniaEntities db;
        public RegalyPolkiForm(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            db = szwalnia;
            btnSearchStorage.Enabled = false;
        }
        private void txtStorage_TextChanged(object sender, EventArgs e)
        {
            if (txtStorage.TextLength > 0)
            {
                btnSearchStorage.Enabled = true;
            }
        }
        private void btnSearchStorage_Click(object sender, EventArgs e)
        {
            PolkiNaRegaleForm regal = new PolkiNaRegaleForm(db, txtStorage.Text);
            regal.Show();
            this.Close();
        }
    }
}
