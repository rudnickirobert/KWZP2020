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

    public partial class Start : Form
    {
        public SzwalniaEntities db;
        public Start()
        {
            InitializeComponent();
            db = new SzwalniaEntities();
        }

        public static Start pomocniczy;
        public static Start GetForm
        {
            get
            {
                if (pomocniczy == null || pomocniczy.IsDisposed)
                    pomocniczy = new Start();
                return pomocniczy;
            }
        }


        static SzwalniaEntities szwalnia_static;
        private static readonly object padLock = new object();
        public static SzwalniaEntities szwalnia
        {
            get
            {
                lock (padLock)
                {
                    if (szwalnia_static == null)
                        szwalnia_static = new SzwalniaEntities();
                    return szwalnia_static;
                }
            }
        }
        private void btnMagazyn_Click(object sender, EventArgs e)
        {
            MagazynForm magForm = new MagazynForm();
            magForm.Show();
            this.Hide();
        }

        private void btnPrzygotowanieProdukcji_Click(object sender, EventArgs e)
        {
            PrzygotowanieProdukcji przygotowanieProdukcji = new PrzygotowanieProdukcji(db);
            przygotowanieProdukcji.Show();
        }

        private void btnProdukcja_Click(object sender, EventArgs e)
        {
            Produkcja formularzProdukcji = new Produkcja(db);
            formularzProdukcji.Show();
        }

        private void btnZarzadzanie_Click(object sender, EventArgs e)
        {
            ZarzadzanieForm zarzadzanieForm = new ZarzadzanieForm(db);
            zarzadzanieForm.Show();
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    } 
}
