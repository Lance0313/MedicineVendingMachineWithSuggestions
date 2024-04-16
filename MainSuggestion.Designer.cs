namespace ThesisBeta
{
    partial class MainSuggestion
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
            this.SuggestionPanel = new System.Windows.Forms.Panel();
            this.linkText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.availableText = new System.Windows.Forms.Label();
            this.unavailableText = new System.Windows.Forms.Label();
            this.BackButton = new ePOSOne.btnProduct.RoundButton();
            this.StartScreenPurchase = new ePOSOne.btnProduct.RoundButton();
            this.ExitButton = new ePOSOne.btnProduct.RoundButton();
            this.SuggestionLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuggestionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuggestionPanel
            // 
            this.SuggestionPanel.BackColor = System.Drawing.Color.White;
            this.SuggestionPanel.Controls.Add(this.linkText);
            this.SuggestionPanel.Controls.Add(this.label1);
            this.SuggestionPanel.Location = new System.Drawing.Point(83, 239);
            this.SuggestionPanel.Name = "SuggestionPanel";
            this.SuggestionPanel.Size = new System.Drawing.Size(631, 143);
            this.SuggestionPanel.TabIndex = 12;
            // 
            // linkText
            // 
            this.linkText.AutoSize = true;
            this.linkText.Location = new System.Drawing.Point(13, 106);
            this.linkText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkText.Name = "linkText";
            this.linkText.Size = new System.Drawing.Size(35, 13);
            this.linkText.TabIndex = 20;
            this.linkText.Text = "Links:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.availableText);
            this.panel1.Controls.Add(this.unavailableText);
            this.panel1.Location = new System.Drawing.Point(214, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 99);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ThesisBeta.Properties.Resources.X;
            this.pictureBox2.Location = new System.Drawing.Point(12, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThesisBeta.Properties.Resources.Check;
            this.pictureBox1.Location = new System.Drawing.Point(9, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // availableText
            // 
            this.availableText.AutoSize = true;
            this.availableText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableText.Location = new System.Drawing.Point(44, 40);
            this.availableText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.availableText.Name = "availableText";
            this.availableText.Size = new System.Drawing.Size(59, 15);
            this.availableText.TabIndex = 19;
            this.availableText.Text = "Available:";
            // 
            // unavailableText
            // 
            this.unavailableText.AutoSize = true;
            this.unavailableText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unavailableText.Location = new System.Drawing.Point(44, 70);
            this.unavailableText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unavailableText.Name = "unavailableText";
            this.unavailableText.Size = new System.Drawing.Size(75, 15);
            this.unavailableText.TabIndex = 18;
            this.unavailableText.Text = "Unavailable:";
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
            this.BackButton.TabIndex = 19;
            this.BackButton.Text = "Back";
            this.BackButton.TextColor = System.Drawing.Color.Black;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StartScreenPurchase
            // 
            this.StartScreenPurchase.BorderColor = System.Drawing.Color.Transparent;
            this.StartScreenPurchase.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.StartScreenPurchase.FlatAppearance.BorderSize = 0;
            this.StartScreenPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartScreenPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenPurchase.Location = new System.Drawing.Point(649, 392);
            this.StartScreenPurchase.Name = "StartScreenPurchase";
            this.StartScreenPurchase.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.StartScreenPurchase.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.StartScreenPurchase.OnHoverTextColor = System.Drawing.Color.Black;
            this.StartScreenPurchase.Size = new System.Drawing.Size(139, 46);
            this.StartScreenPurchase.TabIndex = 20;
            this.StartScreenPurchase.Text = "Purchase";
            this.StartScreenPurchase.TextColor = System.Drawing.Color.Black;
            this.StartScreenPurchase.UseVisualStyleBackColor = true;
            this.StartScreenPurchase.Click += new System.EventHandler(this.StartScreenPurchase_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BorderColor = System.Drawing.Color.Transparent;
            this.ExitButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(682, 21);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.ExitButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.ExitButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ExitButton.Size = new System.Drawing.Size(106, 46);
            this.ExitButton.TabIndex = 21;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextColor = System.Drawing.Color.Black;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // SuggestionLabel
            // 
            this.SuggestionLabel.AutoSize = true;
            this.SuggestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.SuggestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuggestionLabel.ForeColor = System.Drawing.Color.White;
            this.SuggestionLabel.Location = new System.Drawing.Point(229, 47);
            this.SuggestionLabel.Name = "SuggestionLabel";
            this.SuggestionLabel.Size = new System.Drawing.Size(328, 39);
            this.SuggestionLabel.TabIndex = 36;
            this.SuggestionLabel.Text = "Suggestions Found";
            this.SuggestionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(9, 4);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(239, 25);
            this.WelcomeLabel.TabIndex = 38;
            this.WelcomeLabel.Text = "Medicines you can take";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.WelcomeLabel);
            this.panel2.Location = new System.Drawing.Point(268, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 34);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(268, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 34);
            this.panel3.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Information on...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainSuggestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SuggestionLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StartScreenPurchase);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SuggestionPanel);
            this.Name = "MainSuggestion";
            this.Text = "MainSuggestion";
            this.SuggestionPanel.ResumeLayout(false);
            this.SuggestionPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SuggestionPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label unavailableText;
        private ePOSOne.btnProduct.RoundButton BackButton;
        private ePOSOne.btnProduct.RoundButton StartScreenPurchase;
        private ePOSOne.btnProduct.RoundButton ExitButton;
        private System.Windows.Forms.Label linkText;
        private System.Windows.Forms.Label availableText;
        private System.Windows.Forms.Label SuggestionLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}