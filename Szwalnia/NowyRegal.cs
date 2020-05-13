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
        public NowyRegal()
        {
            InitializeComponent();
            db = Start.szwalnia;
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
            regalNew.Oznaczenie = txtOznaczenie.Text;
            db.Regaly.Add(regalNew);
            db.SaveChanges();

            string nowy = txtOznaczenie.Text;
            MessageBox.Show("Pomyślnie dodano do bazy regał " + nowy);

            Regaly_wykaz wykaz = new Regaly_wykaz();
            wykaz.Show();
        }

        private void NowyRegal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
