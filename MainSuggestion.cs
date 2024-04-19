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
            DisplayDescription();
            DisplayAvailable();
            DisplayUnavailable();
            DisplaySourceLink();
        }

        private void DisplayDescription()
        {
            string query = "SELECT description FROM Keywords WHERE keyword=@keyword;";
            string description = null;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@keyword", userInput);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            description = reader["description"].ToString();
                        }
                    }
                }
            }

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
        }

        private void DisplayAvailable()
        {
            string query = "SELECT available_meds FROM Keywords WHERE keyword=@keyword;";
            string available = null;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@keyword", userInput);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            available = reader["available_meds"].ToString();
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(available))
            {
                availableText.Text = "Available: " + available;
            }
            else
            {
                availableText.Text = "No available medications information.";
            }
        }

        private void DisplayUnavailable()
        {
            string query = "SELECT unavailable_meds FROM Keywords WHERE keyword=@keyword;";
            string unavailable = null;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@keyword", userInput);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            unavailable = reader["unavailable_meds"].ToString();
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(unavailable))
            {
                unavailableText.Text = "Unavailable: " + unavailable;
            }
            else
            {
                unavailableText.Text = "No unavailable medications information.";
            }
        }

        private void DisplaySourceLink()
        {
            string query = "SELECT source_link FROM Keywords WHERE keyword=@keyword;";
            string sourceLink = null;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@keyword", userInput);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sourceLink = reader["source_link"].ToString();
                        }
                    }
                }
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


        private void StartScreenPurchase_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();

            this.Visible = false;
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