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
                { "cold", "Take cetirizine" },
                { "sneeze", "Take cetirizine" },
                { "sneezing", "Take cetirizine" },
                { "itchy", "Take cetirizine" },
                { "itching", "Take cetirizine" },
                { "allergy", "Take cetirizine" },
                { "allergic", "Take cetirizine" },
                { "rhinitis", "Take cetirizine" },
                { "watery", "Take cetirizine" },
                { "runny", "Take cetirizine" },

                { "flu", "Take bioflu" },
                { "headache", "Take bioflu" },
                { "fever", "Take bioflu" },
                { "ache", "Take bioflu" },
                { "body pain", "Take bioflu" },
                { "body ache", "Take bioflu" }
                
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

            AddSampleParagraph();
        }

        private string GetMedicineRecommendation(string userInput)
        {
            var tokenizer = SimpleTokenizer.Instance;
            string[] tokens = tokenizer.Tokenize(userInput.ToLower());

            List<string> phrases = new List<string>();

            for (int i = 0; i < tokens.Length - 1; i++)
            {
                phrases.Add(tokens[i] + " " + tokens[i + 1]);
            }

            foreach (var keyword in keywordMap.Keys)
            {
                if (tokens.Contains(keyword) || phrases.Contains(keyword))
                {
                    return keywordMap[keyword];
                }
            }

            return null;
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

        private void AddSampleParagraph()
        {
            // Create a RichTextBox for displaying the sample paragraph
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.ReadOnly = true;
            richTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox.BorderStyle = BorderStyle.None;
            richTextBox.Text = "This is a sample paragraph. It can contain multiple lines and provide information or instructions to the user.";

            // Add the RichTextBox to the panel
            SuggestionPanel.Controls.Add(richTextBox);
        }
    }
 }

