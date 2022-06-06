namespace WorldsHardestGame
{
    partial class HighscoreScreen
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
            this.HighScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.initialTextbox = new System.Windows.Forms.TextBox();
            this.namesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HighScoreLabel
            // 
            this.HighScoreLabel.AutoSize = true;
            this.HighScoreLabel.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HighScoreLabel.Location = new System.Drawing.Point(279, 65);
            this.HighScoreLabel.Name = "HighScoreLabel";
            this.HighScoreLabel.Size = new System.Drawing.Size(180, 45);
            this.HighScoreLabel.TabIndex = 1;
            this.HighScoreLabel.Text = "Highscore";
            this.HighScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(175, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert Initials Here:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // initialTextbox
            // 
            this.initialTextbox.Location = new System.Drawing.Point(423, 154);
            this.initialTextbox.Name = "initialTextbox";
            this.initialTextbox.Size = new System.Drawing.Size(137, 20);
            this.initialTextbox.TabIndex = 3;
            // 
            // namesLabel
            // 
            this.namesLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.namesLabel.Location = new System.Drawing.Point(177, 219);
            this.namesLabel.Name = "namesLabel";
            this.namesLabel.Size = new System.Drawing.Size(100, 328);
            this.namesLabel.TabIndex = 4;
            this.namesLabel.Text = "Names";
            this.namesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(460, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 328);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HighscoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namesLabel);
            this.Controls.Add(this.initialTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HighScoreLabel);
            this.Name = "HighscoreScreen";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HighScoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox initialTextbox;
        private System.Windows.Forms.Label namesLabel;
        private System.Windows.Forms.Label label2;
    }
}
