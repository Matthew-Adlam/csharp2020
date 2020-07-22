using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp2020
{
    public partial class Form1 : Form
    {

        Graphics g; //declare a graphics object called g
        Planet[] planet = new Planet[10];
        Random yspeed = new Random();
        Spaceship spaceship = new Spaceship();

        List<Missile> missiles = new List<Missile>();

        bool left;
        bool right;
        bool up;
        bool down;
        bool gameInProgress = false;
        bool fighterMode = false;
        string move;
        string name;
        int speedMin = 5;
        int speedMax = 20;
        int lives;
        int score;
        int difficulty = 3;
        int highScore = 0;
        int scoreSetBack = 0;
        int scoreBoost = 0;

        public Form1()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });

            for (int i = 0; i < 10; i++)
            {
                int x = 10 + (i * 60);
                planet[i] = new Planet(x);
            }
       


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lives = int.Parse(lblLives.Text);
            TmrPlanet.Enabled = false;
            TmrShip.Enabled = false;
            lblDifficulty.Visible = false;
            easyFButton.Visible = false;
            mediumFButton.Visible = false;
            hardFButton.Visible = false;
            easyNButton.Visible = false;
            mediumNButton.Visible = false;
            hardNButton.Visible = false;
            easyFButton.Enabled = false;
            mediumFButton.Enabled = false;
            hardFButton.Enabled = false;
            easyNButton.Enabled = false;
            mediumNButton.Enabled = false;
            hardNButton.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 10; i++)
            {
                int rndmspeed = yspeed.Next(speedMin, speedMax);
                planet[i].y += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                planet[i].DrawPlanet(g);
            }
            spaceship.DrawSpaceship(g);

        }

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                planet[i].MovePlanet();
                if (spaceship.spaceRec.IntersectsWith(planet[i].planetRec))
                {
                    //reset planet[i] back to top of panel
                    planet[i].y = 30; // set  y value of planetRec
                    lives -= 1;// lose a life
                    lblLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }

                if (planet[i].y >= PnlGame.Height)
                {
                    score += 1;//update the score
                    checkScore();
                    lblScore.Text = score.ToString();// display score
                    planet[i].y = 30;
                }


            }
            PnlGame.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }
            if (e.KeyData == Keys.Escape)
            {
                stopGame();
                MessageBox.Show("Game Paused.");
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }

        }

        public void stopGame()
        {
            TmrPlanet.Enabled = false;
            TmrShip.Enabled = false;
            startButton.Enabled = true;
        }

        public void checkScore()
        {
            if (score == 20 || score > 20 && score < 50) // if the score is greater than or equal to 20 but MUST be less than 50
            {
                speedMin = 10;
                speedMax = 35;
            }
            if (score == 50 || score > 50 && score < 100) // if the score is greater than or equal to 50 but MUST be less than 100
            {
                speedMin = 25;
                speedMax = 50;
            }
            if (score == 100 || score > 100 && score < 250) //if the score is greater than or equal to 100 but must be less than 250
            {
                speedMin = 40;
                speedMax = 75;
            }
            if (score == 250 || score > 250 && score < 500) //if the score is greater than or equal to 250 but must be less than 500
            {
                speedMin = 50;
                speedMax = 100;
            }
            if (score == 500 || score > 500) // gotta go fast
            {
                speedMin = 100;
                speedMax = 200;
            }

        }

        private void TmrShip_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                spaceship.MoveSpaceship(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                spaceship.MoveSpaceship(move);
            }
            if (up) // if right arrow key pressed
            {
                move = "up";
                spaceship.MoveSpaceship(move);
            }
            if (down) // if left arrow key pressed
            {
                move = "down";
                spaceship.MoveSpaceship(move);
            }

        }
        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrPlanet.Enabled = false;
                TmrShip.Enabled = false;
                MessageBox.Show("Game Over, you got a score of" + "" + score + "" + "!");

                if(score > highScore)
                {
                    MessageBox.Show("Congratulations, you got a new high score of " + "" + score + "" + "!");
                    highScore = score;
                    lblHighScore.Text = highScore.ToString();
                }

                score = 0;
                codeRedeemer.Text = "";
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        void StartGame()
        {
            if (fighterMode == false)
            {
                TmrPlanet.Enabled = true;
                TmrShip.Enabled = true;
                lives = difficulty;
                lblLives.Text = lives.ToString();// display number of lives
                score = 0 + scoreBoost - scoreSetBack;
                lblScore.Text = score.ToString();
                gameInProgress = true;
                startButton.Enabled = false;
                codeRedeemer.Enabled = false;
                TxtName.Enabled = false;
                settingsButton.Enabled = false;
                instructButton.Enabled = false;
            }
            if (fighterMode == true)
            {
                // add stuff here
            }

        }

        private void instructButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In normal mode, you control a spaceship attempting to dodge planets, or use the missile to shoot them. If you are hit by one of the planets, you lose a life.");
            MessageBox.Show("Use the arrow keys to control the spaceship, and use the escape key to pause.");
            MessageBox.Show("If you select fighter mode, you engage in a 1v1 versus the AI in a duel! Click the buttons to perform moves to kill the planet before it kills you!");
            MessageBox.Show("Try not to lose all of your lives! Click the settings button to change difficulty, or game mode. Click Start to begin the game, or enter a code at the code redeemer.");
            MessageBox.Show("Use code Geo or geo for +5 score!");
        }

        private void easyNButton_Click(object sender, EventArgs e)
        {
            difficulty = 3;
            PnlGame.Visible = true;
            startButton.Visible = true;
            instructButton.Visible = true;
            txtLives.Visible = true;
            txtScore.Visible = true;
            TxtName.Visible = true;
            lblLives.Visible = true;
            lblName.Visible = true;
            lblScore.Visible = true;
            settingsButton.Visible = true;

            lblDifficulty.Visible = false;
            easyFButton.Visible = false;
            mediumFButton.Visible = false;
            hardFButton.Visible = false;
            easyNButton.Visible = false;
            mediumNButton.Visible = false;
            hardNButton.Visible = false;
        }

        private void mediumNButton_Click(object sender, EventArgs e)
        {
            difficulty = 2;
            PnlGame.Visible = true;
            startButton.Visible = true;
            instructButton.Visible = true;
            txtLives.Visible = true;
            txtScore.Visible = true;
            TxtName.Visible = true;
            lblLives.Visible = true;
            lblName.Visible = true;
            lblScore.Visible = true;
            settingsButton.Visible = true;

            lblDifficulty.Visible = false;
            easyFButton.Visible = false;
            mediumFButton.Visible = false;
            hardFButton.Visible = false;
            easyNButton.Visible = false;
            mediumNButton.Visible = false;
            hardNButton.Visible = false;
        }

        private void hardNButton_Click(object sender, EventArgs e)
        {
            difficulty = 1;
            PnlGame.Visible = true;
            startButton.Visible = true;
            instructButton.Visible = true;
            txtLives.Visible = true;
            txtScore.Visible = true;
            TxtName.Visible = true;
            lblLives.Visible = true;
            lblName.Visible = true;
            lblScore.Visible = true;
            settingsButton.Visible = true;

            lblDifficulty.Visible = false;
            easyFButton.Visible = false;
            mediumFButton.Visible = false;
            hardFButton.Visible = false;
            easyNButton.Visible = false;
            mediumNButton.Visible = false;
            hardNButton.Visible = false;
        }

        private void easyFButton_Click(object sender, EventArgs e)
        {

        }

        private void normalFButton_Click(object sender, EventArgs e)
        {

        }

        private void hardFButton_Click(object sender, EventArgs e)
        {

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            TmrPlanet.Enabled = false;
            TmrShip.Enabled = false;

            PnlGame.Visible = false;
            startButton.Visible = false;
            instructButton.Visible = false;
            txtLives.Visible = false;
            txtScore.Visible = false;
            TxtName.Visible = false;
            lblLives.Visible = false;
            lblName.Visible = false;
            lblScore.Visible = false;
            settingsButton.Visible = false;
            lblHighScore.Visible = false;
            highScoreLbl.Visible = false;
            codeRedeemer.Visible = false;
            lblCodeRedeem.Visible = false;

            lblDifficulty.Visible = true;
            easyFButton.Visible = true;
            mediumFButton.Visible = true;
            hardFButton.Visible = true;
            easyNButton.Visible = true;
            mediumNButton.Visible = true;
            hardNButton.Visible = true;

            easyFButton.Enabled = true;
            mediumFButton.Enabled = true;
            hardFButton.Enabled = true;
            easyNButton.Enabled = true;
            mediumNButton.Enabled = true;
            hardNButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            TmrPlanet.Enabled = false;
            TmrShip.Enabled = false;
            startButton.Enabled = true;
            startButton.Visible = true;
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            {

                string context = TxtName.Text;
                bool isletter = true;
                //for loop checks for letters as characters are entered
                for (int i = 0; i < context.Length; i++)
                {
                    if (!char.IsLetter(context[i]))// if current character not a letter
                    {
                        isletter = false;//make isletter false
                        break; // exit the for loop
                    }

                }

                // if not a letter clear the textbox and focus on it
                // to enter name again
                if (isletter == false)
                {
                    TxtName.Clear();
                    TxtName.Focus();
                    MessageBox.Show("Please enter a valid username - one with only letters");
                }
                else
                {
                    context = name;
                }

            }

        }

        private void codeRedeemer_TextChanged(object sender, EventArgs e)
        {
            if (codeRedeemer.Text == "Geo" || codeRedeemer.Text == "geo" )
            {
                scoreBoost = 5;
                MessageBox.Show("Give Credit to Ryan - +5 points");
            }
            if (codeRedeemer.Text == "Josh" || codeRedeemer.Text == "josh")
            {
                speedMin = 1;
                speedMax = 15;
                MessageBox.Show("Planets Slowed Down - coward");
            }
            if (codeRedeemer.Text == "jquery")
            {
                scoreSetBack = 999;
                MessageBox.Show("Just No.");
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           // spaceship.MoveSpaceship(e.X);
          //  this.Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                missiles.Add(new Missile(spaceship.spaceRec));
            }

        }

        private void tmrShoot_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
//pastebin
//            codeRedeemer.Enabled = false;
//TxtName.Enabled = false;
 //           instructButton.Enabled = false;
 //           settingsButton.Enabled = false;
