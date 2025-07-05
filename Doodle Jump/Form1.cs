using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doodle_Jump
{
    public partial class Form : System.Windows.Forms.Form
    {
        SoundPlayer hover = new SoundPlayer("Q:\\Games\\Doodle Jump\\ForHover.wav");
        bool Right = true;
        int gravity = 5;
        int jumpStrength = 30;  
        bool isJumping = true;
        private PictureBox Platform  = null;
        List <PictureBox> platforms = new List <PictureBox>();
        Random randX1 = new Random();
        Random randX2 = new Random();
        Random randX3 = new Random();
        Random randX4 = new Random();
        public Form()
        {
            
            InitializeComponent();
            JumpTimer.Enabled = false;
            timer1.Enabled = false;
        }



        private void start_Click(object sender, EventArgs e)
        {
            JumpTimer.Enabled = true;   
            this.Controls.Remove(start);
            start.Dispose();
            this.Controls.Remove(Exit);
            Exit.Dispose();
            this.Controls.Remove(Record);
            Record.Dispose();
            this.Controls.Remove(labelGame);
            labelGame.Dispose();
        }

        private void start_MouseHover(object sender, EventArgs e)
        {
            hover.Play();
            start.ForeColor = Color.Black;
        }
        private void Exit_MouseHover(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.Black;
            hover.Play();
        }

        private void start_MouseLeave(object sender, EventArgs e)
        {
            start.ForeColor = Color.WhiteSmoke;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.WhiteSmoke;
        }


        private void player_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 10;
            if ((e.KeyCode == Keys.A || e.KeyCode == Keys.Left))
            {
                if (Right) {
                    player.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    player.Refresh();               
                Right = false;
                }
                player.Left -= speed;
            }
            else if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right))
            {
                if (!Right)
                {
                    player.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    player.Refresh();
                 Right = true;
                }
                 player.Left += speed;
                
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JumpTimer_Tick(object sender, EventArgs e)
        {
            ChangeFone();
            Tpaccept();
            if (isJumping)
            {
                player.Top -= jumpStrength;  
                jumpStrength -= 2;
                if(player.Top <= 0)
                {
                    Cloud1.Top -= player.Top; 
                    Cloud2.Top -= player.Top; 
                    
                }
                if(Cloud1.Top >= 430)
                {
                    Cloud1.Top = 0;
                    Cloud2.Top = -430;
                }


                if (jumpStrength <= 0)
                {
                    isJumping = false;
                    jumpStrength = 30; 
                }
            }
            else
            {
                PlatformJump();
                player.Top += gravity; 

                if (player.Bounds.IntersectsWith(platform.Bounds))
                {                   
                    isJumping = true;
                }
            }
            
        }

        private void Tpaccept()
        {
            
            if (player.Left < 0)
            {
                player.Left = this.Width;
            }
            else if (player.Left > this.Width)
            {
                player.Left = 0;
                GenerationNewPlatforms();
            }
        }
        private void GenerationNewPlatforms()
        {
            Random random = new Random();
            PictureBox newPlatform = new PictureBox
            {
                Image = platform.Image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(100, 25),
                Location = new Point(random.Next(0, this.Width - 100), random.Next(0, player.Location.Y)),
                BackColor = platform.BackColor
            };

            this.Controls.Add(newPlatform);
            newPlatform.BringToFront();
            platforms.Add(newPlatform);
        }
       
        private void PlatformJump()
        {
            foreach (Control tmp in this.Controls) {
              if(tmp is PictureBox && tmp != player && tmp != Cloud1 && tmp!= Cloud2){
                    if (player.Bounds.IntersectsWith(tmp.Bounds) && player.Top < tmp.Top)
                    {
                        isJumping = true; return;
                    }
                }
            }
            isJumping = false;
        }

        private void ChangeFone()
        {
            foreach (Control tmp in this.Controls)
            {
                if (tmp is PictureBox && tmp != player && tmp != platform)
                {
                    if (player.Bounds.IntersectsWith(tmp.Bounds) && player.Top < tmp.Top && isJumping == false && tmp != Cloud1 && tmp != Cloud2)
                    {
                        isJumping = true;
                            platform1.Top += player.Top;
                            platform2.Top += player.Top;
                            platform3.Top += player.Top;
                            platform4.Top += player.Top;
                        PlatformLocation();


                    }
                
                }
            }
           
        }     

        private void PlatformLocation()
        {
            
            if(platform1.Top > this.Height) {
            platform1.Location = new Point(randX1.Next(0 + platform1.Width, this.Width - platform1.Width), 112);
            }
            if (platform2.Top > this.Height)
            {
                platform2.Location = new Point(randX1.Next(0 + platform2.Width, this.Width - platform1.Width), 207);
            }
            if (platform3.Top > this.Height)
            {
                platform3.Location = new Point(randX1.Next(0 + platform1.Width, this.Width - platform1.Width), 295);
            }
            if (platform3.Top > this.Height)
            {
                platform3.Location = new Point(randX1.Next(0 + platform1.Width, this.Width - platform1.Width), 405);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }


        //private async void PlayerJump() 
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        player.Top += JumpSpeed;
        //    }
        //    await Task.Delay(2000);
        //}
    }
}
