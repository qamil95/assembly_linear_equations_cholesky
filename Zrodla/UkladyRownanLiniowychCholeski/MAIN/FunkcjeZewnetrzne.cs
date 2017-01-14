using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MAIN
{
    unsafe class FunkcjeZewnetrzne
    {
        [DllImport("DLL_ASM.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern double licz_asm(double a, double b);

        [DllImport("DLL_C.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double licz_c(double a, double b);
    }
}
