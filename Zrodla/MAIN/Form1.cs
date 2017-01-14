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
        Boolean assembler = true;
        public Form1()
        {
            InitializeComponent();
        }
              
        private void asmRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            assembler = true;
        }

        private void cRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            assembler = false;
        }

        private void openMatrixButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            viewMatrixButton.Enabled = true;
            computeMatrixButton.Enabled = true;
            loadedFileStatus.Text = "Wczytany plik: " + openFileDialog1.FileName;
        }

        private void viewMatrixButton_Click(object sender, EventArgs e)
        {

        }

        private void computeMatrixButton_Click(object sender, EventArgs e)
        {
            Double a, b, wynik;
            a = Double.Parse(textBox1.Text);
            b = Double.Parse(textBox2.Text);
            if (assembler)
            {
                wynik = FunkcjeZewnetrzne.licz_asm(a, b);
            } else
            {
                wynik = FunkcjeZewnetrzne.licz_c(a, b);
            }
            textBox3.Text = wynik.ToString();
        }
    }
}
