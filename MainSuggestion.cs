using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesisBeta
{
    public partial class MainSuggestion : Form
    {
        private Dictionary<string, string> keywordMap;
        public MainSuggestion(string userInput)
        {
            InitializeComponent();

            keywordMap = new Dictionary<string, string>
            {
                { "sneeze", "Take cetirizine" },
                { "rhinitis", "Take cetirizine" },
                { "fever", "Take bioflu" }
                // Add more keywords and suggestions
            };

            string recommendation = GetMedicineRecommendation(userInput);

            if (!string.IsNullOrEmpty(recommendation))
            {
                label1.Text = recommendation;
            }
            else
            {
                label1.Text = "No information available for the entered symptoms.";
            }
        }

        private string GetMedicineRecommendation(string userInput)
        {
            userInput = userInput.ToLower();
            userInput = System.Text.RegularExpressions.Regex.Replace(userInput, @"[^\w\s]", "");

            string[] tokens = userInput.Split(' ');

            string[] stopWords = { "a", "an", "the", "and", "or", "but", "so", "of", "in", "on", "at", "for", "to" };
            List<string> filteredTokens = new List<string>();

            foreach (var token in tokens)
            {
                if (!stopWords.Contains(token))
                {
                    filteredTokens.Add(token);
                }
            }

            foreach (var keyword in keywordMap.Keys)
            {
                if (filteredTokens.Contains(keyword))
                {
                    return keywordMap[keyword];
                }
            }

            return null;
        }

        private void SuggestionBackButton_Click(object sender, EventArgs e)
        {
            SuggestionQuery suggestionQuery = new SuggestionQuery();
            suggestionQuery.Show();

            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            startScreen.Show();

            this.Hide();
        }

        private string FindClosestKeyword(string userInput)
        {
            string closestKeyword = null;
            int minDistance = int.MaxValue;

            foreach (string keyword in keywordMap.Keys)
            {
                int distance = ComputeLevenshteinDistance(keyword, userInput);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestKeyword = keyword;
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


    }
 }

