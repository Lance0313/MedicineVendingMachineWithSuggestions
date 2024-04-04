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
    public partial class SuggestionQuery : Form
    {
        private List<string> suggestions = new List<string> { "cold", "sneeze", "nose itch", "allergy", "allergic rhinitis", "runny nose", "watery eyes" };

        private bool capsLockEnabled = false;
        public SuggestionQuery()
        {
            InitializeComponent();
            InitializeSuggestionsListBox();
        }

        private void InitializeSuggestionsListBox()
        {
            suggestionsListBox.Visible = false;
            suggestionsListBox.SelectedIndexChanged += SuggestionsListBox_SelectedIndexChanged;
            Controls.Add(suggestionsListBox);
        }

        private void SuggestionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suggestionsListBox.SelectedItem != null)
            {
                textBox1.Text = suggestionsListBox.SelectedItem.ToString();
                suggestionsListBox.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string userInput = textBox1.Text.ToLower();
            List<string> matchedSuggestions = suggestions.Where(s => s.StartsWith(userInput)).ToList();

            if (matchedSuggestions.Any())
            {
                suggestionsListBox.Items.Clear();
                suggestionsListBox.Items.AddRange(matchedSuggestions.ToArray());
                suggestionsListBox.Visible = true;
            }
            else
            {
                suggestionsListBox.Visible = false;
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                ShowCustomMessageBox("Please enter a keyword before proceeding.");
                return;
            }

            string userInput = textBox1.Text.ToLower();
            MainSuggestion suggestionForm = new MainSuggestion(userInput);
            suggestionForm.Show();

            this.Hide(); 

            /*textBox1.Text += "\n";*/
        }

        private void ShowCustomMessageBox(string message)
        {
            Form messageBoxForm = new Form();
            messageBoxForm.FormBorderStyle = FormBorderStyle.None;
            messageBoxForm.StartPosition = FormStartPosition.CenterParent;
            messageBoxForm.Size = new Size(300, 150);

            Label label = new Label();
            label.Text = message;
            label.AutoSize = true;
            label.Location = new Point(50, 30);
            label.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;

            Button closeButton = new Button();
            closeButton.Text = "OK";
            closeButton.Location = new Point(115, 80);
            closeButton.Size = new Size(70, 30);
            closeButton.Click += (sender, e) => { messageBoxForm.Close(); };

            messageBoxForm.Controls.Add(label);
            messageBoxForm.Controls.Add(closeButton);
            messageBoxForm.ShowDialog();
        }

        private void q_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "Q" : "q";
        }

        private void w_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "W" : "w";
        }

        private void e_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "E" : "e";
        }

        private void r_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "R" : "r";

        }

        private void t_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "T" : "t";
        }

        private void y_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "Y" : "y";
        }

        private void u_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "U" : "u";
        }

        private void i_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "I" : "i";
        }

        private void o_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "O" : "o";
        }

        private void p_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "P" : "p";
        }

        private void a_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "A" : "a";
        }

        private void s_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "S" : "s";
        }

        private void d_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "D" : "d";
        }

        private void f_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "F" : "f";
        }

        private void g_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "G" : "g";
        }

        private void h_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "H" : "h";
        }

        private void j_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "J" : "j";
        }

        private void k_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "K" : "k";
        }

        private void l_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "L" : "l";
        }

        private void z_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "Z" : "z";
        }

        private void x_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "X" : "x";
        }

        private void c_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "C" : "c";
        }

        private void v_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "V" : "v";
        }

        private void b_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "B" : "b";

        }

        private void n_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "N" : "n";
        }

        private void m_Click(object sender, EventArgs e)
        {
            textBox1.Text += (capsLockEnabled || Control.IsKeyLocked(Keys.CapsLock)) ? "M" : "m";
        }

        private void capsLock_Click(object sender, EventArgs e)
        {
            capsLockEnabled = !capsLockEnabled; // Toggle caps lock state

            // Update letter button labels based on caps lock state
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    char buttonChar;
                    if (char.TryParse(button.Text, out buttonChar) && char.IsLetter(buttonChar))
                    {
                        button.Text = capsLockEnabled ? button.Text.ToUpper() : button.Text.ToLower();
                    }
                }
            }
        }

        private void space_Click(object sender, EventArgs e)
        {
            textBox1.Text += " "; // Append a space when the space button is clicked
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1); // Remove the last character from textBox1
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\r\n";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            startScreen.Show();

            this.Hide();
        }
    }
}
