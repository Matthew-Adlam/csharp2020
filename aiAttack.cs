using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2020
{
    partial class Form1
    {
           public void enemyAttackTime()
            {
            //checks for death, and makes the player unable to move
               deathCheck();
                TmrMoves.Enabled = true;

                move1.Enabled = false;
                move2.Enabled = false;
                move3.Enabled = false;
                move4.Enabled = false;
            // makes the difficulty of the ai based on the game difficulty
                if (easy == true)
                {
                // generates a random number, it will miss, heal or in most cases, attack
                    enemyAccuracy = enemyMoveRand.Next(1, 12);

                    if (enemyAccuracy > 10)
                    {
                        enemyMissLbl.Text = "The enemy missed!";
                        player1Turn = true;
                        playerAttackTime();
                        deathCheck();
                    }
                    if (enemyAccuracy < 9)
                    {
                    // generates a random number of damage to deal, takes away from player, notifies player and passes back to player turn
                        enemyAttack = enemyMoveRand.Next(3, 8);
                        playerHitpoints -= enemyAttack - playerDefense;
                        enemyMissLbl.Text = "You were hit by the enemy for" + "" + (enemyAttack - playerDefense) + "" + "damage!";
                        userHpLbl.Text = playerHitpoints.ToString();
                        player1Turn = true;
                        playerAttackTime();
                        deathCheck();
                    }
                    if (enemyAccuracy > 8 && enemyAccuracy < 11 && enemyHitpoints < 51)
                    {
                    // the code to heal, generates a random number and heals
                        enemyHeal = enemyMoveRand.Next(5, 7);
                        enemyHitpoints += enemyHeal;
                    // checks if enemy has or will be at/over full health after heal
                        if (enemyHitpoints > 50)
                        {
                            enemyHitpoints = 50;
                            enemyMissLbl.Text = "The enemy healed to full health!";
                        }
                        else
                        {
                            enemyMissLbl.Text = "The enemy healed for" + "" + enemyHeal + "" + "damage!";
                        }
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = true;
                        playerAttackTime();
                        deathCheck();
                    }
                }
                if (medium == true) // a step up from easy
                {
                    enemyAccuracy = enemyMoveRand.Next(1, 12);
                // miss code
                if (enemyAccuracy > 10)
                    {
                        enemyMissLbl.Text = "The enemy missed!";
                        player1Turn = true;
                        playerAttackTime();
                        deathCheck();
                    }
                    if (enemyAccuracy < 9)
                {                // generates a random number of damage to deal, takes away from player, notifies player and passes back to player turn
                    enemyAttack = enemyMoveRand.Next(4, 9);
                        playerHitpoints -= enemyAttack;
                        enemyMissLbl.Text = "You were hit by the enemy for" + "" + enemyAttack + "" + "damage!";
                        userHpLbl.Text = playerHitpoints.ToString();
                        player1Turn = true;
                        playerAttackTime();
                        deathCheck();
                    }
                    if (enemyAccuracy > 8 && enemyAccuracy < 11 && enemyHitpoints < 66)
                    { // heal code
                        enemyHeal = enemyMoveRand.Next(6, 8);
                        enemyHitpoints += enemyHeal;
                        if (enemyHitpoints > 65)
                        {
                            enemyHitpoints = 65;
                            enemyMissLbl.Text = "The enemy healed to full health!";
                        }
                        else
                        {
                            enemyMissLbl.Text = "The enemy healed for" + "" + enemyHeal + "" + "damage!";
                        }
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = true;
                        playerAttackTime();
                        deathCheck();
                    }
                }
                if (hard == true)// enemy never misses if hard difficulty
                {
                    enemyAccuracy = enemyMoveRand.Next(1, 12);
                // generates a random number of damage to deal, takes away from player, notifies player and passes back to player turn
                if (enemyAccuracy < 11)
                    {
                        enemyAttack = enemyMoveRand.Next(6, 9);
                        playerHitpoints -= enemyAttack;
                        enemyMissLbl.Text = "You were hit by the enemy for" + "" + enemyAttack + "" + "damage!";
                        userHpLbl.Text = playerHitpoints.ToString();
                        player1Turn = true;
                        playerAttackTime();
                        deathCheck();
                    }
                    if (enemyAccuracy > 10 && enemyAccuracy < 13 && enemyHitpoints < 81)
                    { // heal code
                        enemyHeal = enemyMoveRand.Next(7, 9);
                        enemyHitpoints += enemyHeal;
                        if (enemyHitpoints > 80)
                        {
                            enemyHitpoints = 80;
                            enemyMissLbl.Text = "The enemy healed to full health!";
                        }
                        else
                        {
                            enemyMissLbl.Text = "The enemy healed for" + "" + enemyHeal + "" + "damage!";
                        }
                        enemyHpLbl.Text = enemyHitpoints.ToString();
                        player1Turn = true;
                        playerAttackTime();
                        deathCheck();
                    }
                }
            }
            }
        }
    

                

