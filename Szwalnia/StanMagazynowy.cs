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
    public partial class StanMagazynowy : Form
    {
        public Start start;
        public StanMagazynowy(SzwalniaEntities szwalnia, Start startowy)
        {
            InitializeComponent();
            start = startowy;
        }

        private void StanMagazynowy_FormClosed(object sender, FormClosedEventArgs e)
        {
            start.Show();
        }
    }
}
