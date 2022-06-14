namespace WorldsHardestGame
{
    partial class MenuScreen
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
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.howToPlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playButton.Location = new System.Drawing.Point(281, 211);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(203, 71);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(281, 400);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(203, 71);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Image = global::WorldsHardestGame.Properties.Resources.luffy_face;
            this.label1.Location = new System.Drawing.Point(192, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 100);
            this.label1.TabIndex = 2;
            this.label1.Text = "Worlds Hardest Game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // howToPlayButton
            // 
            this.howToPlayButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.howToPlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlayButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.howToPlayButton.Location = new System.Drawing.Point(281, 303);
            this.howToPlayButton.Name = "howToPlayButton";
            this.howToPlayButton.Size = new System.Drawing.Size(203, 71);
            this.howToPlayButton.TabIndex = 3;
            this.howToPlayButton.Text = "How To Play";
            this.howToPlayButton.UseVisualStyleBackColor = false;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = global::WorldsHardestGame.Properties.Resources.pimpin_one_piece;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.howToPlayButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.PeachPuff;
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button howToPlayButton;
    }
}
