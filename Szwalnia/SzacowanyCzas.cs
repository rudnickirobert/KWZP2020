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
    
    public partial class SzacowanyCzas : Form
    {
        public SzwalniaEntities db;
        public DateTime czasWykonania;
        public DateTime czasTeraz;
        public TimeSpan czasTeraz2;
        public int godziny;
        public double czasSzt;
        public string czasSztString;
        public double czasWieluSztuk;
        public int czasWieluSztukInt;
        public int czasObliczeniowy;
        public int czasObliczeniowyDni;
        public SzacowanyCzas(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;

            cmbNazwaProduktu.DataSource = db.vSredniCzasSztuki.ToList();
            cmbNazwaProduktu.DisplayMember = "Nazwa_produktu";
            cmbNazwaProduktu.ValueMember = "Nazwa_produktu";
        }

        private void btnObliczDate_Click(object sender, EventArgs e)
        {
            vSredniCzasSztuki szacCzas = db.vSredniCzasSztuki.Where(nazwaProduktu => nazwaProduktu.Nazwa_produktu == cmbNazwaProduktu.Text).First();
            czasSztString = szacCzas.Sredni_czas_szt.ToString();
            czasSzt = Convert.ToDouble(czasSztString);
            czasWieluSztuk = Convert.ToDouble(numLiczbaSztuk.Value);
            czasWieluSztuk = czasWieluSztuk * czasSzt;
            czasWieluSztukInt = Convert.ToInt32(czasWieluSztuk);
            czasTeraz = DateTime.Now;
            czasTeraz2 = czasTeraz.TimeOfDay;
            godziny = czasTeraz2.Hours;
            int ostatniaGodzinaPracy = 22;
            int czasPracy = 16;
            int dobowaPrzerwa = 8;
            int weekend = 48;
            int piatek = 5;

            if ((ostatniaGodzinaPracy - godziny) > czasWieluSztukInt)
            {
                czasObliczeniowy = czasWieluSztukInt;
            }
            else {
                czasObliczeniowyDni = (czasWieluSztukInt - (ostatniaGodzinaPracy - godziny)) / czasPracy + 1; 
                

                if ((Convert.ToInt32(czasTeraz.DayOfWeek) + czasObliczeniowyDni) > piatek )
                {
                    czasObliczeniowy = czasObliczeniowyDni * dobowaPrzerwa + weekend + czasWieluSztukInt;
                }
                else czasObliczeniowy = (czasObliczeniowyDni * dobowaPrzerwa) + czasWieluSztukInt;
            }

            czasWykonania = DateTime.Now;
            czasWykonania = czasWykonania.AddHours(czasObliczeniowy);
            txtSzacowanaData.Text = Convert.ToString( czasWykonania);                      
        }
    }
}
