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
    public partial class btnSearch : Form
    {
        public SzwalniaEntities szwalnia_passed;
        public btnSearch(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            szwalnia_passed = szwalnia;
        }

        private void txtRegal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
