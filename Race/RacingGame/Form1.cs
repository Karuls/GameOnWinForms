using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        int Coins_Count = 0;
        int speedtimer_Tick = 5;
        int carSpeed = 7;
        int Cash_Count = 0;
        int CASH;
        private PictureBox collisionImage = null;
        

        public Form1()
        {
            InitializeComponent();
            race1.SizeMode = PictureBoxSizeMode.StretchImage;
            race2.SizeMode = PictureBoxSizeMode.StretchImage;
            race1.Size = new Size(650, 650);
            race2.Size = new Size(650, 650);
            race1.Location = new Point(0, 0);
            race2.Location = new Point(0, -650);
            this.DoubleBuffered = true;
            race1.Anchor = AnchorStyles.Top;
            race2.Anchor = AnchorStyles.Top;
            RestartLabel.Visible = false;
            LoseLabel.Visible = false;
            Car1.Visible = false;
            Car2.Visible = false;
            Car3.Visible = false;
            CarButton1.Visible = false;
            CarButton2.Visible = false;
            CarButton3.Visible = false;
            ErrorLabel.Visible = false;
            this.DoubleBuffered = true;
            
            RecordCheck(Coins_Count);
            Cash_counter();  
        }
        
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();

        }      
        private void timer_Tick(object sender, EventArgs e)
        {                        
            race1.Top += speedtimer_Tick;
            race2.Top += speedtimer_Tick;
            coin.Top += speedtimer_Tick;
            

            if (race1.Top >= 650)
            {
                race1.Top = 0;
                race2.Top = -650;
                
            }
           if(coin.Top >= 650)
            {
                coinFunction();
            }
        }
      
       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 10;
            if ((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && player.Left > 140 && timer.Enabled)
            {
                player.Left -= speed;
            }
            else if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && player.Left < 440 && timer.Enabled)
            {
                player.Left += speed;
            }
            else if ((e.KeyCode == Keys.W || e.KeyCode == Keys.Up) && player.Top > 0 && timer.Enabled)
            {
                player.Top -= speed;

            }
            else if ((e.KeyCode == Keys.S || e.KeyCode == Keys.Down) && player.Top < 420 && timer.Enabled)
            {
                player.Top += speed;
            }

        }
     

        private void Botstimer_Tick(object sender, EventArgs e)
        {
            
            Bot1.Top += carSpeed;
            Bot2.Top += carSpeed;

            if (Bot1.Top > 650)
            {
                Random random = new Random();
                Bot1.Left = random.Next(140, 220);
                Bot1.Top = -260;
            }
            if (Bot2.Top > 650)
            {
                Random random = new Random();
                Bot2.Left = random.Next(250, 440);
                Bot2.Top = -320;
            }

            if (player.Bounds.IntersectsWith(Bot1.Bounds) || player.Bounds.IntersectsWith(Bot2.Bounds))
            {
                if (player.Bounds.IntersectsWith(Bot1.Bounds))
                {

                    HandleCollision();
                    RecordCheck(Coins_Count);
                    Cash_counter();
                }
                else if (player.Bounds.IntersectsWith(Bot2.Bounds))
                    {
                    HandleCollision();
                    RecordCheck(Coins_Count);
                    Cash_counter();
                }
              
            }

            if (player.Bounds.IntersectsWith(coin.Bounds))
            {
                Coins_Count++;
                Coins.Text = "Монеты: " + Coins_Count.ToString();
                coinFunction();
                //speedtimer_Tick++;
                carSpeed++;
                //if (Coins_Count %5 == 0 && Coins_Count > 4)
                //{
                //    player.Width = 100;
                //}
                //else if (Coins_Count %5!= 0){
                //    player.Width = 55;
                //}
                
            }

        }

        private void Restart_click(object sender, EventArgs e)
        {

            if (collisionImage != null)
            {
                this.Controls.Remove(collisionImage);
                collisionImage.Dispose(); 
                collisionImage = null;
            }
            timer.Enabled = true;
            Botstimer.Enabled = true;
            RestartLabel.Visible = false;
            LoseLabel.Visible = false;
            Car1.Visible = false;
            Car2.Visible = false;
            Car3.Visible = false;
            CarButton1.Visible = false;
            CarButton2.Visible = false;
            CarButton3.Visible = false;
            Bot1.Top = -550;
            Bot2.Top = -850;
            Coins_Count = 0;
            Coins.Text = "Монеты: ";
            speedtimer_Tick = 5;
            carSpeed = 10;
            
        }
        private void coinFunction()
        {
            Random random = new Random();
            coin.Left = random.Next(140, 440);
            coin.Top = -120;

        }
        private void HandleCollision()
        {
            
            timer.Enabled = false;
            Botstimer.Enabled = false;

            
            Rectangle intersection = Rectangle.Empty;
            if (player.Bounds.IntersectsWith(Bot1.Bounds))
            {
                intersection = Rectangle.Intersect(player.Bounds, Bot1.Bounds);
            }
            else if (player.Bounds.IntersectsWith(Bot2.Bounds))
            {
                intersection = Rectangle.Intersect(player.Bounds, Bot2.Bounds);
            }

            // Если есть пересечение, добавляем картинку
            if (!intersection.IsEmpty)
            {
                // Удаляем предыдущую картинку, если она есть
                if (collisionImage != null)
                {
                    this.Controls.Remove(collisionImage);
                    collisionImage.Dispose();
                    collisionImage = null;
                }

                collisionImage = new PictureBox
                {
                    Image = new Bitmap("Q:\\Games\\Race\\Boom.png"), 
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(25,25),
                    Location = new Point(intersection.X, intersection.Y),
                    BackColor = Color.Transparent 
                };

                
                this.Controls.Add(collisionImage);
                collisionImage.BringToFront(); 
            }

            Car1.Visible = true;
            Car2.Visible = true;
            Car3.Visible = true;
            CarButton1.Visible = true;
            CarButton2.Visible = true;
            CarButton3.Visible = true;
            RestartLabel.Visible = true;
            LoseLabel.Visible = true;
            
        }

     private void RecordCheck(int nowCoins){

     string path = "Q:\\Games\\Race\\RacingGame\\RECORD_FILE.txt";

        if (!File.Exists(path))
        {
         File.Create(path).Close();
        }
        else
        {
             string[] lines = File.ReadAllLines(path);

            if (int.TryParse(lines[0], out int record))
            {
                if (nowCoins > record)
                {
                        lines[0] = $"{nowCoins}";
                    File.WriteAllLines(path, lines);
                    RecordLabel.Text = "Рекорд :" + nowCoins.ToString();
                }
                    else
                    {
                        RecordLabel.Text = "Рекорд :" + record.ToString();
                    }
               
            }
          
        }
    
   
    }

        

        private void CarButton1_Click(object sender, EventArgs e)
        {
            if (RETURN_CASH() > 50)
            {
                player.Image = Image.FromFile("Q:\\Games\\Race\\Dodge.jpg");
                player.SizeMode = PictureBoxSizeMode.StretchImage;
                player.Size = new Size(55, 100);
            }
            else Error();
        }

        private void CarButton3_Click(object sender, EventArgs e)
        {
            if (RETURN_CASH() > 230)
            {
                player.Image = Image.FromFile("Q:\\Games\\Race\\porshe.png");
                player.Size = new Size(55, 100);
            }
            else Error();
        }

        private void CarButton2_Click(object sender, EventArgs e)
        {
            if (RETURN_CASH() > 100)
            {
                player.Image = Image.FromFile("Q:\\Games\\Race\\camaro.png");
                player.Size = new Size(60, 125);
            }
            else Error();
        }

        private void Form1_Load_1(object sender, EventArgs e){
        this.KeyDown += new KeyEventHandler(Form1_KeyDown); // Привязываем событие KeyDown
        this.KeyPreview = true;
        }

        private void Cash_counter()
        {
            string path = "Q:\\Games\\Race\\RacingGame\\RECORD_FILE.txt";

            if(carSpeed == 7)
            {

            if (!File.Exists(path))
                File.Create(path).Close();
            
            else{
                string[] lines = File.ReadAllLines(path);
                if (int.TryParse(lines[1], out int CASH)) {
                    Cash.Text = "Баланс: " + CASH;
                   }
                }
            
            }
            else{
                string[] lines = File.ReadAllLines(path);
                if (int.TryParse(lines[1], out int CASH))
                {
                    lines[1] = $"{CASH + Coins_Count}";
                    File.WriteAllLines(path, lines);
                    Cash.Text = "Баланс: " + $"{ CASH + Coins_Count}";
                }
            }
                
        }

        private int RETURN_CASH()
        {
            string path = "Q:\\Games\\Race\\RacingGame\\RECORD_FILE.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            else
            {
                string[] lines = File.ReadAllLines(path);
                if (int.TryParse(lines[1],out int CASH))
                {
                    return CASH;
                }
                return 0;
            }
            return 0;

        }

        private async void Error()
        {
            
           ErrorLabel.Visible = true;
           await Task.Delay(500);
           ErrorLabel.Visible = false;
            


        }


    }

}

