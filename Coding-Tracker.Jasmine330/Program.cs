using System;
using System.Configuration;

namespace Coding_Tracker.Jasmine330
{
    class Program
    {
        static string connectionString = ConfigurationManager.AppSettings.Get("ConnectionString");

        static void Main(string[] args)
        {
            DatabaseManager databaseManager = new();
            GetUserInput getUserInput = new();

            databaseManager.CreateTable(connectionString);
            getUserInput.MainMenu();
        }
    }
}