using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a, b, wynik; //i dwie zmienne, które użyjemy do wywołania funkcji
            a = Double.Parse(textBox1.Text); //zmieniamy stringa z pola tekstowego na typ Double
            b = Double.Parse(textBox2.Text);
            wynik = FunkcjeZewnetrzne.licz_asm(a, b); //wywołujemy funkcję i zapisujemy jej wynik do zmiennej wynik
            textBox3.Text = wynik.ToString(); //wysyłamy wynik do naszego pola tekstowego nr 3
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double a, b, wynik; //i dwie zmienne, które użyjemy do wywołania funkcji
            a = Double.Parse(textBox1.Text); //zmieniamy stringa z pola tekstowego na typ Double
            b = Double.Parse(textBox2.Text);
            wynik = FunkcjeZewnetrzne.licz_c(a, b); //wywołujemy funkcję i zapisujemy jej wynik do zmiennej wynik
            textBox3.Text = wynik.ToString(); //wysyłamy wynik do naszego pola tekstowego nr 3
        }
    }
}
