namespace TicTacToe_SathurshanA
{
    partial class Form_TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TicTacToe));
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.pcbHoriLine1 = new System.Windows.Forms.PictureBox();
            this.pcbHoriLine2 = new System.Windows.Forms.PictureBox();
            this.pcbVertiLine1 = new System.Windows.Forms.PictureBox();
            this.pcbVertiLine2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.grpLevelDifficulty = new System.Windows.Forms.GroupBox();
            this.rdoHARD = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoEasy = new System.Windows.Forms.RadioButton();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.btnBoxOne = new System.Windows.Forms.Button();
            this.btnBoxTwo = new System.Windows.Forms.Button();
            this.btnBoxThree = new System.Windows.Forms.Button();
            this.btnBoxFour = new System.Windows.Forms.Button();
            this.btnBoxFive = new System.Windows.Forms.Button();
            this.btnBoxSix = new System.Windows.Forms.Button();
            this.btnBoxSeven = new System.Windows.Forms.Button();
            this.btnBoxEight = new System.Windows.Forms.Button();
            this.btnBoxNine = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDraws = new System.Windows.Forms.Label();
            this.lblNumDrawsDisplay = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHoriLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHoriLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVertiLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVertiLine2)).BeginInit();
            this.grpLevelDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGameTitle.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblGameTitle.Location = new System.Drawing.Point(214, 62);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(316, 44);
            this.lblGameTitle.TabIndex = 0;
            this.lblGameTitle.Text = "Pirate\'s Tic Tac Toe!";
            // 
            // pcbHoriLine1
            // 
            this.pcbHoriLine1.BackColor = System.Drawing.Color.Black;
            this.pcbHoriLine1.Location = new System.Drawing.Point(232, 179);
            this.pcbHoriLine1.Name = "pcbHoriLine1";
            this.pcbHoriLine1.Size = new System.Drawing.Size(272, 10);
            this.pcbHoriLine1.TabIndex = 4;
            this.pcbHoriLine1.TabStop = false;
            // 
            // pcbHoriLine2
            // 
            this.pcbHoriLine2.BackColor = System.Drawing.Color.Black;
            this.pcbHoriLine2.Location = new System.Drawing.Point(231, 253);
            this.pcbHoriLine2.Name = "pcbHoriLine2";
            this.pcbHoriLine2.Size = new System.Drawing.Size(275, 11);
            this.pcbHoriLine2.TabIndex = 5;
            this.pcbHoriLine2.TabStop = false;
            // 
            // pcbVertiLine1
            // 
            this.pcbVertiLine1.BackColor = System.Drawing.Color.Black;
            this.pcbVertiLine1.Location = new System.Drawing.Point(316, 108);
            this.pcbVertiLine1.Name = "pcbVertiLine1";
            this.pcbVertiLine1.Size = new System.Drawing.Size(10, 228);
            this.pcbVertiLine1.TabIndex = 6;
            this.pcbVertiLine1.TabStop = false;
            // 
            // pcbVertiLine2
            // 
            this.pcbVertiLine2.BackColor = System.Drawing.Color.Black;
            this.pcbVertiLine2.Location = new System.Drawing.Point(407, 109);
            this.pcbVertiLine2.Name = "pcbVertiLine2";
            this.pcbVertiLine2.Size = new System.Drawing.Size(10, 227);
            this.pcbVertiLine2.TabIndex = 7;
            this.pcbVertiLine2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.CadetBlue;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(78, 121);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 52);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRestart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestart.BackgroundImage")));
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(78, 195);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(129, 52);
            this.btnRestart.TabIndex = 15;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // grpLevelDifficulty
            // 
            this.grpLevelDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.grpLevelDifficulty.Controls.Add(this.rdoHARD);
            this.grpLevelDifficulty.Controls.Add(this.rdoMedium);
            this.grpLevelDifficulty.Controls.Add(this.rdoEasy);
            this.grpLevelDifficulty.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLevelDifficulty.Location = new System.Drawing.Point(519, 120);
            this.grpLevelDifficulty.Name = "grpLevelDifficulty";
            this.grpLevelDifficulty.Size = new System.Drawing.Size(169, 110);
            this.grpLevelDifficulty.TabIndex = 16;
            this.grpLevelDifficulty.TabStop = false;
            this.grpLevelDifficulty.Text = "LEVEL DIFFICULTY";
            // 
            // rdoHARD
            // 
            this.rdoHARD.AutoSize = true;
            this.rdoHARD.Location = new System.Drawing.Point(6, 78);
            this.rdoHARD.Name = "rdoHARD";
            this.rdoHARD.Size = new System.Drawing.Size(63, 21);
            this.rdoHARD.TabIndex = 2;
            this.rdoHARD.Text = "HARD";
            this.rdoHARD.UseVisualStyleBackColor = true;
            this.rdoHARD.CheckedChanged += new System.EventHandler(this.rdoHARD_CheckedChanged);
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(6, 51);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(77, 21);
            this.rdoMedium.TabIndex = 1;
            this.rdoMedium.Text = "MEDIUM";
            this.rdoMedium.UseVisualStyleBackColor = true;
            this.rdoMedium.CheckedChanged += new System.EventHandler(this.rdoMedium_CheckedChanged);
            // 
            // rdoEasy
            // 
            this.rdoEasy.AutoSize = true;
            this.rdoEasy.Location = new System.Drawing.Point(6, 24);
            this.rdoEasy.Name = "rdoEasy";
            this.rdoEasy.Size = new System.Drawing.Size(59, 21);
            this.rdoEasy.TabIndex = 0;
            this.rdoEasy.Text = "EASY";
            this.rdoEasy.UseVisualStyleBackColor = true;
            this.rdoEasy.CheckedChanged += new System.EventHandler(this.rdoEasy_CheckedChanged);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(530, 247);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(58, 20);
            this.lblScore.TabIndex = 17;
            this.lblScore.Text = "SCORE";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPlayer.Location = new System.Drawing.Point(530, 267);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(74, 20);
            this.lblPlayer.TabIndex = 18;
            this.lblPlayer.Text = "PLAYER:";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.BackColor = System.Drawing.Color.Transparent;
            this.lblComputer.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.ForeColor = System.Drawing.Color.Red;
            this.lblComputer.Location = new System.Drawing.Point(530, 287);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(99, 20);
            this.lblComputer.TabIndex = 19;
            this.lblComputer.Text = "COMPUTER:";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerScore.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(630, 267);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(81, 20);
            this.lblPlayerScore.TabIndex = 20;
            this.lblPlayerScore.Text = "---------";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerScore.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.Location = new System.Drawing.Point(630, 287);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(81, 20);
            this.lblComputerScore.TabIndex = 21;
            this.lblComputerScore.Text = "---------";
            // 
            // btnBoxOne
            // 
            this.btnBoxOne.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnBoxOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoxOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoxOne.Location = new System.Drawing.Point(241, 121);
            this.btnBoxOne.Name = "btnBoxOne";
            this.btnBoxOne.Size = new System.Drawing.Size(69, 52);
            this.btnBoxOne.TabIndex = 22;
            this.btnBoxOne.UseVisualStyleBackColor = false;
            this.btnBoxOne.Click += new System.EventHandler(this.btnBoxOne_Click);
            // 
            // btnBoxTwo
            // 
            this.btnBoxTwo.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnBoxTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoxTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoxTwo.Location = new System.Drawing.Point(332, 121);
            this.btnBoxTwo.Name = "btnBoxTwo";
            this.btnBoxTwo.Size = new System.Drawing.Size(69, 52);
            this.btnBoxTwo.TabIndex = 23;
            this.btnBoxTwo.UseVisualStyleBackColor = false;
            this.btnBoxTwo.Click += new System.EventHandler(this.btnBoxTwo_Click);
            // 
            // btnBoxThree
            // 
            this.btnBoxThree.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnBoxThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoxThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoxThree.Location = new System.Drawing.Point(423, 121);
            this.btnBoxThree.Name = "btnBoxThree";
            this.btnBoxThree.Size = new System.Drawing.Size(69, 52);
            this.btnBoxThree.TabIndex = 24;
            this.btnBoxThree.UseVisualStyleBackColor = false;
            this.btnBoxThree.Click += new System.EventHandler(this.btnBoxThree_Click);
            // 
            // btnBoxFour
            // 
            this.btnBoxFour.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnBoxFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoxFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoxFour.Location = new System.Drawing.Point(241, 195);
            this.btnBoxFour.Name = "btnBoxFour";
            this.btnBoxFour.Size = new System.Drawing.Size(69, 52);
            this.btnBoxFour.TabIndex = 25;
            this.btnBoxFour.UseVisualStyleBackColor = false;
            this.btnBoxFour.Click += new System.EventHandler(this.btnBoxFour_Click);
            // 
            // btnBoxFive
            // 
            this.btnBoxFive.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnBoxFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoxFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoxFive.Location = new System.Drawing.Point(332, 195);
            this.btnBoxFive.Name = "btnBoxFive";
            this.btnBoxFive.Size = new System.Drawing.Size(69, 52);
            this.btnBoxFive.TabIndex = 26;
            this.btnBoxFive.UseVisualStyleBackColor = false;
            this.btnBoxFive.Click += new System.EventHandler(this.btnBoxFive_Click);
            // 
            // btnBoxSix
            // 
            this.btnBoxSix.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnBoxSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoxSix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoxSix.Location = new System.Drawing.Point(423, 195);
            this.btnBoxSix.Name = "btnBoxSix";
            this.btnBoxSix.Size = new System.Drawing.Size(69, 52);
            this.btnBoxSix.TabIndex = 27;
            this.btnBoxSix.UseVisualStyleBackColor = false;
            this.btnBoxSix.Click += new System.EventHandler(this.btnBoxSix_Click);
            // 
            // btnBoxSeven
            // 
            this.btnBoxSeven.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnBoxSeven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoxSeven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoxSeven.Location = new System.Drawing.Point(241, 270);
            this.btnBoxSeven.Name = "btnBoxSeven";
            this.btnBoxSeven.Size = new System.Drawing.Size(69, 52);
            this.btnBoxSeven.TabIndex = 28;
            this.btnBoxSeven.UseVisualStyleBackColor = false;
            this.btnBoxSeven.Click += new System.EventHandler(this.btnBoxSeven_Click);
            // 
            // btnBoxEight
            // 
            this.btnBoxEight.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnBoxEight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoxEight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoxEight.Location = new System.Drawing.Point(332, 270);
            this.btnBoxEight.Name = "btnBoxEight";
            this.btnBoxEight.Size = new System.Drawing.Size(69, 52);
            this.btnBoxEight.TabIndex = 29;
            this.btnBoxEight.UseVisualStyleBackColor = false;
            this.btnBoxEight.Click += new System.EventHandler(this.btnBoxEight_Click);
            // 
            // btnBoxNine
            // 
            this.btnBoxNine.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnBoxNine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoxNine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoxNine.Location = new System.Drawing.Point(423, 270);
            this.btnBoxNine.Name = "btnBoxNine";
            this.btnBoxNine.Size = new System.Drawing.Size(69, 52);
            this.btnBoxNine.TabIndex = 30;
            this.btnBoxNine.UseVisualStyleBackColor = false;
            this.btnBoxNine.Click += new System.EventHandler(this.btnBoxNine_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(78, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 52);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDraws
            // 
            this.lblDraws.AutoSize = true;
            this.lblDraws.BackColor = System.Drawing.Color.Transparent;
            this.lblDraws.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraws.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDraws.Location = new System.Drawing.Point(530, 316);
            this.lblDraws.Name = "lblDraws";
            this.lblDraws.Size = new System.Drawing.Size(135, 20);
            this.lblDraws.TabIndex = 32;
            this.lblDraws.Text = "Number of Draws:";
            // 
            // lblNumDrawsDisplay
            // 
            this.lblNumDrawsDisplay.AutoSize = true;
            this.lblNumDrawsDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblNumDrawsDisplay.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDrawsDisplay.Location = new System.Drawing.Point(661, 316);
            this.lblNumDrawsDisplay.Name = "lblNumDrawsDisplay";
            this.lblNumDrawsDisplay.Size = new System.Drawing.Size(41, 20);
            this.lblNumDrawsDisplay.TabIndex = 33;
            this.lblNumDrawsDisplay.Text = "----";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMessage.Location = new System.Drawing.Point(196, 359);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(73, 20);
            this.lblMessage.TabIndex = 34;
            this.lblMessage.Text = "--------";
            // 
            // Form_TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe_SathurshanA.Pictures_Sa.Map_SA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 443);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblNumDrawsDisplay);
            this.Controls.Add(this.lblDraws);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBoxNine);
            this.Controls.Add(this.btnBoxEight);
            this.Controls.Add(this.btnBoxSeven);
            this.Controls.Add(this.btnBoxSix);
            this.Controls.Add(this.btnBoxFive);
            this.Controls.Add(this.btnBoxFour);
            this.Controls.Add(this.btnBoxThree);
            this.Controls.Add(this.btnBoxTwo);
            this.Controls.Add(this.btnBoxOne);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.grpLevelDifficulty);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pcbVertiLine2);
            this.Controls.Add(this.pcbVertiLine1);
            this.Controls.Add(this.pcbHoriLine2);
            this.Controls.Add(this.pcbHoriLine1);
            this.Controls.Add(this.lblGameTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_TicTacToe";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form_TicTacToe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbHoriLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHoriLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVertiLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVertiLine2)).EndInit();
            this.grpLevelDifficulty.ResumeLayout(false);
            this.grpLevelDifficulty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.PictureBox pcbHoriLine1;
        private System.Windows.Forms.PictureBox pcbHoriLine2;
        private System.Windows.Forms.PictureBox pcbVertiLine1;
        private System.Windows.Forms.PictureBox pcbVertiLine2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.GroupBox grpLevelDifficulty;
        private System.Windows.Forms.RadioButton rdoHARD;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoEasy;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Button btnBoxOne;
        private System.Windows.Forms.Button btnBoxTwo;
        private System.Windows.Forms.Button btnBoxThree;
        private System.Windows.Forms.Button btnBoxFour;
        private System.Windows.Forms.Button btnBoxFive;
        private System.Windows.Forms.Button btnBoxSix;
        private System.Windows.Forms.Button btnBoxSeven;
        private System.Windows.Forms.Button btnBoxEight;
        private System.Windows.Forms.Button btnBoxNine;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDraws;
        private System.Windows.Forms.Label lblNumDrawsDisplay;
        private System.Windows.Forms.Label lblMessage;
    }
}

