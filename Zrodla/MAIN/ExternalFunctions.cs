using System.Runtime.InteropServices;

namespace MAIN
{
    unsafe class ExternalFunctions
    {
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
    }
}
