namespace csharp2020
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
            this.PnlGame = new System.Windows.Forms.Panel();
            this.UserHp = new System.Windows.Forms.Label();
            this.EnemyHp = new System.Windows.Forms.Label();
            this.LblFightUserHp = new System.Windows.Forms.Label();
            this.LblFightAiHp = new System.Windows.Forms.Label();
            this.easyFButton = new System.Windows.Forms.Button();
            this.hardFButton = new System.Windows.Forms.Button();
            this.mediumFButton = new System.Windows.Forms.Button();
            this.mediumNButton = new System.Windows.Forms.Button();
            this.hardNButton = new System.Windows.Forms.Button();
            this.easyNButton = new System.Windows.Forms.Button();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.TmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.TmrShip = new System.Windows.Forms.Timer(this.components);
            this.TxtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.txtLives = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.instructButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.highScoreLbl = new System.Windows.Forms.Label();
            this.lblCodeRedeem = new System.Windows.Forms.Label();
            this.codeRedeemer = new System.Windows.Forms.TextBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.tmrShoot = new System.Windows.Forms.Timer(this.components);
            this.userCharacter = new System.Windows.Forms.PictureBox();
            this.aiCharacter = new System.Windows.Forms.PictureBox();
            this.offensiveChoice = new System.Windows.Forms.Button();
            this.LblClassChoice = new System.Windows.Forms.Label();
            this.sneakyChoice = new System.Windows.Forms.Button();
            this.controlChoice = new System.Windows.Forms.Button();
            this.defensiveChoice = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Silver;
            this.PnlGame.Controls.Add(this.confirmBtn);
            this.PnlGame.Controls.Add(this.defensiveChoice);
            this.PnlGame.Controls.Add(this.controlChoice);
            this.PnlGame.Controls.Add(this.sneakyChoice);
            this.PnlGame.Controls.Add(this.LblClassChoice);
            this.PnlGame.Controls.Add(this.offensiveChoice);
            this.PnlGame.Controls.Add(this.aiCharacter);
            this.PnlGame.Controls.Add(this.userCharacter);
            this.PnlGame.Controls.Add(this.UserHp);
            this.PnlGame.Controls.Add(this.EnemyHp);
            this.PnlGame.Controls.Add(this.LblFightUserHp);
            this.PnlGame.Controls.Add(this.LblFightAiHp);
            this.PnlGame.Location = new System.Drawing.Point(1, 1);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(600, 500);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.easyFButton.Location = new System.Drawing.Point(325, 173);
            this.easyFButton.Name = "easyFButton";
            this.easyFButton.Size = new System.Drawing.Size(166, 50);
            this.easyFButton.TabIndex = 15;
            this.easyFButton.Text = "Easy - Fighter";
            this.easyFButton.UseVisualStyleBackColor = true;
            this.easyFButton.Click += new System.EventHandler(this.easyFButton_Click);
            // 
            // hardFButton
            // 
            this.hardFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardFButton.Location = new System.Drawing.Point(325, 303);
            this.hardFButton.Name = "hardFButton";
            this.hardFButton.Size = new System.Drawing.Size(166, 50);
            this.hardFButton.TabIndex = 14;
            this.hardFButton.Text = "Hard - Fighter";
            this.hardFButton.UseVisualStyleBackColor = true;
            this.hardFButton.Click += new System.EventHandler(this.hardFButton_Click);
            // 
            // mediumFButton
            // 
            this.mediumFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumFButton.Location = new System.Drawing.Point(325, 238);
            this.mediumFButton.Name = "mediumFButton";
            this.mediumFButton.Size = new System.Drawing.Size(166, 50);
            this.mediumFButton.TabIndex = 13;
            this.mediumFButton.Text = "Normal - Fighter";
            this.mediumFButton.UseVisualStyleBackColor = true;
            this.mediumFButton.Click += new System.EventHandler(this.normalFButton_Click);
            // 
            // mediumNButton
            // 
            this.mediumNButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumNButton.Location = new System.Drawing.Point(153, 238);
            this.mediumNButton.Name = "mediumNButton";
            this.mediumNButton.Size = new System.Drawing.Size(166, 50);
            this.mediumNButton.TabIndex = 10;
            this.mediumNButton.Text = "Medium - Normal";
            this.mediumNButton.UseVisualStyleBackColor = true;
            this.mediumNButton.Click += new System.EventHandler(this.mediumNButton_Click);
            // 
            // hardNButton
            // 
            this.hardNButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardNButton.Location = new System.Drawing.Point(153, 303);
            this.hardNButton.Name = "hardNButton";
            this.hardNButton.Size = new System.Drawing.Size(166, 50);
            this.hardNButton.TabIndex = 11;
            this.hardNButton.Text = "Hard - Normal";
            this.hardNButton.UseVisualStyleBackColor = true;
            this.hardNButton.Click += new System.EventHandler(this.hardNButton_Click);
            // 
            // easyNButton
            // 
            this.easyNButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyNButton.Location = new System.Drawing.Point(153, 173);
            this.easyNButton.Name = "easyNButton";
            this.easyNButton.Size = new System.Drawing.Size(166, 50);
            this.easyNButton.TabIndex = 12;
            this.easyNButton.Text = "Easy - Normal";
            this.easyNButton.UseVisualStyleBackColor = true;
            this.easyNButton.Click += new System.EventHandler(this.easyNButton_Click);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(118, 93);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(453, 33);
            this.lblDifficulty.TabIndex = 0;
            this.lblDifficulty.Text = "Select a difficulty and game mode";
            // 
            // TmrPlanet
            // 
            this.TmrPlanet.Enabled = true;
            this.TmrPlanet.Tick += new System.EventHandler(this.TmrPlanet_Tick);
            // 
            // TmrShip
            // 
            this.TmrShip.Enabled = true;
            this.TmrShip.Interval = 50;
            this.TmrShip.Tick += new System.EventHandler(this.TmrShip_Tick);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(622, 239);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 1;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(639, 211);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(652, 313);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Location = new System.Drawing.Point(652, 438);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(13, 13);
            this.lblLives.TabIndex = 4;
            this.lblLives.Text = "3";
            // 
            // txtLives
            // 
            this.txtLives.AutoSize = true;
            this.txtLives.Location = new System.Drawing.Point(642, 406);
            this.txtLives.Name = "txtLives";
            this.txtLives.Size = new System.Drawing.Size(35, 13);
            this.txtLives.TabIndex = 5;
            this.txtLives.Text = "Lives:";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Location = new System.Drawing.Point(639, 279);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(38, 13);
            this.txtScore.TabIndex = 6;
            this.txtScore.Text = "Score:";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(607, 142);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(115, 50);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // instructButton
            // 
            this.instructButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructButton.Location = new System.Drawing.Point(607, 77);
            this.instructButton.Name = "instructButton";
            this.instructButton.Size = new System.Drawing.Size(115, 50);
            this.instructButton.TabIndex = 8;
            this.instructButton.Text = "Instructions";
            this.instructButton.UseVisualStyleBackColor = true;
            this.instructButton.Click += new System.EventHandler(this.instructButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(652, 378);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(13, 13);
            this.lblHighScore.TabIndex = 18;
            this.lblHighScore.Text = "0";
            // 
            // highScoreLbl
            // 
            this.highScoreLbl.AutoSize = true;
            this.highScoreLbl.Location = new System.Drawing.Point(627, 340);
            this.highScoreLbl.Name = "highScoreLbl";
            this.highScoreLbl.Size = new System.Drawing.Size(63, 13);
            this.highScoreLbl.TabIndex = 19;
            this.highScoreLbl.Text = "High Score:";
            // 
            // lblCodeRedeem
            // 
            this.lblCodeRedeem.AutoSize = true;
            this.lblCodeRedeem.Location = new System.Drawing.Point(619, 474);
            this.lblCodeRedeem.Name = "lblCodeRedeem";
            this.lblCodeRedeem.Size = new System.Drawing.Size(87, 13);
            this.lblCodeRedeem.TabIndex = 20;
            this.lblCodeRedeem.Text = "Code Redeemer:";
            // 
            // codeRedeemer
            // 
            this.codeRedeemer.Location = new System.Drawing.Point(622, 502);
            this.codeRedeemer.Name = "codeRedeemer";
            this.codeRedeemer.Size = new System.Drawing.Size(100, 20);
            this.codeRedeemer.TabIndex = 21;
            this.codeRedeemer.TextChanged += new System.EventHandler(this.codeRedeemer_TextChanged);
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = global::csharp2020.Properties.Resources.settings;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.Location = new System.Drawing.Point(622, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 59);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // tmrShoot
            // 
            this.tmrShoot.Tick += new System.EventHandler(this.tmrShoot_Tick);
            // 
            // userCharacter
            // 
            this.userCharacter.BackColor = System.Drawing.Color.Transparent;
            this.userCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userCharacter.Image = global::csharp2020.Properties.Resources.alien1;
            this.userCharacter.Location = new System.Drawing.Point(84, 228);
            this.userCharacter.Name = "userCharacter";
            this.userCharacter.Size = new System.Drawing.Size(100, 84);
            this.userCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userCharacter.TabIndex = 22;
            this.userCharacter.TabStop = false;
            // 
            // aiCharacter
            // 
            this.aiCharacter.BackColor = System.Drawing.Color.Transparent;
            this.aiCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aiCharacter.Image = global::csharp2020.Properties.Resources.planet1;
            this.aiCharacter.Location = new System.Drawing.Point(423, 228);
            this.aiCharacter.Name = "aiCharacter";
            this.aiCharacter.Size = new System.Drawing.Size(100, 84);
            this.aiCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.aiCharacter.TabIndex = 26;
            this.aiCharacter.TabStop = false;
            // 
            // offensiveChoice
            // 
            this.offensiveChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offensiveChoice.Location = new System.Drawing.Point(31, 293);
            this.offensiveChoice.Name = "offensiveChoice";
            this.offensiveChoice.Size = new System.Drawing.Size(115, 50);
            this.offensiveChoice.TabIndex = 27;
            this.offensiveChoice.Text = "Offensive";
            this.offensiveChoice.UseVisualStyleBackColor = true;
            this.offensiveChoice.Click += new System.EventHandler(this.offensiveChoice_Click);
            // 
            // LblClassChoice
            // 
            this.LblClassChoice.AutoSize = true;
            this.LblClassChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClassChoice.Location = new System.Drawing.Point(204, 198);
            this.LblClassChoice.Name = "LblClassChoice";
            this.LblClassChoice.Size = new System.Drawing.Size(149, 24);
            this.LblClassChoice.TabIndex = 28;
            this.LblClassChoice.Text = "Choose A Class:";
            // 
            // sneakyChoice
            // 
            this.sneakyChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sneakyChoice.Location = new System.Drawing.Point(438, 293);
            this.sneakyChoice.Name = "sneakyChoice";
            this.sneakyChoice.Size = new System.Drawing.Size(115, 50);
            this.sneakyChoice.TabIndex = 29;
            this.sneakyChoice.Text = "Sneaky";
            this.sneakyChoice.UseVisualStyleBackColor = true;
            // 
            // controlChoice
            // 
            this.controlChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlChoice.Location = new System.Drawing.Point(302, 293);
            this.controlChoice.Name = "controlChoice";
            this.controlChoice.Size = new System.Drawing.Size(115, 50);
            this.controlChoice.TabIndex = 30;
            this.controlChoice.Text = "Control";
            this.controlChoice.UseVisualStyleBackColor = true;
            // 
            // defensiveChoice
            // 
            this.defensiveChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defensiveChoice.Location = new System.Drawing.Point(170, 293);
            this.defensiveChoice.Name = "defensiveChoice";
            this.defensiveChoice.Size = new System.Drawing.Size(115, 50);
            this.defensiveChoice.TabIndex = 31;
            this.defensiveChoice.Text = "Defensive";
            this.defensiveChoice.UseVisualStyleBackColor = true;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(225, 377);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(128, 73);
            this.confirmBtn.TabIndex = 32;
            this.confirmBtn.Text = "Confirm Class";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.codeRedeemer);
            this.Controls.Add(this.lblCodeRedeem);
            this.Controls.Add(this.highScoreLbl);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.instructButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtLives);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.mediumFButton);
            this.Controls.Add(this.easyNButton);
            this.Controls.Add(this.easyFButton);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.hardFButton);
            this.Controls.Add(this.hardNButton);
            this.Controls.Add(this.mediumNButton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.PnlGame.ResumeLayout(false);
            this.PnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrPlanet;
        private System.Windows.Forms.Timer TmrShip;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label txtLives;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button instructButton;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Button easyFButton;
        private System.Windows.Forms.Button hardFButton;
        private System.Windows.Forms.Button mediumFButton;
        private System.Windows.Forms.Button mediumNButton;
        private System.Windows.Forms.Button hardNButton;
        private System.Windows.Forms.Button easyNButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label highScoreLbl;
        private System.Windows.Forms.Label lblCodeRedeem;
        private System.Windows.Forms.TextBox codeRedeemer;
        private System.Windows.Forms.Timer tmrShoot;
        private System.Windows.Forms.Label LblFightAiHp;
        private System.Windows.Forms.Label UserHp;
        private System.Windows.Forms.Label EnemyHp;
        private System.Windows.Forms.Label LblFightUserHp;
        private System.Windows.Forms.PictureBox userCharacter;
        private System.Windows.Forms.PictureBox aiCharacter;
        private System.Windows.Forms.Button defensiveChoice;
        private System.Windows.Forms.Button controlChoice;
        private System.Windows.Forms.Button sneakyChoice;
        private System.Windows.Forms.Label LblClassChoice;
        private System.Windows.Forms.Button offensiveChoice;
        private System.Windows.Forms.Button confirmBtn;
    }
}

