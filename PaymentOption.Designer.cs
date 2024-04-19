namespace ThesisBeta
{
    partial class PaymentOption
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
            this.label1 = new System.Windows.Forms.Label();
            this.CashPayment = new System.Windows.Forms.PictureBox();
            this.Epayment = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CashPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epayment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "LMMN Epayment";
            // 
            // CashPayment
            // 
            this.CashPayment.Image = global::ThesisBeta.Properties.Resources.Peso_Sign;
            this.CashPayment.Location = new System.Drawing.Point(397, 25);
            this.CashPayment.Name = "CashPayment";
            this.CashPayment.Size = new System.Drawing.Size(298, 308);
            this.CashPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CashPayment.TabIndex = 2;
            this.CashPayment.TabStop = false;
            this.CashPayment.Click += new System.EventHandler(this.CashPayment_Click);
            // 
            // Epayment
            // 
            this.Epayment.Image = global::ThesisBeta.Properties.Resources.Logo_Epayment;
            this.Epayment.Location = new System.Drawing.Point(29, 25);
            this.Epayment.Name = "Epayment";
            this.Epayment.Size = new System.Drawing.Size(301, 308);
            this.Epayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Epayment.TabIndex = 0;
            this.Epayment.TabStop = false;
            this.Epayment.Click += new System.EventHandler(this.Epayment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cash Payment";
            // 
            // PaymentOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(729, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CashPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Epayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.CashPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Epayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CashPayment;
        private System.Windows.Forms.Label label2;
    }
}
