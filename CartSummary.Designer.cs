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
            this.CartSummaryText = new System.Windows.Forms.Panel();
            this.CartSummaryPrice = new System.Windows.Forms.Panel();
            this.CartSummaryQuantity = new System.Windows.Forms.Panel();
            this.CartSummaryItemName = new System.Windows.Forms.Panel();
            this.CartSummaryTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PPQ = new System.Windows.Forms.Label();
            this.ECash = new System.Windows.Forms.Label();
            this.CartSummaryProceed = new ePOSOne.btnProduct.RoundButton();
            this.CartSummaryBack = new ePOSOne.btnProduct.RoundButton();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.CartSummaryPanel.SuspendLayout();
            this.CartSummaryText.SuspendLayout();
            this.SuspendLayout();
            // 
            // CartSummaryPanel
            // 
            this.CartSummaryPanel.BackColor = System.Drawing.Color.White;
            this.CartSummaryPanel.Controls.Add(this.CartSummaryText);
            this.CartSummaryPanel.Controls.Add(this.CartSummaryTotal);
            this.CartSummaryPanel.Controls.Add(this.ECash);
            this.CartSummaryPanel.Location = new System.Drawing.Point(56, 93);
            this.CartSummaryPanel.Name = "CartSummaryPanel";
            this.CartSummaryPanel.Size = new System.Drawing.Size(698, 341);
            this.CartSummaryPanel.TabIndex = 9;
            // 
            // label1
            // 
            this.CartSummaryText.Controls.Add(this.CartSummaryPrice);
            this.CartSummaryText.Controls.Add(this.CartSummaryQuantity);
            this.CartSummaryText.Controls.Add(this.CartSummaryItemName);
            this.CartSummaryText.Location = new System.Drawing.Point(26, 57);
            this.CartSummaryText.Name = "CartSummaryText";
            this.CartSummaryText.Size = new System.Drawing.Size(630, 250);
            this.CartSummaryText.TabIndex = 7;
            // 
            // CartSummaryPrice
            // 
            this.CartSummaryPrice.Font = new System.Drawing.Font("MicraC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartSummaryPrice.Location = new System.Drawing.Point(531, 13);
            this.CartSummaryPrice.Name = "CartSummaryPrice";
            this.CartSummaryPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CartSummaryPrice.Size = new System.Drawing.Size(84, 221);
            this.CartSummaryPrice.TabIndex = 5;
            // 
            // CartSummaryQuantity
            // 
            this.CartSummaryQuantity.Font = new System.Drawing.Font("MicraC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartSummaryQuantity.Location = new System.Drawing.Point(293, 13);
            this.CartSummaryQuantity.Name = "CartSummaryQuantity";
            this.CartSummaryQuantity.Size = new System.Drawing.Size(112, 221);
            this.CartSummaryQuantity.TabIndex = 5;
            // 
            // CartSummaryItemName
            // 
            this.CartSummaryItemName.Font = new System.Drawing.Font("MicraC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartSummaryItemName.Location = new System.Drawing.Point(14, 13);
            this.CartSummaryItemName.Name = "CartSummaryItemName";
            this.CartSummaryItemName.Size = new System.Drawing.Size(181, 221);
            this.CartSummaryItemName.TabIndex = 4;
            // 
            // CartSummaryTotal
            // 
            this.CartSummaryTotal.AutoSize = true;
            this.CartSummaryTotal.BackColor = System.Drawing.Color.Transparent;
            this.CartSummaryTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartSummaryTotal.ForeColor = System.Drawing.Color.Black;
            this.CartSummaryTotal.Location = new System.Drawing.Point(510, 310);
            this.CartSummaryTotal.Name = "CartSummaryTotal";
            this.CartSummaryTotal.Size = new System.Drawing.Size(94, 20);
            this.CartSummaryTotal.TabIndex = 6;
            this.CartSummaryTotal.Text = "Total: 0.00";
            // 
            // ECash
            // 
            this.ECash.AutoSize = true;
            this.ECash.BackColor = System.Drawing.Color.Transparent;
            this.ECash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECash.ForeColor = System.Drawing.Color.Black;
            this.ECash.Location = new System.Drawing.Point(22, 20);
            this.ECash.Name = "ECash";
            this.ECash.Size = new System.Drawing.Size(122, 20);
            this.ECash.TabIndex = 4;
            this.ECash.Text = "Cart Summary\r\n";
            // 
            // CartSummaryProceed
            // 
            this.CartSummaryProceed.BorderColor = System.Drawing.Color.Transparent;
            this.CartSummaryProceed.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.CartSummaryProceed.FlatAppearance.BorderSize = 0;
            this.CartSummaryProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartSummaryProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartSummaryProceed.Location = new System.Drawing.Point(670, 21);
            this.CartSummaryProceed.Name = "CartSummaryProceed";
            this.CartSummaryProceed.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.CartSummaryProceed.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.CartSummaryProceed.OnHoverTextColor = System.Drawing.Color.Black;
            this.CartSummaryProceed.Size = new System.Drawing.Size(106, 46);
            this.CartSummaryProceed.TabIndex = 11;
            this.CartSummaryProceed.Text = "Proceed";
            this.CartSummaryProceed.TextColor = System.Drawing.Color.Black;
            this.CartSummaryProceed.UseVisualStyleBackColor = true;
            this.CartSummaryProceed.Click += new System.EventHandler(this.CartSummaryProceed_Click);
            // 
            // CartSummaryBack
            // 
            this.CartSummaryBack.BorderColor = System.Drawing.Color.Transparent;
            this.CartSummaryBack.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.CartSummaryBack.FlatAppearance.BorderSize = 0;
            this.CartSummaryBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartSummaryBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartSummaryBack.Location = new System.Drawing.Point(13, 21);
            this.CartSummaryBack.Name = "CartSummaryBack";
            this.CartSummaryBack.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.CartSummaryBack.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.CartSummaryBack.OnHoverTextColor = System.Drawing.Color.Black;
            this.CartSummaryBack.Size = new System.Drawing.Size(106, 46);
            this.CartSummaryBack.TabIndex = 10;
            this.CartSummaryBack.Text = "Back";
            this.CartSummaryBack.TextColor = System.Drawing.Color.Black;
            this.CartSummaryBack.UseVisualStyleBackColor = true;
            this.CartSummaryBack.Click += new System.EventHandler(this.CartSummaryBack_Click);
            // 
            // CartSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.CartSummaryProceed);
            this.Controls.Add(this.CartSummaryBack);
            this.Controls.Add(this.CartSummaryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.CartSummaryPanel.ResumeLayout(false);
            this.CartSummaryPanel.PerformLayout();
            this.CartSummaryText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ePOSOne.btnProduct.RoundButton CartSummaryBack;
        private System.Windows.Forms.Panel CartSummaryPanel;
        private System.Windows.Forms.Label ECash;
        private System.Windows.Forms.Label CartSummaryTotal;
        private ePOSOne.btnProduct.RoundButton CartSummaryProceed;
        private System.Windows.Forms.Panel CartSummaryText;
        private System.Windows.Forms.Panel CartSummaryItemName;
        private System.Windows.Forms.Panel CartSummaryPrice;
        private System.Windows.Forms.Panel CartSummaryQuantity;
    }
}
