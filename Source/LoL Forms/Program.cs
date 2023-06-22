using System.Data.SqlClient;

namespace LoL_Forms
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
            Application.Run(new HomePage());
        }
    }

    public static class DatabaseConnection
    {


        public static SqlConnection GetConnection()
        {
            SqlConnection connection;
            
                // Establish the database connection [CHANGE DB HERE]
                string connectionString = "Server=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Database=p7g8;User Id=p7g8;Password=BaseDados2023;";
                connection = new SqlConnection(connectionString);
                connection.Open();
            
            return connection;
        }
    }

}