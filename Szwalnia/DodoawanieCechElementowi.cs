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
    public partial class DodoawanieCechElementowi : Form
    {
        public SzwalniaEntities db;
        public DodoawanieCechElementowi(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            db = szwalnia;
            dgvListaElementow.DataSource = szwalnia.Elementy.ToList();
            dgvListaCech.DataSource = szwalnia.Elementy_Cechy_Slownik.ToList();
            dgvListaJednostek.DataSource = szwalnia.Elementy_Jednostki.ToList();
        }


    }
}
