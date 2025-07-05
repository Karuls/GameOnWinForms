namespace Doodle_Jump
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.JumpTimer = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelGame = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.Record = new System.Windows.Forms.Label();
            this.platform = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.platform1 = new System.Windows.Forms.PictureBox();
            this.platform2 = new System.Windows.Forms.PictureBox();
            this.platform3 = new System.Windows.Forms.PictureBox();
            this.platform4 = new System.Windows.Forms.PictureBox();
            this.Cloud1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Cloud2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud2)).BeginInit();
            this.SuspendLayout();
            // 
            // JumpTimer
            // 
            this.JumpTimer.Enabled = true;
            this.JumpTimer.Interval = 20;
            this.JumpTimer.Tick += new System.EventHandler(this.JumpTimer_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1, 568);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(8, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // labelGame
            // 
            this.labelGame.BackColor = System.Drawing.Color.Transparent;
            this.labelGame.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelGame.Location = new System.Drawing.Point(1, 60);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(450, 82);
            this.labelGame.TabIndex = 2;
            this.labelGame.Text = "Eazy Game";
            this.labelGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.start.Location = new System.Drawing.Point(1, 254);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(450, 38);
            this.start.TabIndex = 3;
            this.start.Text = "Начать играть(Enter)";
            this.start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.start.Click += new System.EventHandler(this.start_Click);
            this.start.MouseLeave += new System.EventHandler(this.start_MouseLeave);
            this.start.MouseHover += new System.EventHandler(this.start_MouseHover);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Exit.Location = new System.Drawing.Point(1, 304);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(450, 38);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Выход(Esc)";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            this.Exit.MouseHover += new System.EventHandler(this.Exit_MouseHover);
            // 
            // Record
            // 
            this.Record.BackColor = System.Drawing.Color.Transparent;
            this.Record.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Record.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Record.Location = new System.Drawing.Point(1, 354);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(450, 38);
            this.Record.TabIndex = 5;
            this.Record.Text = "Рекорд: 0";
            this.Record.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.Transparent;
            this.platform.Image = ((System.Drawing.Image)(resources.GetObject("platform.Image")));
            this.platform.Location = new System.Drawing.Point(31, 510);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(115, 30);
            this.platform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform.TabIndex = 6;
            this.platform.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(63, 441);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(53, 67);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 7;
            this.player.TabStop = false;
            // 
            // platform1
            // 
            this.platform1.BackColor = System.Drawing.Color.Transparent;
            this.platform1.Image = ((System.Drawing.Image)(resources.GetObject("platform1.Image")));
            this.platform1.Location = new System.Drawing.Point(157, 405);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(115, 30);
            this.platform1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform1.TabIndex = 8;
            this.platform1.TabStop = false;
            // 
            // platform2
            // 
            this.platform2.BackColor = System.Drawing.Color.Transparent;
            this.platform2.Image = ((System.Drawing.Image)(resources.GetObject("platform2.Image")));
            this.platform2.Location = new System.Drawing.Point(157, 295);
            this.platform2.Name = "platform2";
            this.platform2.Size = new System.Drawing.Size(115, 30);
            this.platform2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform2.TabIndex = 9;
            this.platform2.TabStop = false;
            // 
            // platform3
            // 
            this.platform3.BackColor = System.Drawing.Color.Transparent;
            this.platform3.Image = ((System.Drawing.Image)(resources.GetObject("platform3.Image")));
            this.platform3.Location = new System.Drawing.Point(157, 207);
            this.platform3.Name = "platform3";
            this.platform3.Size = new System.Drawing.Size(115, 30);
            this.platform3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform3.TabIndex = 10;
            this.platform3.TabStop = false;
            // 
            // platform4
            // 
            this.platform4.BackColor = System.Drawing.Color.Transparent;
            this.platform4.Image = ((System.Drawing.Image)(resources.GetObject("platform4.Image")));
            this.platform4.Location = new System.Drawing.Point(157, 112);
            this.platform4.Name = "platform4";
            this.platform4.Size = new System.Drawing.Size(115, 30);
            this.platform4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform4.TabIndex = 11;
            this.platform4.TabStop = false;
            // 
            // Cloud1
            // 
            this.Cloud1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cloud1.BackgroundImage")));
            this.Cloud1.Image = ((System.Drawing.Image)(resources.GetObject("Cloud1.Image")));
            this.Cloud1.Location = new System.Drawing.Point(0, 0);
            this.Cloud1.Name = "Cloud1";
            this.Cloud1.Size = new System.Drawing.Size(445, 570);
            this.Cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud1.TabIndex = 12;
            this.Cloud1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cloud2
            // 
            this.Cloud2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cloud2.BackgroundImage")));
            this.Cloud2.Image = ((System.Drawing.Image)(resources.GetObject("Cloud2.Image")));
            this.Cloud2.Location = new System.Drawing.Point(0, -570);
            this.Cloud2.Name = "Cloud2";
            this.Cloud2.Size = new System.Drawing.Size(445, 570);
            this.Cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud2.TabIndex = 13;
            this.Cloud2.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 570);
            this.Controls.Add(this.platform4);
            this.Controls.Add(this.platform3);
            this.Controls.Add(this.platform2);
            this.Controls.Add(this.platform1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.start);
            this.Controls.Add(this.labelGame);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Cloud1);
            this.Controls.Add(this.Cloud2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doodle Jump";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.player_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelGame;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Record;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer JumpTimer;
        private System.Windows.Forms.PictureBox platform1;
        private System.Windows.Forms.PictureBox platform2;
        private System.Windows.Forms.PictureBox platform3;
        private System.Windows.Forms.PictureBox platform4;
        private System.Windows.Forms.PictureBox Cloud1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Cloud2;
    }
}

