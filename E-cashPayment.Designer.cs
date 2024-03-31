namespace ThesisBeta
{
    partial class UserControl1
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
            this.ScantheQR = new System.Windows.Forms.Label();
            this.ECash = new System.Windows.Forms.Label();
            this.BackButton = new ePOSOne.btnProduct.RoundButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TotalAmountValue = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.ECashPaymentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ECashPaymentPanel
            // 
            this.ECashPaymentPanel.BackColor = System.Drawing.Color.White;
            this.ECashPaymentPanel.Controls.Add(this.TotalAmountValue);
            this.ECashPaymentPanel.Controls.Add(this.TotalAmount);
            this.ECashPaymentPanel.Controls.Add(this.pictureBox1);
            this.ECashPaymentPanel.Controls.Add(this.ScantheQR);
            this.ECashPaymentPanel.Controls.Add(this.ECash);
            this.ECashPaymentPanel.Location = new System.Drawing.Point(56, 93);
            this.ECashPaymentPanel.Name = "ECashPaymentPanel";
            this.ECashPaymentPanel.Size = new System.Drawing.Size(698, 341);
            this.ECashPaymentPanel.TabIndex = 7;
            // 
            // ScantheQR
            // 
            this.ScantheQR.AutoSize = true;
            this.ScantheQR.BackColor = System.Drawing.Color.Transparent;
            this.ScantheQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScantheQR.ForeColor = System.Drawing.Color.Black;
            this.ScantheQR.Location = new System.Drawing.Point(22, 53);
            this.ScantheQR.Name = "ScantheQR";
            this.ScantheQR.Size = new System.Drawing.Size(336, 20);
            this.ScantheQR.TabIndex = 5;
            this.ScantheQR.Text = "Please scan the provided QR code below";
            // 
            // ECash
            // 
            this.ECash.AutoSize = true;
            this.ECash.BackColor = System.Drawing.Color.Transparent;
            this.ECash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECash.ForeColor = System.Drawing.Color.Black;
            this.ECash.Location = new System.Drawing.Point(22, 20);
            this.ECash.Name = "ECash";
            this.ECash.Size = new System.Drawing.Size(286, 20);
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
            this.BackButton.Location = new System.Drawing.Point(13, 21);
            this.BackButton.Name = "BackButton";
            this.BackButton.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.BackButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.BackButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.BackButton.Size = new System.Drawing.Size(106, 46);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.TextColor = System.Drawing.Color.Black;
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThesisBeta.Properties.Resources.SampleQR;
            this.pictureBox1.Location = new System.Drawing.Point(184, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // TotalAmountValue
            // 
            this.TotalAmountValue.AutoSize = true;
            this.TotalAmountValue.BackColor = System.Drawing.Color.Transparent;
            this.TotalAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountValue.ForeColor = System.Drawing.Color.Black;
            this.TotalAmountValue.Location = new System.Drawing.Point(523, 206);
            this.TotalAmountValue.Name = "TotalAmountValue";
            this.TotalAmountValue.Size = new System.Drawing.Size(44, 20);
            this.TotalAmountValue.TabIndex = 8;
            this.TotalAmountValue.Text = "0.00";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.ForeColor = System.Drawing.Color.Black;
            this.TotalAmount.Location = new System.Drawing.Point(447, 158);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(202, 20);
            this.TotalAmount.TabIndex = 7;
            this.TotalAmount.Text = "Total Amount to be Paid";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ECashPaymentPanel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 480);
            this.ECashPaymentPanel.ResumeLayout(false);
            this.ECashPaymentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ECashPaymentPanel;
        private System.Windows.Forms.Label ScantheQR;
        private System.Windows.Forms.Label ECash;
        private ePOSOne.btnProduct.RoundButton BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TotalAmountValue;
        private System.Windows.Forms.Label TotalAmount;
    }
}
