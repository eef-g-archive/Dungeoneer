namespace DungeonDelver.View
{
    partial class DungeonView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DungeonView));
            this.fightButton = new System.Windows.Forms.Button();
            this.backgroundImage = new System.Windows.Forms.PictureBox();
            this.blockButton = new System.Windows.Forms.Button();
            this.healButton = new System.Windows.Forms.Button();
            this.statusText = new System.Windows.Forms.RichTextBox();
            this.imageDisplay = new System.Windows.Forms.PictureBox();
            this.runButton = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.playerHPText = new System.Windows.Forms.Label();
            this.playerHealthText = new System.Windows.Forms.Label();
            this.playerBlockingIcon = new System.Windows.Forms.PictureBox();
            this.playerIcon = new System.Windows.Forms.PictureBox();
            this.playerHealthBar = new System.Windows.Forms.ProgressBar();
            this.monsterHealthBar = new System.Windows.Forms.ProgressBar();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.newGameLabel = new System.Windows.Forms.Label();
            this.loadChoiceButton = new System.Windows.Forms.Button();
            this.newChoiceButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.loadLabel = new System.Windows.Forms.Label();
            this.difficultyImage = new System.Windows.Forms.PictureBox();
            this.difficultySelect = new System.Windows.Forms.ComboBox();
            this.loadGameButton = new System.Windows.Forms.Button();
            this.savedGamesList = new System.Windows.Forms.ComboBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBlockingIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyImage)).BeginInit();
            this.resultsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fightButton
            // 
            this.fightButton.BackColor = System.Drawing.Color.Transparent;
            this.fightButton.BackgroundImage = global::DungeonDelver.Properties.Resources.ButtonBG;
            this.fightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fightButton.Font = new System.Drawing.Font("RuneScape UF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fightButton.ForeColor = System.Drawing.Color.Gold;
            this.fightButton.Location = new System.Drawing.Point(11, 437);
            this.fightButton.Margin = new System.Windows.Forms.Padding(2);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(185, 63);
            this.fightButton.TabIndex = 0;
            this.fightButton.Text = "FIGHT";
            this.fightButton.UseVisualStyleBackColor = false;
            this.fightButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundImage
            // 
            this.backgroundImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(129)))), ((int)(((byte)(109)))));
            this.backgroundImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundImage.Image = global::DungeonDelver.Properties.Resources.Wall;
            this.backgroundImage.Location = new System.Drawing.Point(0, -1);
            this.backgroundImage.Name = "backgroundImage";
            this.backgroundImage.Size = new System.Drawing.Size(409, 293);
            this.backgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundImage.TabIndex = 1;
            this.backgroundImage.TabStop = false;
            // 
            // blockButton
            // 
            this.blockButton.BackgroundImage = global::DungeonDelver.Properties.Resources.ButtonBG;
            this.blockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blockButton.FlatAppearance.BorderSize = 0;
            this.blockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blockButton.Font = new System.Drawing.Font("RuneScape UF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blockButton.ForeColor = System.Drawing.Color.Gold;
            this.blockButton.Location = new System.Drawing.Point(11, 502);
            this.blockButton.Margin = new System.Windows.Forms.Padding(2);
            this.blockButton.Name = "blockButton";
            this.blockButton.Size = new System.Drawing.Size(185, 64);
            this.blockButton.TabIndex = 2;
            this.blockButton.Text = "BLOCK";
            this.blockButton.UseVisualStyleBackColor = true;
            this.blockButton.Click += new System.EventHandler(this.blockButton_Click);
            // 
            // healButton
            // 
            this.healButton.BackgroundImage = global::DungeonDelver.Properties.Resources.ButtonBG;
            this.healButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.healButton.FlatAppearance.BorderSize = 0;
            this.healButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.healButton.Font = new System.Drawing.Font("RuneScape UF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.healButton.ForeColor = System.Drawing.Color.Gold;
            this.healButton.Location = new System.Drawing.Point(208, 436);
            this.healButton.Margin = new System.Windows.Forms.Padding(2);
            this.healButton.Name = "healButton";
            this.healButton.Size = new System.Drawing.Size(185, 64);
            this.healButton.TabIndex = 3;
            this.healButton.Text = "HEAL";
            this.healButton.UseVisualStyleBackColor = true;
            this.healButton.Click += new System.EventHandler(this.healButton_Click);
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusText.Font = new System.Drawing.Font("RuneScape UF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusText.ForeColor = System.Drawing.Color.Gold;
            this.statusText.Location = new System.Drawing.Point(11, 350);
            this.statusText.Name = "statusText";
            this.statusText.ReadOnly = true;
            this.statusText.Size = new System.Drawing.Size(382, 83);
            this.statusText.TabIndex = 5;
            this.statusText.Text = "> This is a test to see how the status text will be\n> [ALERT] Low Health\n> [LOOT]" +
    " You got a sword\n> Action Text\n> [RESULTS] XP Gain";
            // 
            // imageDisplay
            // 
            this.imageDisplay.BackColor = System.Drawing.Color.Transparent;
            this.imageDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageDisplay.Location = new System.Drawing.Point(126, 79);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(184, 213);
            this.imageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageDisplay.TabIndex = 6;
            this.imageDisplay.TabStop = false;
            // 
            // runButton
            // 
            this.runButton.BackgroundImage = global::DungeonDelver.Properties.Resources.ButtonBG;
            this.runButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.runButton.FlatAppearance.BorderSize = 0;
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runButton.Font = new System.Drawing.Font("RuneScape UF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.runButton.ForeColor = System.Drawing.Color.Gold;
            this.runButton.Location = new System.Drawing.Point(208, 503);
            this.runButton.Margin = new System.Windows.Forms.Padding(2);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(185, 64);
            this.runButton.TabIndex = 7;
            this.runButton.Text = "RUN";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(129)))), ((int)(((byte)(109)))));
            this.gamePanel.Controls.Add(this.playerHPText);
            this.gamePanel.Controls.Add(this.playerHealthText);
            this.gamePanel.Controls.Add(this.playerBlockingIcon);
            this.gamePanel.Controls.Add(this.playerIcon);
            this.gamePanel.Controls.Add(this.playerHealthBar);
            this.gamePanel.Controls.Add(this.monsterHealthBar);
            this.gamePanel.Controls.Add(this.imageDisplay);
            this.gamePanel.Controls.Add(this.backgroundImage);
            this.gamePanel.Controls.Add(this.fightButton);
            this.gamePanel.Controls.Add(this.blockButton);
            this.gamePanel.Controls.Add(this.healButton);
            this.gamePanel.Controls.Add(this.statusText);
            this.gamePanel.Controls.Add(this.runButton);
            this.gamePanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.gamePanel.Location = new System.Drawing.Point(-4, 0);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(412, 574);
            this.gamePanel.TabIndex = 8;
            // 
            // playerHPText
            // 
            this.playerHPText.AutoSize = true;
            this.playerHPText.Font = new System.Drawing.Font("RuneScape UF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerHPText.ForeColor = System.Drawing.Color.Gold;
            this.playerHPText.Location = new System.Drawing.Point(96, 311);
            this.playerHPText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerHPText.Name = "playerHPText";
            this.playerHPText.Size = new System.Drawing.Size(231, 15);
            this.playerHPText.TabIndex = 13;
            this.playerHPText.Text = "{player.Health} \\ {player.max_health}";
            // 
            // playerHealthText
            // 
            this.playerHealthText.AutoSize = true;
            this.playerHealthText.Font = new System.Drawing.Font("RuneScape UF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerHealthText.ForeColor = System.Drawing.Color.Gold;
            this.playerHealthText.Location = new System.Drawing.Point(96, 295);
            this.playerHealthText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerHealthText.Name = "playerHealthText";
            this.playerHealthText.Size = new System.Drawing.Size(144, 15);
            this.playerHealthText.TabIndex = 12;
            this.playerHealthText.Text = "{player.Name}\'s Health ";
            // 
            // playerBlockingIcon
            // 
            this.playerBlockingIcon.BackColor = System.Drawing.Color.Transparent;
            this.playerBlockingIcon.Image = global::DungeonDelver.Properties.Resources.Shield_icon;
            this.playerBlockingIcon.Location = new System.Drawing.Point(347, 295);
            this.playerBlockingIcon.Name = "playerBlockingIcon";
            this.playerBlockingIcon.Size = new System.Drawing.Size(45, 28);
            this.playerBlockingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerBlockingIcon.TabIndex = 11;
            this.playerBlockingIcon.TabStop = false;
            this.playerBlockingIcon.Visible = false;
            // 
            // playerIcon
            // 
            this.playerIcon.BackColor = System.Drawing.Color.SeaShell;
            this.playerIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerIcon.Image = global::DungeonDelver.Properties.Resources.PlayerSprite;
            this.playerIcon.Location = new System.Drawing.Point(13, 294);
            this.playerIcon.Name = "playerIcon";
            this.playerIcon.Size = new System.Drawing.Size(79, 53);
            this.playerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerIcon.TabIndex = 10;
            this.playerIcon.TabStop = false;
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.ForeColor = System.Drawing.Color.Lime;
            this.playerHealthBar.Location = new System.Drawing.Point(97, 328);
            this.playerHealthBar.Margin = new System.Windows.Forms.Padding(2);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(295, 19);
            this.playerHealthBar.TabIndex = 9;
            // 
            // monsterHealthBar
            // 
            this.monsterHealthBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monsterHealthBar.ForeColor = System.Drawing.Color.Crimson;
            this.monsterHealthBar.Location = new System.Drawing.Point(126, 64);
            this.monsterHealthBar.Margin = new System.Windows.Forms.Padding(2);
            this.monsterHealthBar.Name = "monsterHealthBar";
            this.monsterHealthBar.Size = new System.Drawing.Size(184, 20);
            this.monsterHealthBar.TabIndex = 8;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuPanel.BackgroundImage = global::DungeonDelver.Properties.Resources.mainMenu2;
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPanel.Controls.Add(this.backButton);
            this.menuPanel.Controls.Add(this.newGameLabel);
            this.menuPanel.Controls.Add(this.loadChoiceButton);
            this.menuPanel.Controls.Add(this.newChoiceButton);
            this.menuPanel.Controls.Add(this.startButton);
            this.menuPanel.Controls.Add(this.difficultyLabel);
            this.menuPanel.Controls.Add(this.loadLabel);
            this.menuPanel.Controls.Add(this.difficultyImage);
            this.menuPanel.Controls.Add(this.difficultySelect);
            this.menuPanel.Controls.Add(this.loadGameButton);
            this.menuPanel.Controls.Add(this.savedGamesList);
            this.menuPanel.Controls.Add(this.newGameButton);
            this.menuPanel.Controls.Add(this.userNameInput);
            this.menuPanel.Controls.Add(this.titleLabel);
            this.menuPanel.Location = new System.Drawing.Point(-6, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(414, 576);
            this.menuPanel.TabIndex = 8;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(130)))), ((int)(((byte)(113)))));
            this.backButton.Enabled = false;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("RuneScape UF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.ForeColor = System.Drawing.Color.Gold;
            this.backButton.Location = new System.Drawing.Point(282, 436);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(58, 25);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newGameLabel
            // 
            this.newGameLabel.AutoSize = true;
            this.newGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.newGameLabel.Enabled = false;
            this.newGameLabel.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newGameLabel.ForeColor = System.Drawing.Color.Gold;
            this.newGameLabel.Location = new System.Drawing.Point(109, 361);
            this.newGameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newGameLabel.Name = "newGameLabel";
            this.newGameLabel.Size = new System.Drawing.Size(184, 24);
            this.newGameLabel.TabIndex = 15;
            this.newGameLabel.Text = "Adventurer\'s Name";
            this.newGameLabel.Visible = false;
            // 
            // loadChoiceButton
            // 
            this.loadChoiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(130)))), ((int)(((byte)(113)))));
            this.loadChoiceButton.Enabled = false;
            this.loadChoiceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.loadChoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadChoiceButton.Font = new System.Drawing.Font("RuneScape UF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadChoiceButton.ForeColor = System.Drawing.Color.Gold;
            this.loadChoiceButton.Location = new System.Drawing.Point(138, 317);
            this.loadChoiceButton.Name = "loadChoiceButton";
            this.loadChoiceButton.Size = new System.Drawing.Size(121, 27);
            this.loadChoiceButton.TabIndex = 14;
            this.loadChoiceButton.Text = "Load Game";
            this.loadChoiceButton.UseVisualStyleBackColor = false;
            this.loadChoiceButton.Visible = false;
            this.loadChoiceButton.Click += new System.EventHandler(this.loadChoiceButton_Click);
            // 
            // newChoiceButton
            // 
            this.newChoiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(130)))), ((int)(((byte)(113)))));
            this.newChoiceButton.Enabled = false;
            this.newChoiceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.newChoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newChoiceButton.Font = new System.Drawing.Font("RuneScape UF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newChoiceButton.ForeColor = System.Drawing.Color.Gold;
            this.newChoiceButton.Location = new System.Drawing.Point(138, 289);
            this.newChoiceButton.Name = "newChoiceButton";
            this.newChoiceButton.Size = new System.Drawing.Size(121, 27);
            this.newChoiceButton.TabIndex = 13;
            this.newChoiceButton.Text = "New Game";
            this.newChoiceButton.UseVisualStyleBackColor = false;
            this.newChoiceButton.Visible = false;
            this.newChoiceButton.Click += new System.EventHandler(this.newChoiceButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(130)))), ((int)(((byte)(113)))));
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("RuneScape UF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.Gold;
            this.startButton.Location = new System.Drawing.Point(138, 299);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(121, 27);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.BackColor = System.Drawing.Color.Transparent;
            this.difficultyLabel.Enabled = false;
            this.difficultyLabel.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difficultyLabel.ForeColor = System.Drawing.Color.Gold;
            this.difficultyLabel.Location = new System.Drawing.Point(118, 262);
            this.difficultyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(159, 24);
            this.difficultyLabel.TabIndex = 11;
            this.difficultyLabel.Text = "Difficulty Select";
            this.difficultyLabel.Visible = false;
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadLabel.Enabled = false;
            this.loadLabel.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadLabel.ForeColor = System.Drawing.Color.Gold;
            this.loadLabel.Location = new System.Drawing.Point(138, 362);
            this.loadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(106, 24);
            this.loadLabel.TabIndex = 10;
            this.loadLabel.Text = "Load Game";
            this.loadLabel.Visible = false;
            // 
            // difficultyImage
            // 
            this.difficultyImage.BackColor = System.Drawing.Color.Transparent;
            this.difficultyImage.Image = global::DungeonDelver.Properties.Resources.Slimev1;
            this.difficultyImage.Location = new System.Drawing.Point(148, 466);
            this.difficultyImage.Margin = new System.Windows.Forms.Padding(2);
            this.difficultyImage.Name = "difficultyImage";
            this.difficultyImage.Size = new System.Drawing.Size(119, 106);
            this.difficultyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.difficultyImage.TabIndex = 1;
            this.difficultyImage.TabStop = false;
            // 
            // difficultySelect
            // 
            this.difficultySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultySelect.Enabled = false;
            this.difficultySelect.FormattingEnabled = true;
            this.difficultySelect.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Extra Hard"});
            this.difficultySelect.Location = new System.Drawing.Point(118, 286);
            this.difficultySelect.Margin = new System.Windows.Forms.Padding(2);
            this.difficultySelect.Name = "difficultySelect";
            this.difficultySelect.Size = new System.Drawing.Size(157, 23);
            this.difficultySelect.TabIndex = 8;
            this.difficultySelect.Visible = false;
            this.difficultySelect.SelectedIndexChanged += new System.EventHandler(this.difficultySelect_SelectedIndexChanged);
            // 
            // loadGameButton
            // 
            this.loadGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(130)))), ((int)(((byte)(113)))));
            this.loadGameButton.Enabled = false;
            this.loadGameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.loadGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadGameButton.Font = new System.Drawing.Font("RuneScape UF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadGameButton.ForeColor = System.Drawing.Color.Gold;
            this.loadGameButton.Location = new System.Drawing.Point(118, 415);
            this.loadGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Size = new System.Drawing.Size(159, 47);
            this.loadGameButton.TabIndex = 7;
            this.loadGameButton.Text = "Continue As This Adventurer";
            this.loadGameButton.UseVisualStyleBackColor = false;
            this.loadGameButton.Visible = false;
            this.loadGameButton.Click += new System.EventHandler(this.loadGameButton_Click);
            // 
            // savedGamesList
            // 
            this.savedGamesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.savedGamesList.Enabled = false;
            this.savedGamesList.FormattingEnabled = true;
            this.savedGamesList.Location = new System.Drawing.Point(118, 388);
            this.savedGamesList.Margin = new System.Windows.Forms.Padding(2);
            this.savedGamesList.Name = "savedGamesList";
            this.savedGamesList.Size = new System.Drawing.Size(157, 23);
            this.savedGamesList.TabIndex = 6;
            this.savedGamesList.Visible = false;
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(130)))), ((int)(((byte)(113)))));
            this.newGameButton.Enabled = false;
            this.newGameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameButton.Font = new System.Drawing.Font("RuneScape UF", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newGameButton.ForeColor = System.Drawing.Color.Gold;
            this.newGameButton.Location = new System.Drawing.Point(118, 415);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(159, 47);
            this.newGameButton.TabIndex = 5;
            this.newGameButton.Text = "Begin As This Adventurer";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Visible = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // userNameInput
            // 
            this.userNameInput.Enabled = false;
            this.userNameInput.Font = new System.Drawing.Font("RuneScape UF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameInput.Location = new System.Drawing.Point(118, 388);
            this.userNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(157, 22);
            this.userNameInput.TabIndex = 4;
            this.userNameInput.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("RuneScape UF", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.Gold;
            this.titleLabel.Location = new System.Drawing.Point(54, 186);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(303, 64);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Dungeoneer";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resultsPanel
            // 
            this.resultsPanel.Controls.Add(this.richTextBox1);
            this.resultsPanel.Controls.Add(this.label1);
            this.resultsPanel.Location = new System.Drawing.Point(0, 0);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(408, 578);
            this.resultsPanel.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("RuneScape UF", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(35, 64);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(332, 349);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Room 1 ......................................................................1500" +
    "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 570);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.resultsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Dungeoneer";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBlockingIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyImage)).EndInit();
            this.resultsPanel.ResumeLayout(false);
            this.resultsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button fightButton;
        private PictureBox backgroundImage;
        private Button blockButton;
        private Button healButton;
        private RichTextBox statusText;
        private PictureBox imageDisplay;
        private Button runButton;
        private Panel gamePanel;
        private Panel menuPanel;
        private Label difficultyLabel;
        private Label loadLabel;
        private ComboBox difficultySelect;
        private Button loadGameButton;
        private ComboBox savedGamesList;
        private Button newGameButton;
        private TextBox userNameInput;
        private PictureBox difficultyImage;
        private Label titleLabel;
        private ProgressBar monsterHealthBar;
        private ProgressBar playerHealthBar;
        private PictureBox playerBlockingIcon;
        private PictureBox playerIcon;
        private Label playerHealthText;
        private Label playerHPText;
        private Panel resultsPanel;
        private Button startButton;
        private Button loadChoiceButton;
        private Button newChoiceButton;
        private Label newGameLabel;
        private Button backButton;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}