using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace WorldsHardestGame
{
    public partial class GameScreen : UserControl
    {
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;
        Size screenSize;
        Player player;
        int ballSpeed = 10;
        int ballX = 390;
        int ballY = 290;
        int ballSize = 20;
        int ball2Y = 340;
        int ball3Y = 390;
        int ball4Y = 240;
        int ball5Y = 190;
        Stopwatch sw = Stopwatch.StartNew();


        public GameScreen()
        {
            InitializeComponent();
            InitializeGame();
        }

        public void InitializeGame()
        {
            screenSize = new Size(this.Width, this.Height);

            int x = 140;
            int y = 400;

            player = new Player(x, y);

          
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
          

            Rectangle playerRec = new Rectangle(player.x, player.y, player.width, player.height);

            Rectangle Topwall = new Rectangle(0, 0, 800, 120);
            Rectangle Bottomwall = new Rectangle(0, 480, 800, 120);
            Rectangle Leftwall = new Rectangle(0, 120, 100, 360);
            Rectangle Rightwall = new Rectangle(700, 120, 100, 360);
            Rectangle homebaseWall = new Rectangle(200, 180, 20, 300);
            Rectangle endWall = new Rectangle(580, 120, 20, 300);
            Rectangle winningRec = new Rectangle(640, 190, 20, 20);

            Rectangle ballRec = new Rectangle(ballX, ballY, ballSize, ballSize);

            timeLabel.Text = sw.Elapsed.ToString();

            if (leftArrowDown == true)
            {
                player.Move("left", screenSize);
            }

            if (rightArrowDown == true)
            {
                player.Move("right", screenSize);
            }

            if (upArrowDown == true)
            {
                player.Move("up", screenSize);
                
            }

            if (downArrowDown == true)
            {
                player.Move("down", screenSize);
                
            }

            ballX += ballSpeed;

            if (ballX > 550)
            {
                ballSpeed *= -1;
            }

            if (ballX < 230)
            {
                ballSpeed *= -1;
            }

            if (ballRec.IntersectsWith(playerRec))
            {
                gameTimer.Stop();
                Form1.ChangeScreen(this, new GameoverScreen());
                sw.Stop();
            }

            if (playerRec.IntersectsWith(Topwall))
            {
                upArrowDown = false;
            }
            if (playerRec.IntersectsWith(winningRec))
            {
                gameTimer.Stop();
                Form1.ChangeScreen(this, new WinScreen());
                //burh//
            }

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DodgerBlue, player.x, player.y, player.width, player.height);
           
            e.Graphics.FillRectangle(Brushes.MediumPurple, 0, 0, 800, 120);
            e.Graphics.FillRectangle(Brushes.MediumPurple, 0, 480, 800, 120);
            e.Graphics.FillRectangle(Brushes.MediumPurple, 0, 120, 100, 360);
            e.Graphics.FillRectangle(Brushes.MediumPurple, 700, 120, 100, 360);
            e.Graphics.FillRectangle(Brushes.MediumPurple, 200, 180, 20, 300);
            e.Graphics.FillRectangle(Brushes.MediumPurple, 580, 120, 20, 300);

            e.Graphics.FillEllipse(Brushes.Red, ballX, ballY, ballSize, ballSize);
            e.Graphics.FillEllipse(Brushes.Red, ballX, ball2Y, ballSize, ballSize);
            e.Graphics.FillEllipse(Brushes.Red, ballX, ball3Y, ballSize, ballSize);
            e.Graphics.FillEllipse(Brushes.Red, ballX, ball4Y, ballSize, ballSize);
            e.Graphics.FillEllipse(Brushes.Red, ballX, ball5Y, ballSize, ballSize);
            e.Graphics.FillRectangle(Brushes.Green, 640, 190, 20, 20);
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
