namespace WinFormsApp3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // show splash screen first
            using (var splash = new SplashForm())
            {
                splash.DurationMilliseconds = 2500; // show for 2.5 seconds
                splash.ShowDialog();
            }
            Application.Run(new Form1());
        }
    }
}