namespace RacingGame
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.race1 = new System.Windows.Forms.PictureBox();
            this.race2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.Bot1 = new System.Windows.Forms.PictureBox();
            this.Bot2 = new System.Windows.Forms.PictureBox();
            this.Botstimer = new System.Windows.Forms.Timer(this.components);
            this.LoseLabel = new System.Windows.Forms.Label();
            this.RestartLabel = new System.Windows.Forms.Label();
            this.Coins = new System.Windows.Forms.Label();
            this.coin = new System.Windows.Forms.PictureBox();
            this.RecordLabel = new System.Windows.Forms.Label();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.CarButton2 = new System.Windows.Forms.Button();
            this.Car3 = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.CarButton3 = new System.Windows.Forms.Button();
            this.CarButton1 = new System.Windows.Forms.Button();
            this.Cash = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.race1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.race2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 25;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // race1
            // 
            this.race1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.race1.Enabled = false;
            this.race1.Image = ((System.Drawing.Image)(resources.GetObject("race1.Image")));
            this.race1.Location = new System.Drawing.Point(0, 0);
            this.race1.Margin = new System.Windows.Forms.Padding(0);
            this.race1.Name = "race1";
            this.race1.Size = new System.Drawing.Size(840, 650);
            this.race1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.race1.TabIndex = 0;
            this.race1.TabStop = false;
            // 
            // race2
            // 
            this.race2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.race2.Image = ((System.Drawing.Image)(resources.GetObject("race2.Image")));
            this.race2.Location = new System.Drawing.Point(0, -650);
            this.race2.Margin = new System.Windows.Forms.Padding(0);
            this.race2.Name = "race2";
            this.race2.Size = new System.Drawing.Size(840, 650);
            this.race2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.race2.TabIndex = 1;
            this.race2.TabStop = false;
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(452, 515);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(73, 123);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // Bot1
            // 
            this.Bot1.Image = ((System.Drawing.Image)(resources.GetObject("Bot1.Image")));
            this.Bot1.Location = new System.Drawing.Point(200, -140);
            this.Bot1.Name = "Bot1";
            this.Bot1.Size = new System.Drawing.Size(72, 123);
            this.Bot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bot1.TabIndex = 3;
            this.Bot1.TabStop = false;
            // 
            // Bot2
            // 
            this.Bot2.Image = ((System.Drawing.Image)(resources.GetObject("Bot2.Image")));
            this.Bot2.Location = new System.Drawing.Point(561, -850);
            this.Bot2.Name = "Bot2";
            this.Bot2.Size = new System.Drawing.Size(72, 123);
            this.Bot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bot2.TabIndex = 4;
            this.Bot2.TabStop = false;
            // 
            // Botstimer
            // 
            this.Botstimer.Enabled = true;
            this.Botstimer.Interval = 30;
            this.Botstimer.Tick += new System.EventHandler(this.Botstimer_Tick);
            // 
            // LoseLabel
            // 
            this.LoseLabel.BackColor = System.Drawing.Color.Maroon;
            this.LoseLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoseLabel.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoseLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoseLabel.Location = new System.Drawing.Point(291, 145);
            this.LoseLabel.Name = "LoseLabel";
            this.LoseLabel.Size = new System.Drawing.Size(258, 58);
            this.LoseLabel.TabIndex = 5;
            this.LoseLabel.Text = "Проиграл";
            this.LoseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestartLabel
            // 
            this.RestartLabel.BackColor = System.Drawing.Color.Maroon;
            this.RestartLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RestartLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RestartLabel.Location = new System.Drawing.Point(331, 222);
            this.RestartLabel.Name = "RestartLabel";
            this.RestartLabel.Size = new System.Drawing.Size(181, 38);
            this.RestartLabel.TabIndex = 6;
            this.RestartLabel.Text = "Играть снова";
            this.RestartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RestartLabel.Click += new System.EventHandler(this.Restart_click);
            // 
            // Coins
            // 
            this.Coins.BackColor = System.Drawing.Color.Maroon;
            this.Coins.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Coins.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Coins.Location = new System.Drawing.Point(0, 0);
            this.Coins.Name = "Coins";
            this.Coins.Size = new System.Drawing.Size(141, 42);
            this.Coins.TabIndex = 7;
            this.Coins.Text = "Монеты: ";
            this.Coins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // coin
            // 
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(576, -100);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(39, 39);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 8;
            this.coin.TabStop = false;
            // 
            // RecordLabel
            // 
            this.RecordLabel.BackColor = System.Drawing.Color.Maroon;
            this.RecordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RecordLabel.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RecordLabel.Location = new System.Drawing.Point(0, 53);
            this.RecordLabel.Name = "RecordLabel";
            this.RecordLabel.Size = new System.Drawing.Size(125, 42);
            this.RecordLabel.TabIndex = 9;
            this.RecordLabel.Text = "Рекорд : ";
            this.RecordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Car2
            // 
            this.Car2.Image = ((System.Drawing.Image)(resources.GetObject("Car2.Image")));
            this.Car2.Location = new System.Drawing.Point(736, 197);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(67, 132);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car2.TabIndex = 10;
            this.Car2.TabStop = false;
            // 
            // CarButton2
            // 
            this.CarButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarButton2.Location = new System.Drawing.Point(727, 335);
            this.CarButton2.Name = "CarButton2";
            this.CarButton2.Size = new System.Drawing.Size(86, 28);
            this.CarButton2.TabIndex = 12;
            this.CarButton2.Text = "100$";
            this.CarButton2.UseVisualStyleBackColor = true;
            this.CarButton2.Click += new System.EventHandler(this.CarButton2_Click);
            // 
            // Car3
            // 
            this.Car3.Image = ((System.Drawing.Image)(resources.GetObject("Car3.Image")));
            this.Car3.Location = new System.Drawing.Point(736, 7);
            this.Car3.Name = "Car3";
            this.Car3.Size = new System.Drawing.Size(67, 132);
            this.Car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car3.TabIndex = 13;
            this.Car3.TabStop = false;
            // 
            // Car1
            // 
            this.Car1.Image = ((System.Drawing.Image)(resources.GetObject("Car1.Image")));
            this.Car1.Location = new System.Drawing.Point(736, 385);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(67, 132);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car1.TabIndex = 15;
            this.Car1.TabStop = false;
            // 
            // CarButton3
            // 
            this.CarButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarButton3.Location = new System.Drawing.Point(727, 145);
            this.CarButton3.Name = "CarButton3";
            this.CarButton3.Size = new System.Drawing.Size(86, 28);
            this.CarButton3.TabIndex = 16;
            this.CarButton3.Text = "230$";
            this.CarButton3.UseVisualStyleBackColor = true;
            this.CarButton3.Click += new System.EventHandler(this.CarButton3_Click);
            // 
            // CarButton1
            // 
            this.CarButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarButton1.Location = new System.Drawing.Point(727, 523);
            this.CarButton1.Name = "CarButton1";
            this.CarButton1.Size = new System.Drawing.Size(86, 28);
            this.CarButton1.TabIndex = 17;
            this.CarButton1.Text = "50$";
            this.CarButton1.UseVisualStyleBackColor = true;
            this.CarButton1.Click += new System.EventHandler(this.CarButton1_Click);
            // 
            // Cash
            // 
            this.Cash.BackColor = System.Drawing.Color.Maroon;
            this.Cash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cash.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cash.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cash.Location = new System.Drawing.Point(0, 608);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(164, 42);
            this.Cash.TabIndex = 18;
            this.Cash.Text = "Баланс : ";
            this.Cash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BackColor = System.Drawing.Color.Maroon;
            this.ErrorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ErrorLabel.Font = new System.Drawing.Font("Nirmala UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ErrorLabel.Location = new System.Drawing.Point(50, 145);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(740, 187);
            this.ErrorLabel.TabIndex = 19;
            this.ErrorLabel.Text = "Недостаточно средств";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.CarButton1);
            this.Controls.Add(this.CarButton3);
            this.Controls.Add(this.Car1);
            this.Controls.Add(this.Car3);
            this.Controls.Add(this.CarButton2);
            this.Controls.Add(this.Car2);
            this.Controls.Add(this.RecordLabel);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.Coins);
            this.Controls.Add(this.RestartLabel);
            this.Controls.Add(this.LoseLabel);
            this.Controls.Add(this.Bot2);
            this.Controls.Add(this.Bot1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.race2);
            this.Controls.Add(this.race1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.race1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.race2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox race1;
        private System.Windows.Forms.PictureBox race2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Bot1;
        private System.Windows.Forms.PictureBox Bot2;
        private System.Windows.Forms.Timer Botstimer;
        private System.Windows.Forms.Label LoseLabel;
        private System.Windows.Forms.Label RestartLabel;
        private System.Windows.Forms.Label Coins;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label RecordLabel;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.Button CarButton2;
        private System.Windows.Forms.PictureBox Car3;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.Button CarButton3;
        private System.Windows.Forms.Button CarButton1;
        private System.Windows.Forms.Label Cash;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

