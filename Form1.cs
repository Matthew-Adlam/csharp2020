﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;
using System.Text;
using System.Threading;
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

        bool gameInProgress = false;
        bool fighterMode = false;
        bool offensive = false;
        bool defensive = false;
        bool control = false;
        bool sneaky = false;
        bool easy = true;
        bool medium = false;
        bool hard = false;
        bool player1Turn;
        bool player2Turn;
        string name;

        int playerAttack;
        int playerDefense;
        int playerAccuracy;
        int playerHitpoints;
        int enemyAttack;
        int enemyDefense;
        int enemyAccuracy;
        int enemyHitpoints;

        Random playerAcc = new Random();
        Random bigAttack = new Random();
        Random enemyMoveRand = new Random();

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                int x = 10 + (i * 60);
                planet[i] = new Planet(x);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDifficulty.Visible = false;
            startButton.Visible = false;
            easyFButton.Visible = false;
            mediumFButton.Visible = false;
            hardFButton.Visible = false;
            easyFButton.Enabled = false;
            mediumFButton.Enabled = false;
            hardFButton.Enabled = false;
            LblFightAiHp.Visible = false;
            LblFightUserHp.Visible = false;
            UserHp.Visible = false;
            EnemyHp.Visible = false;
            offBtn.Visible = false;
            defButton.Visible = false;
            controlBtn.Visible = false;
            sneakyBtn.Visible = false;
            conBtn.Visible = false;
            classLbl.Visible = false;
            planetAi.Visible = false;
            alien.Visible = false;
            userhealthLbl.Visible = false;
            userHpLbl.Visible = false;
            enemyhealthLbl.Visible = false;
            enemyHpLbl.Visible = false;
            move1.Visible = false;
            move2.Visible = false;
            move3.Visible = false;
            move4.Visible = false;
            move5.Visible = false;
            moveInfo.Visible = false;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        public void stopGame()
        {
            startButton.Enabled = true;
        }


        private void startButton_Click(object sender, EventArgs e)
        { 
        }


        private void instructButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In normal mode, you control a spaceship attempting to dodge planets, or use the missile to shoot them. If you are hit by one of the planets, you lose a life. Try not to lose all of your lives!");
            MessageBox.Show("Use the arrow keys to control the spaceship, and use the escape key to pause.");
            MessageBox.Show("If you select fighter mode, you engage in a 1v1 versus the AI in a duel! Click the buttons to perform moves to kill the planet before it kills you!");
            MessageBox.Show("Click the settings button to change difficulty, or game mode. Click Start to begin the game, or enter a code at the code redeemer.");
            MessageBox.Show("Use code Geo or geo for +5 score! (Normal only)");
        }

  

        private void easyFButton_Click(object sender, EventArgs e)
        {
            fighterMode = true;
            easy = true;
            MessageBox.Show("Selected Easy.");
            startButton.Visible = false;
            instructButton.Visible = false;
            TxtName.Visible = false;
            lblName.Visible = false;
            settingsButton.Visible = false;

            lblDifficulty.Visible = false;
            easyFButton.Visible = false;
            mediumFButton.Visible = false;
            hardFButton.Visible = false;

            controlBtn.Visible = true;
            offBtn.Visible = true;
            defButton.Visible = true;
            sneakyBtn.Visible = true;
            classLbl.Visible = true;

        }

        private void normalFButton_Click(object sender, EventArgs e)
        {

        }

        private void hardFButton_Click(object sender, EventArgs e)
        {

        }

        private void settingsButton_Click(object sender, EventArgs e)
        { 
            startButton.Visible = false;
            instructButton.Visible = false;
            TxtName.Visible = false;
            lblName.Visible = false;
            settingsButton.Visible = false;
            instructLbl.Visible = false;
            bossyLbl.Visible = false;

            lblDifficulty.Visible = true;
            easyFButton.Visible = true;
            mediumFButton.Visible = true;
            hardFButton.Visible = true;
            easyFButton.Enabled = true;
            mediumFButton.Enabled = true;
            hardFButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
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

        private void offBtn_Click(object sender, EventArgs e)
        {
            offensive = true;
            defensive = false;
            sneaky = false;
            control = false;
            MessageBox.Show("Offensive Class. Very attack focused.");
            conBtn.Visible = true;
        }

        private void conBtn_Click(object sender, EventArgs e)
        {
            if (offensive == true)
            {
                MessageBox.Show("Selected Offensive Class.");
                playerAttack = 9;
                playerDefense = 4;
                playerHitpoints = 50;
                enemyHitpoints = 50; // ^^^ and this subject to change due to difficulty
                startGame();
            }
        }
        void startGame()
        {
            userHpLbl.Text = playerHitpoints.ToString();
            enemyHpLbl.Text = enemyHitpoints.ToString();
            controlBtn.Visible = false;
            offBtn.Visible = false;
            sneakyBtn.Visible = false;
            defButton.Visible = false;
            conBtn.Visible = false;
            classLbl.Visible = false;

            alien.Visible = true;
            planetAi.Visible = true;
            userhealthLbl.Visible = true;
            userHpLbl.Visible = true;
            enemyhealthLbl.Visible = true;
            enemyHpLbl.Visible = true;
            move1.Visible = true;
            move2.Visible = true;
            move3.Visible = true;
            move4.Visible = true;
            move5.Visible = true;
            moveInfo.Visible = true;

            player1Turn = true;
        }

        private void move1_Click(object sender, EventArgs e)
        {
            if (player1Turn == true)
            {
                if (offensive == true)
                {
                    playerAccuracy = playerAcc.Next(1, 10);
                    if (playerAccuracy > 6)
                    {
                        missLbl.Text = "Player 1, You Missed!";
                        player1Turn = false;
                        enemyAttackTime();
                    }
                    if (playerAccuracy < 7)
                    {
                        playerAttack = bigAttack.Next(6, 8);
                        enemyHitpoints -= playerAttack;
                        missLbl.Text = "You hit the enemy for" + "" + playerAttack + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();
                    }
                }
            }
            
        }
        void enemyAttackTime()
        {
            move1.Enabled = false;
            move2.Enabled = false;
            move3.Enabled = false;
            move4.Enabled = false;
            move5.Enabled = false;

            Thread.Sleep(2000);

            enemyAccuracy = enemyMoveRand.Next(1, 10);

            if (enemyAccuracy > 8)
            {
                enemyMissLbl.Text = "The enemy missed!";
                player1Turn = true;
                playerAttackTime();
            }
            if (enemyAccuracy < 9)
            {
                enemyAttack = enemyMoveRand.Next(3, 8);
                playerHitpoints -= enemyAttack;
                enemyMissLbl.Text = "You were hit by the enemy for" + "" + enemyAttack + "" + "damage!";
                userHpLbl.Text = playerHitpoints.ToString();
                player1Turn = true;
                playerAttackTime();
            }
        }

        void playerAttackTime()
        {
            move1.Enabled = true;
            move2.Enabled = true;
            move3.Enabled = true;
            move4.Enabled = true;
            move5.Enabled = true;
        }

        private void move2_Click(object sender, EventArgs e)
        {
            if (player1Turn == true)
            {
                if (offensive == true)
                {
                    playerAccuracy = playerAcc.Next(1, 10);
                    if (playerAccuracy > 8)
                    {
                        missLbl.Text = "Player 1, You Missed!";
                        enemyAttackTime();
                    }
                    if (playerAccuracy < 9)
                    {
                        playerAttack = bigAttack.Next(4, 7);
                        enemyHitpoints -= playerAttack;
                        missLbl.Text = "You hit the enemy for" + "" + playerAttack + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        enemyAttackTime();
                    }
                }
            }
        }
    }

}

//pastebin
//            codeRedeemer.Enabled = false;
//TxtName.Enabled = false;
 //           instructButton.Enabled = false;
 //           settingsButton.Enabled = false;
