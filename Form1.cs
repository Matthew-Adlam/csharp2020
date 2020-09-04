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
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp2020
{
    public partial class Form1 : Form
    {
        // declares variables, not all necessary but most are
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
        public bool gameEnd = false;

        string move;
        string name = "user";

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // sets up what I need on my home page
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
            backBtn.Visible = false;
            difficultyLbl.Visible = false;
            loseLbl.Visible = false;
            winLbl.Visible = false;
            exitLbl.Visible = false;
            nameLbl.Visible = false;
        }

        // next 2 are not necessary
        public void stopGame()
        {
            startButton.Enabled = true;
        }


        private void startButton_Click(object sender, EventArgs e)
        {
        }

        // shows instructions
        private void instructButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome! The object of this game is to reduce your enemy's hitpoints to 0, before they reduce yours to 0. Performing moves is the way to do so. If you want to know what the moves do, see the move info button in game.");
            MessageBox.Show("WARNING - Don't heal at maximum health because it won't let you, and you miss a turn.");
        }


        // the different difficulties, moves to next screen, and sets the enemy health based on player selection
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
            nameLbl.Visible = false;
            settingsButton.Visible = false;
            instructLbl.Visible = false;

            lblDifficulty.Visible = false;
            easyFButton.Visible = false;
            mediumFButton.Visible = false;
            hardFButton.Visible = false;

            backBtn.Visible = true;
            controlBtn.Visible = true;
            offBtn.Visible = true;
            defButton.Visible = true;
            sneakyBtn.Visible = true;
            classLbl.Visible = true;
            classSelectionMenu = true;
            difficultySelectionMenu = false;
            difficultyLbl.Visible = false;
        }
        // the different difficulties, moves to next screen, and sets the enemy health based on player selection
        private void normalFButton_Click(object sender, EventArgs e)
        {
            fighterMode = true;
            easy = false;
            medium = true;
            hard = false;
            MessageBox.Show("Selected Normal.");
            startButton.Visible = false;
            instructButton.Visible = false;
            TxtName.Visible = false;
            lblName.Visible = false;
            nameLbl.Visible = false;
            settingsButton.Visible = false;
            instructLbl.Visible = false;

            lblDifficulty.Visible = false;
            easyFButton.Visible = false;
            mediumFButton.Visible = false;
            hardFButton.Visible = false;

            backBtn.Visible = true;
            controlBtn.Visible = true;
            offBtn.Visible = true;
            defButton.Visible = true;
            sneakyBtn.Visible = true;
            classLbl.Visible = true;
            classSelectionMenu = true;
            difficultySelectionMenu = false;
            difficultyLbl.Visible = false;
        }
        // the different difficulties, moves to next screen, and sets the enemy health based on player selection
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
            nameLbl.Visible = false;
            settingsButton.Visible = false;
            instructLbl.Visible = false;
            backBtn.Visible = true;

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
            difficultyLbl.Visible = false;
        }
