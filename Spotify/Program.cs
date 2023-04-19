using System.Windows.Forms;

namespace Spotify {
    internal static class Program {

        public static Form1 form1 {
            get; set;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // sets the Database class properties
            Database.Instance().server = "Localhost";
            Database.Instance().databaseName = "spotify";
            Database.Instance().userName = "root";
            Database.Instance().password = "";

            // makes a connection to the Database
            Database.Instance().IsConnect();

            Application.Run(new LoginSignUpForm());
        }
    }
}