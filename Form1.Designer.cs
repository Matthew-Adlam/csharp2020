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
            this.settingsButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Silver;
            this.PnlGame.Location = new System.Drawing.Point(1, 1);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(600, 500);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.lblLives.Location = new System.Drawing.Point(652, 369);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(13, 13);
            this.lblLives.TabIndex = 4;
            this.lblLives.Text = "3";
            // 
            // txtLives
            // 
            this.txtLives.AutoSize = true;
            this.txtLives.Location = new System.Drawing.Point(642, 341);
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
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(607, 142);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(115, 50);
            this.stopButton.TabIndex = 16;
            this.stopButton.Text = "Pause";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.stopButton);
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
        private System.Windows.Forms.Button stopButton;
    }
}

