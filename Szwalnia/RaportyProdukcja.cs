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
    public partial class RaportyProdukcja : Form
    {
        public SzwalniaEntities db;
        public RaportyProdukcja(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
        }
    }
}
