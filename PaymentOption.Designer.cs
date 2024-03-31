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
            this.PaymentOptionPanel.Location = new System.Drawing.Point(43, 47);
            this.PaymentOptionPanel.Name = "PaymentOptionPanel";
            this.PaymentOptionPanel.Size = new System.Drawing.Size(412, 224);
            this.PaymentOptionPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gcash";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThesisBeta.Properties.Resources.Peso;
            this.pictureBox1.Location = new System.Drawing.Point(212, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PaymentOptionGcash
            // 
            this.PaymentOptionGcash.Image = global::ThesisBeta.Properties.Resources.Gcash;
            this.PaymentOptionGcash.Location = new System.Drawing.Point(12, 15);
            this.PaymentOptionGcash.Name = "PaymentOptionGcash";
            this.PaymentOptionGcash.Size = new System.Drawing.Size(188, 162);
            this.PaymentOptionGcash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PaymentOptionGcash.TabIndex = 0;
            this.PaymentOptionGcash.TabStop = false;
            this.PaymentOptionGcash.Click += new System.EventHandler(this.PaymentOptionGcash_Click);
            // 
            // PaymentOptionClose
            // 
            this.PaymentOptionClose.Image = global::ThesisBeta.Properties.Resources.Yellow_X;
            this.PaymentOptionClose.Location = new System.Drawing.Point(456, 3);
            this.PaymentOptionClose.Name = "PaymentOptionClose";
            this.PaymentOptionClose.Size = new System.Drawing.Size(41, 35);
            this.PaymentOptionClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PaymentOptionClose.TabIndex = 2;
            this.PaymentOptionClose.TabStop = false;
            this.PaymentOptionClose.Click += new System.EventHandler(this.PaymentOptionClose_Click);
            // 
            // PaymentOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.PaymentOptionClose);
            this.Controls.Add(this.PaymentOptionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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