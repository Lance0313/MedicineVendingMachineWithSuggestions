namespace ThesisBeta
{
    partial class Gcash
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GcashTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GcashAmountReceived = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CartSummaryBack = new ePOSOne.btnProduct.RoundButton();
            this.GcashProceed = new ePOSOne.btnProduct.RoundButton();
            this.GcashQRImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcashQRImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.GcashQRImage);
            this.panel1.Controls.Add(this.GcashTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.GcashAmountReceived);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(63, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 362);
            this.panel1.TabIndex = 0;
            // 
            // GcashTotal
            // 
            this.GcashTotal.AutoSize = true;
            this.GcashTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GcashTotal.Location = new System.Drawing.Point(521, 144);
            this.GcashTotal.Name = "GcashTotal";
            this.GcashTotal.Size = new System.Drawing.Size(76, 25);
            this.GcashTotal.TabIndex = 7;
            this.GcashTotal.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Php";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Scan the QR Code to pay";
            // 
            // GcashAmountReceived
            // 
            this.GcashAmountReceived.AutoSize = true;
            this.GcashAmountReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GcashAmountReceived.Location = new System.Drawing.Point(521, 255);
            this.GcashAmountReceived.Name = "GcashAmountReceived";
            this.GcashAmountReceived.Size = new System.Drawing.Size(76, 25);
            this.GcashAmountReceived.TabIndex = 3;
            this.GcashAmountReceived.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Php";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount Received:";
            // 
            // CartSummaryBack
            // 
            this.CartSummaryBack.BorderColor = System.Drawing.Color.Transparent;
            this.CartSummaryBack.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.CartSummaryBack.FlatAppearance.BorderSize = 0;
            this.CartSummaryBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartSummaryBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartSummaryBack.Location = new System.Drawing.Point(23, 12);
            this.CartSummaryBack.Name = "CartSummaryBack";
            this.CartSummaryBack.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.CartSummaryBack.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.CartSummaryBack.OnHoverTextColor = System.Drawing.Color.Black;
            this.CartSummaryBack.Size = new System.Drawing.Size(106, 46);
            this.CartSummaryBack.TabIndex = 11;
            this.CartSummaryBack.Text = "Back";
            this.CartSummaryBack.TextColor = System.Drawing.Color.Black;
            this.CartSummaryBack.UseVisualStyleBackColor = true;
            this.CartSummaryBack.Click += new System.EventHandler(this.CartSummaryBack_Click);
            // 
            // GcashProceed
            // 
            this.GcashProceed.BorderColor = System.Drawing.Color.Transparent;
            this.GcashProceed.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.GcashProceed.FlatAppearance.BorderSize = 0;
            this.GcashProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GcashProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GcashProceed.Location = new System.Drawing.Point(668, 12);
            this.GcashProceed.Name = "GcashProceed";
            this.GcashProceed.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.GcashProceed.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.GcashProceed.OnHoverTextColor = System.Drawing.Color.Black;
            this.GcashProceed.Size = new System.Drawing.Size(106, 46);
            this.GcashProceed.TabIndex = 12;
            this.GcashProceed.Text = "Proceed";
            this.GcashProceed.TextColor = System.Drawing.Color.Black;
            this.GcashProceed.UseVisualStyleBackColor = true;
            this.GcashProceed.Click += new System.EventHandler(this.GcashProceed_Click);
            // 
            // GcashQRImage
            // 
            this.GcashQRImage.Location = new System.Drawing.Point(60, 48);
            this.GcashQRImage.Name = "GcashQRImage";
            this.GcashQRImage.Size = new System.Drawing.Size(256, 268);
            this.GcashQRImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GcashQRImage.TabIndex = 8;
            this.GcashQRImage.TabStop = false;
            // 
            // Gcash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.GcashProceed);
            this.Controls.Add(this.CartSummaryBack);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gcash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gcash";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcashQRImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.RoundButton CartSummaryBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GcashAmountReceived;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GcashTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ePOSOne.btnProduct.RoundButton GcashProceed;
        private System.Windows.Forms.PictureBox GcashQRImage;
    }
}