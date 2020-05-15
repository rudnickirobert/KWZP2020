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
        }
        private bool isUnique()
        {
            return db.Regaly.Where(regal => regal.Oznaczenie.Equals(txtOznaczenie.Text)).Count() == 0;
        }

        private void txtOznaczenie_TextChanged(object sender, EventArgs e)
        {
            if (txtOznaczenie.TextLength == 2)
                btnDodajRegal.Enabled = true;
            else btnDodajRegal.Enabled = false;
        }

        private void btnDodajRegal_Click(object sender, EventArgs e)
        {
            txtOznaczenie.Text = txtOznaczenie.Text.ToUpper();
            string nowy = txtOznaczenie.Text;
           
            Regaly regalNew = new Regaly();

            if (isUnique())
            {
                regalNew.Oznaczenie = txtOznaczenie.Text;
                db.Regaly.Add(regalNew);
                db.SaveChanges();
                MessageBox.Show("Pomyślnie dodano do bazy regał " + nowy);

                Regaly_wykaz wykaz = new Regaly_wykaz(); //to na razie jest tylko w celu sprawdzenia czy się dodał i pokazuje alfabetycznie
                wykaz.Show();
                this.Close();
            }
            else
                MessageBox.Show("Regał " + nowy + " już istnieje!");
                regalNew = null;    
        }

        private void NowyRegal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
