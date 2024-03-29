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
        private Form virtualKeyboardForm;
        private TextBox targetTextBox;
        private bool capsLockEnabled = false;

        public SuggestionQuery()
        {
            InitializeComponent();
        }
        private void SuggestionQuery_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the text box is empty
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                ShowCustomMessageBox("Please tell me your sickness before proceeding.");
                return;
            }

            string userInput = textBox1.Text.ToLower();
            MainSuggestion suggestionForm = new MainSuggestion(userInput);
            suggestionForm.Show();

            this.Hide();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            targetTextBox = (TextBox)sender;
            ShowVirtualKeyboard();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (virtualKeyboardForm != null)
            {
                virtualKeyboardForm.Hide();
            }
        }

        private void ShowVirtualKeyboard()
        {
            if (virtualKeyboardForm == null || virtualKeyboardForm.IsDisposed)
            {
                virtualKeyboardForm = new Form();

                virtualKeyboardForm.FormBorderStyle = FormBorderStyle.None;
                virtualKeyboardForm.StartPosition = FormStartPosition.Manual;

                Point textBoxLocation = targetTextBox.PointToScreen(Point.Empty);
                int buttonWidth = 30;
                int buttonHeight = 30;
                int keyboardWidth = 13 * buttonWidth;

                virtualKeyboardForm.Location = new Point(textBoxLocation.X, textBoxLocation.Y + targetTextBox.Height);
                virtualKeyboardForm.Width = keyboardWidth;
                virtualKeyboardForm.Height = buttonHeight * 5; // Increased height for space button

                int x = 0, y = 0;
                string keys = "qwertyuiopasdfghjklzxcvbnm";
                foreach (char c in keys)
                {
                    AddLetterButton(c, x, y, buttonWidth, buttonHeight);
                    x++;
                    if (x >= keyboardWidth / buttonWidth)
                    {
                        x = 0;
                        y++;
                    }
                }

                int spaceButtonWidth = buttonWidth * 7;
                int spaceButtonHeight = buttonHeight;
                int spaceButtonX = (keyboardWidth - spaceButtonWidth) / 2;
                int spaceButtonY = (y + 0) * buttonHeight; // Positioned below the last row of letter keys

                AddSpaceButton(spaceButtonX, spaceButtonY, spaceButtonWidth, spaceButtonHeight);

                int backspaceButtonX = spaceButtonX + spaceButtonWidth;
                int backspaceButtonY = spaceButtonY;

                AddBackspaceButton(backspaceButtonX, backspaceButtonY, buttonWidth, buttonHeight);


                int capsLockButtonX = 0; // Positioning it at the start of the keyboard
                int capsLockButtonY = (y + 0) * buttonHeight; // Aligning vertically below the letter keys
                int capsLockButtonWidth = buttonWidth * 3; // Adjusted width for Caps Lock button

                AddCapsLockButton(capsLockButtonX, capsLockButtonY, capsLockButtonWidth, buttonHeight);



                int enterButtonX = backspaceButtonX + buttonWidth;
                int enterButtonY = backspaceButtonY;

                AddEnterButton(enterButtonX, enterButtonY, buttonWidth, buttonHeight);
            }

            virtualKeyboardForm.Show();
        }

        private void AddLetterButton(char character, int x, int y, int buttonWidth, int buttonHeight)
        {
            Button btn = new Button();
            btn.Text = character.ToString();
            btn.Width = buttonWidth;
            btn.Height = buttonHeight;
            btn.Location = new Point(x * buttonWidth, y * buttonHeight);
            btn.Click += (s, e) =>
            {
                if (targetTextBox != null)
                {
                    char charToAdd = capsLockEnabled ? Char.ToUpper(character) : Char.ToLower(character);
                    targetTextBox.Text += charToAdd;
                }
            };
            virtualKeyboardForm.Controls.Add(btn);
        }

        private void AddSpaceButton(int x, int y, int buttonWidth, int buttonHeight)
        {
            Button btn = new Button();
            btn.Text = " ";
            btn.Width = buttonWidth;
            btn.Height = buttonHeight;
            btn.Location = new Point(x, y);
            btn.Click += (s, e) =>
            {
                if (targetTextBox != null)
                {
                    targetTextBox.Text += " ";
                }
            };
            virtualKeyboardForm.Controls.Add(btn);
        }

        private void AddBackspaceButton(int x, int y, int buttonWidth, int buttonHeight)
        {
            Button backspaceBtn = new Button();
            backspaceBtn.Text = "⌫"; // Unicode character for backspace
            backspaceBtn.Width = buttonWidth;
            backspaceBtn.Height = buttonHeight;
            backspaceBtn.Location = new Point(x, y);
            backspaceBtn.Click += (s, e) =>
            {
                if (targetTextBox != null && targetTextBox.Text.Length > 0)
                {
                    targetTextBox.Text = targetTextBox.Text.Remove(targetTextBox.Text.Length - 1);
                }
            };
            virtualKeyboardForm.Controls.Add(backspaceBtn);
        }

        private void AddCapsLockButton(int x, int y, int buttonWidth, int buttonHeight)
        {
            Button capsLockBtn = new Button();
            capsLockBtn.Text = "Caps Lock";
            capsLockBtn.Width = buttonWidth * 1;
            capsLockBtn.Height = buttonHeight;
            capsLockBtn.Location = new Point(x, y);
            capsLockBtn.Click += (s, e) =>
            {
                capsLockEnabled = !capsLockEnabled;
                UpdateButtonLabels();
            };
            capsLockBtn.KeyPress += (s, e) =>
            {
                if (e.KeyChar == (char)Keys.CapsLock)
                {
                    capsLockEnabled = !capsLockEnabled;
                    UpdateButtonLabels();
                }
            };
            virtualKeyboardForm.Controls.Add(capsLockBtn);
        }

        private void AddEnterButton(int x, int y, int buttonWidth, int buttonHeight)
        {
            Button enterBtn = new Button();
            enterBtn.Text = "Enter";
            enterBtn.Width = buttonWidth * 2;
            enterBtn.Height = buttonHeight;
            enterBtn.Location = new Point(x, y);
            enterBtn.Click += (s, e) =>
            {
                if (virtualKeyboardForm != null)
                {
                    virtualKeyboardForm.Hide();
                }
            };
            virtualKeyboardForm.Controls.Add(enterBtn);
        }

        private void UpdateButtonLabels()
        {
            foreach (Control control in virtualKeyboardForm.Controls)
            {
                if (control is Button btn && btn.Text.Length == 1)
                {
                    char originalChar = Char.ToLower(btn.Text[0]);
                    btn.Text = capsLockEnabled ? Char.ToUpper(originalChar).ToString() : originalChar.ToString();
                }
            }
        }

        private void SuggestionBackButton_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            startScreen.Show();

            this.Hide();
        }
    }
}
