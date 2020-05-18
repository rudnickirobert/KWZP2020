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
    public partial class OdbierzMaterialZProdukcji : Form
    {
        public SzwalniaEntities db;
        public OdbierzMaterialZProdukcji()
        {
            InitializeComponent();
            db = Start.szwalnia;
            if (db.vNieodebraneMaterialyWgDostawy.Any())
            {
                dgvMaterialDoOdebrania.DataSource = db.vNieodebraneMaterialyWgDostawy.ToList();
            }
            else
            {
                DataTable informacjaOBrakuMaterialowDoOdbioru = new DataTable();
                informacjaOBrakuMaterialowDoOdbioru.Columns.Add("Informacja");
                informacjaOBrakuMaterialowDoOdbioru.Rows.Add("Brak resztek materiałów do odbioru");
                dgvMaterialDoOdebrania.DataSource = informacjaOBrakuMaterialowDoOdbioru;
            }
        }
    }
}
