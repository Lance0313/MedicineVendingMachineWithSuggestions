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
            // Load the HTML content from the website
            var htmlWeb = new HtmlWeb();
            var htmlDoc = htmlWeb.Load("https://www.drugs.com/cetirizine-hcl.html");

            // Find the elements containing the desired information using combined XPath expression
            var infoNodes = htmlDoc.DocumentNode.SelectNodes("//*[@id='content']/p[3] | //*[@id=\"content\"]/p[4] | //*[@id='content']/p[5]");

            // Initialize a string to store the combined text of both elements
            string combinedText = "";

            if (infoNodes != null)
            {
                // Concatenate the inner text of each selected element
                foreach (var node in infoNodes)
                {
                    combinedText += node.InnerText.Trim() + "\n\n"; // Add a new line for separation
                }
            }
            else
            {
                // If information extraction fails, display a message
                combinedText = "Failed to retrieve information from the website.";
            }

            // Create a RichTextBox for displaying the scraped information
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.ReadOnly = true;
            richTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox.BorderStyle = BorderStyle.None;
            richTextBox.Text = combinedText;

            // Add the RichTextBox to the panel
            SuggestionPanel.Controls.Add(richTextBox);
        }
    }
 }