// the settings button - the Start Game button
        private void settingsButton_Click(object sender, EventArgs e)
        {
            // Start Game Button
            startButton.Visible = false;
            instructButton.Visible = false;
            instructLbl.Visible = true;
            TxtName.Visible = false;
            lblName.Visible = false;
            settingsButton.Visible = false;
            instructLbl.Visible = false;
            bossyLbl.Visible = false;
            quitGame.Visible = false;

            backBtn.Visible = true;
            lblDifficulty.Visible = true;
            easyFButton.Visible = true;
            mediumFButton.Visible = true;
            hardFButton.Visible = true;
            easyFButton.Enabled = true;
            mediumFButton.Enabled = true;
            hardFButton.Enabled = true;
            difficultySelectionMenu = true;
            difficultyLbl.Visible = true;
        }
        // ignore
        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            startButton.Visible = true;
        }
        // the name text box - records user entry
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            {
                string context = TxtName.Text;
                name = context;
            
            }
        }
        // ignore next 3 blocks
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
        // offensive button clicked
        private void offBtn_Click(object sender, EventArgs e)
        {
            offensive = true;
            defensive = false;
            sneaky = false;
            control = false;
            MessageBox.Show("Offensive Class. Very attack focused.");
            conBtn.Visible = true;
        }
        // confirm button - checks what class player chose and set game to those
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
            { // default class is offensive, so if not offensive change move names
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
            {// default class is offensive, so if not offensive change move names
                MessageBox.Show("Selected Sneaky Class.");
                playerHitpoints = 30;
                enemyHitpoints = 50; // ^^^ and this subject to change due to difficulty
                move1.Text = "Pounce";
                move2.Text = "Knock Out";
                move3.Text = "Accuracy Boost (Max 2)";
                move4.Text = "Weak Heal";
                move5.Text = "Run Away!";
                startGame();
            }
            if (control == true)
            {// default class is offensive, so if not offensive change move names
                MessageBox.Show("Selected Control Class.");
                playerHitpoints = 60;
                enemyHitpoints = 50; // ^^^ and this subject to change due to difficulty
                move1.Text = "Decent Attack";
                move2.Text = "Defensive Boost (Max 2)";
                move3.Text = "Little Heal";
                move4.Text = "Risky Attack";
                move5.Text = "Run Away!";
                startGame();
            }

        }
        void startGame()
        { // when game starts, set enemy hp, set default values and move to game screen
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
            backBtn.Visible = false;
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
            move1.Enabled = true;
            move2.Enabled = true;
            move3.Enabled = true;
            move4.Enabled = true;
            move5.Enabled = true;
            moveInfo.Visible = true;
            missLbl.Visible = true;
            enemyMissLbl.Visible = true;

            missLbl.Text = name + " Attack to start!";
            player1Turn = true;
        }

        private void move1_Click(object sender, EventArgs e)
        { // if it is the players turn
            if (player1Turn == true)
            { // if offensive class
                if (offensive == true)
                {
                   // attacks with possibility of missing
                    playerAccuracy = playerAcc.Next(1, 10);
                    if (playerAccuracy > 6)
                    {
                        // if player misses
                        missLbl.Text = name + "," + "" + "You Missed!";
                        player1Turn = false;
                        enemyAttackTime();
                     
                    }
                    if (playerAccuracy < 7)
                    {
                        // player attacks, changes enemy health, notifies player and passes turn to enemy
                        playerAttack = bigAttack.Next(6, 8);
                        enemyHitpoints -= playerAttack + strengthBuff;
                        missLbl.Text = "You hit the enemy for" + "" + (playerAttack + strengthBuff) + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();
                       
                    }
                }
                if (defensive == true)
                { // if defensive class
                    playerAccuracy = playerAcc.Next(1, 10);
                    if (playerAccuracy > 8)
                    {
                        // if player misses
                        missLbl.Text = name + "," + "" + "You Missed!";
                        player1Turn = false;
                        enemyAttackTime();
                        
                    }
                    if (playerAccuracy < 9)
                    {
                        // player attacks, changes enemy health, notifies player and passes turn to enemy
                        playerAttack = bigAttack.Next(2, 5);
                        enemyHitpoints -= playerAttack ;
                        missLbl.Text = "You hit the enemy for" + "" + playerAttack  + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();
                        
                    }
                }
                if (sneaky == true)
                { // if sneaky class
                    playerAccuracy = playerAcc.Next(1, 10);
                    // checks if player's accuracy is less than maximum - for sneaky class only
                    if (playerAccuracy < 11)
                    {
                        playerAccuracy += accuracyBuff;
                    }
                    if (playerAccuracy > 8)
                    {
                        // if player misses
                        missLbl.Text = name + "," + "" + "You Missed!";
                        player1Turn = false;
                        enemyAttackTime();
                        
                    }
                    if (playerAccuracy < 9)
                    {
                        // player attacks, changes enemy health, notifies player and passes turn to enemy
                        playerAttack = 7;
                        enemyHitpoints -= playerAttack;
                        missLbl.Text = "You hit the enemy for" + "" + playerAttack + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();
                        
                    }
                }
                if (control == true)
                { // if control class
                    playerAccuracy = playerAcc.Next(1, 10);
                    if (playerAccuracy > 8)
                    {
                        // if player misses
                        missLbl.Text = name + "," + "" + "You Missed!";
                        player1Turn = false;
                        enemyAttackTime();
                      
                    }
                    if (playerAccuracy < 9)
                    {
                        // player attacks, changes enemy health, notifies player and passes turn to enemy
                        playerAttack = bigAttack.Next(2, 5);
                        enemyHitpoints -= playerAttack + strengthBuff;
                        missLbl.Text = "You hit the enemy for" + "" + (playerAttack + strengthBuff) + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();
                        
                    }
                }
            }

        }
  
        // when its time for player to attack
        void playerAttackTime()
        {
            deathCheck();
            player1Turn = true;
            move1.Enabled = true;
            move2.Enabled = true;
            move3.Enabled = true;
            move4.Enabled = true;
            TmrMoves.Enabled = false;
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
                        missLbl.Text = name + "," + "" + "You Missed!";
                        player1Turn = false;
                        enemyAttackTime();
                       
                    }
                    if (playerAccuracy < 9)
                    {
                        playerAttack = bigAttack.Next(3, 7);
                        enemyHitpoints -= playerAttack + strengthBuff;
                        missLbl.Text = "You hit the enemy for" + "" + (playerAttack + strengthBuff) + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();
                      
                    }
                }
                if (defensive == true && playerHitpoints < 76)
                {
                    // heals if under max health
                    playerHeal = playerAcc.Next(3, 5);
                    playerHitpoints += playerHeal;
                    missLbl.Text = "You healed for" + "" + playerHeal + "" + "damage!";
                    userHpLbl.Text = playerHitpoints.ToString();
                    player1Turn = false;
                    enemyAttackTime();
                    
                }
                if (sneaky == true)
                {
                    playerAccuracy = playerAcc.Next(1, 10);
                    if (playerAccuracy > 2)
                    {
                        missLbl.Text = name + "," + "" + "You Missed!";
                        player1Turn = false;
                        enemyAttackTime();

                    }
                    if (playerAccuracy < 3)
                    {
                        playerAttack = bigAttack.Next(15, 20);
                        enemyHitpoints -= playerAttack;
                        missLbl.Text = "You hit the enemy for" + "" + playerAttack +  "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();

                    }
                }
                if (control == true && defenseBuffCount >= 1)
                {
                    // there is a limit to defenses, check if exceeded then buffs the defense
                    playerDefense += 1;
                    missLbl.Text = "Buffed" + "" + name + "'s" + "" + " Defense!";
                    player1Turn = false;
                    defenseBuffCount -= 1;
                    move2.Text = "Defense Buff" + "" + defenseBuffCount + "" + "left!";
                    enemyAttackTime();
                    
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
                    missLbl.Text = "Buffed" + "" + name + "'s" + "" + " Strength!";
                    player1Turn = false;
                    strengthBuffCount -= 1;
                    move3.Text = "Strength Buff" + "" + strengthBuffCount + "" + "left!";
                    enemyAttackTime();
                  
                }
                if (defensive == true && defenseBuffCount >= 1)
                {
                    playerDefense += 1;
                    missLbl.Text = "Buffed" + "" + name + "'s" + "" + " Defense!";
                    player1Turn = false;
                    defenseBuffCount -= 1;
                    move3.Text = "Defense Buff" + "" + defenseBuffCount + "" + "left!";
                    enemyAttackTime();
                  
                }
                if (sneaky == true && accuracyBuffCount >= 1)
                {
                    accuracyBuff += 1;
                    missLbl.Text = "Buffed" + "" + name + "'s" + "" + " Accuracy!";
                    player1Turn = false;
                    accuracyBuffCount -= 1;
                    move3.Text = "Accuracy Buff" + "" + accuracyBuffCount + "" + "left!";
                    enemyAttackTime();
                    
                }
                if (control == true && playerHitpoints < 61)
                {
                    playerHeal = playerAcc.Next(1, 4);
                    playerHitpoints += playerHeal;
                    missLbl.Text = "You healed for" + "" + playerHeal + "" + "damage!";
                    userHpLbl.Text = playerHitpoints.ToString();
                    player1Turn = false;
                    enemyAttackTime();

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
                        missLbl.Text = name + "," + "" + "You Missed!";
                        player1Turn = false;
                        enemyAttackTime();
                       
                    }
                    if (playerAccuracy < 4)
                    {
                        playerAttack = bigAttack.Next(8, 13);
                        enemyHitpoints -= playerAttack + strengthBuff;
                        missLbl.Text = "You hit the enemy for" + "" + (playerAttack + strengthBuff) + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();
                       
                    }
                }
                if (defensive == true)
                {
                    playerAccuracy = playerAcc.Next(1, 10);
                    if (playerAccuracy > 7)
                    {
                        missLbl.Text = name + "," + "" + "You Missed!";
                        player1Turn = false;
                        enemyAttackTime();
                      
                    }
                    if (playerAccuracy < 8)
                    {
                        playerAttack = bigAttack.Next(6, 8);
                        enemyHitpoints -= playerAttack + strengthBuff;
                        missLbl.Text = "You hit the enemy for" + "" + (playerAttack + strengthBuff) + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();
                       
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
                
                }
                if (control == true)
                {
                    playerAccuracy = playerAcc.Next(1, 10);
                    if (playerAccuracy > 3)
                    {
                        missLbl.Text = name + "," + "" + "You Missed!";
                        player1Turn = false;
                        enemyAttackTime();

                    }
                    if (playerAccuracy < 4)
                    {
                        playerAttack = bigAttack.Next(7, 12);
                        enemyHitpoints -= playerAttack;
                        missLbl.Text = "You hit the enemy for" + "" + playerAttack + "" + "damage!";
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = false;
                        enemyAttackTime();

                    }
                }
            }
        }

        private void move5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You ran from the planet!");
            resetGame();
        }
        // sets class to defensive
        private void defButton_Click(object sender, EventArgs e)
        {
            offensive = false;
            defensive = true;
            sneaky = false;
            control = false;
            MessageBox.Show("Defensive Class. Very survival focused.");
            conBtn.Visible = true;
        }
        // checks if a player has won/lost the game, and displays appropriate label
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
                winLbl.Visible = true;
                exitLbl.Visible = true;
                gameEnd = true;
            }
            if (playerHitpoints == 0 || playerHitpoints < 0)
            {
                player1Turn = false;
                move1.Enabled = false;
                move2.Enabled = false;
                move3.Enabled = false;
                move4.Enabled = false;
                move5.Enabled = false;
                loseLbl.Visible = true;
                exitLbl.Visible = true;
                gameEnd = true;
            }
        }
        // resets the game to difficulty screen
        public void resetGame()
        {
            lblDifficulty.Visible = true;
            easyFButton.Visible = true;
            mediumFButton.Visible = true;
            hardFButton.Visible = true;
            easyFButton.Enabled = true;
            mediumFButton.Enabled = true;
            hardFButton.Enabled = true;
            backBtn.Visible = true;
            difficultyLbl.Visible = true;

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
            winLbl.Visible = false;
            loseLbl.Visible = false;
            exitLbl.Visible = false;
        }
        // displays info about what the moves do
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
                MessageBox.Show("Decent Attack - decent damage and high accuracy, Defense Buff - buffs defense (max 2),Little Heal - heals a little, Risky Attack - fairly low accuracy but high damage.");
            }
            if(sneaky == true)
            {
                MessageBox.Show("Pounce - high damage and decent accuracy, Accuracy Buff - buffs accuracy (max 2), Knock Out - massive damage but low accuracy, Weak Heal - heals for a little bit.");
            }
        }
        // selects sneaky class
        private void sneakyBtn_Click(object sender, EventArgs e)
        {
            offensive = false;
            defensive = false;
            sneaky = true;
            control = false;
            MessageBox.Show("Sneaky Class. Extremely good attack, but weaker on the defensive side.");
            conBtn.Visible = true;
        }
        // selects control class
        private void controlBtn_Click(object sender, EventArgs e)
        {
            offensive = false;
            defensive = false;
            sneaky = false;
            control = true;
            MessageBox.Show("Control Class. A bit of everything.");
            conBtn.Visible = true;
        }
        // controls enemy moves - the click too fast bug was a factor here, so this is irrelevant rn
        private void TmrMoves_Tick(object sender, EventArgs e)
        {
            TmrMoves.Enabled = false;
        }
        // controls the multi use back button - depending on what screen it is on
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (difficultySelectionMenu == true)
            {
                instructButton.Visible = true;
                instructLbl.Visible = true;
                TxtName.Visible = true;
                lblName.Visible = true;
                settingsButton.Visible = true;
                instructLbl.Visible = true;
                bossyLbl.Visible = true;
                quitGame.Visible = true;

                lblDifficulty.Visible = false;
                easyFButton.Visible = false;
                mediumFButton.Visible = false;
                hardFButton.Visible = false;
                hardFButton.Visible = false;
                backBtn.Visible = false;
                difficultyLbl.Visible = false;
            }
            if (classSelectionMenu == true)
            {
                lblDifficulty.Visible = true;
                easyFButton.Visible = true;
                mediumFButton.Visible = true;
                hardFButton.Visible = true;
                backBtn.Visible = true;
                difficultyLbl.Visible = true;

                controlBtn.Visible = false;
                offBtn.Visible = false;
                sneakyBtn.Visible = false;
                defButton.Visible = false;
                conBtn.Visible = false;
                classLbl.Visible = false;

            }
        }
        // cosmetic effects
        private void settingsButton_MouseHover(object sender, EventArgs e)
        {
            settingsButton.BackColor = Color.Yellow;
        }

        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsButton.BackColor = Color.Red;
        }

        private void instructButton_MouseHover(object sender, EventArgs e)
        {
            instructButton.BackColor = Color.Yellow;
        }

        private void instructButton_MouseLeave(object sender, EventArgs e)
        {
            instructButton.BackColor = Color.Lime;
        }

        private void quitGame_MouseHover(object sender, EventArgs e)
        {
            quitGame.BackColor = Color.Yellow;
        }

        private void quitGame_MouseLeave(object sender, EventArgs e)
        {
            quitGame.BackColor = Color.Blue;
        }
        // next 3 are irrelevant
        public void tutorialBox_Click(object sender, EventArgs e)
        {
        }

        private void tmrTutorial_Tick(object sender, EventArgs e)
        {
   //
        }

        private void tmrWin_Tick(object sender, EventArgs e)
        {
        }
        // end game label navigation
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Escape)
            {
                resetGame();
            }
        }
    }
}


//pastebin
//            codeRedeemer.Enabled = false;
//TxtName.Enabled = false;
 //           instructButton.Enabled = false;
 //           settingsButton.Enabled = false;
