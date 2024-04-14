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
            this.YourCart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unavailableText = new System.Windows.Forms.Label();
            this.BackButton = new ePOSOne.btnProduct.RoundButton();
            this.StartScreenPurchase = new ePOSOne.btnProduct.RoundButton();
            this.ExitButton = new ePOSOne.btnProduct.RoundButton();
            this.availableText = new System.Windows.Forms.Label();
            this.linkText = new System.Windows.Forms.Label();
            this.SuggestionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuggestionPanel
            // 
            this.SuggestionPanel.BackColor = System.Drawing.Color.White;
            this.SuggestionPanel.Controls.Add(this.label1);
            this.SuggestionPanel.Controls.Add(this.YourCart);
            this.SuggestionPanel.Location = new System.Drawing.Point(56, 73);
            this.SuggestionPanel.Name = "SuggestionPanel";
            this.SuggestionPanel.Size = new System.Drawing.Size(493, 302);
            this.SuggestionPanel.TabIndex = 12;
            // 
            // YourCart
            // 
            this.YourCart.AutoSize = true;
            this.YourCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourCart.Location = new System.Drawing.Point(26, 252);
            this.YourCart.Name = "YourCart";
            this.YourCart.Size = new System.Drawing.Size(438, 22);
            this.YourCart.TabIndex = 0;
            this.YourCart.Text = "SUGGESTIONS BASED ON YOUR SYMTOMPS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.linkText);
            this.panel1.Controls.Add(this.availableText);
            this.panel1.Controls.Add(this.unavailableText);
            this.panel1.Location = new System.Drawing.Point(555, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 302);
            this.panel1.TabIndex = 18;
            // 
            // unavailableText
            // 
            this.unavailableText.AutoSize = true;
            this.unavailableText.Location = new System.Drawing.Point(18, 126);
            this.unavailableText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unavailableText.Name = "unavailableText";
            this.unavailableText.Size = new System.Drawing.Size(66, 13);
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
            this.StartScreenPurchase.Location = new System.Drawing.Point(56, 381);
            this.StartScreenPurchase.Name = "StartScreenPurchase";
            this.StartScreenPurchase.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.StartScreenPurchase.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.StartScreenPurchase.OnHoverTextColor = System.Drawing.Color.Black;
            this.StartScreenPurchase.Size = new System.Drawing.Size(208, 46);
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
            this.ExitButton.Location = new System.Drawing.Point(546, 381);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.ExitButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.ExitButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ExitButton.Size = new System.Drawing.Size(208, 46);
            this.ExitButton.TabIndex = 21;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextColor = System.Drawing.Color.Black;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // availableText
            // 
            this.availableText.AutoSize = true;
            this.availableText.Location = new System.Drawing.Point(18, 55);
            this.availableText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.availableText.Name = "availableText";
            this.availableText.Size = new System.Drawing.Size(53, 13);
            this.availableText.TabIndex = 19;
            this.availableText.Text = "Available:";
            // 
            // linkText
            // 
            this.linkText.AutoSize = true;
            this.linkText.Location = new System.Drawing.Point(18, 193);
            this.linkText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkText.Name = "linkText";
            this.linkText.Size = new System.Drawing.Size(35, 13);
            this.linkText.TabIndex = 20;
            this.linkText.Text = "Links:";
            // 
            // MainSuggestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SuggestionPanel;
        private System.Windows.Forms.Label YourCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label unavailableText;
        private ePOSOne.btnProduct.RoundButton BackButton;
        private ePOSOne.btnProduct.RoundButton StartScreenPurchase;
        private ePOSOne.btnProduct.RoundButton ExitButton;
        private System.Windows.Forms.Label linkText;
        private System.Windows.Forms.Label availableText;
    }
}