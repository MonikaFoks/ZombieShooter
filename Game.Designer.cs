namespace MonikaFoksLab1Zadanie
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.exitGameButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.zombie1 = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.missedShotLabel = new System.Windows.Forms.Label();
            this.totalShotsLabel = new System.Windows.Forms.Label();
            this.firstZombieTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimeLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pupper = new System.Windows.Forms.PictureBox();
            this.pupperTimer = new System.Windows.Forms.Timer(this.components);
            this.badShotLabel = new System.Windows.Forms.Label();
            this.pupperOnBoardTimer = new System.Windows.Forms.Timer(this.components);
            this.labelsTimer = new System.Windows.Forms.Timer(this.components);
            this.zombie2 = new System.Windows.Forms.PictureBox();
            this.secondZombieTimer = new System.Windows.Forms.Timer(this.components);
            this.bat = new System.Windows.Forms.PictureBox();
            this.batTimer = new System.Windows.Forms.Timer(this.components);
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.firstZombieVisibleTimer = new System.Windows.Forms.Timer(this.components);
            this.secondZombieVisibleTimer = new System.Windows.Forms.Timer(this.components);
            this.batVisibleTimer = new System.Windows.Forms.Timer(this.components);
            this.jumpScarePic = new System.Windows.Forms.PictureBox();
            this.jumpscareTimer = new System.Windows.Forms.Timer(this.components);
            this.jumpScareJumpTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zombie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpScarePic)).BeginInit();
            this.SuspendLayout();
            // 
            // exitGameButton
            // 
            this.exitGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitGameButton.Font = new System.Drawing.Font("Chiller", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitGameButton.Location = new System.Drawing.Point(823, 12);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(75, 27);
            this.exitGameButton.TabIndex = 0;
            this.exitGameButton.Text = "EXIT";
            this.exitGameButton.UseVisualStyleBackColor = false;
            this.exitGameButton.Click += new System.EventHandler(this.exitGameButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.restartButton.Font = new System.Drawing.Font("Chiller", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(804, 45);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(94, 30);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "RESTART";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // zombie1
            // 
            this.zombie1.BackColor = System.Drawing.Color.Transparent;
            this.zombie1.Image = global::MonikaFoksLab1Zadanie.Properties.Resources.Zombie_High_Quality_PNG;
            this.zombie1.Location = new System.Drawing.Point(363, 322);
            this.zombie1.Name = "zombie1";
            this.zombie1.Size = new System.Drawing.Size(112, 189);
            this.zombie1.TabIndex = 3;
            this.zombie1.TabStop = false;
            this.zombie1.Visible = false;
            this.zombie1.Click += new System.EventHandler(this.zombie1_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Lavender;
            this.scoreLabel.Location = new System.Drawing.Point(12, 8);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(91, 31);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score: 0";
            // 
            // missedShotLabel
            // 
            this.missedShotLabel.AutoSize = true;
            this.missedShotLabel.BackColor = System.Drawing.Color.Transparent;
            this.missedShotLabel.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missedShotLabel.ForeColor = System.Drawing.Color.Lavender;
            this.missedShotLabel.Location = new System.Drawing.Point(12, 32);
            this.missedShotLabel.Name = "missedShotLabel";
            this.missedShotLabel.Size = new System.Drawing.Size(155, 31);
            this.missedShotLabel.TabIndex = 5;
            this.missedShotLabel.Text = "Missed shots: 0";
            // 
            // totalShotsLabel
            // 
            this.totalShotsLabel.AutoSize = true;
            this.totalShotsLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalShotsLabel.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalShotsLabel.ForeColor = System.Drawing.Color.Lavender;
            this.totalShotsLabel.Location = new System.Drawing.Point(12, 56);
            this.totalShotsLabel.Name = "totalShotsLabel";
            this.totalShotsLabel.Size = new System.Drawing.Size(142, 31);
            this.totalShotsLabel.TabIndex = 6;
            this.totalShotsLabel.Text = "Total shots: 0";
            // 
            // firstZombieTimer
            // 
            this.firstZombieTimer.Enabled = true;
            this.firstZombieTimer.Interval = 3000;
            this.firstZombieTimer.Tick += new System.EventHandler(this.firstZombieTimer_Tick);
            // 
            // gameTimeLabel
            // 
            this.gameTimeLabel.AutoSize = true;
            this.gameTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameTimeLabel.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTimeLabel.ForeColor = System.Drawing.Color.Lavender;
            this.gameTimeLabel.Location = new System.Drawing.Point(12, 80);
            this.gameTimeLabel.Name = "gameTimeLabel";
            this.gameTimeLabel.Size = new System.Drawing.Size(84, 31);
            this.gameTimeLabel.TabIndex = 7;
            this.gameTimeLabel.Text = "Time: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pupper
            // 
            this.pupper.BackColor = System.Drawing.Color.Transparent;
            this.pupper.Image = global::MonikaFoksLab1Zadanie.Properties.Resources.cute_puppy_png_puppy_dachshund_clipart_9f01eff568716b29;
            this.pupper.Location = new System.Drawing.Point(28, 430);
            this.pupper.Name = "pupper";
            this.pupper.Size = new System.Drawing.Size(118, 111);
            this.pupper.TabIndex = 8;
            this.pupper.TabStop = false;
            this.pupper.Visible = false;
            this.pupper.Click += new System.EventHandler(this.pupper_Click);
            // 
            // pupperTimer
            // 
            this.pupperTimer.Enabled = true;
            this.pupperTimer.Interval = 12000;
            this.pupperTimer.Tick += new System.EventHandler(this.pupperTimer_Tick);
            // 
            // badShotLabel
            // 
            this.badShotLabel.AutoSize = true;
            this.badShotLabel.BackColor = System.Drawing.Color.Transparent;
            this.badShotLabel.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badShotLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.badShotLabel.Location = new System.Drawing.Point(12, 111);
            this.badShotLabel.Name = "badShotLabel";
            this.badShotLabel.Size = new System.Drawing.Size(112, 31);
            this.badShotLabel.TabIndex = 9;
            this.badShotLabel.Text = "Puppers: 0";
            // 
            // pupperOnBoardTimer
            // 
            this.pupperOnBoardTimer.Interval = 2000;
            this.pupperOnBoardTimer.Tick += new System.EventHandler(this.pupperOnBoardTimer_Tick);
            // 
            // labelsTimer
            // 
            this.labelsTimer.Interval = 3500;
            this.labelsTimer.Tick += new System.EventHandler(this.labelsTimer_Tick);
            // 
            // zombie2
            // 
            this.zombie2.BackColor = System.Drawing.Color.Transparent;
            this.zombie2.Image = global::MonikaFoksLab1Zadanie.Properties.Resources.zombie_16001;
            this.zombie2.Location = new System.Drawing.Point(605, 259);
            this.zombie2.Name = "zombie2";
            this.zombie2.Size = new System.Drawing.Size(169, 305);
            this.zombie2.TabIndex = 11;
            this.zombie2.TabStop = false;
            this.zombie2.Visible = false;
            this.zombie2.Click += new System.EventHandler(this.zombie2_Click);
            // 
            // secondZombieTimer
            // 
            this.secondZombieTimer.Enabled = true;
            this.secondZombieTimer.Interval = 8000;
            this.secondZombieTimer.Tick += new System.EventHandler(this.secondZombieTimer_Tick);
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.Image = global::MonikaFoksLab1Zadanie.Properties.Resources.Halloween_Bat_PNG_Clip_Art_Image;
            this.bat.Location = new System.Drawing.Point(227, 32);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(200, 125);
            this.bat.TabIndex = 12;
            this.bat.TabStop = false;
            this.bat.Visible = false;
            this.bat.Click += new System.EventHandler(this.bat_Click);
            // 
            // batTimer
            // 
            this.batTimer.Enabled = true;
            this.batTimer.Interval = 20000;
            this.batTimer.Tick += new System.EventHandler(this.batTimer_Tick);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Chiller", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameOverLabel.Location = new System.Drawing.Point(208, 208);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(452, 111);
            this.gameOverLabel.TabIndex = 13;
            this.gameOverLabel.Text = "GAME OVER!";
            this.gameOverLabel.Visible = false;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageLabel.Font = new System.Drawing.Font("Chiller", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.messageLabel.Location = new System.Drawing.Point(263, 160);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(339, 38);
            this.messageLabel.TabIndex = 10;
            this.messageLabel.Text = "Oh no, you shoot a pupper! :(";
            this.messageLabel.Visible = false;
            // 
            // firstZombieVisibleTimer
            // 
            this.firstZombieVisibleTimer.Interval = 600;
            this.firstZombieVisibleTimer.Tick += new System.EventHandler(this.firstZombieVisibleTimer_Tick);
            // 
            // secondZombieVisibleTimer
            // 
            this.secondZombieVisibleTimer.Interval = 500;
            this.secondZombieVisibleTimer.Tick += new System.EventHandler(this.secondZombieVisibleTimer_Tick);
            // 
            // batVisibleTimer
            // 
            this.batVisibleTimer.Interval = 700;
            this.batVisibleTimer.Tick += new System.EventHandler(this.batVisibleTimer_Tick);
            // 
            // jumpScarePic
            // 
            this.jumpScarePic.Image = global::MonikaFoksLab1Zadanie.Properties.Resources.maxresdefault;
            this.jumpScarePic.Location = new System.Drawing.Point(-215, -15);
            this.jumpScarePic.Name = "jumpScarePic";
            this.jumpScarePic.Size = new System.Drawing.Size(1167, 615);
            this.jumpScarePic.TabIndex = 14;
            this.jumpScarePic.TabStop = false;
            this.jumpScarePic.Visible = false;
            this.jumpScarePic.Click += new System.EventHandler(this.jumpScare_Click);
            // 
            // jumpscareTimer
            // 
            this.jumpscareTimer.Enabled = true;
            this.jumpscareTimer.Interval = 30000;
            this.jumpscareTimer.Tick += new System.EventHandler(this.jumpscareTimer_Tick);
            // 
            // jumpScareJumpTimer
            // 
            this.jumpScareJumpTimer.Enabled = true;
            this.jumpScareJumpTimer.Interval = 20;
            this.jumpScareJumpTimer.Tick += new System.EventHandler(this.jumpScareJumpTimer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MonikaFoksLab1Zadanie.Properties.Resources.cemetery_;
            this.ClientSize = new System.Drawing.Size(910, 597);
            this.Controls.Add(this.jumpScarePic);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.zombie2);
            this.Controls.Add(this.badShotLabel);
            this.Controls.Add(this.pupper);
            this.Controls.Add(this.gameTimeLabel);
            this.Controls.Add(this.totalShotsLabel);
            this.Controls.Add(this.missedShotLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.zombie1);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.exitGameButton);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "ZombieShooter";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Game_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.zombie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpScarePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitGameButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.PictureBox zombie1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label missedShotLabel;
        private System.Windows.Forms.Label totalShotsLabel;
        private System.Windows.Forms.Timer firstZombieTimer;
        private System.Windows.Forms.Label gameTimeLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pupper;
        private System.Windows.Forms.Timer pupperTimer;
        private System.Windows.Forms.Label badShotLabel;
        private System.Windows.Forms.Timer pupperOnBoardTimer;
        private System.Windows.Forms.Timer labelsTimer;
        private System.Windows.Forms.PictureBox zombie2;
        private System.Windows.Forms.Timer secondZombieTimer;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.Timer batTimer;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Timer firstZombieVisibleTimer;
        private System.Windows.Forms.Timer secondZombieVisibleTimer;
        private System.Windows.Forms.Timer batVisibleTimer;
        private System.Windows.Forms.PictureBox jumpScarePic;
        private System.Windows.Forms.Timer jumpscareTimer;
        private System.Windows.Forms.Timer jumpScareJumpTimer;
    }
}