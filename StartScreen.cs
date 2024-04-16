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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            DatabaseSuggestion.InitializeDatabase();

            DatabaseSuggestion.AddSampleKeywordsFromCsv(@"..\..\Files\keywords.csv");

        }

        private void StartScreenLabel_Click(object sender, EventArgs e)
        {

        }

        private void StartScreenPurchase_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();

            // Show Form2
            purchase.Show();

            // Close Form1
            this.Hide();
        }

        private void StartScreenSuggestion_Click(object sender, EventArgs e)
        {
            SuggestionQuery suggestionQuery = new SuggestionQuery();
            suggestionQuery.Show();

            this.Hide();
        }
    }
}
