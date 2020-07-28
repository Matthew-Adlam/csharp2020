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
            this.userCharacter = new System.Windows.Forms.PictureBox();
            this.aiCharacter = new System.Windows.Forms.PictureBox();
            this.bossyLbl = new System.Windows.Forms.Label();
            this.controlBtn = new System.Windows.Forms.Button();
            this.offBtn = new System.Windows.Forms.Button();
            this.defButton = new System.Windows.Forms.Button();
            this.sneakyBtn = new System.Windows.Forms.Button();
            this.classLbl = new System.Windows.Forms.Label();
            this.conBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiCharacter)).BeginInit();
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
            this.lblName.Location = new System.Drawing.Point(627, 157);
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
            this.instructButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructButton.Location = new System.Drawing.Point(121, 157);
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
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = global::csharp2020.Properties.Resources.settings;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.Location = new System.Drawing.Point(0, 94);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 59);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
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
            // bossyLbl
            // 
            this.bossyLbl.AutoSize = true;
            this.bossyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bossyLbl.Location = new System.Drawing.Point(18, 46);
            this.bossyLbl.Name = "bossyLbl";
            this.bossyLbl.Size = new System.Drawing.Size(672, 25);
            this.bossyLbl.TabIndex = 18;
            this.bossyLbl.Text = "Welcome to Fight Club!  Press the instructions button for how to play!";
            // 
            // controlBtn
            // 
            this.controlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlBtn.Location = new System.Drawing.Point(256, 371);
            this.controlBtn.Name = "controlBtn";
            this.controlBtn.Size = new System.Drawing.Size(166, 50);
            this.controlBtn.TabIndex = 19;
            this.controlBtn.Text = "Control";
            this.controlBtn.UseVisualStyleBackColor = true;
            // 
            // offBtn
            // 
            this.offBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offBtn.Location = new System.Drawing.Point(256, 174);
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
            this.defButton.Location = new System.Drawing.Point(256, 239);
            this.defButton.Name = "defButton";
            this.defButton.Size = new System.Drawing.Size(166, 50);
            this.defButton.TabIndex = 21;
            this.defButton.Text = "Defensive";
            this.defButton.UseVisualStyleBackColor = true;
            // 
            // sneakyBtn
            // 
            this.sneakyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sneakyBtn.Location = new System.Drawing.Point(256, 304);
            this.sneakyBtn.Name = "sneakyBtn";
            this.sneakyBtn.Size = new System.Drawing.Size(166, 50);
            this.sneakyBtn.TabIndex = 22;
            this.sneakyBtn.Text = "Sneaky";
            this.sneakyBtn.UseVisualStyleBackColor = true;
            // 
            // classLbl
            // 
            this.classLbl.AutoSize = true;
            this.classLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLbl.Location = new System.Drawing.Point(81, 112);
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
            this.conBtn.Location = new System.Drawing.Point(256, 437);
            this.conBtn.Name = "conBtn";
            this.conBtn.Size = new System.Drawing.Size(166, 50);
            this.conBtn.TabIndex = 24;
            this.conBtn.Text = "Confirm";
            this.conBtn.UseVisualStyleBackColor = false;
            this.conBtn.Click += new System.EventHandler(this.conBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 489);
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
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.userCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiCharacter)).EndInit();
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
        private System.Windows.Forms.PictureBox userCharacter;
        private System.Windows.Forms.PictureBox aiCharacter;
        private System.Windows.Forms.Button defensiveChoice;
        private System.Windows.Forms.Button controlChoice;
        private System.Windows.Forms.Button sneakyChoice;
        private System.Windows.Forms.Label LblClassChoice;
        private System.Windows.Forms.Button offensiveChoice;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label bossyLbl;
        private System.Windows.Forms.Button controlBtn;
        private System.Windows.Forms.Button offBtn;
        private System.Windows.Forms.Button defButton;
        private System.Windows.Forms.Button sneakyBtn;
        private System.Windows.Forms.Label classLbl;
        private System.Windows.Forms.Button conBtn;
    }
}

