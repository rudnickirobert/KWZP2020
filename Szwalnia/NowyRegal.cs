using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            dgv.DataSource = db.Regaly.ToList();
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
            bool unikalna = true;
            txtOznaczenie.Text = txtOznaczenie.Text.ToUpper();

            for (int i=0; i<db.Regaly.Count(); i++)
            {
                if (Equals(txtOznaczenie.Text, (dgv.Rows[i].Cells[1].Value)))
                {
                    MessageBox.Show("Podane oznaczenie regału jest już wykorzystywane");
                    unikalna = false;
                    break;
                }
            }

            if (unikalna == true)
            {
                regalNew.Oznaczenie = txtOznaczenie.Text;
                db.Regaly.Add(regalNew);
                db.SaveChanges();

                string nowy = txtOznaczenie.Text;
                MessageBox.Show("Pomyślnie dodano do bazy regał " + nowy);

                Regaly_wykaz wykaz = new Regaly_wykaz(); //to na razie jest tylko w celu sprawdzenia czy się dodał i pokazuje alfabetycznie
                wykaz.Show();
                this.Close();
            }
            else
                regalNew = null;                 
        }

        private void NowyRegal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
