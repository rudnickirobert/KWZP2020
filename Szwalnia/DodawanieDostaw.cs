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
    public partial class DodawanieDostaw : Form
    {
        private static bool zamknieciePrzezInnyFormularz;
        public static bool czyZamknietyPrzezInny
        {
            get
            {
                return zamknieciePrzezInnyFormularz;
            }
            set
            {
                if (zamknieciePrzezInnyFormularz != value)
                    zamknieciePrzezInnyFormularz = value;
            }
        }
        public SzwalniaEntities db;
        public DodawanieDostaw(bool czyPuste)
        {
            InitializeComponent();
            db = Start.szwalnia;
            zamknieciePrzezInnyFormularz = false;
            if (czyPuste) 
            {
                dgvListaMaterialow.Visible = false;
            }
            else
            {
                dgvListaMaterialow.Visible = true;
                dgvListaMaterialow.DataSource = null;
                dgvListaMaterialow.DataSource = db.vMaterialyDoZamowieniaBrak.ToList();
                dgvListaMaterialow.Columns[0].HeaderText = "Numer zamówienia";
                dgvListaMaterialow.Columns[1].HeaderText = "Numer produktu";
                dgvListaMaterialow.Columns[2].HeaderText = "Nazwa produktu";
                dgvListaMaterialow.Columns[1].Visible = false;
                dgvListaMaterialow.Columns[3].HeaderText = "Brakująca ilość";
                dgvListaMaterialow.AutoResizeRows();
            }
        }

        private void DodawanieDostaw_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!zamknieciePrzezInnyFormularz)
            {
                Application.OpenForms[typeof(ObslugaDostaw).Name].Show();
            }
        }

        private void dgvListaMaterialow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int intIDZamowienia  = Convert.ToInt32(dgvListaMaterialow.CurrentRow.Cells[0].Value);
            int intIDElementu = Convert.ToInt32(dgvListaMaterialow.CurrentRow.Cells[1].Value);
            int intIlosc = Convert.ToInt32(dgvListaMaterialow.CurrentRow.Cells[3].Value);
            WyborOferty wybierzOferte = new WyborOferty(intIDZamowienia, intIDElementu, intIlosc);
            wybierzOferte.Show();
            this.Hide();
        }
    }
}
