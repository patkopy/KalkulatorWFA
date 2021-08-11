using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorWFA
{
    public partial class Kalkulator : Form
    {
        double a;
        string operacja;
        double b;
        double wynik;

        public Kalkulator()
        {
            InitializeComponent();
        }

        private void Kalkulator_Load(object sender, EventArgs e)
        {

        }

        private void buttonCzysc_Click(object sender, EventArgs e)
        {
            textBoxWynik.Clear();
            a = 0;
            b = 0;
        }

        private void buttonC9_Click(object sender, EventArgs e)
        {
            textBoxWynik.Text += Convert.ToString("9");
        }

        private void buttonC8_Click(object sender, EventArgs e)
        {
            textBoxWynik.Text += Convert.ToString("8");
        }

        private void buttonC7_Click(object sender, EventArgs e)
        {
            textBoxWynik.Text += Convert.ToString("7");
        }

        private void buttonC6_Click(object sender, EventArgs e)
        {
            textBoxWynik.Text += Convert.ToString("6");
        }

        private void buttonC5_Click(object sender, EventArgs e)
        {
            textBoxWynik.Text += Convert.ToString("5");
        }

        private void buttonC4_Click(object sender, EventArgs e)
        {
            textBoxWynik.Text += Convert.ToString("4");
        }

        private void buttonC3_Click(object sender, EventArgs e)
        {
            textBoxWynik.Text += Convert.ToString("3");
        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            textBoxWynik.Text += Convert.ToString("2");
        }

        private void buttonC1_Click(object sender, EventArgs e)
        {
            textBoxWynik.Text += Convert.ToString("1");
        }

        private void buttonC0_Click(object sender, EventArgs e)
        {
            textBoxWynik.Text += Convert.ToString("0");
        }

        private void buttonPrzecinek_Click(object sender, EventArgs e)
        {
            textBoxWynik.Text += Convert.ToString(",");
        }

        private void buttonDziel_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBoxWynik.Text);
            }
            catch
            {
                textBoxWynik.Clear();
            }
            operacja = "/";
            textBoxWynik.Clear();
        }

        private void buttonMnoz_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBoxWynik.Text);
            }
            catch
            {
                textBoxWynik.Clear();
            }
            operacja = "*";
            textBoxWynik.Clear();
        }

        private void buttonOdejmij_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBoxWynik.Text);
            }
            catch
            {
                textBoxWynik.Clear();
            }
            operacja = "-";
            textBoxWynik.Clear();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBoxWynik.Text);
            }
            catch
            {
                textBoxWynik.Clear();
            }
            operacja = "+";
            textBoxWynik.Clear();
        }

        private void buttonRowna_Click(object sender, EventArgs e)
        {
            try
            {
                Dzialania();
            }
            catch
            {
                textBoxWynik.Clear();
            }
        }

        private void Dzialania()
        {
            b = Convert.ToDouble(textBoxWynik.Text);

            if (operacja == "+")
            {
                wynik = a + b;
                textBoxWynik.Text = Convert.ToString(wynik);
                a = wynik;
            }
            if (operacja == "-")
            {
                wynik = a - b;
                textBoxWynik.Text = Convert.ToString(wynik);
                a = wynik;
            }
            if (operacja == "/")
            {
                if(b != 0)
                {
                    wynik = a / b;
                }
                else
                {
                    textBoxWynik.Clear();
                }
                textBoxWynik.Text = Convert.ToString(wynik);
                a = wynik;
            }
            if (operacja == "*")
            {
                wynik = a * b;
                textBoxWynik.Text = Convert.ToString(wynik);
                a = wynik;
            }
        }
    }
}
