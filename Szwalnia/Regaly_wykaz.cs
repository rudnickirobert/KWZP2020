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
    public partial class Regaly_wykaz : Form
    {
        public SzwalniaEntities db;
        public Regaly_wykaz()
        {
            InitializeComponent();
            db = Start.szwalnia;
            dataGridView1.DataSource = db.Regaly.ToList();

        }
    }
}
