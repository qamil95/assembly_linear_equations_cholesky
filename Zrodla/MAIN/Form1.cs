using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAIN
{
    public partial class Form1 : Form
    {
        bool assembly = true;
        bool computed = false;
        double[][] matrixA; //macierz ze współczynnikami
        double[] vectorB; //wektor wyrazów wolnych
        double[] vectorX;
        public Form1()
        {
            InitializeComponent();
        }
              
        private void asmRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            assembly = true;
        }

        private void cRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            assembly = false;
        }

        private void openMatrixButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string[] file = File.ReadAllLines(openFileDialog1.FileName);
            int size = file.Length;
            matrixA = new double[size][];
            vectorB = new double[size];
            try
            {
                for (int i = 0; i < size; i++)
                {
                    string[] line = file[i].Split(' ');
                    matrixA[i] = new double[size];
                    for (int j = 0; j < size; j++)
                    {
                        matrixA[i][j] = double.Parse(line[j]);
                    }
                    vectorB[i] = double.Parse(line[size]);
                }
                computed = false;
                viewMatrixButton.Enabled = true;
                computeMatrixButton.Enabled = true;
                loadedFileStatus.Text = "Wczytany plik: " + openFileDialog1.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void viewMatrixButton_Click(object sender, EventArgs e)
        {
            viewMatrix form = new viewMatrix(matrixA, vectorB, vectorX, computed);
            form.Show();
        }

        private void computeMatrixButton_Click(object sender, EventArgs e)
        {
            Double a, b, wynik;
            a = Double.Parse(textBox1.Text);
            b = Double.Parse(textBox2.Text);
            if (assembly)
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
