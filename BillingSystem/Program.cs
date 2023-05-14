namespace BillingSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int aux = 0;
            string[] userarr = new string[5];
            string[] passarr = new string[5];


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginScreen(userarr, passarr, aux));
        }
    }
}