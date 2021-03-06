﻿using System;
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
    public partial class ZnajomoscJezykowWFirmie : Form
    {
        public SzwalniaEntities db;
        public ZnajomoscJezykowWFirmie(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;

            dgvJezyki.DataSource = db.vJezykiWFirmie.ToList();
            dgvJezyki.Columns[0].Visible = false;
        }
    }
}
