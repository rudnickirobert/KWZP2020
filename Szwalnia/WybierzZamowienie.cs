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
    public partial class WybierzZamowienie : Form
    {
        public SzwalniaEntities db;
        public bool czyOtworzycPoprzedni = true;
        public WybierzZamowienie()
        {
            InitializeComponent();
            db = Start.szwalnia;
            if(db.vZamowieniaDoWykonaniaUDostawcy.Any())
            {
                cmbListaZamowien.DataSource = db.vZamowieniaDoWykonaniaUDostawcy.ToList();
                cmbListaZamowien.DisplayMember = "ID_Dostawy";
                cmbListaZamowien.ValueMember = "ID_Dostawy";
            }
            else
            {
                DataTable brakZamowien = new DataTable();
                brakZamowien.Columns.Add("Informacja");
                brakZamowien.Rows.Add("Nie ma żadnych niezamówionych dostaw");
                cmbListaZamowien.DataSource = brakZamowien;
                cmbListaZamowien.DisplayMember = "Informacja";
                cmbListaZamowien.ValueMember = "Informacja";

            }
        }

        private void btnAkceptuj_Click(object sender, EventArgs e)
        {
            if (db.vZamowieniaDoWykonaniaUDostawcy.Any())
            {
                int intDostawaID = Convert.ToInt32(cmbListaZamowien.SelectedValue);
                ZamowDostawe zamowDostawe = new ZamowDostawe(intDostawaID);
                czyOtworzycPoprzedni = false;
                zamowDostawe.Show();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void WybierzZamowienie_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (czyOtworzycPoprzedni)
            {
                Application.OpenForms[typeof(ObslugaDostaw).Name].Show();
            }
        }
    }
}
