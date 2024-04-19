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
            this.ReleaseButton = new ePOSOne.btnProduct.RoundButton();
            this.ExitButton = new ePOSOne.btnProduct.RoundButton();
            this.WaterpictureBox = new System.Windows.Forms.PictureBox();
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
            this.NeedWater.Location = new System.Drawing.Point(250, 23);
            this.NeedWater.Name = "NeedWater";
            this.NeedWater.Size = new System.Drawing.Size(184, 31);
            this.NeedWater.TabIndex = 5;
            this.NeedWater.Text = "Need Water?";
            // 
            // WaterDescription
            // 
            this.WaterDescription.AutoSize = true;
            this.WaterDescription.BackColor = System.Drawing.Color.Transparent;
            this.WaterDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterDescription.ForeColor = System.Drawing.Color.Black;
            this.WaterDescription.Location = new System.Drawing.Point(54, 67);
            this.WaterDescription.Name = "WaterDescription";
            this.WaterDescription.Size = new System.Drawing.Size(582, 20);
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
            this.WaterPanel.Location = new System.Drawing.Point(63, 85);
            this.WaterPanel.Name = "WaterPanel";
            this.WaterPanel.Size = new System.Drawing.Size(698, 341);
            this.WaterPanel.TabIndex = 12;
            // 
            // ReleaseButton
            // 
            this.ReleaseButton.BorderColor = System.Drawing.Color.Transparent;
            this.ReleaseButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.ReleaseButton.FlatAppearance.BorderSize = 0;
            this.ReleaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReleaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseButton.Location = new System.Drawing.Point(245, 278);
            this.ReleaseButton.Name = "ReleaseButton";
            this.ReleaseButton.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.ReleaseButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.ReleaseButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ReleaseButton.Size = new System.Drawing.Size(208, 46);
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
            this.ExitButton.Location = new System.Drawing.Point(13, 21);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.ExitButton.OnHoverButtonColor = System.Drawing.Color.Gold;
            this.ExitButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ExitButton.Size = new System.Drawing.Size(106, 46);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextColor = System.Drawing.Color.Black;
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // WaterpictureBox
            // 
            this.WaterpictureBox.Image = global::ThesisBeta.Properties.Resources.Water;
            this.WaterpictureBox.Location = new System.Drawing.Point(243, 96);
            this.WaterpictureBox.Name = "WaterpictureBox";
            this.WaterpictureBox.Size = new System.Drawing.Size(210, 172);
            this.WaterpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WaterpictureBox.TabIndex = 13;
            this.WaterpictureBox.TabStop = false;
            // 
            // Water
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.Controls.Add(this.WaterPanel);
            this.Controls.Add(this.ExitButton);
            this.Name = "Water";
            this.Size = new System.Drawing.Size(800, 480);
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
