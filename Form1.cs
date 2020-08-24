using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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

        public bool gameInProgress = false;
        public bool fighterMode = false;
        public bool offensive = false;
        public bool defensive = false;
        public bool control = false;
        public bool sneaky = false;
        public bool easy = true;
        public bool medium = false;
        public bool hard = false;
        public bool player1Turn;
        public bool player2Turn;
        public bool classSelectionMenu = false;
        public bool difficultySelectionMenu = false;

        string move;
        string name;

        bool left;
        bool right;
        bool up;
        bool down;

        public int playerAttack;
        public int playerDefense = 0;
        public int playerAccuracy;
        public int accuracyBuff = 0;
        public int playerHitpoints;
        public int playerHeal;
        public int enemyAttack;
        public int enemyDefense;
        public int enemyAccuracy;
        public int enemyHeal;
        public int enemyHitpoints;
        public int strengthBuff = 0;
        public int strengthBuffCount = 2;
        public int defenseBuffCount = 2;
        public int accuracyBuffCount = 2;
        public int wound = 3;

        int lives;
        int score;

        public Random playerAcc = new Random();
        public Random bigAttack = new Random();
        public Random enemyMoveRand = new Random();

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
            enemyMissLbl.Visible = false;
            missLbl.Visible = false;
            instructLbl.Visible = false;
            waitLbl.Visible = false;
            backBtn.Visible = false;
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
            MessageBox.Show("In this game, you engage in a 1v1 versus the AI in a duel! Click the buttons to perform moves to kill the planet before it kills you! (Health down to 0)");
            MessageBox.Show("When you click Start, select a class and jump in! Click the moves to perform them on the planet, or click the Move Info button if you are not sure.");
            MessageBox.Show("If you want to earn a reward boost for Easy difficulty, play the bonus game - dodge the planets until you get to 100 points!");
        }



        private void easyFButton_Click(object sender, EventArgs e)
        {
            fighterMode = true;
            easy = true;
            medium = false;
            hard = false;
            enemyHitpoints = 50;
            MessageBox.Show("Selected Easy.");
            startButton.Visible = false;
            instructButton.Visible = false;
            TxtName.Visible = false;
            lblName.Visible = false;
            settingsButton.Visible = false;
            instructLbl.Visible = false;

            lblDifficulty.Visible = false;
            easyFButton.Visible = false;
            mediumFButton.Visible = false;
            hardFButton.Visible = false;

            controlBtn.Visible = true;
            offBtn.Visible = true;
            defButton.Visible = true;
            sneakyBtn.Visible = true;
            classLbl.Visible = true;
            classSelectionMenu = true;
            difficultySelectionMenu = false;
        }

        private void normalFButton_Click(object sender, EventArgs e)
        {
            fighterMode = true;
            easy = false;
            medium = true;
            hard = false;
            MessageBox.Show("Selected Medium.");
            startButton.Visible = false;
            instructButton.Visible = false;
            TxtName.Visible = false;
            lblName.Visible = false;
            settingsButton.Visible = false;
            instructLbl.Visible = false;

            lblDifficulty.Visible = false;
            easyFButton.Visible = false;
            mediumFButton.Visible = false;
            hardFButton.Visible = false;

            controlBtn.Visible = true;
            offBtn.Visible = true;
            defButton.Visible = true;
            sneakyBtn.Visible = true;
            classLbl.Visible = true;
            classSelectionMenu = true;
            difficultySelectionMenu = false;
        }

        private void hardFButton_Click(object sender, EventArgs e)
        {
            fighterMode = true;
            easy = false;
            medium = false;
            hard = true;
            MessageBox.Show("Selected Hard.");
            startButton.Visible = false;
            instructButton.Visible = false;
            TxtName.Visible = false;
            lblName.Visible = false;
            settingsButton.Visible = false;
            instructLbl.Visible = false;

            lblDifficulty.Visible = false;
            easyFButton.Visible = false;
            mediumFButton.Visible = false;
            hardFButton.Visible = false;

            controlBtn.Visible = true;
            offBtn.Visible = true;
            defButton.Visible = true;
            sneakyBtn.Visible = true;
            classLbl.Visible = true;
            classSelectionMenu = true;
            difficultySelectionMenu = false;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            instructButton.Visible = false;
            instructLbl.Visible = true;
            TxtName.Visible = false;
            lblName.Visible = false;
            settingsButton.Visible = false;
            instructLbl.Visible = false;
            bossyLbl.Visible = false;
            quitGame.Visible = false;

            lblDifficulty.Visible = true;
            easyFButton.Visible = true;
            mediumFButton.Visible = true;
            hardFButton.Visible = true;
            easyFButton.Enabled = true;
            mediumFButton.Enabled = true;
            hardFButton.Enabled = true;
            difficultySelectionMenu = true;
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
                playerHitpoints = 50;
                enemyHitpoints = 50; // ^^^ and this subject to change due to difficulty
                startGame();
            }
            if (defensive == true)
            {
                MessageBox.Show("Selected Defensive Class.");
                playerHitpoints = 75;
                enemyHitpoints = 50; // ^^^ and this subject to change due to difficulty
                move1.Text = "Average Attack";
                move2.Text = "Heal";
                move3.Text = "Defensive Boost (Max 2)";
                move4.Text = "Swipe";
                move5.Text = "Run Away!";
                startGame();              
            }
            if (sneaky == true)
            {
                MessageBox.Show("Selected Sneaky Class.");
                playerHitpoints = 30;
                enemyHitpoints = 50; // ^^^ and this subject to change due to difficulty
                move1.Text = "Pounce";
                move2.Text = "Sharpen (Max 2)";
                move3.Text = "Accuracy Boost (Max 2)";
                move4.Text = "Weak Heal";
                move5.Text = "Run Away!";
                startGame();
            }
            if (control == true)
            {
                MessageBox.Show("Selected Sneaky Class.");
                playerHitpoints = 60;
                enemyHitpoints = 50; // ^^^ and this subject to change due to difficulty
                move1.Text = "Decent Attack";
                move2.Text = "Defensive Boost (Max 2)";
                move3.Text = "Accuracy Boost (Max 2)";
                move4.Text = "Strength Boost (Max 2)";
                move5.Text = "Run Away!";
                startGame();
            }

        }
        void startGame()
        {
            if (easy == true)
            {
                enemyHitpoints = 50;
            }
            if (medium == true)
            {
                enemyHitpoints = 65;
            }
            if (hard == true)
            {
                enemyHitpoints = 80;
            }
            move5.Text = "Run Away!";
            strengthBuff = 0;
            playerDefense = 0;
            strengthBuffCount = 2;
            accuracyBuffCount = 2;
            defenseBuffCount = 2;
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
            missLbl.Visible = true;
            enemyMissLbl.Visible = true;

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
                        deathCheck();
                    }
                    if (playerAccuracy < 7)
                    {
                        playerAttack = bigAttack.Next(6, 8);
                        enemyHitpoints -= playerAttack + strengthBuff;
                        missLbl.Text = "You hit the enemy for" + "" + (playerAttack + strengthBuff) + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();
                        deathCheck();
                    }
                }
                if (defensive == true)
                {
                    playerAccuracy = playerAcc.Next(1, 10);
                    if (playerAccuracy > 8)
                    {
                        missLbl.Text = "Player 1, You Missed!";
                        player1Turn = false;
                        enemyAttackTime();
                        deathCheck();
                    }
                    if (playerAccuracy < 9)
                    {
                        playerAttack = bigAttack.Next(2, 5);
                        enemyHitpoints -= playerAttack ;
                        missLbl.Text = "You hit the enemy for" + "" + playerAttack  + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();
                        deathCheck();
                    }
                }
                if (sneaky == true)
                {
                    playerAccuracy = playerAcc.Next(1, 10);
                    if (playerAccuracy < 11)
                    {
                        playerAccuracy += accuracyBuff;
                    }
                    if (playerAccuracy > 8)
                    {
                        missLbl.Text = "Player 1, You Missed!";
                        player1Turn = false;
                        enemyAttackTime();
                        deathCheck();
                    }
                    if (playerAccuracy < 9)
                    {
                        playerAttack = 7;
                        enemyHitpoints -= playerAttack;
                        missLbl.Text = "You hit the enemy for" + "" + playerAttack + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();
                        deathCheck();
                    }
                }
                if (control == true)
                {
                    playerAccuracy = playerAcc.Next(1, 10);
                    if (playerAccuracy > 8)
                    {
                        missLbl.Text = "Player 1, You Missed!";
                        player1Turn = false;
                        enemyAttackTime();
                        deathCheck();
                    }
                    if (playerAccuracy < 9)
                    {
                        playerAttack = bigAttack.Next(2, 5);
                        enemyHitpoints -= playerAttack + strengthBuff;
                        missLbl.Text = "You hit the enemy for" + "" + (playerAttack + strengthBuff) + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();
                        deathCheck();
                    }
                }
            }

        }
  

        void playerAttackTime()
        {
            waitLbl.Visible = false;
            player1Turn = true;
            move1.Enabled = true;
            move2.Enabled = true;
            move3.Enabled = true;
            move4.Enabled = true;
            move5.Enabled = true;
        }

        private void move2_Click(object sender, EventArgs e)
        {
        }

        private void quitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void move2_Click_1(object sender, EventArgs e)
        {
            if (player1Turn == true)
            {
                if (offensive == true)
                {
                    playerAccuracy = playerAcc.Next(1, 10);
                    if (playerAccuracy > 8)
                    {
                        missLbl.Text = "Player 1, You Missed!";
                        player1Turn = false;
                        enemyAttackTime();
                        deathCheck();
                    }
                    if (playerAccuracy < 9)
                    {
                        playerAttack = bigAttack.Next(3, 7);
                        enemyHitpoints -= playerAttack + strengthBuff;
                        missLbl.Text = "You hit the enemy for" + "" + (playerAttack + strengthBuff) + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();
                        deathCheck();
                    }
                }
                if (defensive == true && playerHitpoints < 76)
                {
                    playerHeal = playerAcc.Next(3, 5);
                    playerHitpoints += playerHeal;
                    missLbl.Text = "You healed for" + "" + playerHeal + "" + "damage!";
                    userHpLbl.Text = playerHitpoints.ToString();
                    player1Turn = false;
                    enemyAttackTime();
                    deathCheck();
                }
                if (sneaky == true && strengthBuffCount >= 1)
                {
                    strengthBuff += 1;
                    missLbl.Text = "Buffed Player 1's Strength!";
                    player1Turn = false;
                    strengthBuffCount -= 1;
                    move3.Text = "Strength Buff" + "" + strengthBuffCount + "" + "left!";
                    enemyAttackTime();
                    deathCheck();
                }
                if (control == true && defenseBuffCount >= 1)
                {
                    playerDefense += 1;
                    missLbl.Text = "Buffed Player 1's Defense!";
                    player1Turn = false;
                    defenseBuffCount -= 1;
                    move3.Text = "Defense Buff" + "" + defenseBuffCount + "" + "left!";
                    enemyAttackTime();
                    deathCheck();
                }
            }
        }

        private void move3_Click(object sender, EventArgs e)
        {
            if (player1Turn == true)
            {
                if (offensive == true && strengthBuffCount >= 1)
                {
                    strengthBuff += 1;
                    missLbl.Text = "Buffed Player 1's Strength!";
                    player1Turn = false;
                    strengthBuffCount -= 1;
                    move3.Text = "Strength Buff" + "" + strengthBuffCount + "" + "left!";
                    enemyAttackTime();
                    deathCheck();
                }
                if (defensive == true && defenseBuffCount >= 1)
                {
                    playerDefense += 1;
                    missLbl.Text = "Buffed Player 1's Defense!";
                    player1Turn = false;
                    defenseBuffCount -= 1;
                    move3.Text = "Defense Buff" + "" + defenseBuffCount + "" + "left!";
                    enemyAttackTime();
                    deathCheck();
                }
                if (sneaky == true && accuracyBuffCount >= 1)
                {
                    accuracyBuff += 1;
                    missLbl.Text = "Buffed Player 1's Accuracy!";
                    player1Turn = false;
                    accuracyBuffCount -= 1;
                    move3.Text = "Accuracy Buff" + "" + accuracyBuffCount + "" + "left!";
                    enemyAttackTime();
                    deathCheck();
                }
                if (control == true && accuracyBuffCount >= 1)
                {
                    strengthBuff += 1;
                    missLbl.Text = "Buffed Player 1's Accuracy!";
                    player1Turn = false;
                    strengthBuffCount -= 1;
                    move3.Text = "Accuracy Buff" + "" + accuracyBuffCount + "" + "left!";
                    enemyAttackTime();
                    deathCheck();
                }
            }
        }

        private void move4_Click(object sender, EventArgs e)
        {
            if (player1Turn == true)
            {
                if (offensive == true)
                {
                    playerAccuracy = playerAcc.Next(1, 10);
                    if (playerAccuracy > 3)
                    {
                        missLbl.Text = "Player 1, You Missed!";
                        player1Turn = false;
                        enemyAttackTime();
                        deathCheck();
                    }
                    if (playerAccuracy < 4)
                    {
                        playerAttack = bigAttack.Next(8, 13);
                        enemyHitpoints -= playerAttack + strengthBuff;
                        missLbl.Text = "You hit the enemy for" + "" + (playerAttack + strengthBuff) + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();
                        deathCheck();
                    }
                }
                if (defensive == true)
                {
                    playerAccuracy = playerAcc.Next(1, 10);
                    if (playerAccuracy > 7)
                    {
                        missLbl.Text = "Player 1, You Missed!";
                        player1Turn = false;
                        enemyAttackTime();
                        deathCheck();
                    }
                    if (playerAccuracy < 8)
                    {
                        playerAttack = bigAttack.Next(6, 8);
                        enemyHitpoints -= playerAttack + strengthBuff;
                        missLbl.Text = "You hit the enemy for" + "" + (playerAttack + strengthBuff) + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();
                        deathCheck();
                    }
                }
                if (sneaky == true && playerHitpoints < 31)
                {
                    playerHeal = playerAcc.Next(2, 3);
                    playerHitpoints += playerHeal;
                    missLbl.Text = "You healed for" + "" + playerHeal + "" + "damage!";
                    userHpLbl.Text = playerHitpoints.ToString();
                    player1Turn = false;
                    enemyAttackTime();
                    deathCheck();
                }
                if (control == true && strengthBuffCount >= 1)
                {
                    strengthBuff += 1;
                    missLbl.Text = "Buffed Player 1's Strength!";
                    player1Turn = false;
                    strengthBuffCount -= 1;
                    move3.Text = "Strength Buff" + "" + strengthBuffCount + "" + "left!";
                    enemyAttackTime();
                    deathCheck();
                }
            }
        }

        private void move5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You ran from the planet!");
            resetGame();
        }

        private void defButton_Click(object sender, EventArgs e)
        {
            offensive = false;
            defensive = true;
            sneaky = false;
            control = false;
            MessageBox.Show("Defensive Class. Very survival focused.");
            conBtn.Visible = true;
        }
        public void deathCheck()
        {
            if (enemyHitpoints == 0 || enemyHitpoints < 0)
            {
                player1Turn = false;
                move1.Enabled = false;
                move2.Enabled = false;
                move3.Enabled = false;
                move4.Enabled = false;
                move5.Enabled = false;
                MessageBox.Show("Congratulations! You killed the planet! Try a harder difficulty!");
                resetGame();
            }
            if (playerHitpoints == 0 || playerHitpoints < 0)
            {
                player1Turn = false;
                move1.Enabled = false;
                move2.Enabled = false;
                move3.Enabled = false;
                move4.Enabled = false;
                move5.Enabled = false;
                MessageBox.Show("You Died! Better luck next time!");
                resetGame();
            }
        }
        public void resetGame()
        {
            lblDifficulty.Visible = true;
            easyFButton.Visible = true;
            mediumFButton.Visible = true;
            hardFButton.Visible = true;
            easyFButton.Enabled = true;
            mediumFButton.Enabled = true;
            hardFButton.Enabled = true;

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
            enemyMissLbl.Visible = false;
            missLbl.Visible = false;
        }

        private void moveInfo_Click(object sender, EventArgs e)
        {
            if(offensive == true)
            {
                MessageBox.Show("Big Attack - big damage and decent accuracy, Decent Attack - decent damage and high accuracy, Strength Buff - makes you deal more damage, HUGE attack - massive damage but low accuracy");
            }
            if(defensive == true)
            {
                MessageBox.Show("Average Attack - average damage and high accuracy, Heal - heals for a decent amount, Defense Buff - buffs defense(max 2), Swipe - does decent damage with moderate accuracy");
            }
            if (control == true)
            {
                MessageBox.Show("Decent Attack - decent damage and high accuracy, Defense Buff - buffs defense (max 2), Accuracy Buff - buffs accuracy (max 2), Strength Buff - buffs strength (max 2).");
            }
            if(sneaky == true)
            {
                MessageBox.Show("Pounce - high damage and decent accuracy, Accuracy Buff - buffs accuracy (max 2), Strength Buff - buffs strength (max 2), Weak Heal - heals for a little bit.");
            }
        }

        private void sneakyBtn_Click(object sender, EventArgs e)
        {
            offensive = false;
            defensive = false;
            sneaky = true;
            control = false;
            MessageBox.Show("Sneaky Class. Extremely good attack, but weaker on the defensive side.");
            conBtn.Visible = true;
        }

        private void controlBtn_Click(object sender, EventArgs e)
        {
            offensive = false;
            defensive = false;
            sneaky = false;
            control = true;
            MessageBox.Show("Control Class. A bit of everything.");
            conBtn.Visible = true;
        }

        private void TmrMoves_Tick(object sender, EventArgs e)
        {
            TmrMoves.Enabled = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (difficultySelectionMenu == true)
            {
                startButton.Visible = true;
                instructButton.Visible = true;
                instructLbl.Visible = true;
                TxtName.Visible = true;
                lblName.Visible = true;
                settingsButton.Visible = true;
                instructLbl.Visible = true;
                bossyLbl.Visible = true;
                quitGame.Visible = true;
            }
            if (classSelectionMenu == true)
            {
                lblDifficulty.Visible = false;
                easyFButton.Visible = false;
                mediumFButton.Visible = false;
                hardFButton.Visible = false;
                backBtn.Visible = true;
            }
        }
    }
}

//pastebin
//            codeRedeemer.Enabled = false;
//TxtName.Enabled = false;
 //           instructButton.Enabled = false;
 //           settingsButton.Enabled = false;
