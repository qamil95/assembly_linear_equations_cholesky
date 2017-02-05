/*
	Autor: Kamil Ziętek
	Rok akademicki: 2016/2017
	Semestr: 5
	Grupa: 8
*/

using System;
using System.Windows.Forms;

namespace MAIN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
