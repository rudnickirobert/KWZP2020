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
    public partial class NowyRozmiarPolki : Form
    {
        public SzwalniaEntities db;
        public NowyRozmiarPolki()
        {
            InitializeComponent();
            db = Start.szwalnia;
        }

        bool allFilled()
        {
            return mtxtWysokosc.Text != "" & mtxtSzerokosc.Text != "" && mtxtGlebokosc.Text != "";              
        }

        bool correctData()
        {
            return Convert.ToInt16(mtxtWysokosc.Text) > 0 && Convert.ToInt16(mtxtSzerokosc.Text) > 0 && Convert.ToInt16(mtxtGlebokosc.Text) > 0;
        }

        bool isUnique()
        {
            int wysokosc = Convert.ToInt16(mtxtWysokosc.Text);
            int szerokosc = Convert.ToInt16(mtxtSzerokosc.Text);
            int glebokosc = Convert.ToInt16(mtxtGlebokosc.Text);
            return !(db.Polki_Rozmiary.Where(rozmiar => rozmiar.Wysokosc == wysokosc).Count() > 0 
                && db.Polki_Rozmiary.Where(rozmiar => rozmiar.Szerokosc == szerokosc).Count() > 0 
                && db.Polki_Rozmiary.Where(rozmiar => rozmiar.Glebokosc == glebokosc).Count() > 0);
        }

        private void btnDodajRozmiar_Click(object sender, EventArgs e)
        {
            if (allFilled() && correctData() && isUnique())
            {
                Polki_Rozmiary rozmiarNew = new Polki_Rozmiary();
                rozmiarNew.Wysokosc = Int16.Parse(mtxtWysokosc.Text);
                rozmiarNew.Szerokosc = Int16.Parse(mtxtSzerokosc.Text);
                rozmiarNew.Glebokosc = Int16.Parse(mtxtGlebokosc.Text);

                    db.Polki_Rozmiary.Add(rozmiarNew);
                    db.SaveChanges();
                    MessageBox.Show("Pomyślnie dodano rozmiar półkę o wymiarach " + Convert.ToInt16(mtxtWysokosc.Text).ToString() + " x " + 
                        Convert.ToInt16(mtxtSzerokosc.Text).ToString() + " x " + Convert.ToInt16(mtxtGlebokosc.Text).ToString() + " cm.");
            }
            else if (allFilled() == false)
                MessageBox.Show("Uzupełnij wszystkie pola tekstowe!");
            else if (correctData() == false)
                MessageBox.Show("Wprowadź prawidłowe wartości wymiarów!");
            else
                MessageBox.Show("Rozmiar półki o zaproponowanych wymiarach już istnieje!");
        }

        private void NowyRozmiarPolki_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

    }
}
