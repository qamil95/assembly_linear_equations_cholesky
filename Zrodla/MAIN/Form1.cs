using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MAIN
{
    public partial class Form1 : Form
    {
        bool assembly = true;
        bool computed = false;
        int size; //wymiar macierzy (są kwadratowe) i długość wektora
        double[][] matrixA; //macierz ze współczynnikami
        double[] vectorB; //wektor wyrazów wolnych
        double[] vectorX; //wektor wyniku

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
            size = file.Length;

            //przydzielenie pamięci na tablice
            matrixA = new double[size][];            
            vectorB = new double[size];
            vectorX = new double[size];

            //wczytanie danych z pliku
            try
            {
                for (int i = 0; i < size; i++)
                {
                    string[] line = file[i].Split(' ');
                    matrixA[i] = new double[size];
                    for (int j = 0; j < size; j++)
                        matrixA[i][j] = double.Parse(line[j]);       
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
            //macierze i wektory do obliczeń
            double[] matrixU = new double[size * size];
            double[] matrixL = new double[size * size];
            double[] vectorY = new double[size];

            //skopiowanie macierzy A do macierzy U oraz wyzerowanie macierzy L
            for (int i=0; i<size; i++)
                for (int j = 0; j < size; j++)
                {
                    matrixU[i * size + j] = matrixA[i][j];
                    matrixL[i * size + j] = 0;
                }

            //główna część obliczeniowa
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            if (assembly)
            {
                ExternalFunctions.computeMatrixU_ASM(matrixU, size);
                ExternalFunctions.computeMatrixL_ASM(matrixL, matrixU, size);
                ExternalFunctions.computeVectorY_ASM(vectorY, vectorB, matrixL, size);

                //ExternalFunctions.computeVectorX_ASM(vectorX, vectorY, matrixU, size);
                ExternalFunctions.computeVectorX_plotek(vectorX, vectorY, matrixU, size);

            }
            else
            {
                ExternalFunctions.computeMatrixU_C(matrixU, size);
                ExternalFunctions.computeMatrixL_C(matrixL, matrixU, size);
                ExternalFunctions.computeVectorY_C(vectorY, vectorB, matrixL, size);
                ExternalFunctions.computeVectorX_C(vectorX, vectorY, matrixU, size);
            }

            stopWatch.Stop();
            timerTextBox.Text = stopWatch.Elapsed.ToString();
            computed = true;
       
        }
    }
}
