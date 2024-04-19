namespace ThesisBeta
{
    partial class EcashPayment
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
            this.ECashPaymentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LMMNAmountReceived = new System.Windows.Forms.Label();
            this.LMMNTotal = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.LMMNQRImage = new System.Windows.Forms.PictureBox();
            this.ScantheQR = new System.Windows.Forms.Label();
            this.ECash = new System.Windows.Forms.Label();
            this.BackButton = new ePOSOne.btnProduct.RoundButton();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.EcashProceed = new ePOSOne.btnProduct.RoundButton();
            this.ECashPaymentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LMMNQRImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ECashPaymentPanel
            // 
            this.ECashPaymentPanel.BackColor = System.Drawing.Color.White;
            this.ECashPaymentPanel.Controls.Add(this.label1);
            this.ECashPaymentPanel.Controls.Add(this.LMMNAmountReceived);
            this.ECashPaymentPanel.Controls.Add(this.LMMNTotal);
            this.ECashPaymentPanel.Controls.Add(this.TotalAmount);
            this.ECashPaymentPanel.Controls.Add(this.LMMNQRImage);
            this.ECashPaymentPanel.Controls.Add(this.ScantheQR);
            this.ECashPaymentPanel.Controls.Add(this.ECash);
            this.ECashPaymentPanel.Location = new System.Drawing.Point(75, 114);
            this.ECashPaymentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ECashPaymentPanel.Name = "ECashPaymentPanel";
            this.ECashPaymentPanel.Size = new System.Drawing.Size(931, 420);
            this.ECashPaymentPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(535, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Amount Received:";
            // 
            // LMMNAmountReceived
            // 
            this.LMMNAmountReceived.AutoSize = true;
            this.LMMNAmountReceived.Location = new System.Drawing.Point(605, 271);
            this.LMMNAmountReceived.Name = "LMMNAmountReceived";
            this.LMMNAmountReceived.Size = new System.Drawing.Size(44, 16);
            this.LMMNAmountReceived.TabIndex = 9;
            this.LMMNAmountReceived.Text = "label1";
            // 
            // LMMNTotal
            // 
            this.LMMNTotal.AutoSize = true;
            this.LMMNTotal.BackColor = System.Drawing.Color.Transparent;
            this.LMMNTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMMNTotal.ForeColor = System.Drawing.Color.Black;
            this.LMMNTotal.Location = new System.Drawing.Point(603, 154);
            this.LMMNTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LMMNTotal.Name = "LMMNTotal";
            this.LMMNTotal.Size = new System.Drawing.Size(54, 25);
            this.LMMNTotal.TabIndex = 8;
            this.LMMNTotal.Text = "0.00";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.ForeColor = System.Drawing.Color.Black;
            this.TotalAmount.Location = new System.Drawing.Point(507, 106);
            this.TotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(244, 25);
            this.TotalAmount.TabIndex = 7;
            this.TotalAmount.Text = "Total Amount to be Paid";
            // 
            // LMMNQRImage
            // 
            this.LMMNQRImage.Location = new System.Drawing.Point(126, 106);
            this.LMMNQRImage.Margin = new System.Windows.Forms.Padding(4);
            this.LMMNQRImage.Name = "LMMNQRImage";
            this.LMMNQRImage.Size = new System.Drawing.Size(288, 288);
            this.LMMNQRImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LMMNQRImage.TabIndex = 6;
            this.LMMNQRImage.TabStop = false;
            // 
            // ScantheQR
            // 
            this.ScantheQR.AutoSize = true;
            this.ScantheQR.BackColor = System.Drawing.Color.Transparent;
            this.ScantheQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScantheQR.ForeColor = System.Drawing.Color.Black;
            this.ScantheQR.Location = new System.Drawing.Point(29, 65);
            this.ScantheQR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScantheQR.Name = "ScantheQR";
            this.ScantheQR.Size = new System.Drawing.Size(407, 25);
            this.ScantheQR.TabIndex = 5;
            this.ScantheQR.Text = "Please scan the provided QR code below";
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
            this.ECash.Size = new System.Drawing.Size(350, 25);
            this.ECash.TabIndex = 4;
            this.ECash.Text = "Payment Method: E-Cash Payment";
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
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.TextColor = System.Drawing.Color.Black;
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 50;
            this.elipseControl1.TargetControl = this.ECashPaymentPanel;
            // 
            // EcashProceed
            // 
            this.EcashProceed.BorderColor = System.Drawing.Color.Transparent;
            this.EcashProceed.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.EcashProceed.FlatAppearance.BorderSize = 0;
            this.EcashProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EcashProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EcashProceed.Location = new System.Drawing.Point(894, 26);
            this.EcashProceed.Margin = new System.Windows.Forms.Padding(4);
            this.EcashProceed.Name = "EcashProceed";
            this.EcashProceed.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.EcashProceed.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.EcashProceed.OnHoverTextColor = System.Drawing.Color.Black;
            this.EcashProceed.Size = new System.Drawing.Size(141, 57);
            this.EcashProceed.TabIndex = 9;
            this.EcashProceed.Text = "Proceed";
            this.EcashProceed.TextColor = System.Drawing.Color.Black;
            this.EcashProceed.UseVisualStyleBackColor = true;
            this.EcashProceed.Click += new System.EventHandler(this.EcashProceed_Click);
            // 
            // EcashPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1067, 591);
            this.Controls.Add(this.EcashProceed);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ECashPaymentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EcashPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ECashPaymentPanel.ResumeLayout(false);
            this.ECashPaymentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LMMNQRImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ECashPaymentPanel;
        private System.Windows.Forms.Label ScantheQR;
        private System.Windows.Forms.Label ECash;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private ePOSOne.btnProduct.RoundButton BackButton;
        private System.Windows.Forms.PictureBox LMMNQRImage;
        private System.Windows.Forms.Label LMMNTotal;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LMMNAmountReceived;
        private ePOSOne.btnProduct.RoundButton EcashProceed;
    }
}
