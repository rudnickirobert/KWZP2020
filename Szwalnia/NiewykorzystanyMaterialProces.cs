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
    public partial class NiewykorzystanyMaterialProces : Form
    {
        public SzwalniaEntities db;
        public int IdProcesu;
        public NiewykorzystanyMaterialProces(SzwalniaEntities db, int IdProcesu )
        {
            InitializeComponent();
            this.db = db;
            this.IdProcesu = IdProcesu;
            Proces_Produkcyjny proces = db.Proces_Produkcyjny.Where(wybrany => wybrany.ID_Procesu_Produkcyjnego == IdProcesu).First();
            lblTekst.Text = "Realizacja procesu dla procesu produkcyjnego o ID " + proces.ID_Procesu_Produkcyjnego;
            dgvNiewykorzystanyMaterial.DataSource = db.Material_Na_Produkcji.Where(material => material.ID_Procesu_Produkcyjnego == proces.ID_Procesu_Produkcyjnego).ToList();
            dgvNiewykorzystanyMaterial.Columns[0].Visible = false;
        }
    }
}
