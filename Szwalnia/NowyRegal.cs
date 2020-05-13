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
    public partial class NowyRegal : Form
    {
        SzwalniaEntities db;
        public NowyRegal(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            db = szwalnia;
            btnDodajRegal.Enabled = false;
        }
        private void txtOznaczenie_TextChanged(object sender, EventArgs e)
        {
            if (txtOznaczenie.TextLength == 2)
                btnDodajRegal.Enabled = true;
            else btnDodajRegal.Enabled = false;
        }
        private void btnDodajRegal_Click(object sender, EventArgs e)
        {
            Regaly regalNew = new Regaly();
            string nowy = txtOznaczenie.Text;
            txtOznaczenie.Text = regalNew.Oznaczenie;
            db.Regaly.Add(regalNew);
            db.SaveChanges();
            MessageBox.Show("Pomyślnie dodano do bazy regał " + nowy);
        }

        private void NowyRegal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start start = new Start();
            start.Show();
        }
    }
}
