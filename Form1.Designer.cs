﻿namespace csharp2020
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UserHp = new System.Windows.Forms.Label();
            this.EnemyHp = new System.Windows.Forms.Label();
            this.LblFightUserHp = new System.Windows.Forms.Label();
            this.LblFightAiHp = new System.Windows.Forms.Label();
            this.easyFButton = new System.Windows.Forms.Button();
            this.hardFButton = new System.Windows.Forms.Button();
            this.mediumFButton = new System.Windows.Forms.Button();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.instructButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.offBtn = new System.Windows.Forms.Button();
            this.defButton = new System.Windows.Forms.Button();
            this.sneakyBtn = new System.Windows.Forms.Button();
            this.classLbl = new System.Windows.Forms.Label();
            this.conBtn = new System.Windows.Forms.Button();
            this.bossyLbl = new System.Windows.Forms.Label();
            this.instructLbl = new System.Windows.Forms.Label();
            this.userhealthLbl = new System.Windows.Forms.Label();
            this.enemyhealthLbl = new System.Windows.Forms.Label();
            this.userHpLbl = new System.Windows.Forms.Label();
            this.enemyHpLbl = new System.Windows.Forms.Label();
            this.move1 = new System.Windows.Forms.Button();
            this.move2 = new System.Windows.Forms.Button();
            this.move3 = new System.Windows.Forms.Button();
            this.move4 = new System.Windows.Forms.Button();
            this.move5 = new System.Windows.Forms.Button();
            this.moveInfo = new System.Windows.Forms.Button();
            this.missLbl = new System.Windows.Forms.Label();
            this.enemyMissLbl = new System.Windows.Forms.Label();
            this.quitGame = new System.Windows.Forms.Button();
            this.TmrShip = new System.Windows.Forms.Timer(this.components);
            this.TmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.TmrMoves = new System.Windows.Forms.Timer(this.components);
            this.controlBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.planetAi = new System.Windows.Forms.PictureBox();
            this.alien = new System.Windows.Forms.PictureBox();
            this.tmrTutorial = new System.Windows.Forms.Timer(this.components);
            this.difficultyLbl = new System.Windows.Forms.Label();
            this.winLbl = new System.Windows.Forms.Label();
            this.loseLbl = new System.Windows.Forms.Label();
            this.tmrWin = new System.Windows.Forms.Timer(this.components);
            this.exitLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.planetAi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).BeginInit();
            this.SuspendLayout();
            // 
            // UserHp
            // 
            this.UserHp.AutoSize = true;
            this.UserHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserHp.Location = new System.Drawing.Point(119, 158);
            this.UserHp.Name = "UserHp";
            this.UserHp.Size = new System.Drawing.Size(18, 20);
            this.UserHp.TabIndex = 25;
            this.UserHp.Text = "0";
            // 
            // EnemyHp
            // 
            this.EnemyHp.AutoSize = true;
            this.EnemyHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyHp.Location = new System.Drawing.Point(472, 158);
            this.EnemyHp.Name = "EnemyHp";
            this.EnemyHp.Size = new System.Drawing.Size(18, 20);
            this.EnemyHp.TabIndex = 24;
            this.EnemyHp.Text = "0";
            // 
            // LblFightUserHp
            // 
            this.LblFightUserHp.AutoSize = true;
            this.LblFightUserHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFightUserHp.Location = new System.Drawing.Point(70, 115);
            this.LblFightUserHp.Name = "LblFightUserHp";
            this.LblFightUserHp.Size = new System.Drawing.Size(114, 24);
            this.LblFightUserHp.TabIndex = 23;
            this.LblFightUserHp.Text = "Your Health:";
            // 
            // LblFightAiHp
            // 
            this.LblFightAiHp.AutoSize = true;
            this.LblFightAiHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFightAiHp.Location = new System.Drawing.Point(419, 115);
            this.LblFightAiHp.Name = "LblFightAiHp";
            this.LblFightAiHp.Size = new System.Drawing.Size(134, 24);
            this.LblFightAiHp.TabIndex = 22;
            this.LblFightAiHp.Text = "Enemy Health:";
            // 
            // easyFButton
            // 
            this.easyFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyFButton.Location = new System.Drawing.Point(256, 174);
            this.easyFButton.Name = "easyFButton";
            this.easyFButton.Size = new System.Drawing.Size(166, 50);
            this.easyFButton.TabIndex = 15;
            this.easyFButton.Text = "Easy";
            this.easyFButton.UseVisualStyleBackColor = true;
            this.easyFButton.Click += new System.EventHandler(this.easyFButton_Click);
            // 
            // hardFButton
            // 
            this.hardFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardFButton.Location = new System.Drawing.Point(256, 304);
            this.hardFButton.Name = "hardFButton";
            this.hardFButton.Size = new System.Drawing.Size(166, 50);
            this.hardFButton.TabIndex = 14;
            this.hardFButton.Text = "Hard ";
            this.hardFButton.UseVisualStyleBackColor = true;
            this.hardFButton.Click += new System.EventHandler(this.hardFButton_Click);
            // 
            // mediumFButton
            // 
            this.mediumFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumFButton.Location = new System.Drawing.Point(256, 239);
            this.mediumFButton.Name = "mediumFButton";
            this.mediumFButton.Size = new System.Drawing.Size(166, 50);
            this.mediumFButton.TabIndex = 13;
            this.mediumFButton.Text = "Normal";
            this.mediumFButton.UseVisualStyleBackColor = true;
            this.mediumFButton.Click += new System.EventHandler(this.normalFButton_Click);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(234, 94);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(243, 33);
            this.lblDifficulty.TabIndex = 0;
            this.lblDifficulty.Text = "Select a difficulty:";
            this.lblDifficulty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(590, 187);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 1;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(617, 157);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(121, 226);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(115, 50);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // instructButton
            // 
            this.instructButton.BackColor = System.Drawing.Color.Lime;
            this.instructButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructButton.Location = new System.Drawing.Point(210, 230);
            this.instructButton.Name = "instructButton";
            this.instructButton.Size = new System.Drawing.Size(267, 92);
            this.instructButton.TabIndex = 8;
            this.instructButton.Text = "Tutorial";
            this.instructButton.UseVisualStyleBackColor = false;
            this.instructButton.Click += new System.EventHandler(this.instructButton_Click);
            this.instructButton.MouseLeave += new System.EventHandler(this.instructButton_MouseLeave);
            this.instructButton.MouseHover += new System.EventHandler(this.instructButton_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Red;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(210, 94);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(267, 92);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.Text = "Start Game!";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.MouseLeave += new System.EventHandler(this.settingsButton_MouseLeave);
            this.settingsButton.MouseHover += new System.EventHandler(this.settingsButton_MouseHover);
            // 
            // offBtn
            // 
            this.offBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offBtn.Location = new System.Drawing.Point(256, 136);
            this.offBtn.Name = "offBtn";
            this.offBtn.Size = new System.Drawing.Size(166, 50);
            this.offBtn.TabIndex = 20;
            this.offBtn.Text = "Offensive";
            this.offBtn.UseVisualStyleBackColor = true;
            this.offBtn.Click += new System.EventHandler(this.offBtn_Click);
            // 
            // defButton
            // 
            this.defButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defButton.Location = new System.Drawing.Point(256, 206);
            this.defButton.Name = "defButton";
            this.defButton.Size = new System.Drawing.Size(166, 50);
            this.defButton.TabIndex = 21;
            this.defButton.Text = "Defensive";
            this.defButton.UseVisualStyleBackColor = true;
            this.defButton.Click += new System.EventHandler(this.defButton_Click);
            // 
            // sneakyBtn
            // 
            this.sneakyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sneakyBtn.Location = new System.Drawing.Point(256, 272);
            this.sneakyBtn.Name = "sneakyBtn";
            this.sneakyBtn.Size = new System.Drawing.Size(166, 50);
            this.sneakyBtn.TabIndex = 22;
            this.sneakyBtn.Text = "Sneaky";
            this.sneakyBtn.UseVisualStyleBackColor = true;
            this.sneakyBtn.Click += new System.EventHandler(this.sneakyBtn_Click);
            // 
            // classLbl
            // 
            this.classLbl.AutoSize = true;
            this.classLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLbl.Location = new System.Drawing.Point(81, 92);
            this.classLbl.Name = "classLbl";
            this.classLbl.Size = new System.Drawing.Size(584, 24);
            this.classLbl.TabIndex = 23;
            this.classLbl.Text = "Select a class for information, and press confirm when you are ready!";
            this.classLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // conBtn
            // 
            this.conBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.conBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conBtn.Location = new System.Drawing.Point(256, 444);
            this.conBtn.Name = "conBtn";
            this.conBtn.Size = new System.Drawing.Size(166, 50);
            this.conBtn.TabIndex = 24;
            this.conBtn.Text = "Confirm";
            this.conBtn.UseVisualStyleBackColor = false;
            this.conBtn.Click += new System.EventHandler(this.conBtn_Click);
            // 
            // bossyLbl
            // 
            this.bossyLbl.AutoSize = true;
            this.bossyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bossyLbl.Location = new System.Drawing.Point(18, 9);
            this.bossyLbl.Name = "bossyLbl";
            this.bossyLbl.Size = new System.Drawing.Size(672, 25);
            this.bossyLbl.TabIndex = 18;
            this.bossyLbl.Text = "Welcome to Fight Club!  Press the instructions button for how to play!";
            // 
            // instructLbl
            // 
            this.instructLbl.AutoSize = true;
            this.instructLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructLbl.Location = new System.Drawing.Point(80, 46);
            this.instructLbl.Name = "instructLbl";
            this.instructLbl.Size = new System.Drawing.Size(484, 25);
            this.instructLbl.TabIndex = 25;
            this.instructLbl.Text = "Click the Settings button to modify game settings.";
            // 
            // userhealthLbl
            // 
            this.userhealthLbl.AutoSize = true;
            this.userhealthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userhealthLbl.Location = new System.Drawing.Point(100, 47);
            this.userhealthLbl.Name = "userhealthLbl";
            this.userhealthLbl.Size = new System.Drawing.Size(114, 24);
            this.userhealthLbl.TabIndex = 28;
            this.userhealthLbl.Text = "Your Health:";
            // 
            // enemyhealthLbl
            // 
            this.enemyhealthLbl.AutoSize = true;
            this.enemyhealthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyhealthLbl.Location = new System.Drawing.Point(442, 47);
            this.enemyhealthLbl.Name = "enemyhealthLbl";
            this.enemyhealthLbl.Size = new System.Drawing.Size(134, 24);
            this.enemyhealthLbl.TabIndex = 29;
            this.enemyhealthLbl.Text = "Enemy Health:";
            // 
            // userHpLbl
            // 
            this.userHpLbl.AutoSize = true;
            this.userHpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userHpLbl.Location = new System.Drawing.Point(137, 96);
            this.userHpLbl.Name = "userHpLbl";
            this.userHpLbl.Size = new System.Drawing.Size(27, 20);
            this.userHpLbl.TabIndex = 30;
            this.userHpLbl.Text = "10";
            // 
            // enemyHpLbl
            // 
            this.enemyHpLbl.AutoSize = true;
            this.enemyHpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyHpLbl.Location = new System.Drawing.Point(493, 96);
            this.enemyHpLbl.Name = "enemyHpLbl";
            this.enemyHpLbl.Size = new System.Drawing.Size(27, 20);
            this.enemyHpLbl.TabIndex = 31;
            this.enemyHpLbl.Text = "10";
            // 
            // move1
            // 
            this.move1.BackColor = System.Drawing.Color.Red;
            this.move1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.move1.Location = new System.Drawing.Point(48, 317);
            this.move1.Name = "move1";
            this.move1.Size = new System.Drawing.Size(166, 50);
            this.move1.TabIndex = 32;
            this.move1.Text = "Big Attack";
            this.move1.UseVisualStyleBackColor = false;
            this.move1.Click += new System.EventHandler(this.move1_Click);
            // 
            // move2
            // 
            this.move2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.move2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.move2.Location = new System.Drawing.Point(256, 317);
            this.move2.Name = "move2";
            this.move2.Size = new System.Drawing.Size(166, 50);
            this.move2.TabIndex = 33;
            this.move2.Text = "Decent Attack";
            this.move2.UseVisualStyleBackColor = false;
            this.move2.Click += new System.EventHandler(this.move2_Click_1);
            // 
            // move3
            // 
            this.move3.BackColor = System.Drawing.Color.Yellow;
            this.move3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.move3.Location = new System.Drawing.Point(462, 317);
            this.move3.Name = "move3";
            this.move3.Size = new System.Drawing.Size(166, 50);
            this.move3.TabIndex = 34;
            this.move3.Text = "Strength Buff (Max 2)";
            this.move3.UseVisualStyleBackColor = false;
            this.move3.Click += new System.EventHandler(this.move3_Click);
            // 
            // move4
            // 
            this.move4.BackColor = System.Drawing.Color.Lime;
            this.move4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.move4.Location = new System.Drawing.Point(48, 389);
            this.move4.Name = "move4";
            this.move4.Size = new System.Drawing.Size(166, 53);
            this.move4.TabIndex = 36;
            this.move4.Text = "HUGE Attack";
            this.move4.UseVisualStyleBackColor = false;
            this.move4.Click += new System.EventHandler(this.move4_Click);
            // 
            // move5
            // 
            this.move5.BackColor = System.Drawing.Color.DodgerBlue;
            this.move5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.move5.Location = new System.Drawing.Point(256, 389);
            this.move5.Name = "move5";
            this.move5.Size = new System.Drawing.Size(166, 53);
            this.move5.TabIndex = 37;
            this.move5.Text = "Run away!";
            this.move5.UseVisualStyleBackColor = false;
            this.move5.Click += new System.EventHandler(this.move5_Click);
            // 
            // moveInfo
            // 
            this.moveInfo.BackColor = System.Drawing.Color.Fuchsia;
            this.moveInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveInfo.Location = new System.Drawing.Point(462, 389);
            this.moveInfo.Name = "moveInfo";
            this.moveInfo.Size = new System.Drawing.Size(166, 53);
            this.moveInfo.TabIndex = 38;
            this.moveInfo.Text = "Move Info";
            this.moveInfo.UseVisualStyleBackColor = false;
            this.moveInfo.Click += new System.EventHandler(this.moveInfo_Click);
            // 
            // missLbl
            // 
            this.missLbl.AutoSize = true;
            this.missLbl.BackColor = System.Drawing.Color.Transparent;
            this.missLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missLbl.Location = new System.Drawing.Point(12, 460);
            this.missLbl.Name = "missLbl";
            this.missLbl.Size = new System.Drawing.Size(0, 20);
            this.missLbl.TabIndex = 39;
            // 
            // enemyMissLbl
            // 
            this.enemyMissLbl.AutoSize = true;
            this.enemyMissLbl.BackColor = System.Drawing.Color.Transparent;
            this.enemyMissLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyMissLbl.Location = new System.Drawing.Point(361, 460);
            this.enemyMissLbl.Name = "enemyMissLbl";
            this.enemyMissLbl.Size = new System.Drawing.Size(0, 20);
            this.enemyMissLbl.TabIndex = 40;
            // 
            // quitGame
            // 
            this.quitGame.BackColor = System.Drawing.Color.Blue;
            this.quitGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitGame.Location = new System.Drawing.Point(210, 360);
            this.quitGame.Name = "quitGame";
            this.quitGame.Size = new System.Drawing.Size(267, 92);
            this.quitGame.TabIndex = 41;
            this.quitGame.Text = "Quit Game";
            this.quitGame.UseVisualStyleBackColor = false;
            this.quitGame.Click += new System.EventHandler(this.quitGame_Click);
            this.quitGame.MouseLeave += new System.EventHandler(this.quitGame_MouseLeave);
            this.quitGame.MouseHover += new System.EventHandler(this.quitGame_MouseHover);
            // 
            // TmrShip
            // 
            this.TmrShip.Enabled = true;
            // 
            // TmrPlanet
            // 
            this.TmrPlanet.Enabled = true;
            // 
            // TmrMoves
            // 
            this.TmrMoves.Interval = 3000;
            this.TmrMoves.Tick += new System.EventHandler(this.TmrMoves_Tick);
            // 
            // controlBtn
            // 
            this.controlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlBtn.Location = new System.Drawing.Point(256, 333);
            this.controlBtn.Name = "controlBtn";
            this.controlBtn.Size = new System.Drawing.Size(166, 50);
            this.controlBtn.TabIndex = 19;
            this.controlBtn.Text = "Control";
            this.controlBtn.UseVisualStyleBackColor = true;
            this.controlBtn.Click += new System.EventHandler(this.controlBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(-2, 437);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(166, 50);
            this.backBtn.TabIndex = 43;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // planetAi
            // 
            this.planetAi.BackgroundImage = global::csharp2020.Properties.Resources.planet1;
            this.planetAi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.planetAi.Location = new System.Drawing.Point(462, 187);
            this.planetAi.Name = "planetAi";
            this.planetAi.Size = new System.Drawing.Size(114, 69);
            this.planetAi.TabIndex = 27;
            this.planetAi.TabStop = false;
            // 
            // alien
            // 
            this.alien.BackgroundImage = global::csharp2020.Properties.Resources.alien1;
            this.alien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alien.Location = new System.Drawing.Point(100, 187);
            this.alien.Name = "alien";
            this.alien.Size = new System.Drawing.Size(114, 69);
            this.alien.TabIndex = 26;
            this.alien.TabStop = false;
            // 
            // tmrTutorial
            // 
            this.tmrTutorial.Interval = 1000;
            this.tmrTutorial.Tick += new System.EventHandler(this.tmrTutorial_Tick);
            // 
            // difficultyLbl
            // 
            this.difficultyLbl.AutoSize = true;
            this.difficultyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLbl.Location = new System.Drawing.Point(157, 410);
            this.difficultyLbl.Name = "difficultyLbl";
            this.difficultyLbl.Size = new System.Drawing.Size(352, 24);
            this.difficultyLbl.TabIndex = 44;
            this.difficultyLbl.Text = "This changes how hard the enemy AI is. ";
            // 
            // winLbl
            // 
            this.winLbl.AutoSize = true;
            this.winLbl.BackColor = System.Drawing.Color.Transparent;
            this.winLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.winLbl.Location = new System.Drawing.Point(123, 183);
            this.winLbl.Name = "winLbl";
            this.winLbl.Size = new System.Drawing.Size(433, 108);
            this.winLbl.TabIndex = 45;
            this.winLbl.Text = "You Win!";
            // 
            // loseLbl
            // 
            this.loseLbl.AutoSize = true;
            this.loseLbl.BackColor = System.Drawing.Color.Transparent;
            this.loseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loseLbl.Location = new System.Drawing.Point(123, 183);
            this.loseLbl.Name = "loseLbl";
            this.loseLbl.Size = new System.Drawing.Size(475, 108);
            this.loseLbl.TabIndex = 46;
            this.loseLbl.Text = "You Lose!";
            // 
            // tmrWin
            // 
            this.tmrWin.Interval = 3000;
            this.tmrWin.Tick += new System.EventHandler(this.tmrWin_Tick);
            // 
            // exitLbl
            // 
            this.exitLbl.AutoSize = true;
            this.exitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLbl.Location = new System.Drawing.Point(115, 291);
            this.exitLbl.Name = "exitLbl";
            this.exitLbl.Size = new System.Drawing.Size(461, 55);
            this.exitLbl.TabIndex = 47;
            this.exitLbl.Text = "Press Escape to exit";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(11, 136);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(96, 24);
            this.nameLbl.TabIndex = 48;
            this.nameLbl.Text = "Welcome,";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 489);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.exitLbl);
            this.Controls.Add(this.loseLbl);
            this.Controls.Add(this.winLbl);
            this.Controls.Add(this.difficultyLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.quitGame);
            this.Controls.Add(this.enemyMissLbl);
            this.Controls.Add(this.missLbl);
            this.Controls.Add(this.moveInfo);
            this.Controls.Add(this.move5);
            this.Controls.Add(this.move4);
            this.Controls.Add(this.move3);
            this.Controls.Add(this.move2);
            this.Controls.Add(this.move1);
            this.Controls.Add(this.enemyHpLbl);
            this.Controls.Add(this.userHpLbl);
            this.Controls.Add(this.enemyhealthLbl);
            this.Controls.Add(this.userhealthLbl);
            this.Controls.Add(this.planetAi);
            this.Controls.Add(this.alien);
            this.Controls.Add(this.instructLbl);
            this.Controls.Add(this.conBtn);
            this.Controls.Add(this.classLbl);
            this.Controls.Add(this.sneakyBtn);
            this.Controls.Add(this.defButton);
            this.Controls.Add(this.offBtn);
            this.Controls.Add(this.controlBtn);
            this.Controls.Add(this.bossyLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.instructButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.mediumFButton);
            this.Controls.Add(this.easyFButton);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.hardFButton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.planetAi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button instructButton;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Button easyFButton;
        private System.Windows.Forms.Button hardFButton;
        private System.Windows.Forms.Button mediumFButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFightAiHp;
        private System.Windows.Forms.Label UserHp;
        private System.Windows.Forms.Label EnemyHp;
        private System.Windows.Forms.Label LblFightUserHp;
        private System.Windows.Forms.Button defensiveChoice;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button offBtn;
        private System.Windows.Forms.Button defButton;
        private System.Windows.Forms.Button sneakyBtn;
        private System.Windows.Forms.Label classLbl;
        private System.Windows.Forms.Button conBtn;
        private System.Windows.Forms.Label bossyLbl;
        private System.Windows.Forms.Label instructLbl;
        private System.Windows.Forms.PictureBox alien;
        private System.Windows.Forms.PictureBox planetAi;
        private System.Windows.Forms.Label userhealthLbl;
        private System.Windows.Forms.Label enemyhealthLbl;
        private System.Windows.Forms.Label userHpLbl;
        private System.Windows.Forms.Label enemyHpLbl;
        private System.Windows.Forms.Button move1;
        private System.Windows.Forms.Button move2;
        private System.Windows.Forms.Button move3;
        private System.Windows.Forms.Button move4;
        private System.Windows.Forms.Button move5;
        private System.Windows.Forms.Button moveInfo;
        private System.Windows.Forms.Label missLbl;
        private System.Windows.Forms.Label enemyMissLbl;
        private System.Windows.Forms.Button quitGame;
        private System.Windows.Forms.Timer TmrShip;
        private System.Windows.Forms.Timer TmrPlanet;
        private System.Windows.Forms.Timer TmrMoves;
        private System.Windows.Forms.Button controlBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Timer tmrTutorial;
        private System.Windows.Forms.Label difficultyLbl;
        private System.Windows.Forms.Label winLbl;
        private System.Windows.Forms.Label loseLbl;
        private System.Windows.Forms.Timer tmrWin;
        private System.Windows.Forms.Label exitLbl;
        private System.Windows.Forms.Label nameLbl;
    }
}

