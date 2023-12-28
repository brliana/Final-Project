using System;
using System.Data.SQLite;
using System.IO;

namespace FinalProject.Database
{
    public class DatabaseConnection {
        public static string dbDir = $"{Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\Database";
        public static SQLiteConnection connection = new SQLiteConnection($"Data Source={dbDir}\\database.db;Version=3;");
    }
}
