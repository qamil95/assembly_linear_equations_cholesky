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
    public partial class viewMatrix : Form
    {
        private double[][] matrixA;
        private double[] vectorB;
        private double[] vectorX;
        private bool computed;

        public viewMatrix()
        {
            InitializeComponent();
        }

        public viewMatrix(double[][] matrixA, double[] vectorB, double[] vectorX, bool computed)
        {
            InitializeComponent();
            this.matrixA = matrixA;
            this.vectorB = vectorB;
            this.vectorX = vectorX;
            this.computed = computed;
            for (int i=0; i<matrixA.Length; i++)
            {
                text.Text += 'x' + (i + 1).ToString() + '\t';
            }
            text.Text += "B\tX\r\n\r\n";
            for (int i=0; i<matrixA.Length; i++)
            {
                for (int j=0; j<matrixA[i].Length; j++)
                {
                    text.Text += matrixA[i][j].ToString() + '\t';
                }
                if (computed)
                    text.Text += vectorB[i].ToString() + '\t' + vectorX[i].ToString() + "\r\n";
                else
                    text.Text += vectorB[i].ToString() + '\t' + "???\r\n";
            }               
        }        
    }
}
