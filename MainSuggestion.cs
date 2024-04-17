using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpNL.Tokenize;
using SharpNL.Tokenize.Language;
using HtmlAgilityPack;
using System.Data.SQLite;

namespace ThesisBeta
{
    public partial class MainSuggestion : Form
    {
        private string userInput;
        private string connectionString = @"Data Source=..\..\Files\ThesisBeta.db;Version=3;";
        public MainSuggestion(string userInput)
        {
            InitializeComponent();

            this.userInput = userInput.ToLower();
            DisplayInformationFromDatabase();
        }

        private void DisplayInformationFromDatabase()
        {
            string closestKeyword = FindClosestKeyword(userInput);

            if (string.IsNullOrEmpty(closestKeyword))
            {
                label1.Text = "No information available for the entered symptoms.";
                availableText.Text = "No available medications information.";
                unavailableText.Text = "No unavailable medications information.";
                linkText.Text = "No source link available.";
                return;
            }

            string query = "SELECT description, available_meds, unavailable_meds, source_link FROM Keywords WHERE keyword=@keyword;";
            string description = null;
            string available = null;
            string unavailable = null;
            string sourceLink = null;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@keyword", closestKeyword);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            description = reader["description"].ToString();
                            available = reader["available_meds"].ToString();
                            unavailable = reader["unavailable_meds"].ToString();
                            sourceLink = reader["source_link"].ToString();
                        }
                    }
                }
            }

            // Display fetched information or appropriate messages
            if (!string.IsNullOrEmpty(description))
            {
                // Replace "<br>" with newline character "\n"
                description = description.Replace("<br>", "\n");
                label1.Text = description;
            }
            else
            {
                label1.Text = "No information available for the entered symptoms.";
            }

            if (!string.IsNullOrEmpty(available))
            {
                availableText.Text = "Available: " + available;
            }
            else
            {
                availableText.Text = "No available medications information.";
            }

            if (!string.IsNullOrEmpty(unavailable))
            {
                unavailableText.Text = "Unavailable: " + unavailable;
            }
            else
            {
                unavailableText.Text = "No unavailable medications information.";
            }

            if (!string.IsNullOrEmpty(sourceLink))
            {
                linkText.Text = "Link: " + sourceLink;
            }
            else
            {
                linkText.Text = "No source link available.";
            }
        }

        private string FindClosestKeyword(string userInput)
        {
            string closestKeyword = null;
            int minDistance = int.MaxValue;

            string query = "SELECT keyword FROM Keywords;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string keyword = reader["keyword"].ToString();
                            int distance = ComputeLevenshteinDistance(keyword, userInput);
                            if (distance < minDistance)
                            {
                                minDistance = distance;
                                closestKeyword = keyword;
                            }
                        }
                    }
                }
            }

            return closestKeyword;
        }

        private int ComputeLevenshteinDistance(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            if (n == 0)
                return m;
            if (m == 0)
                return n;

            for (int i = 0; i <= n; d[i, 0] = i++) ;
            for (int j = 0; j <= m; d[0, j] = j++) ;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            return d[n, m];
        }


        private void StartScreenPurchase_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();

            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SuggestionQuery suggestionQuery = new SuggestionQuery();
            suggestionQuery.Show();

            this.Hide();
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            startScreen.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void YourResults_Click(object sender, EventArgs e)
        {

        }
    }
}