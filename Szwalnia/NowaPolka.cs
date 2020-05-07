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
    public partial class NowaPolka : Form
    {
        int nowaPolka;
        public Start start;
        public NowaPolka(SzwalniaEntities db, Start startowy, int ostatniaPolka)
        {
            InitializeComponent();
            start = startowy;
            nowaPolka = ostatniaPolka+1;
            lblNumerNowejPolki.Text = nowaPolka.ToString();
        }

        private void NowaPolka_FormClosed(object sender, FormClosedEventArgs e)
        {
            start.Show();
        }
    }
}
