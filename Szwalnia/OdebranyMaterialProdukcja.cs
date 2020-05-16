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
    public partial class OdebranyMaterialProdukcja : Form
    {
        public SzwalniaEntities db;
        public int idProcesu;
        public OdebranyMaterialProdukcja(SzwalniaEntities db, int idProcesu)
        {
            InitializeComponent();
            this.db = db;
            this.idProcesu = idProcesu;
            dgvMaterial.DataSource = db.vOdebranyMaterial.Where(material => material.ID_Procesu_Produkcyjnego==idProcesu).ToList();
        }
    }
}
