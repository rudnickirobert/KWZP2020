using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Szwalnia
{
    public partial class PrzyjmowanieGotowychProduktow : Form
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
        public PrzyjmowanieGotowychProduktow()
        {
            InitializeComponent();
            db = Start.szwalnia;
            dgvGotoweProdukty.ReadOnly = true;

            if (db.vOdbior_Gotowych_Produktow.Any())
            {
                dgvGotoweProdukty.DataSource = db.vOdbior_Gotowych_Produktow.ToList();
            }
            else
            {
                DataTable brakProduktow = new DataTable();
                brakProduktow.Columns.Add("Informacja");
                brakProduktow.Rows.Add("Brak produktów do przyjęcia");
                dgvGotoweProdukty.DataSource = brakProduktow;
                dgvGotoweProdukty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void PrzyjmowanieGotowychProduktow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!zamknieciePrzezInnyFormularz)
            {
                Application.OpenForms[typeof(ObslugaZamowien).Name].Show();
            }
        }

        private void dgvGotoweProdukty_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int intZamowienieID = Convert.ToInt32(dgvGotoweProdukty.CurrentRow.Cells[0].Value);
            if (db.vOdbior_Gotowych_Produktow.Where(doOdebrania => doOdebrania.ID_Zamowienia == intZamowienieID).Any())
            {
                int intElementID = Convert.ToInt32(dgvGotoweProdukty.CurrentRow.Cells[3].Value);
                int intIloscSztuk = Convert.ToInt32(dgvGotoweProdukty.CurrentRow.Cells[4].Value);
                WyborPolkiDoOdlozenia wybieraniePolkiDoOdlozeniaElementu = new WyborPolkiDoOdlozenia("przyjecieGotowychProduktow", intZamowienieID, intElementID, intIloscSztuk);
                wybieraniePolkiDoOdlozeniaElementu.Show();
                this.Hide();
            }
        }
    }
}
