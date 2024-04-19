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
            this.CartSummaryItemName = new System.Windows.Forms.Label();
            this.ECash = new System.Windows.Forms.Label();
            this.CartSummaryPrice = new System.Windows.Forms.Label();
            this.CartSummaryQuantity = new System.Windows.Forms.Label();
            this.CartSummaryTotal = new System.Windows.Forms.Label();
            this.BackButton = new ePOSOne.btnProduct.RoundButton();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.CartSummaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CartSummaryPanel
            // 
            this.CartSummaryPanel.BackColor = System.Drawing.Color.White;
            this.CartSummaryPanel.Controls.Add(this.CartSummaryTotal);
            this.CartSummaryPanel.Controls.Add(this.CartSummaryQuantity);
            this.CartSummaryPanel.Controls.Add(this.CartSummaryPrice);
            this.CartSummaryPanel.Controls.Add(this.CartSummaryItemName);
            this.CartSummaryPanel.Controls.Add(this.ECash);
            this.CartSummaryPanel.Location = new System.Drawing.Point(59, 91);
            this.CartSummaryPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CartSummaryPanel.Name = "CartSummaryPanel";
            this.CartSummaryPanel.Size = new System.Drawing.Size(931, 420);
            this.CartSummaryPanel.TabIndex = 9;
            // 
            // CartSummaryItemName
            // 
            this.CartSummaryItemName.AutoSize = true;
            this.CartSummaryItemName.Location = new System.Drawing.Point(31, 66);
            this.CartSummaryItemName.Name = "CartSummaryItemName";
            this.CartSummaryItemName.Size = new System.Drawing.Size(0, 16);
            this.CartSummaryItemName.TabIndex = 7;
            // 
            // ECash
            // 
            this.ECash.AutoSize = true;
            this.ECash.BackColor = System.Drawing.Color.Transparent;
            this.ECash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECash.ForeColor = System.Drawing.Color.Black;
            this.ECash.Location = new System.Drawing.Point(29, 25);
            this.ECash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ECash.Name = "ECash";
            this.ECash.Size = new System.Drawing.Size(150, 25);
            this.ECash.TabIndex = 4;
            this.ECash.Text = "Cart Summary\r\n";
            // 
            // CartSummaryPrice
            // 
            this.CartSummaryPrice.AutoSize = true;
            this.CartSummaryPrice.BackColor = System.Drawing.Color.Transparent;
            this.CartSummaryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartSummaryPrice.ForeColor = System.Drawing.Color.Black;
            this.CartSummaryPrice.Location = new System.Drawing.Point(696, 75);
            this.CartSummaryPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CartSummaryPrice.Name = "CartSummaryPrice";
            this.CartSummaryPrice.Size = new System.Drawing.Size(0, 25);
            this.CartSummaryPrice.TabIndex = 8;
            // 
            // CartSummaryQuantity
            // 
            this.CartSummaryQuantity.AutoSize = true;
            this.CartSummaryQuantity.Location = new System.Drawing.Point(384, 84);
            this.CartSummaryQuantity.Name = "CartSummaryQuantity";
            this.CartSummaryQuantity.Size = new System.Drawing.Size(0, 16);
            this.CartSummaryQuantity.TabIndex = 9;
            // 
            // CartSummaryTotal
            // 
            this.CartSummaryTotal.AutoSize = true;
            this.CartSummaryTotal.BackColor = System.Drawing.Color.Transparent;
            this.CartSummaryTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartSummaryTotal.ForeColor = System.Drawing.Color.Black;
            this.CartSummaryTotal.Location = new System.Drawing.Point(724, 378);
            this.CartSummaryTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CartSummaryTotal.Name = "CartSummaryTotal";
            this.CartSummaryTotal.Size = new System.Drawing.Size(0, 25);
            this.CartSummaryTotal.TabIndex = 10;
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
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 50;
            this.elipseControl1.TargetControl = this.CartSummaryPanel;
            // 
            // CartSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1043, 533);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CartSummaryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CartSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.CartSummaryPanel.ResumeLayout(false);
            this.CartSummaryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ePOSOne.btnProduct.RoundButton BackButton;
        private System.Windows.Forms.Panel CartSummaryPanel;
        private System.Windows.Forms.Label ECash;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Label CartSummaryItemName;
        private System.Windows.Forms.Label CartSummaryPrice;
        private System.Windows.Forms.Label CartSummaryQuantity;
        private System.Windows.Forms.Label CartSummaryTotal;
    }
}
