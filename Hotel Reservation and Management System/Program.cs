using Hotel_Reservation_and_Management_System.Data;

namespace Hotel_Reservation_and_Management_System
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

            try { UserRepository.EnsureDefaultAdmin(); }
            catch{ MessageBox.Show("Cannot connect to database"); }
            Application.Run(new frmLogin());
        }
    }
}