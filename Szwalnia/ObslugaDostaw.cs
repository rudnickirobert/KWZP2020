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
    public partial class ObslugaDostaw : Form
    {
        public SzwalniaEntities db;
        public ObslugaDostaw()
        {
            InitializeComponent();
            db = Start.szwalnia;
        }

        private void ObslugaDostaw_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<MagazynForm>().Count() > 0)
            {
                Application.OpenForms[typeof(MagazynForm).Name].Show();
            }
            else
            {
                MagazynForm otworzNowyMagazynForm = new MagazynForm();
                otworzNowyMagazynForm.Show();
            }
        }

        private void ObslugaDostaw_Load(object sender, EventArgs e)
        {
             if (db.vMaterialyDoZamowieniaBrak.Where(elementDoZamowienia => elementDoZamowienia.ID_Element > 0).Any() == false)
            {
                lblInfo.Text = "";
            }
             else
            {
                lblInfo.Text = "Istnieją niezamówione materiały";
            }
        }

        private void btnAddDelivery_Click(object sender, EventArgs e)
        {
            if (db.vMaterialyDoZamowieniaBrak.Where(elementDoZamowienia => elementDoZamowienia.ID_Element > 0).Any() == false)
            {
                DodawanieDostaw formularzDodawanieDostaw = new DodawanieDostaw(true);
                formularzDodawanieDostaw.Show();
                this.Hide();
            }
            else
            {
                DodawanieDostaw formularzDodawanieDostaw = new DodawanieDostaw(false);
                formularzDodawanieDostaw.Show();
                this.Hide();
            }
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            if (db.vMaterialyDoZamowieniaBrak.Where(elementDoZamowienia => elementDoZamowienia.ID_Element > 0).Any() == false)
            {
                DodawanieDostaw formularzDodawanieDostaw = new DodawanieDostaw(true);
                formularzDodawanieDostaw.Show();
                this.Hide();
            }
            else
            {
                DodawanieDostaw formularzDodawanieDostaw = new DodawanieDostaw(false);
                formularzDodawanieDostaw.Show();
                this.Hide();
            }
        }

        private void btnPrzyjmijDostawe_Click(object sender, EventArgs e)
        {
            if (db.vDostawyDoOdbioru.Where(doOdebrania => doOdebrania.Ilosc>0).Any() == false)
            {
                PrzyjmowanieDostaw formularzPrzyjmowanieDostaw = new PrzyjmowanieDostaw(true);
                formularzPrzyjmowanieDostaw.Show();
                this.Hide();
            }
            else
            {
                PrzyjmowanieDostaw formularzPrzyjmowanieDostaw = new PrzyjmowanieDostaw(false);
                formularzPrzyjmowanieDostaw.Show();
                this.Hide();
            }

        }

        private void btnWydajProdukcji_Click(object sender, EventArgs e)
        {
            WydajMaterialProdukcji wydajNowyMaterial = new WydajMaterialProdukcji();
            wydajNowyMaterial.Show();
            this.Hide();
        }

        private void btnOdbierzMaterial_Click(object sender, EventArgs e)
        {
            OdbierzMaterialZProdukcji odbierzNieodebranyMaterial = new OdbierzMaterialZProdukcji();
            odbierzNieodebranyMaterial.Show();
            this.Hide();
        }
    }
}
