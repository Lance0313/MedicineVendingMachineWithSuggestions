namespace ThesisBeta
{
    partial class SuggestionQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new ePOSOne.btnProduct.RoundButton();
            this.BackButton = new ePOSOne.btnProduct.RoundButton();
            this.SuggestionLabel = new System.Windows.Forms.Label();
            this.SuggestionLabel1 = new System.Windows.Forms.Label();
            this.KeypadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.BorderColor = System.Drawing.Color.Transparent;
            this.button1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(470, 246);
            this.button1.Name = "button1";
            this.button1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button1.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.button1.OnHoverTextColor = System.Drawing.Color.Black;
            this.button1.Size = new System.Drawing.Size(208, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Enter";
            this.button1.TextColor = System.Drawing.Color.Black;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackButton
            // 
            this.BackButton.BorderColor = System.Drawing.Color.Transparent;
            this.BackButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(13, 21);
            this.BackButton.Name = "BackButton";
            this.BackButton.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.BackButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.BackButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.BackButton.Size = new System.Drawing.Size(106, 46);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.TextColor = System.Drawing.Color.Black;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SuggestionLabel
            // 
            this.SuggestionLabel.AutoSize = true;
            this.SuggestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.SuggestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuggestionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SuggestionLabel.Location = new System.Drawing.Point(111, 133);
            this.SuggestionLabel.Name = "SuggestionLabel";
            this.SuggestionLabel.Size = new System.Drawing.Size(230, 46);
            this.SuggestionLabel.TabIndex = 15;
            this.SuggestionLabel.Text = "Suggestion";
            this.SuggestionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SuggestionLabel1
            // 
            this.SuggestionLabel1.AutoSize = true;
            this.SuggestionLabel1.BackColor = System.Drawing.Color.Transparent;
            this.SuggestionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuggestionLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SuggestionLabel1.Location = new System.Drawing.Point(115, 185);
            this.SuggestionLabel1.Name = "SuggestionLabel1";
            this.SuggestionLabel1.Size = new System.Drawing.Size(563, 48);
            this.SuggestionLabel1.TabIndex = 16;
            this.SuggestionLabel1.Text = "Please enter a keyword describing your symptoms so I can \r\nprovide suggestions ba" +
    "sed on your current condition.";
            this.SuggestionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KeypadLabel
            // 
            this.KeypadLabel.AutoSize = true;
            this.KeypadLabel.BackColor = System.Drawing.Color.Transparent;
            this.KeypadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeypadLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.KeypadLabel.Location = new System.Drawing.Point(117, 284);
            this.KeypadLabel.Name = "KeypadLabel";
            this.KeypadLabel.Size = new System.Drawing.Size(130, 12);
            this.KeypadLabel.TabIndex = 17;
            this.KeypadLabel.Text = "Use the provided keypad";
            this.KeypadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KeypadLabel.Click += new System.EventHandler(this.KeypadLabel_Click);
            // 
            // SuggestionQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KeypadLabel);
            this.Controls.Add(this.SuggestionLabel1);
            this.Controls.Add(this.SuggestionLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "SuggestionQuery";
            this.Text = "SuggestionQuery";
            this.Click += new System.EventHandler(this.SuggestionQuery_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private ePOSOne.btnProduct.RoundButton button1;
        private ePOSOne.btnProduct.RoundButton BackButton;
        private System.Windows.Forms.Label SuggestionLabel;
        private System.Windows.Forms.Label SuggestionLabel1;
        private System.Windows.Forms.Label KeypadLabel;
    }
}