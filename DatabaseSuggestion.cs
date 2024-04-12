using System.Data.SQLite;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace ThesisBeta
{
    internal class DatabaseSuggestion
    {
        private static string connectionString = @"Data Source=..\..\Files\ThesisBeta.db;Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists(@"..\..\Files\ThesisBeta.db"))
            {
                SQLiteConnection.CreateFile(@"..\..\Files\ThesisBeta.db");

                using(var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    //Create tables for your data
                    string createKeywordsTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Keywords (
                            id INTEGER PRIMARY KEY AUTOINCREMENT, 
                            keyword TEXT NOT NULL,
                            available_meds TEXT NOT NULL,
                            unavailable_meds TEXT NOT NULL,
                            description TEXT NOT NULL, 
                            source_link TEXT NOT NULL
                        );";

                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = createKeywordsTableQuery;
                        command.ExecuteNonQuery();



                    }


                }


            }
        }

        public static void AddSampleKeywordsFromCsv(string csvPath)
        {
            if (File.Exists(csvPath))
            {
                using (var reader = new StreamReader(csvPath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {


                    csv.Read();
                    csv.ReadHeader();

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand(connection))
                        {
                            while (csv.Read())
                            {
                                string keyword = csv.GetField<string>("Keyword");
                                string available_meds = csv.GetField<string>("Available");
                                string unavailable_meds = csv.GetField<string>("Unavailable");
                                string description = csv.GetField<string>("Description").Replace("\n", "<br>"); //Replace("\n", Environment.NewLine)
                                string source_link = csv.GetField<string>("SourceLink");



                                command.CommandText = "INSERT INTO Keywords (keyword, available_meds, unavailable_meds, description, source_link) VALUES (@keyword, @available_meds, @unavailable_meds, @description, @source_link)";
                                command.Parameters.AddWithValue("@keyword", keyword);
                                command.Parameters.AddWithValue("@available_meds", available_meds);
                                command.Parameters.AddWithValue("@unavailable_meds", unavailable_meds);
                                command.Parameters.AddWithValue("@description", description);
                                command.Parameters.AddWithValue("@source_link", source_link);

                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
    }
}
