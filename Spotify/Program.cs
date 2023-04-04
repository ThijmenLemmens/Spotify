using System.Windows.Forms;

namespace Spotify {
    internal static class Program {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Database.Instance().server = "Localhost";
            Database.Instance().databaseName = "spotify";
            Database.Instance().userName = "root";
            Database.Instance().password = "";

            Database.Instance().IsConnect();

            Application.Run(new LoginSignUpForm());
        }
    }
}