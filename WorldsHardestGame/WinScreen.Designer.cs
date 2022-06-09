namespace WorldsHardestGame
{
    partial class WinScreen
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
            this.winLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.winLabel.Location = new System.Drawing.Point(304, 88);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(160, 42);
            this.winLabel.TabIndex = 0;
            this.winLabel.Text = "You Win!";
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NextButton.Location = new System.Drawing.Point(278, 375);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(203, 71);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Continue";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorldsHardestGame.Properties.Resources.poggers;
            this.pictureBox1.InitialImage = global::WorldsHardestGame.Properties.Resources.poggers;
            this.pictureBox1.Location = new System.Drawing.Point(266, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.winLabel);
            this.Name = "WinScreen";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
