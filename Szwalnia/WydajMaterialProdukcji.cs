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
    public partial class WydajMaterialProdukcji : Form
    {
        public SzwalniaEntities db;
        public WydajMaterialProdukcji()
        {
            InitializeComponent();
            db = Start.szwalnia;
            if (db.vDostawyDoWydania.Any())
            {
                dgvMaterialyDoWydania.DataSource = db.vDostawyDoWydania.Where(dostawa => dostawa.ID_Zamowienie_Element > 0).ToList();
            }
            else
            {
                DataTable brakDostawDoWydania = new DataTable();
                brakDostawDoWydania.Columns.Add("Informacja");
                brakDostawDoWydania.Rows.Add("Brak dostaw do wydania");
                dgvMaterialyDoWydania.DataSource = brakDostawDoWydania;
            }    
        }
    }
}
