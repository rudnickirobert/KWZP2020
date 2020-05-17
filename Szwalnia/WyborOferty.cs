using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class WyborOferty : Form
    {
        private static bool zamknieciePrzezInnyFormularz;
        public static bool czyZamknietyPrzezInny {
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
        public int intIlosc;
        public int intElement;
        public int intZamowienie;
        public int intIloscPaczek;
        public SzwalniaEntities db;
        public WyborOferty(int intZamowienie, int intElement, int intIlosc)
        {
            InitializeComponent();
            zamknieciePrzezInnyFormularz = false;
            this.intIlosc = intIlosc;
            this.intElement = intElement;
            this.intZamowienie = intZamowienie;

            db = Start.szwalnia;
            if (db.Oferta.Where(element => element.ID_Element == intElement).Any() == true)
            {
                dgvListaOfert.DataSource = db.vOferta.Where(element => element.ID_Element == intElement).ToList();
                dgvListaOfert.Columns[0].Visible = false;
                dgvListaOfert.Columns[1].Visible = false;
                dgvListaOfert.Columns[2].Visible = false;
            }
            else
            {
                dgvListaOfert.Visible = false;
            }
            
        }

        private void WyborOferty_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!zamknieciePrzezInnyFormularz)
            {
                Start.GetForm.Show();
            }
        }

        private void dgvListaOfert_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int intDostawca = Convert.ToInt32(dgvListaOfert.CurrentRow.Cells[2].Value);
            PopupAcceptDeny popupAkceptujOdrzuc = new PopupAcceptDeny(intDostawca);
            popupAkceptujOdrzuc.Show();
            this.Hide();
        }
    }
}
