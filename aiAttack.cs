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
                TmrMoves.Enabled = true;

                waitLbl.Visible = true;
                move1.Enabled = false;
                move2.Enabled = false;
                move3.Enabled = false;
                move4.Enabled = false;
                move5.Enabled = false;

                if (easy == true)
                {
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
                        enemyHeal = enemyMoveRand.Next(5, 7);
                        enemyHitpoints += enemyHeal;
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
                if (medium == true)
                {
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
                        enemyAttack = enemyMoveRand.Next(4, 9);
                        playerHitpoints -= enemyAttack;
                        enemyMissLbl.Text = "You were hit by the enemy for" + "" + enemyAttack + "" + "damage!";
                        userHpLbl.Text = playerHitpoints.ToString();
                        player1Turn = true;
                        playerAttackTime();
                        deathCheck();
                    }
                    if (enemyAccuracy > 8 && enemyAccuracy < 11 && enemyHitpoints < 66)
                    {
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
                if (hard == true)
                {
                    enemyAccuracy = enemyMoveRand.Next(1, 12);

                    if (enemyAccuracy < 9)
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
                    {
                        enemyHeal = enemyMoveRand.Next(7, 9);
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
            }
            }
        }
    

                

