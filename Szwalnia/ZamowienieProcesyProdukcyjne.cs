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
    public partial class ZamowienieProcesyProdukcyjne : Form
    {
        public SzwalniaEntities db;
        public int ostatniNumerZamowienia;
        public ZamowienieProcesyProdukcyjne(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            if (nudNumerZamowienia.Value > 0)
            {
                if (nudNumerZamowienia.Value <= ostatniNumerZamowienia)
                {
                   
                }
                else
                    MessageBox.Show("Nie istnieje takie ID Zamowienia!");
            }
            else
                MessageBox.Show("Wprowadź poprawne ID Zamowienia (wieksze od zera)!");
        }
    }
}
