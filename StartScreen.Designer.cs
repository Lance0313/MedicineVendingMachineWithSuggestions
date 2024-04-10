namespace ThesisBeta
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.StartScreenLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartScreenFooter = new System.Windows.Forms.Label();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartScreenSuggestion = new ePOSOne.btnProduct.RoundButton();
            this.StartScreenPurchase = new ePOSOne.btnProduct.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // StartScreenLabel
            // 
            this.StartScreenLabel.AutoSize = true;
            this.StartScreenLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartScreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StartScreenLabel.Location = new System.Drawing.Point(49, 46);
            this.StartScreenLabel.Name = "StartScreenLabel";
            this.StartScreenLabel.Size = new System.Drawing.Size(713, 152);
            this.StartScreenLabel.TabIndex = 1;
            this.StartScreenLabel.Text = "SMART \r\nPharmaceutical Kiosk ";
            this.StartScreenLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StartScreenLabel.Click += new System.EventHandler(this.StartScreenLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(29, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Streamlined Over-the-Counter Medicine Dispensing Innovation\r\n";
            // 
            // StartScreenFooter
            // 
            this.StartScreenFooter.AutoSize = true;
            this.StartScreenFooter.BackColor = System.Drawing.Color.Transparent;
            this.StartScreenFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenFooter.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.StartScreenFooter.Location = new System.Drawing.Point(261, 428);
            this.StartScreenFooter.Name = "StartScreenFooter";
            this.StartScreenFooter.Size = new System.Drawing.Size(270, 20);
            this.StartScreenFooter.TabIndex = 4;
            this.StartScreenFooter.Text = "All rights reserved. 2024 ©LMMN";
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Quantity,
            this.ProductPrice});
            this.dataGridViewCart.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.Size = new System.Drawing.Size(334, 183);
            this.dataGridViewCart.TabIndex = 5;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "String";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "int";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "double";
            this.ProductPrice.HeaderText = "ProductPrice";
            this.ProductPrice.Name = "ProductPrice";
            // 
            // StartScreenSuggestion
            // 
            this.StartScreenSuggestion.BorderColor = System.Drawing.Color.Transparent;
            this.StartScreenSuggestion.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.StartScreenSuggestion.FlatAppearance.BorderSize = 0;
            this.StartScreenSuggestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartScreenSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenSuggestion.Location = new System.Drawing.Point(457, 297);
            this.StartScreenSuggestion.Name = "StartScreenSuggestion";
            this.StartScreenSuggestion.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.StartScreenSuggestion.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.StartScreenSuggestion.OnHoverTextColor = System.Drawing.Color.Black;
            this.StartScreenSuggestion.Size = new System.Drawing.Size(208, 46);
            this.StartScreenSuggestion.TabIndex = 2;
            this.StartScreenSuggestion.Text = "Suggestion";
            this.StartScreenSuggestion.TextColor = System.Drawing.Color.Black;
            this.StartScreenSuggestion.UseVisualStyleBackColor = true;
            // 
            // StartScreenPurchase
            // 
            this.StartScreenPurchase.BorderColor = System.Drawing.Color.Transparent;
            this.StartScreenPurchase.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.StartScreenPurchase.FlatAppearance.BorderSize = 0;
            this.StartScreenPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartScreenPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenPurchase.Location = new System.Drawing.Point(138, 297);
            this.StartScreenPurchase.Name = "StartScreenPurchase";
            this.StartScreenPurchase.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.StartScreenPurchase.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.StartScreenPurchase.OnHoverTextColor = System.Drawing.Color.Black;
            this.StartScreenPurchase.Size = new System.Drawing.Size(208, 46);
            this.StartScreenPurchase.TabIndex = 0;
            this.StartScreenPurchase.Text = "Purchase";
            this.StartScreenPurchase.TextColor = System.Drawing.Color.Black;
            this.StartScreenPurchase.UseVisualStyleBackColor = true;
            this.StartScreenPurchase.Click += new System.EventHandler(this.StartScreenPurchase_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.StartScreenFooter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartScreenSuggestion);
            this.Controls.Add(this.StartScreenLabel);
            this.Controls.Add(this.StartScreenPurchase);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.RoundButton StartScreenPurchase;
        private System.Windows.Forms.Label StartScreenLabel;
        private ePOSOne.btnProduct.RoundButton StartScreenSuggestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StartScreenFooter;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
    }
}

