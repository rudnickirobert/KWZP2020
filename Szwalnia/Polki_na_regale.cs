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
    public partial class Polki_na_regale : Form
    {
        public Polki_na_regale(SzwalniaEntities szwalnia_passed, string oznaczenie)
        {
            InitializeComponent();
            vPolki_na_regalach storage = szwalnia_passed.vPolki_na_regalach.Where(regal => regal.Oznaczenie == oznaczenie).First();

            lblTitle.Text = "REGAL " + storage.Oznaczenie;

            dgvRegaly.DataSource = szwalnia_passed.vPolki_na_regalach.Where(regal => regal.Oznaczenie == storage.Oznaczenie).ToList();
        }
    }
}
