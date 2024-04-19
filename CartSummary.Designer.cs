namespace ThesisBeta
{
    partial class CartSummary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CartSummaryPanel = new System.Windows.Forms.Panel();
            this.CartSummaryTotal = new System.Windows.Forms.Label();
            this.ECash = new System.Windows.Forms.Label();
            this.CartSummaryItemName = new System.Windows.Forms.Panel();
            this.CartSummaryQuantity = new System.Windows.Forms.Panel();
            this.CartSummaryPrice = new System.Windows.Forms.Panel();
            this.BackButton = new ePOSOne.btnProduct.RoundButton();
            this.ProceedButton = new ePOSOne.btnProduct.RoundButton();
            this.CartSummaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CartSummaryPanel
            // 
            this.CartSummaryPanel.BackColor = System.Drawing.Color.White;
            this.CartSummaryPanel.Controls.Add(this.CartSummaryPrice);
            this.CartSummaryPanel.Controls.Add(this.CartSummaryQuantity);
            this.CartSummaryPanel.Controls.Add(this.CartSummaryItemName);
            this.CartSummaryPanel.Controls.Add(this.CartSummaryTotal);
            this.CartSummaryPanel.Controls.Add(this.ECash);
            this.CartSummaryPanel.Location = new System.Drawing.Point(66, 91);
            this.CartSummaryPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CartSummaryPanel.Name = "CartSummaryPanel";
            this.CartSummaryPanel.Size = new System.Drawing.Size(931, 436);
            this.CartSummaryPanel.TabIndex = 9;
            // 
            // CartSummaryTotal
            // 
            this.CartSummaryTotal.AutoSize = true;
            this.CartSummaryTotal.BackColor = System.Drawing.Color.Transparent;
            this.CartSummaryTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartSummaryTotal.ForeColor = System.Drawing.Color.Black;
            this.CartSummaryTotal.Location = new System.Drawing.Point(675, 391);
            this.CartSummaryTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CartSummaryTotal.Name = "CartSummaryTotal";
            this.CartSummaryTotal.Size = new System.Drawing.Size(0, 25);
            this.CartSummaryTotal.TabIndex = 10;
            // 
            // ECash
            // 
            this.ECash.AutoSize = true;
            this.ECash.BackColor = System.Drawing.Color.Transparent;
            this.ECash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECash.ForeColor = System.Drawing.Color.Black;
            this.ECash.Location = new System.Drawing.Point(38, 33);
            this.ECash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ECash.Name = "ECash";
            this.ECash.Size = new System.Drawing.Size(150, 25);
            this.ECash.TabIndex = 4;
            this.ECash.Text = "Cart Summary\r\n";
            // 
            // CartSummaryItemName
            // 
            this.CartSummaryItemName.Location = new System.Drawing.Point(43, 73);
            this.CartSummaryItemName.Name = "CartSummaryItemName";
            this.CartSummaryItemName.Size = new System.Drawing.Size(228, 315);
            this.CartSummaryItemName.TabIndex = 11;
            // 
            // CartSummaryQuantity
            // 
            this.CartSummaryQuantity.Location = new System.Drawing.Point(343, 73);
            this.CartSummaryQuantity.Name = "CartSummaryQuantity";
            this.CartSummaryQuantity.Size = new System.Drawing.Size(228, 315);
            this.CartSummaryQuantity.TabIndex = 12;
            // 
            // CartSummaryPrice
            // 
            this.CartSummaryPrice.Location = new System.Drawing.Point(633, 73);
            this.CartSummaryPrice.Name = "CartSummaryPrice";
            this.CartSummaryPrice.Size = new System.Drawing.Size(228, 315);
            this.CartSummaryPrice.TabIndex = 13;
            // 
            // BackButton
            // 
            this.BackButton.BorderColor = System.Drawing.Color.Transparent;
            this.BackButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(17, 26);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.BackButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.BackButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.BackButton.Size = new System.Drawing.Size(150, 57);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.TextColor = System.Drawing.Color.Black;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ProceedButton
            // 
            this.ProceedButton.BorderColor = System.Drawing.Color.Transparent;
            this.ProceedButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.ProceedButton.FlatAppearance.BorderSize = 0;
            this.ProceedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedButton.Location = new System.Drawing.Point(894, 26);
            this.ProceedButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.ProceedButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.ProceedButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ProceedButton.Size = new System.Drawing.Size(150, 57);
            this.ProceedButton.TabIndex = 11;
            this.ProceedButton.Text = "Proceed";
            this.ProceedButton.TextColor = System.Drawing.Color.Black;
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // CartSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1067, 591);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CartSummaryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CartSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CartSummary_Load);
            this.CartSummaryPanel.ResumeLayout(false);
            this.CartSummaryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ePOSOne.btnProduct.RoundButton BackButton;
        private System.Windows.Forms.Panel CartSummaryPanel;
        private System.Windows.Forms.Label ECash;
        private System.Windows.Forms.Label CartSummaryTotal;
        private System.Windows.Forms.Panel CartSummaryItemName;
        private System.Windows.Forms.Panel CartSummaryQuantity;
        private System.Windows.Forms.Panel CartSummaryPrice;
        private ePOSOne.btnProduct.RoundButton ProceedButton;
    }
}
