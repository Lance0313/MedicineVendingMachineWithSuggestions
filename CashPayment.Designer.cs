﻿namespace ThesisBeta
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
            this.TotalInsertedAmount = new System.Windows.Forms.Label();
            this.TotalInserted = new System.Windows.Forms.Label();
            this.TotalAmountValue = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.Cash = new System.Windows.Forms.Label();
            this.BackButton = new ePOSOne.btnProduct.RoundButton();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.InsertpictureBox = new System.Windows.Forms.PictureBox();
            this.TotalpictureBox = new System.Windows.Forms.PictureBox();
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
            this.CashPaymentPanel.Location = new System.Drawing.Point(56, 93);
            this.CashPaymentPanel.Name = "CashPaymentPanel";
            this.CashPaymentPanel.Size = new System.Drawing.Size(698, 341);
            this.CashPaymentPanel.TabIndex = 6;
            // 
            // TotalInsertedAmount
            // 
            this.TotalInsertedAmount.AutoSize = true;
            this.TotalInsertedAmount.BackColor = System.Drawing.Color.Transparent;
            this.TotalInsertedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalInsertedAmount.ForeColor = System.Drawing.Color.Black;
            this.TotalInsertedAmount.Location = new System.Drawing.Point(483, 288);
            this.TotalInsertedAmount.Name = "TotalInsertedAmount";
            this.TotalInsertedAmount.Size = new System.Drawing.Size(44, 20);
            this.TotalInsertedAmount.TabIndex = 8;
            this.TotalInsertedAmount.Text = "0.00";
            // 
            // TotalInserted
            // 
            this.TotalInserted.AutoSize = true;
            this.TotalInserted.BackColor = System.Drawing.Color.Transparent;
            this.TotalInserted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalInserted.ForeColor = System.Drawing.Color.Black;
            this.TotalInserted.Location = new System.Drawing.Point(409, 240);
            this.TotalInserted.Name = "TotalInserted";
            this.TotalInserted.Size = new System.Drawing.Size(188, 20);
            this.TotalInserted.TabIndex = 7;
            this.TotalInserted.Text = "Total Amount Inserted";
            // 
            // TotalAmountValue
            // 
            this.TotalAmountValue.AutoSize = true;
            this.TotalAmountValue.BackColor = System.Drawing.Color.Transparent;
            this.TotalAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountValue.ForeColor = System.Drawing.Color.Black;
            this.TotalAmountValue.Location = new System.Drawing.Point(164, 288);
            this.TotalAmountValue.Name = "TotalAmountValue";
            this.TotalAmountValue.Size = new System.Drawing.Size(44, 20);
            this.TotalAmountValue.TabIndex = 6;
            this.TotalAmountValue.Text = "0.00";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.ForeColor = System.Drawing.Color.Black;
            this.TotalAmount.Location = new System.Drawing.Point(88, 240);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(202, 20);
            this.TotalAmount.TabIndex = 5;
            this.TotalAmount.Text = "Total Amount to be Paid";
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.BackColor = System.Drawing.Color.Transparent;
            this.Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cash.ForeColor = System.Drawing.Color.Black;
            this.Cash.Location = new System.Drawing.Point(22, 20);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(268, 20);
            this.Cash.TabIndex = 4;
            this.Cash.Text = "Payment Method: Cash Payment";
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
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.TextColor = System.Drawing.Color.Black;
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 50;
            this.elipseControl1.TargetControl = this.CashPaymentPanel;
            // 
            // InsertpictureBox
            // 
            this.InsertpictureBox.Image = global::ThesisBeta.Properties.Resources.Insert;
            this.InsertpictureBox.Location = new System.Drawing.Point(415, 73);
            this.InsertpictureBox.Name = "InsertpictureBox";
            this.InsertpictureBox.Size = new System.Drawing.Size(175, 150);
            this.InsertpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InsertpictureBox.TabIndex = 10;
            this.InsertpictureBox.TabStop = false;
            // 
            // TotalpictureBox
            // 
            this.TotalpictureBox.Image = global::ThesisBeta.Properties.Resources.Total;
            this.TotalpictureBox.Location = new System.Drawing.Point(114, 87);
            this.TotalpictureBox.Name = "TotalpictureBox";
            this.TotalpictureBox.Size = new System.Drawing.Size(155, 127);
            this.TotalpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TotalpictureBox.TabIndex = 9;
            this.TotalpictureBox.TabStop = false;
            // 
            // CashPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CashPaymentPanel);
            this.Name = "CashPayment";
            this.Size = new System.Drawing.Size(800, 480);
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
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.PictureBox TotalpictureBox;
        private System.Windows.Forms.PictureBox InsertpictureBox;
    }
}
