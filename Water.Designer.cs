namespace ThesisBeta
{
    partial class Water
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
            this.NeedWater = new System.Windows.Forms.Label();
            this.WaterDescription = new System.Windows.Forms.Label();
            this.WaterPanel = new System.Windows.Forms.Panel();
            this.WaterpictureBox = new System.Windows.Forms.PictureBox();
            this.ReleaseButton = new ePOSOne.btnProduct.RoundButton();
            this.ExitButton = new ePOSOne.btnProduct.RoundButton();
            this.WaterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaterpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NeedWater
            // 
            this.NeedWater.AutoSize = true;
            this.NeedWater.BackColor = System.Drawing.Color.Transparent;
            this.NeedWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeedWater.ForeColor = System.Drawing.Color.Black;
            this.NeedWater.Location = new System.Drawing.Point(365, 28);
            this.NeedWater.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NeedWater.Name = "NeedWater";
            this.NeedWater.Size = new System.Drawing.Size(228, 39);
            this.NeedWater.TabIndex = 5;
            this.NeedWater.Text = "Need Water?";
            // 
            // WaterDescription
            // 
            this.WaterDescription.AutoSize = true;
            this.WaterDescription.BackColor = System.Drawing.Color.Transparent;
            this.WaterDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterDescription.ForeColor = System.Drawing.Color.Black;
            this.WaterDescription.Location = new System.Drawing.Point(123, 77);
            this.WaterDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WaterDescription.Name = "WaterDescription";
            this.WaterDescription.Size = new System.Drawing.Size(690, 25);
            this.WaterDescription.TabIndex = 6;
            this.WaterDescription.Text = "If you are in need of water take a cup and press the \"RELEASE\" button";
            // 
            // WaterPanel
            // 
            this.WaterPanel.BackColor = System.Drawing.Color.White;
            this.WaterPanel.Controls.Add(this.WaterpictureBox);
            this.WaterPanel.Controls.Add(this.ReleaseButton);
            this.WaterPanel.Controls.Add(this.WaterDescription);
            this.WaterPanel.Controls.Add(this.NeedWater);
            this.WaterPanel.Location = new System.Drawing.Point(84, 105);
            this.WaterPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WaterPanel.Name = "WaterPanel";
            this.WaterPanel.Size = new System.Drawing.Size(931, 420);
            this.WaterPanel.TabIndex = 12;
            // 
            // WaterpictureBox
            // 
            this.WaterpictureBox.Image = global::ThesisBeta.Properties.Resources.Water;
            this.WaterpictureBox.Location = new System.Drawing.Point(324, 118);
            this.WaterpictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WaterpictureBox.Name = "WaterpictureBox";
            this.WaterpictureBox.Size = new System.Drawing.Size(280, 212);
            this.WaterpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WaterpictureBox.TabIndex = 13;
            this.WaterpictureBox.TabStop = false;
            // 
            // ReleaseButton
            // 
            this.ReleaseButton.BorderColor = System.Drawing.Color.Transparent;
            this.ReleaseButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.ReleaseButton.FlatAppearance.BorderSize = 0;
            this.ReleaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReleaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseButton.Location = new System.Drawing.Point(327, 342);
            this.ReleaseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReleaseButton.Name = "ReleaseButton";
            this.ReleaseButton.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.ReleaseButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.ReleaseButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ReleaseButton.Size = new System.Drawing.Size(277, 57);
            this.ReleaseButton.TabIndex = 7;
            this.ReleaseButton.Text = "Release";
            this.ReleaseButton.TextColor = System.Drawing.Color.Black;
            this.ReleaseButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.BorderColor = System.Drawing.Color.Transparent;
            this.ExitButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(17, 26);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.ExitButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.ExitButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ExitButton.Size = new System.Drawing.Size(141, 57);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextColor = System.Drawing.Color.Black;
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // Water
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.WaterPanel);
            this.Controls.Add(this.ExitButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Water";
            this.Size = new System.Drawing.Size(1067, 591);
            this.WaterPanel.ResumeLayout(false);
            this.WaterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaterpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ePOSOne.btnProduct.RoundButton ExitButton;
        private System.Windows.Forms.Label NeedWater;
        private System.Windows.Forms.Label WaterDescription;
        private System.Windows.Forms.Panel WaterPanel;
        private ePOSOne.btnProduct.RoundButton ReleaseButton;
        private System.Windows.Forms.PictureBox WaterpictureBox;
    }
}
