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
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
            this.gamePanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // fightButton
            // 
            this.fightButton.Location = new System.Drawing.Point(11, 670);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(264, 135);
            this.fightButton.TabIndex = 0;
            this.fightButton.Text = "FIGHT";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundImage
            // 
            this.backgroundImage.Image = global::DungeonDelver.Properties.Resources.Wall;
            this.backgroundImage.Location = new System.Drawing.Point(11, 20);
            this.backgroundImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backgroundImage.Name = "backgroundImage";
            this.backgroundImage.Size = new System.Drawing.Size(546, 463);
            this.backgroundImage.TabIndex = 1;
            this.backgroundImage.TabStop = false;
            // 
            // blockButton
            // 
            this.blockButton.Location = new System.Drawing.Point(293, 670);
            this.blockButton.Name = "blockButton";
            this.blockButton.Size = new System.Drawing.Size(264, 135);
            this.blockButton.TabIndex = 2;
            this.blockButton.Text = "BLOCK";
            this.blockButton.UseVisualStyleBackColor = true;
            this.blockButton.Click += new System.EventHandler(this.blockButton_Click);
            // 
            // healButton
            // 
            this.healButton.Location = new System.Drawing.Point(11, 812);
            this.healButton.Name = "healButton";
            this.healButton.Size = new System.Drawing.Size(264, 135);
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
            this.statusText.Location = new System.Drawing.Point(11, 493);
            this.statusText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusText.Name = "statusText";
            this.statusText.ReadOnly = true;
            this.statusText.Size = new System.Drawing.Size(544, 166);
            this.statusText.TabIndex = 5;
            this.statusText.Text = "> This is a test to see how the status text will be\n> [ALERT] Low Health\n> [LOOT]" +
    " You got a sword\n> Action Text\n> [RESULTS] XP Gain";
            // 
            // imageDisplay
            // 
            this.imageDisplay.BackColor = System.Drawing.Color.Transparent;
            this.imageDisplay.BackgroundImage = global::DungeonDelver.Properties.Resources.CreatureBackground;
            this.imageDisplay.Location = new System.Drawing.Point(161, 157);
            this.imageDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(263, 327);
            this.imageDisplay.TabIndex = 6;
            this.imageDisplay.TabStop = false;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(293, 812);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(264, 135);
            this.runButton.TabIndex = 7;
            this.runButton.Text = "RUN";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.monsterHealthBar);
            this.gamePanel.Controls.Add(this.imageDisplay);
            this.gamePanel.Controls.Add(this.backgroundImage);
            this.gamePanel.Controls.Add(this.blockButton);
            this.gamePanel.Controls.Add(this.healButton);
            this.gamePanel.Controls.Add(this.statusText);
            this.gamePanel.Controls.Add(this.runButton);
            this.gamePanel.Controls.Add(this.fightButton);
            this.gamePanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.gamePanel.Location = new System.Drawing.Point(8, 14);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(554, 933);
            this.gamePanel.TabIndex = 8;
            // 
            // monsterHealthBar
            // 
            this.monsterHealthBar.Location = new System.Drawing.Point(161, 126);
            this.monsterHealthBar.Name = "monsterHealthBar";
            this.monsterHealthBar.Size = new System.Drawing.Size(263, 34);
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
            this.menuPanel.Location = new System.Drawing.Point(8, 14);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(557, 933);
            this.menuPanel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(227, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "Difficulty Select";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(337, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Load Game";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DungeonDelver.Properties.Resources.Gooblinv1;
            this.pictureBox2.Location = new System.Drawing.Point(319, 623);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 160);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DungeonDelver.Properties.Resources.Slimev1;
            this.pictureBox1.Location = new System.Drawing.Point(48, 613);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 160);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 36);
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
            this.difficultySelect.Location = new System.Drawing.Point(239, 274);
            this.difficultySelect.Name = "difficultySelect";
            this.difficultySelect.Size = new System.Drawing.Size(222, 33);
            this.difficultySelect.TabIndex = 8;
            // 
            // loadGameButton
            // 
            this.loadGameButton.Location = new System.Drawing.Point(330, 552);
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Size = new System.Drawing.Size(151, 65);
            this.loadGameButton.TabIndex = 7;
            this.loadGameButton.Text = "Continue As This Adventurer";
            this.loadGameButton.UseVisualStyleBackColor = true;
            this.loadGameButton.Click += new System.EventHandler(this.loadGameButton_Click);
            // 
            // savedGamesList
            // 
            this.savedGamesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.savedGamesList.FormattingEnabled = true;
            this.savedGamesList.Location = new System.Drawing.Point(293, 505);
            this.savedGamesList.Name = "savedGamesList";
            this.savedGamesList.Size = new System.Drawing.Size(222, 33);
            this.savedGamesList.TabIndex = 6;
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(69, 542);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(151, 65);
            this.newGameButton.TabIndex = 5;
            this.newGameButton.Text = "Begin As This Adventurer";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(24, 505);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(222, 31);
            this.userNameInput.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DungeonDelver.Properties.Resources.Loanv1;
            this.pictureBox3.Location = new System.Drawing.Point(48, 157);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(172, 160);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RuneScape UF", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ethan\'s Dungeon Delver";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 950);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.gamePanel);
            this.Name = "Form1";
            this.Text = "Dungen Delver";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
            this.gamePanel.ResumeLayout(false);
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
    }
}