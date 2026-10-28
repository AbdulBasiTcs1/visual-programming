using System;
using System.Windows.Forms;

namespace Q5_SplashApp
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new SplashForm());
        }
    }
}
