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
    public partial class PrzygotowanieProdukcji : Form
    {
        private SzwalniaEntities szwalnia;
        public int ostatniNumerZamowienia;
        public int ostatniNumerProcesu;
        public PrzygotowanieProdukcji(SzwalniaEntities db)

        {
            InitializeComponent();
            szwalnia = db;
            
            cmbRodzajObslugi.DataSource = db.Rodzaj_Obslugi.ToList();
            cmbRodzajObslugi.DisplayMember = "Nazwa";
            cmbRodzajObslugi.ValueMember = "Nazwa";

            dgvProcesy.DataSource = szwalnia.vProces_technologiczny.ToList();
            dgvZamowienia.DataSource = szwalnia.vProces_technologiczny.ToList();
            dgvProcesy2.DataSource = szwalnia.vProcesy.ToList();

            int ostatniNumer = dgvProcesy.Rows.Cast<DataGridViewRow>().Max(wartosc => Convert.ToInt32(wartosc.Cells["Numer_zamówienia"].Value));
            ostatniNumerZamowienia = ostatniNumer;

            int ostatniNumerP = dgvProcesy2.Rows.Cast<DataGridViewRow>().Max(wartosc => Convert.ToInt32(wartosc.Cells["ID_Proces_Technologiczny"].Value));
            ostatniNumerProcesu = ostatniNumerP;

            cmbProcesy.DataSource = db.Rodzaj_Etapu.ToList();
            cmbProcesy.DisplayMember = "Nazwa";
            cmbProcesy.ValueMember = "Nazwa";

        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
           
            dgvObsluga.DataSource = szwalnia.vObsluga.Where(nazwa => nazwa.Rodzaj_obsługi == cmbRodzajObslugi.Text).ToList();
            
        }

        private void btnSzukajZamowienie_Click(object sender, EventArgs e)
           
        {
            if (nudNumerZamowienia.Value > 0)
            {
                if (nudNumerZamowienia.Value <= ostatniNumerZamowienia)
                {
                    dgvProcesy.DataSource = szwalnia.vProces_technologiczny.Where(zamowienie => zamowienie.Numer_zamówienia == nudNumerZamowienia.Value).ToList();
                    
                }
                else
                    MessageBox.Show("Nie istnieje takie ID Zamowienia!");
            }
            else
                MessageBox.Show("Wprowadź poprawne ID Zamowienia (wieksze od zera)!");

        }

        private void tab_Proces_technologiczny_MouseClick(object sender, MouseEventArgs e)
        {
            nudNumerZamowienia.Value = ostatniNumerZamowienia;
            if (nudNumerZamowienia.Value > 0)
            {
                if (nudNumerZamowienia.Value <= ostatniNumerZamowienia)
                {
                    dgvProcesy.DataSource = szwalnia.vProces_technologiczny.Where(zamowienie => zamowienie.Numer_zamówienia == nudNumerZamowienia.Value).ToList();

                }
                else
                    MessageBox.Show("Nie istnieje takie ID Zamowienia!");
            }
            else
                MessageBox.Show("Wprowadź poprawne ID Zamowienia (wieksze od zera)!");

            nudNumerProcesu.Value = ostatniNumerProcesu;
            dgvProcesy2.Columns["ID_Proces_Technologiczny"].Visible = false;

            if (nudNumerProcesu.Value > 0)
            {
                if (nudNumerProcesu.Value <= ostatniNumerProcesu)
                {
                    dgvProcesy2.DataSource = szwalnia.vProcesy.Where(zamowienie => zamowienie.ID_Proces_Technologiczny == nudNumerProcesu.Value).ToList();

                }
                else
                    MessageBox.Show("Nie istnieje takie ID Zamowienia!");
            }
            else
                MessageBox.Show("Wprowadź poprawne ID Zamowienia (wieksze od zera)!");
        }

        private void btnSzukajProces_Click(object sender, EventArgs e)
        {
            if (nudNumerProcesu.Value > 0)
            {
                if (nudNumerProcesu.Value <= ostatniNumerProcesu)
                {
                    dgvProcesy2.DataSource = szwalnia.vProcesy.Where(zamowienie => zamowienie.ID_Proces_Technologiczny == nudNumerProcesu.Value).ToList();

                }
                else
                    MessageBox.Show("Nie istnieje takie ID Zamowienia!");
            }
            else
                MessageBox.Show("Wprowadź poprawne ID Zamowienia (wieksze od zera)!");
        }

      
    }
   
}
