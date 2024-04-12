namespace ThesisBeta
{
    partial class CashPayment
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
            this.CashPaymentPanel = new System.Windows.Forms.Panel();
            this.InsertpictureBox = new System.Windows.Forms.PictureBox();
            this.TotalpictureBox = new System.Windows.Forms.PictureBox();
            this.TotalInsertedAmount = new System.Windows.Forms.Label();
            this.TotalInserted = new System.Windows.Forms.Label();
            this.TotalAmountValue = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.Cash = new System.Windows.Forms.Label();
            this.CashPaymentProceed = new ePOSOne.btnProduct.RoundButton();
            this.BackButton = new ePOSOne.btnProduct.RoundButton();
            this.CashPaymentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InsertpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CashPaymentPanel
            // 
            this.CashPaymentPanel.BackColor = System.Drawing.Color.White;
            this.CashPaymentPanel.Controls.Add(this.InsertpictureBox);
            this.CashPaymentPanel.Controls.Add(this.TotalpictureBox);
            this.CashPaymentPanel.Controls.Add(this.TotalInsertedAmount);
            this.CashPaymentPanel.Controls.Add(this.TotalInserted);
            this.CashPaymentPanel.Controls.Add(this.TotalAmountValue);
            this.CashPaymentPanel.Controls.Add(this.TotalAmount);
            this.CashPaymentPanel.Controls.Add(this.Cash);
            this.CashPaymentPanel.Location = new System.Drawing.Point(75, 114);
            this.CashPaymentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CashPaymentPanel.Name = "CashPaymentPanel";
            this.CashPaymentPanel.Size = new System.Drawing.Size(931, 420);
            this.CashPaymentPanel.TabIndex = 6;
            // 
            // InsertpictureBox
            // 
            this.InsertpictureBox.Image = global::ThesisBeta.Properties.Resources.Insert;
            this.InsertpictureBox.Location = new System.Drawing.Point(553, 90);
            this.InsertpictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.InsertpictureBox.Name = "InsertpictureBox";
            this.InsertpictureBox.Size = new System.Drawing.Size(233, 185);
            this.InsertpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InsertpictureBox.TabIndex = 10;
            this.InsertpictureBox.TabStop = false;
            // 
            // TotalpictureBox
            // 
            this.TotalpictureBox.Image = global::ThesisBeta.Properties.Resources.Total;
            this.TotalpictureBox.Location = new System.Drawing.Point(152, 107);
            this.TotalpictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalpictureBox.Name = "TotalpictureBox";
            this.TotalpictureBox.Size = new System.Drawing.Size(207, 156);
            this.TotalpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TotalpictureBox.TabIndex = 9;
            this.TotalpictureBox.TabStop = false;
            // 
            // TotalInsertedAmount
            // 
            this.TotalInsertedAmount.AutoSize = true;
            this.TotalInsertedAmount.BackColor = System.Drawing.Color.Transparent;
            this.TotalInsertedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalInsertedAmount.ForeColor = System.Drawing.Color.Black;
            this.TotalInsertedAmount.Location = new System.Drawing.Point(644, 354);
            this.TotalInsertedAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalInsertedAmount.Name = "TotalInsertedAmount";
            this.TotalInsertedAmount.Size = new System.Drawing.Size(54, 25);
            this.TotalInsertedAmount.TabIndex = 8;
            this.TotalInsertedAmount.Text = "0.00";
            this.TotalInsertedAmount.TextChanged += new System.EventHandler(this.InitializeEventListeners);
            // 
            // TotalInserted
            // 
            this.TotalInserted.AutoSize = true;
            this.TotalInserted.BackColor = System.Drawing.Color.Transparent;
            this.TotalInserted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalInserted.ForeColor = System.Drawing.Color.Black;
            this.TotalInserted.Location = new System.Drawing.Point(545, 295);
            this.TotalInserted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalInserted.Name = "TotalInserted";
            this.TotalInserted.Size = new System.Drawing.Size(225, 25);
            this.TotalInserted.TabIndex = 7;
            this.TotalInserted.Text = "Total Amount Inserted";
            // 
            // TotalAmountValue
            // 
            this.TotalAmountValue.AutoSize = true;
            this.TotalAmountValue.BackColor = System.Drawing.Color.Transparent;
            this.TotalAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountValue.ForeColor = System.Drawing.Color.Black;
            this.TotalAmountValue.Location = new System.Drawing.Point(219, 354);
            this.TotalAmountValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalAmountValue.Name = "TotalAmountValue";
            this.TotalAmountValue.Size = new System.Drawing.Size(24, 25);
            this.TotalAmountValue.TabIndex = 6;
            this.TotalAmountValue.Text = "0";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.ForeColor = System.Drawing.Color.Black;
            this.TotalAmount.Location = new System.Drawing.Point(117, 295);
            this.TotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(244, 25);
            this.TotalAmount.TabIndex = 5;
            this.TotalAmount.Text = "Total Amount to be Paid";
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.BackColor = System.Drawing.Color.Transparent;
            this.Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cash.ForeColor = System.Drawing.Color.Black;
            this.Cash.Location = new System.Drawing.Point(29, 25);
            this.Cash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(328, 25);
            this.Cash.TabIndex = 4;
            this.Cash.Text = "Payment Method: Cash Payment";
            // 
            // CashPaymentProceed
            // 
            this.CashPaymentProceed.BorderColor = System.Drawing.Color.Transparent;
            this.CashPaymentProceed.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.CashPaymentProceed.FlatAppearance.BorderSize = 0;
            this.CashPaymentProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashPaymentProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashPaymentProceed.Location = new System.Drawing.Point(890, 26);
            this.CashPaymentProceed.Margin = new System.Windows.Forms.Padding(4);
            this.CashPaymentProceed.Name = "CashPaymentProceed";
            this.CashPaymentProceed.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.CashPaymentProceed.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.CashPaymentProceed.OnHoverTextColor = System.Drawing.Color.Black;
            this.CashPaymentProceed.Size = new System.Drawing.Size(141, 57);
            this.CashPaymentProceed.TabIndex = 8;
            this.CashPaymentProceed.Text = "Proceed";
            this.CashPaymentProceed.TextColor = System.Drawing.Color.Black;
            this.CashPaymentProceed.UseVisualStyleBackColor = true;
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
            this.BackButton.Size = new System.Drawing.Size(141, 57);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.TextColor = System.Drawing.Color.Black;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CashPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1067, 591);
            this.Controls.Add(this.CashPaymentProceed);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CashPaymentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CashPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.CashPaymentPanel.ResumeLayout(false);
            this.CashPaymentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InsertpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ePOSOne.btnProduct.RoundButton BackButton;
        private System.Windows.Forms.Panel CashPaymentPanel;
        private System.Windows.Forms.Label Cash;
        private System.Windows.Forms.Label TotalInsertedAmount;
        private System.Windows.Forms.Label TotalInserted;
        private System.Windows.Forms.Label TotalAmountValue;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.PictureBox TotalpictureBox;
        private System.Windows.Forms.PictureBox InsertpictureBox;
        private ePOSOne.btnProduct.RoundButton CashPaymentProceed;
    }
}
