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
    public partial class WyborOferty : Form
    {
        public SzwalniaEntities db;
        public WyborOferty(int intZamowienie, int intElement, int intIlosc)
        {
            InitializeComponent();
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
    }
}
