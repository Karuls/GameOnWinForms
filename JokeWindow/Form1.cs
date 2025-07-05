using NAudio.CoreAudioApi;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace JokeWindow
{

    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(@"Q:\Games\Race\ПУК.wav");
        [DllImport("winmm.dll", EntryPoint = "waveOutSetVolume")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            this.MouseMove += Form1_MouseMove;
            //FullScreenImage();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int minDistabse = 70; 

            
            int buttonX = button1.Location.X + button1.Width / 2;
            int buttonY = button1.Location.Y + button1.Height / 2;

            
            double distance = Math.Sqrt(Math.Pow(e.X - buttonX, 2) + Math.Pow(e.Y - buttonY, 2));

            if (distance < minDistabse)
            {
                MoveButton();
            }
        }

        private void MoveButton()
        {
            player1.Play();
            int newX = random.Next(0, this.ClientSize.Width - button1.Width);
            int newY = random.Next(0, this.ClientSize.Height - button1.Height);
            button1.Location = new Point(newX, newY);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var enumerator = new MMDeviceEnumerator();
            var device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            device.AudioEndpointVolume.MasterVolumeLevelScalar = 1.0f;

            label1.Text = "Умница";
            label1.Visible = false;
            button1.Visible = false;

          //  System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Q:\Games\JokeWindow\Крик.wav");
            
            button2.Visible = false;
            this.Controls.Remove(button1);
            button1.Dispose();

            
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Image.FromFile("Q:\\Games\\Race\\Хоррор.jpg");
          //  player.Play();
            await Task.Delay(5000);
            //Process.Start("shutdown","/s /t 0");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FullScreenImage()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.BackgroundImage = Image.FromFile("C:\\Users\\fedor\\OneDrive\\Desktop\\Race\\Car.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.KeyDown += (s, e) => { if (e.KeyCode == Keys.Escape) this.Close(); };
        }




    }
}
