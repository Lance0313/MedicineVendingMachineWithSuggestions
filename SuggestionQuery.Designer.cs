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
            this.SuggestionBackButton = new ePOSOne.btnProduct.RoundButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
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
            this.button1.Location = new System.Drawing.Point(449, 103);
            this.button1.Name = "button1";
            this.button1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button1.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.button1.OnHoverTextColor = System.Drawing.Color.Black;
            this.button1.Size = new System.Drawing.Size(259, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Enter";
            this.button1.TextColor = System.Drawing.Color.Black;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SuggestionBackButton
            // 
            this.SuggestionBackButton.BackColor = System.Drawing.Color.Transparent;
            this.SuggestionBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SuggestionBackButton.BorderColor = System.Drawing.Color.Transparent;
            this.SuggestionBackButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.SuggestionBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SuggestionBackButton.FlatAppearance.BorderSize = 0;
            this.SuggestionBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuggestionBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuggestionBackButton.ForeColor = System.Drawing.Color.Black;
            this.SuggestionBackButton.Location = new System.Drawing.Point(39, 28);
            this.SuggestionBackButton.Name = "SuggestionBackButton";
            this.SuggestionBackButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.SuggestionBackButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.SuggestionBackButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.SuggestionBackButton.Size = new System.Drawing.Size(184, 46);
            this.SuggestionBackButton.TabIndex = 16;
            this.SuggestionBackButton.Text = "BACK";
            this.SuggestionBackButton.TextColor = System.Drawing.Color.Black;
            this.SuggestionBackButton.UseVisualStyleBackColor = false;
            this.SuggestionBackButton.Click += new System.EventHandler(this.SuggestionBackButton_Click);
            // 
            // SuggestionQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SuggestionBackButton);
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
        private ePOSOne.btnProduct.RoundButton SuggestionBackButton;
    }
}