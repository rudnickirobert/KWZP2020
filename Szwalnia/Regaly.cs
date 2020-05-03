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
    public partial class RegalyForm : Form
    {
        public SzwalniaEntities szwalnia_passed;
        public RegalyForm(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            szwalnia_passed = szwalnia;
            btnSearch.Enabled = false;
        }

        private void txtRegal_TextChanged(object sender, EventArgs e)
        {
            if (txtRegal.TextLength > 0)
                { btnSearch.Enabled = true;
            };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Zapelnienie_regalu regal = new Zapelnienie_regalu(szwalnia_passed, txtRegal.Text);
            regal.Show();
            this.Close();
        }
    }
}
