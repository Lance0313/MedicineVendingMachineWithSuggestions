namespace ThesisBeta
{
    partial class PaymentMethod
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
            this.PaymentMethodPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PesopictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PaywithCashButton = new ePOSOne.btnProduct.RoundButton();
            this.PaywithEcashButton = new ePOSOne.btnProduct.RoundButton();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.elipseControl2 = new ElipseToolDemo.ElipseControl();
            this.BackButton = new ePOSOne.btnProduct.RoundButton();
            this.PaymentMethodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentMethodPanel
            // 
            this.PaymentMethodPanel.BackColor = System.Drawing.Color.White;
            this.PaymentMethodPanel.Controls.Add(this.pictureBox1);
            this.PaymentMethodPanel.Controls.Add(this.PesopictureBox);
            this.PaymentMethodPanel.Controls.Add(this.label1);
            this.PaymentMethodPanel.Controls.Add(this.PaywithCashButton);
            this.PaymentMethodPanel.Controls.Add(this.PaywithEcashButton);
            this.PaymentMethodPanel.Location = new System.Drawing.Point(56, 93);
            this.PaymentMethodPanel.Name = "PaymentMethodPanel";
            this.PaymentMethodPanel.Size = new System.Drawing.Size(698, 341);
            this.PaymentMethodPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThesisBeta.Properties.Resources.Gcash;
            this.pictureBox1.Location = new System.Drawing.Point(431, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PesopictureBox
            // 
            this.PesopictureBox.Image = global::ThesisBeta.Properties.Resources.Peso;
            this.PesopictureBox.Location = new System.Drawing.Point(101, 83);
            this.PesopictureBox.Name = "PesopictureBox";
            this.PesopictureBox.Size = new System.Drawing.Size(144, 162);
            this.PesopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PesopictureBox.TabIndex = 5;
            this.PesopictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose a payment method below";
            // 
            // PaywithCashButton
            // 
            this.PaywithCashButton.BorderColor = System.Drawing.Color.Transparent;
            this.PaywithCashButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.PaywithCashButton.FlatAppearance.BorderSize = 0;
            this.PaywithCashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaywithCashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaywithCashButton.Location = new System.Drawing.Point(65, 262);
            this.PaywithCashButton.Name = "PaywithCashButton";
            this.PaywithCashButton.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.PaywithCashButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.PaywithCashButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.PaywithCashButton.Size = new System.Drawing.Size(208, 46);
            this.PaywithCashButton.TabIndex = 1;
            this.PaywithCashButton.Text = "Pay with Cash";
            this.PaywithCashButton.TextColor = System.Drawing.Color.Black;
            this.PaywithCashButton.UseVisualStyleBackColor = true;
            // 
            // PaywithEcashButton
            // 
            this.PaywithEcashButton.BorderColor = System.Drawing.Color.Transparent;
            this.PaywithEcashButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.PaywithEcashButton.FlatAppearance.BorderSize = 0;
            this.PaywithEcashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaywithEcashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaywithEcashButton.Location = new System.Drawing.Point(407, 262);
            this.PaywithEcashButton.Name = "PaywithEcashButton";
            this.PaywithEcashButton.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.PaywithEcashButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.PaywithEcashButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.PaywithEcashButton.Size = new System.Drawing.Size(208, 46);
            this.PaywithEcashButton.TabIndex = 2;
            this.PaywithEcashButton.Text = "Pay with E-Cash";
            this.PaywithEcashButton.TextColor = System.Drawing.Color.Black;
            this.PaywithEcashButton.UseVisualStyleBackColor = true;
            this.PaywithEcashButton.Click += new System.EventHandler(this.PaywithEcash_Click);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 50;
            this.elipseControl1.TargetControl = null;
            // 
            // elipseControl2
            // 
            this.elipseControl2.CornerRadius = 50;
            this.elipseControl2.TargetControl = this.PaymentMethodPanel;
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
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.TextColor = System.Drawing.Color.Black;
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // PaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PaymentMethodPanel);
            this.Name = "PaymentMethod";
            this.Size = new System.Drawing.Size(800, 480);
            this.PaymentMethodPanel.ResumeLayout(false);
            this.PaymentMethodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PesopictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaymentMethodPanel;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private ElipseToolDemo.ElipseControl elipseControl2;
        private ePOSOne.btnProduct.RoundButton PaywithCashButton;
        private ePOSOne.btnProduct.RoundButton PaywithEcashButton;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.RoundButton BackButton;
        private System.Windows.Forms.PictureBox PesopictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
