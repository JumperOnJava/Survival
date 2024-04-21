using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Survival.Entites;
using Survival.Models;
using WindowsFormsApp1.Controllers;

namespace Survival
{
    public partial class Form1 : Form
    {
        public Image playerSheet;
        public Image monsterSheet;
        public Entity player;
        private int playerDirection;
        

        public Form1()
        {
            InitializeComponent();

            timerMovement.Interval = 50;
            timerMovement.Tick += new EventHandler(Update);
            KeyDown += new KeyEventHandler(Keyboard);
            KeyUp += new KeyEventHandler(FreeKeyboard);

            Init();

        }

        private void LeftMouseButton(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (playerDirection)
                {
                    case 0:
                        player.SetAnimationConfiguration(9);
                        break;
                    case 1:
                        player.SetAnimationConfiguration(8);
                        break;
                    case 2:
                        player.SetAnimationConfiguration(11);
                        break;
                    case 3:
                        player.SetAnimationConfiguration(10);
                        break;
                }
            }
        }

        private void FreeKeyboard(object sender, KeyEventArgs e)
        {
            player.dirX = 0;
            player.dirY = 0;
            player.isMoving = false;
            switch (e.KeyCode)
            {
                case Keys.W:
                    player.SetAnimationConfiguration(5);
                    break;
                case Keys.S:
                    player.SetAnimationConfiguration(4);
                    break;
                case Keys.D:
                    player.SetAnimationConfiguration(6);
                    break;
                case Keys.A:
                    player.SetAnimationConfiguration(7);
                    break;
                case Keys.Space:
                    switch (playerDirection)
                    {
                        case 0:
                            player.SetAnimationConfiguration(5);
                            break;
                        case 1:
                            player.SetAnimationConfiguration(4);
                            break;
                        case 2:
                            player.SetAnimationConfiguration(6);
                            break;
                        case 3:
                            player.SetAnimationConfiguration(7);
                            break;
                    }
                    break;
            }
        }

        private void Keyboard(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.W:
                    player.dirY = -5;
                    player.isMoving = true;
                    player.SetAnimationConfiguration(1);
                    playerDirection = 0;
                    break;
                case Keys.S:
                    player.dirY = 5;
                    player.isMoving = true;
                    player.SetAnimationConfiguration(0);
                    playerDirection = 1;
                    break;
                case Keys.D:
                    player.dirX = 5;
                    player.isMoving = true;
                    player.SetAnimationConfiguration(2);
                    playerDirection = 2;
                    break;
                case Keys.A:
                    player.dirX = -5;
                    player.isMoving = true;
                    player.SetAnimationConfiguration(3);
                    playerDirection = 3;
                    break;
                case Keys.Space:
                    player.dirX = 0;
                    player.dirY = 0;
                    player.isMoving = false;
                    switch (playerDirection)
                    {
                        case 0:
                            player.SetAnimationConfiguration(9);
                            break;
                        case 1:
                            player.SetAnimationConfiguration(8);
                            break;
                        case 2:
                            player.SetAnimationConfiguration(11);
                            break;
                        case 3:
                            player.SetAnimationConfiguration(10);
                            break;
                    }
                    break;
            }

        }

        private void Update(object sender, EventArgs e)
        {
            if (player.isMoving)
            {
                player.Move();
            }
            Invalidate();

        }


        public void Init()
        {
            MapController.Init();

            this.Width = MapController.GetWidth();
            this.Height = MapController.GetHeight();

            playerSheet = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\player.png"));

            player = new Entity(0, 0, Hero.runFrames, Hero.idleFrames, Hero.attackFrames, Hero.hitFrames, Hero.deathFrames, playerSheet);

            timerMovement.Start();

        }

        public void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MapController.DrawMap(g);
            player.PlayAnimation(g);
        }

    }
}
