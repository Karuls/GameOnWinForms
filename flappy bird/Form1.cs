using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird
{
    public partial class Form1 : Form
    {
        int speed = 5;
        int playerSpeed = 5 ;
        bool JumpActive = false;
        int  jumpSize = 9;
        Random Down = new Random();
        Random Up = new Random();
        bool Nolose = true;
        int StartPositionX = 300;
        int BoostStartSpeed = 1;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Timer.Enabled = false;
            Birdtimer.Enabled = false;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            
            this.KeyPreview = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            blockDown.Left -= speed;
            BlockUp.Left -= speed;

            blockDown1.Left -= speed;
            BlockUp1.Left -= speed;

            BlockDown2.Left -= speed;
            BlockUp2.Left -= speed;

            if(BlockUp.Left <= -110)
            {

                blockDown.Location = new Point(680, Up.Next(320, 390));
                BlockUp.Location = new Point(680, (Down.Next(2, 62) * -1));
                
            }
            if (BlockUp1.Left <= -110)
            {

                blockDown1.Location = new Point(680, Up.Next(320, 390));
                BlockUp1.Location = new Point(680, (Down.Next(2, 62) * -1));

            }
            if (BlockUp2.Left <= -110)
            {

                BlockDown2.Location = new Point(680, Up.Next(320, 390));
                BlockUp2.Location = new Point(680, (Down.Next(2, 72) * -1));

            }
            int margin = -10;

            if (player.Bounds.IntersectsWith(new Rectangle(blockDown.Bounds.X - margin, blockDown.Bounds.Y - margin, blockDown.Bounds.Width + 2 * margin, blockDown.Bounds.Height + 2 * margin)) ||
                player.Bounds.IntersectsWith(new Rectangle(BlockUp.Bounds.X - margin, BlockUp.Bounds.Y - margin, BlockUp.Bounds.Width + 2 * margin, BlockUp.Bounds.Height + 2 * margin)) ||
                player.Bounds.IntersectsWith(new Rectangle(blockDown1.Bounds.X - margin, blockDown1.Bounds.Y - margin, blockDown1.Bounds.Width + 2 * margin, blockDown1.Bounds.Height + 2 * margin)) ||
                player.Bounds.IntersectsWith(new Rectangle(BlockUp1.Bounds.X - margin, BlockUp1.Bounds.Y - margin, BlockUp1.Bounds.Width + 2 * margin, BlockUp1.Bounds.Height + 2 * margin)) ||
                player.Bounds.IntersectsWith(new Rectangle(BlockDown2.Bounds.X - margin, BlockDown2.Bounds.Y - margin, BlockDown2.Bounds.Width + 2 * margin, BlockDown2.Bounds.Height + 2 * margin)) ||
                player.Bounds.IntersectsWith(new Rectangle(BlockUp2.Bounds.X - margin, BlockUp2.Bounds.Y - margin, BlockUp2.Bounds.Width + 2 * margin, BlockUp2.Bounds.Height + 2 * margin)) ||
                player.Top >= 620)
            {
                Timer.Enabled = false;
                Birdtimer.Enabled = false;
            }

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && Nolose)
            {
                JumpActive = true;
                e.Handled = true;
            }
        }

        private void Birdtimer_Tick(object sender, EventArgs e)
        {
            
            if(JumpActive)
            {
                player.Top -= playerSpeed + BoostStartSpeed;
                BoostStartSpeed = 0;
                jumpSize--;
                if(jumpSize <= 0)
                {
                    BoostStartSpeed = 1;
                    jumpSize = 9;
                    JumpActive = false;
                }                    
            }
            else
            {
                player.Top += playerSpeed;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            player.Location = new Point(100, 260);
            Timer.Enabled = true;
            Birdtimer.Enabled = true;
            Start.Visible = false;
            Logo.Visible = false;
            gost.Visible = false;   
            Score.Visible = false;       
            panel1.Visible = false;
            
            
        }

        private void Score_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            ButtonOK.Visible = true;
            Start.Visible = false;
            Score.Visible = false;
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOK(object sender, EventArgs e)
        {
            ButtonOK.Visible = false;
            panel1.Visible = false;
            Start.Visible = true;
            Score.Visible = true;
        }
    }
}
