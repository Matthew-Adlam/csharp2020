using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp2020
{
    public partial class Form1 : Form
    {

        Graphics g; //declare a graphics object called g
        Planet[] planet = new Planet[8];
        Random yspeed = new Random();
        Spaceship spaceship = new Spaceship();

        bool left;
        bool right;
        bool gameInProgress = false;
        string move;
        int lives;
        int score;
        int difficulty = 3;

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 8; i++)
            {
                int x = 10 + (i * 75);
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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 8; i++)
            {
                int rndmspeed = yspeed.Next(5, 20);
                planet[i].y += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                planet[i].DrawPlanet(g);
            }
            spaceship.DrawSpaceship(g);

        }

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
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

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }

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

        }
        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrPlanet.Enabled = false;
                TmrShip.Enabled = false;
                MessageBox.Show("Game Over");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (gameInProgress == false)
            {
                TmrPlanet.Enabled = true;
                TmrShip.Enabled = true;
                startButton.Text = "Pause";
                lives = difficulty;
                score = 0;
                gameInProgress = true;
            }
            else if (gameInProgress == true)
            {
                TmrPlanet.Enabled = false;
                TmrShip.Enabled = false;
                startButton.Text = "Start";
                gameInProgress = false;
            }
        }

        private void instructButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("actually put something");
        }

        private void easyNButton_Click(object sender, EventArgs e)
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
            
        }

        private void hardNButton_Click(object sender, EventArgs e)
        {

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

            lblDifficulty.Visible = true;
            easyFButton.Visible = true;
            mediumFButton.Visible = true;
            hardFButton.Visible = true;
            easyNButton.Visible = true;
            mediumNButton.Visible = true;
            hardNButton.Visible = true;
        }
    }
}
