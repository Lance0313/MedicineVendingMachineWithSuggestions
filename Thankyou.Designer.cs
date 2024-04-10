namespace ThesisBeta
{
    partial class Thankyou
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thankyou));
            this.SPKLabel = new System.Windows.Forms.Label();
            this.ThankyouLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartScreenFooter = new System.Windows.Forms.Label();
            this.BacktoStartButton = new ePOSOne.btnProduct.RoundButton();
            this.SuspendLayout();
            // 
            // SPKLabel
            // 
            this.SPKLabel.AutoSize = true;
            this.SPKLabel.BackColor = System.Drawing.Color.Transparent;
            this.SPKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPKLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SPKLabel.Location = new System.Drawing.Point(110, 132);
            this.SPKLabel.Name = "SPKLabel";
            this.SPKLabel.Size = new System.Drawing.Size(606, 46);
            this.SPKLabel.TabIndex = 2;
            this.SPKLabel.Text = "SMART  Pharmaceutical Kiosk ";
            this.SPKLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ThankyouLabel
            // 
            this.ThankyouLabel.AutoSize = true;
            this.ThankyouLabel.BackColor = System.Drawing.Color.Transparent;
            this.ThankyouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThankyouLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ThankyouLabel.Location = new System.Drawing.Point(152, 69);
            this.ThankyouLabel.Name = "ThankyouLabel";
            this.ThankyouLabel.Size = new System.Drawing.Size(518, 63);
            this.ThankyouLabel.TabIndex = 3;
            this.ThankyouLabel.Text = "Thank you for using";
            this.ThankyouLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(38, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Streamlined Over-the-Counter Medicine Dispensing Innovation\r\n";
            // 
            // StartScreenFooter
            // 
            this.StartScreenFooter.AutoSize = true;
            this.StartScreenFooter.BackColor = System.Drawing.Color.Transparent;
            this.StartScreenFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenFooter.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.StartScreenFooter.Location = new System.Drawing.Point(272, 429);
            this.StartScreenFooter.Name = "StartScreenFooter";
            this.StartScreenFooter.Size = new System.Drawing.Size(270, 20);
            this.StartScreenFooter.TabIndex = 5;
            this.StartScreenFooter.Text = "All rights reserved. 2024 ©LMMN";
            // 
            // BacktoStartButton
            // 
            this.BacktoStartButton.BorderColor = System.Drawing.Color.Transparent;
            this.BacktoStartButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.BacktoStartButton.FlatAppearance.BorderSize = 0;
            this.BacktoStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BacktoStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacktoStartButton.Location = new System.Drawing.Point(298, 287);
            this.BacktoStartButton.Name = "BacktoStartButton";
            this.BacktoStartButton.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.BacktoStartButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.BacktoStartButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.BacktoStartButton.Size = new System.Drawing.Size(208, 46);
            this.BacktoStartButton.TabIndex = 6;
            this.BacktoStartButton.Text = "Back to Start";
            this.BacktoStartButton.TextColor = System.Drawing.Color.Black;
            this.BacktoStartButton.UseVisualStyleBackColor = true;
            // 
            // Thankyou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.BacktoStartButton);
            this.Controls.Add(this.StartScreenFooter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThankyouLabel);
            this.Controls.Add(this.SPKLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Thankyou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SPKLabel;
        private System.Windows.Forms.Label ThankyouLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StartScreenFooter;
        private ePOSOne.btnProduct.RoundButton BacktoStartButton;
    }
}
