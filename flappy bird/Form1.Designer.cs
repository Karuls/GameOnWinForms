namespace flappy_bird
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.blockDown = new System.Windows.Forms.PictureBox();
            this.BlockUp = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Birdtimer = new System.Windows.Forms.Timer(this.components);
            this.blockDown1 = new System.Windows.Forms.PictureBox();
            this.BlockUp1 = new System.Windows.Forms.PictureBox();
            this.BlockUp2 = new System.Windows.Forms.PictureBox();
            this.BlockDown2 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.gost = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BestScore = new System.Windows.Forms.Label();
            this.ScoreNow = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockUp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockUp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gost)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(382, 273);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(51, 38);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // blockDown
            // 
            this.blockDown.BackColor = System.Drawing.Color.Transparent;
            this.blockDown.Image = ((System.Drawing.Image)(resources.GetObject("blockDown.Image")));
            this.blockDown.Location = new System.Drawing.Point(880, 394);
            this.blockDown.Name = "blockDown";
            this.blockDown.Size = new System.Drawing.Size(110, 300);
            this.blockDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blockDown.TabIndex = 1;
            this.blockDown.TabStop = false;
            // 
            // BlockUp
            // 
            this.BlockUp.BackColor = System.Drawing.Color.Transparent;
            this.BlockUp.Image = ((System.Drawing.Image)(resources.GetObject("BlockUp.Image")));
            this.BlockUp.Location = new System.Drawing.Point(880, -62);
            this.BlockUp.Name = "BlockUp";
            this.BlockUp.Size = new System.Drawing.Size(110, 300);
            this.BlockUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlockUp.TabIndex = 2;
            this.BlockUp.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 30;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(880, 620);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Birdtimer
            // 
            this.Birdtimer.Enabled = true;
            this.Birdtimer.Interval = 30;
            this.Birdtimer.Tick += new System.EventHandler(this.Birdtimer_Tick);
            // 
            // blockDown1
            // 
            this.blockDown1.BackColor = System.Drawing.Color.Transparent;
            this.blockDown1.Image = ((System.Drawing.Image)(resources.GetObject("blockDown1.Image")));
            this.blockDown1.Location = new System.Drawing.Point(1070, 450);
            this.blockDown1.Name = "blockDown1";
            this.blockDown1.Size = new System.Drawing.Size(110, 300);
            this.blockDown1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blockDown1.TabIndex = 4;
            this.blockDown1.TabStop = false;
            // 
            // BlockUp1
            // 
            this.BlockUp1.BackColor = System.Drawing.Color.Transparent;
            this.BlockUp1.Image = ((System.Drawing.Image)(resources.GetObject("BlockUp1.Image")));
            this.BlockUp1.Location = new System.Drawing.Point(1070, -21);
            this.BlockUp1.Name = "BlockUp1";
            this.BlockUp1.Size = new System.Drawing.Size(110, 300);
            this.BlockUp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlockUp1.TabIndex = 5;
            this.BlockUp1.TabStop = false;
            // 
            // BlockUp2
            // 
            this.BlockUp2.BackColor = System.Drawing.Color.Transparent;
            this.BlockUp2.Image = ((System.Drawing.Image)(resources.GetObject("BlockUp2.Image")));
            this.BlockUp2.Location = new System.Drawing.Point(1400, -68);
            this.BlockUp2.Name = "BlockUp2";
            this.BlockUp2.Size = new System.Drawing.Size(110, 300);
            this.BlockUp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlockUp2.TabIndex = 7;
            this.BlockUp2.TabStop = false;
            // 
            // BlockDown2
            // 
            this.BlockDown2.BackColor = System.Drawing.Color.Transparent;
            this.BlockDown2.Image = ((System.Drawing.Image)(resources.GetObject("BlockDown2.Image")));
            this.BlockDown2.Location = new System.Drawing.Point(1400, 388);
            this.BlockDown2.Name = "BlockDown2";
            this.BlockDown2.Size = new System.Drawing.Size(110, 300);
            this.BlockDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlockDown2.TabIndex = 6;
            this.BlockDown2.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(213, 21);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(445, 124);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            // 
            // gost
            // 
            this.gost.BackColor = System.Drawing.Color.Transparent;
            this.gost.Image = ((System.Drawing.Image)(resources.GetObject("gost.Image")));
            this.gost.Location = new System.Drawing.Point(345, 194);
            this.gost.Name = "gost";
            this.gost.Size = new System.Drawing.Size(188, 186);
            this.gost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gost.TabIndex = 10;
            this.gost.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Score.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Score.BackgroundImage")));
            this.Score.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Score.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Score.Location = new System.Drawing.Point(478, 457);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(180, 65);
            this.Score.TabIndex = 11;
            this.Score.TabStop = false;
            this.Score.UseVisualStyleBackColor = true;
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // Start
            // 
            this.Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start.BackgroundImage")));
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Location = new System.Drawing.Point(213, 457);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(180, 65);
            this.Start.TabIndex = 12;
            this.Start.TabStop = false;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.BestScore);
            this.panel1.Controls.Add(this.ScoreNow);
            this.panel1.Location = new System.Drawing.Point(200, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 241);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // BestScore
            // 
            this.BestScore.BackColor = System.Drawing.Color.Transparent;
            this.BestScore.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BestScore.ForeColor = System.Drawing.Color.White;
            this.BestScore.Location = new System.Drawing.Point(345, 152);
            this.BestScore.Name = "BestScore";
            this.BestScore.Size = new System.Drawing.Size(100, 37);
            this.BestScore.TabIndex = 1;
            this.BestScore.Text = "0";
            this.BestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreNow
            // 
            this.ScoreNow.BackColor = System.Drawing.Color.Transparent;
            this.ScoreNow.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreNow.ForeColor = System.Drawing.Color.White;
            this.ScoreNow.Location = new System.Drawing.Point(339, 63);
            this.ScoreNow.Name = "ScoreNow";
            this.ScoreNow.Size = new System.Drawing.Size(100, 37);
            this.ScoreNow.TabIndex = 0;
            this.ScoreNow.Text = "0";
            this.ScoreNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonOK
            // 
            this.ButtonOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonOK.BackgroundImage")));
            this.ButtonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonOK.Location = new System.Drawing.Point(345, 425);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(180, 65);
            this.ButtonOK.TabIndex = 14;
            this.ButtonOK.TabStop = false;
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Visible = false;
            this.ButtonOK.Click += new System.EventHandler(this.buttonOK);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 620);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.player);
            this.Controls.Add(this.gost);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.BlockUp2);
            this.Controls.Add(this.BlockDown2);
            this.Controls.Add(this.BlockUp1);
            this.Controls.Add(this.blockDown1);
            this.Controls.Add(this.BlockUp);
            this.Controls.Add(this.blockDown);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockUp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockUp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gost)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox blockDown;
        private System.Windows.Forms.PictureBox BlockUp;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Birdtimer;
        private System.Windows.Forms.PictureBox blockDown1;
        private System.Windows.Forms.PictureBox BlockUp1;
        private System.Windows.Forms.PictureBox BlockUp2;
        private System.Windows.Forms.PictureBox BlockDown2;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox gost;
        private System.Windows.Forms.Button Score;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ScoreNow;
        private System.Windows.Forms.Label BestScore;
        private System.Windows.Forms.Button ButtonOK;
    }
}

