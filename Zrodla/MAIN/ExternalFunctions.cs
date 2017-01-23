using System.Runtime.InteropServices;

namespace MAIN
{
    unsafe class ExternalFunctions
    {
        [DllImport("DLL_ASM.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern double test_asm(double a, double b);

        [DllImport("DLL_ASM.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void computeMatrixU_ASM(double[] matrixU, int size);        

        [DllImport("DLL_ASM.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void computeMatrixL_ASM(double[] matrixL, double[] matrixU, int size);

        [DllImport("DLL_ASM.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void computeVectorY_ASM(double[] vectorY, double[] vectorB, double[] matrixL, int size);

        [DllImport("DLL_ASM.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void computeVectorX_ASM(double[] vectorX, double[] vectorY, double[] matrixU, int size);

        [DllImport("DLL_C.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void computeMatrixU_C(double[] matrixU, int size);

        [DllImport("DLL_C.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void computeMatrixL_C(double[] matrixL, double[] matrixU, int size);

        [DllImport("DLL_C.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void computeVectorY_C(double[] vectorY, double[] vectorB, double[] matrixL, int size);

        [DllImport("DLL_C.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void computeVectorX_C(double[] vectorX, double[] vectorY, double[] matrixU, int size);

        
        internal static void computeMatrixU_plotek(double[] matrixU, int size)
        {
            for (int k = 0; k < size - 1; k++)
                for (int i = k + 1; i < size; i++)
                    for (int j = k + 1; j < size; j++)
                        matrixU[i * size + j] = matrixU[i * size + j] - ((matrixU[i * size + k] * matrixU[k * size + j]) / matrixU[k * size + k]);
        }        

        internal static void computeVectorY_plotek(double[] vectorY, double[] vectorB, double[] matrixL, int size)
        {
            vectorY[0] = vectorB[0];
            for (int i = 1; i < size; i++)
            {
                double sum = 0;
                for (int k = 0; k <= i; k++)
                {
                    sum += matrixL[i * size + k] * vectorY[k];
                }
                vectorY[i] = vectorB[i] - sum;
            }
        }

        internal static void computeVectorX_plotek(double[] vectorX, double[] vectorY, double[] matrixU, int size)
        {
            vectorX[size - 1] = vectorY[size - 1] / matrixU[(size - 1) * size + (size - 1)];
            for (int i = size - 2; i >= 0; i--)
            {
                double sum = 0;
                for (int k = i + 1; k < size; k++)
                {
                    sum = sum + matrixU[i * size + k] * vectorX[k];
                }
                vectorX[i] = (vectorY[i] - sum) / matrixU[i * size + i];
            }
        }
        
    }
}
