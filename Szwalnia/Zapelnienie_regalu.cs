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
    public partial class Zapelnienie_regalu : Form
    {
        public Zapelnienie_regalu(SzwalniaEntities szwalnia_passed, string oznaczenie)
        {
            InitializeComponent();
            vRegaly storage = szwalnia_passed.vRegaly.Where(regal => regal.Oznaczenie == oznaczenie).First();

            lblTitle.Text = "REGAL " + storage.Oznaczenie;

            dgvRegaly.DataSource = szwalnia_passed.vRegaly.Where(regal => regal.Oznaczenie == storage.Oznaczenie).ToList();
        }
    }
}
