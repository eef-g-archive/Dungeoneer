namespace DungeonDelver
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.difficultySelect = new System.Windows.Forms.ComboBox();
            this.loadGameButton = new System.Windows.Forms.Button();
            this.savedGamesList = new System.Windows.Forms.ComboBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBlockingIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // fightButton
            // 
            this.fightButton.Location = new System.Drawing.Point(8, 428);
            this.fightButton.Margin = new System.Windows.Forms.Padding(2);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(185, 64);
            this.fightButton.TabIndex = 0;
            this.fightButton.Text = "FIGHT";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundImage
            // 
            this.backgroundImage.Image = global::DungeonDelver.Properties.Resources.Wall;
            this.backgroundImage.Location = new System.Drawing.Point(8, 12);
            this.backgroundImage.Name = "backgroundImage";
            this.backgroundImage.Size = new System.Drawing.Size(382, 278);
            this.backgroundImage.TabIndex = 1;
            this.backgroundImage.TabStop = false;
            // 
            // blockButton
            // 
            this.blockButton.Location = new System.Drawing.Point(8, 496);
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
            this.healButton.Location = new System.Drawing.Point(205, 428);
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
            this.statusText.Location = new System.Drawing.Point(6, 347);
            this.statusText.Name = "statusText";
            this.statusText.ReadOnly = true;
            this.statusText.Size = new System.Drawing.Size(382, 80);
            this.statusText.TabIndex = 5;
            this.statusText.Text = "> This is a test to see how the status text will be\n> [ALERT] Low Health\n> [LOOT]" +
    " You got a sword\n> Action Text\n> [RESULTS] XP Gain";
            // 
            // imageDisplay
            // 
            this.imageDisplay.BackColor = System.Drawing.Color.Transparent;
            this.imageDisplay.BackgroundImage = global::DungeonDelver.Properties.Resources.CreatureBackground;
            this.imageDisplay.Location = new System.Drawing.Point(113, 94);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(184, 196);
            this.imageDisplay.TabIndex = 6;
            this.imageDisplay.TabStop = false;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(205, 496);
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
            this.playerHPText.Location = new System.Drawing.Point(91, 311);
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
            this.playerHealthText.Location = new System.Drawing.Point(91, 295);
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
            this.playerBlockingIcon.Location = new System.Drawing.Point(342, 296);
            this.playerBlockingIcon.Name = "playerBlockingIcon";
            this.playerBlockingIcon.Size = new System.Drawing.Size(45, 28);
            this.playerBlockingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerBlockingIcon.TabIndex = 11;
            this.playerBlockingIcon.TabStop = false;
            this.playerBlockingIcon.Visible = false;
            // 
            // playerIcon
            // 
            this.playerIcon.BackColor = System.Drawing.Color.Transparent;
            this.playerIcon.Image = global::DungeonDelver.Properties.Resources.Gooblinv1;
            this.playerIcon.Location = new System.Drawing.Point(8, 292);
            this.playerIcon.Name = "playerIcon";
            this.playerIcon.Size = new System.Drawing.Size(79, 53);
            this.playerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerIcon.TabIndex = 10;
            this.playerIcon.TabStop = false;
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.ForeColor = System.Drawing.Color.Lime;
            this.playerHealthBar.Location = new System.Drawing.Point(92, 325);
            this.playerHealthBar.Margin = new System.Windows.Forms.Padding(2);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(295, 19);
            this.playerHealthBar.TabIndex = 9;
            // 
            // monsterHealthBar
            // 
            this.monsterHealthBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monsterHealthBar.ForeColor = System.Drawing.Color.Crimson;
            this.monsterHealthBar.Location = new System.Drawing.Point(113, 76);
            this.monsterHealthBar.Margin = new System.Windows.Forms.Padding(2);
            this.monsterHealthBar.Name = "monsterHealthBar";
            this.monsterHealthBar.Size = new System.Drawing.Size(184, 20);
            this.monsterHealthBar.TabIndex = 8;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.label4);
            this.menuPanel.Controls.Add(this.label3);
            this.menuPanel.Controls.Add(this.pictureBox2);
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Controls.Add(this.label2);
            this.menuPanel.Controls.Add(this.difficultySelect);
            this.menuPanel.Controls.Add(this.loadGameButton);
            this.menuPanel.Controls.Add(this.savedGamesList);
            this.menuPanel.Controls.Add(this.newGameButton);
            this.menuPanel.Controls.Add(this.userNameInput);
            this.menuPanel.Controls.Add(this.pictureBox3);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Location = new System.Drawing.Point(-6, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(431, 576);
            this.menuPanel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(159, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Difficulty Select";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(236, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Load Game";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DungeonDelver.Properties.Resources.Gooblinv1;
            this.pictureBox2.Location = new System.Drawing.Point(223, 374);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DungeonDelver.Properties.Resources.Slimev1;
            this.pictureBox1.Location = new System.Drawing.Point(34, 368);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "New Game";
            // 
            // difficultySelect
            // 
            this.difficultySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultySelect.FormattingEnabled = true;
            this.difficultySelect.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Extra Hard"});
            this.difficultySelect.Location = new System.Drawing.Point(167, 164);
            this.difficultySelect.Margin = new System.Windows.Forms.Padding(2);
            this.difficultySelect.Name = "difficultySelect";
            this.difficultySelect.Size = new System.Drawing.Size(157, 23);
            this.difficultySelect.TabIndex = 8;
            // 
            // loadGameButton
            // 
            this.loadGameButton.Location = new System.Drawing.Point(231, 331);
            this.loadGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Size = new System.Drawing.Size(106, 39);
            this.loadGameButton.TabIndex = 7;
            this.loadGameButton.Text = "Continue As This Adventurer";
            this.loadGameButton.UseVisualStyleBackColor = true;
            this.loadGameButton.Click += new System.EventHandler(this.loadGameButton_Click);
            // 
            // savedGamesList
            // 
            this.savedGamesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.savedGamesList.FormattingEnabled = true;
            this.savedGamesList.Location = new System.Drawing.Point(205, 303);
            this.savedGamesList.Margin = new System.Windows.Forms.Padding(2);
            this.savedGamesList.Name = "savedGamesList";
            this.savedGamesList.Size = new System.Drawing.Size(157, 23);
            this.savedGamesList.TabIndex = 6;
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(44, 328);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(106, 39);
            this.newGameButton.TabIndex = 5;
            this.newGameButton.Text = "Begin As This Adventurer";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(17, 303);
            this.userNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(157, 23);
            this.userNameInput.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DungeonDelver.Properties.Resources.Loanv1;
            this.pictureBox3.Location = new System.Drawing.Point(34, 94);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RuneScape UF", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ethan\'s Dungeon Delver";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resultsPanel
            // 
            this.resultsPanel.Location = new System.Drawing.Point(0, 0);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(408, 578);
            this.resultsPanel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 570);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.resultsPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Dungen Delver";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBlockingIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox difficultySelect;
        private Button loadGameButton;
        private ComboBox savedGamesList;
        private Button newGameButton;
        private TextBox userNameInput;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private ProgressBar monsterHealthBar;
        private ProgressBar playerHealthBar;
        private PictureBox playerBlockingIcon;
        private PictureBox playerIcon;
        private Label playerHealthText;
        private Label playerHPText;
        private Panel resultsPanel;
    }
}