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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PaymentOptionPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PaymentOptionGcash = new System.Windows.Forms.PictureBox();
            this.PaymentOptionClose = new System.Windows.Forms.PictureBox();
            this.PaymentOptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentOptionGcash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentOptionClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentOptionPanel
            // 
            this.PaymentOptionPanel.BackColor = System.Drawing.Color.White;
            this.PaymentOptionPanel.Controls.Add(this.label2);
            this.PaymentOptionPanel.Controls.Add(this.label1);
            this.PaymentOptionPanel.Controls.Add(this.pictureBox1);
            this.PaymentOptionPanel.Controls.Add(this.PaymentOptionGcash);
            this.PaymentOptionPanel.Location = new System.Drawing.Point(57, 58);
            this.PaymentOptionPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PaymentOptionPanel.Name = "PaymentOptionPanel";
            this.PaymentOptionPanel.Size = new System.Drawing.Size(549, 276);
            this.PaymentOptionPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gcash";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThesisBeta.Properties.Resources.Peso;
            this.pictureBox1.Location = new System.Drawing.Point(283, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PaymentOptionGcash
            // 
            this.PaymentOptionGcash.Image = global::ThesisBeta.Properties.Resources.Gcash;
            this.PaymentOptionGcash.Location = new System.Drawing.Point(16, 18);
            this.PaymentOptionGcash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PaymentOptionGcash.Name = "PaymentOptionGcash";
            this.PaymentOptionGcash.Size = new System.Drawing.Size(251, 199);
            this.PaymentOptionGcash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PaymentOptionGcash.TabIndex = 0;
            this.PaymentOptionGcash.TabStop = false;
            this.PaymentOptionGcash.Click += new System.EventHandler(this.PaymentOptionGcash_Click);
            // 
            // PaymentOptionClose
            // 
            this.PaymentOptionClose.Image = global::ThesisBeta.Properties.Resources.Yellow_X;
            this.PaymentOptionClose.Location = new System.Drawing.Point(608, 4);
            this.PaymentOptionClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PaymentOptionClose.Name = "PaymentOptionClose";
            this.PaymentOptionClose.Size = new System.Drawing.Size(55, 43);
            this.PaymentOptionClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PaymentOptionClose.TabIndex = 2;
            this.PaymentOptionClose.TabStop = false;
            this.PaymentOptionClose.Click += new System.EventHandler(this.PaymentOptionClose_Click);
            // 
            // PaymentOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(667, 369);
            this.Controls.Add(this.PaymentOptionClose);
            this.Controls.Add(this.PaymentOptionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PaymentOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentOption";
            this.PaymentOptionPanel.ResumeLayout(false);
            this.PaymentOptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentOptionGcash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentOptionClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaymentOptionPanel;
        private System.Windows.Forms.PictureBox PaymentOptionGcash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PaymentOptionClose;
    }
}
