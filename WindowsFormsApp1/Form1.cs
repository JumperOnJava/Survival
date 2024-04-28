using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Survival.Entites;
using Survival.Models;
using Survival.Controllers;


namespace Survival
{
    public partial class Form1 : Form
    {
        public Image playerSheet;
        public Image slimeSheet;
        public Image dwarfSheet;
        public Player player;
        public Monster monster;
        public Slime slime;
        public Dwarf dwarf;
        Random rnd = new Random();
        public bool gameOver = false;
        //public bool gameIsStart = false;

  

        public Form1(Form2 f)
        {
            InitializeComponent();

            timerMovement.Interval = 50;
            timerMovement.Tick += new EventHandler(Update);
            KeyDown += new KeyEventHandler(Keyboard);
            KeyUp += new KeyEventHandler(FreeKeyboard);

            timerDeleteMonster.Interval = 30000;
            timerDeleteMonster.Tick += new EventHandler(DeleteMonster);

            

            Init();
            //timerMovement.Start();

        }

        private void DeleteMonster(object sender, EventArgs e)
        {
            // Видаліть монстра з форми
            monster = null; // або інша логіка для видалення монстра
            Invalidate(); // Перемалюйте форму, щоб оновити відображення
            timerDeleteMonster.Stop(); // Зупиніть таймер
        }
        private void LeftMouseButton(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (player.direction)
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
                    switch (player.direction)
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
                    player.direction = 0;
                    break;
                case Keys.S:
                    player.dirY = 5;
                    player.isMoving = true;
                    player.SetAnimationConfiguration(0);
                    player.direction = 1;
                    break;
                case Keys.D:
                    player.dirX = 5;
                    player.isMoving = true;
                    player.SetAnimationConfiguration(2);
                    player.direction = 2;
                    break;
                case Keys.A:
                    player.dirX = -5;
                    player.isMoving = true;
                    player.SetAnimationConfiguration(3);
                    player.direction = 3;
                    break;
                case Keys.Space:
                    player.dirX = 0;
                    player.dirY = 0;
                    player.isMoving = false;
                    switch (player.direction)
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

                    if (monster != null)
                    {
                        PlayerAttack(player, monster);
                    }

                    break;
            }

        }
        private void PlayerAttack(Player player, Monster monster)
        {
            // Логіка атаки гравця
            if (player.IntersectsWith(monster) && monster.health > 0)
            {
                monster.isMoving = false;
                monster.dirX = 0;
                monster.dirY = 0;
                monster.health -= 20; // Наприклад, зменшення здоров'я монстра
                monster.SetAnimationConfiguration(12);

            }

            if (monster.health == 0)
            {
                monster.isMoving = false;
                monster.dirX = 0;
                monster.dirY = 0;
                monster.SetAnimationConfiguration(16);
                //timerMovement.Stop();
                timerDeleteMonster.Start(); // Запустіть таймер для видалення монстра

            }

        }

        private void Update(object sender, EventArgs e)
        {
            if (player.isMoving)
            {
                player.Move();
            }

            if (monster != null)
            {
                if (monster.isMoving)
                {
                    monster.UpdateMonsterMovement(player);
                    monster.DetermineMonsterAnimation(player);
                }

                monster.MonsterAttack(player);
                Control(monster, player);

                if (monster.health > 0)
                {
                    monster.isMoving = true;
                }
            }

            slime.UpdateMonsterMovement(player);
            slime.DetermineMonsterAnimation(player);
            //AutoMovingAnim(monster);
            //AutoMoving(monster);

            Invalidate();

        }

        private void Control(Monster monster, Entity player)
        {
            if (player.health == 0)
            {
                player.dirX = 0;
                player.dirY = 0;
                player.SetAnimationConfiguration(16);
                timerMovement.Stop();
            }
        }

        public void Init()
        {
            MapController.Init();

            this.Width = MapController.GetWidth();
            this.Height = MapController.GetHeight();

            playerSheet = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\player.png"));
            slimeSheet = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\slime.png"));
            dwarfSheet = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\dwarf.png"));


            player = new Player(0, 0, Hero.runFrames, Hero.idleFrames, Hero.attackFrames, Hero.hitFrames, Hero.deathFrames, 128, 100, playerSheet);


            monster = new Monster(150, 150, Hero.runFrames, Hero.idleFrames, Hero.attackFrames, Hero.hitFrames, Hero.deathFrames, 128, 100, playerSheet);


            slime = new Slime(100, 100, SlimeMonster.runFrames, SlimeMonster.idleFrames, SlimeMonster.attackFrames, SlimeMonster.hitFrames, SlimeMonster.deathFrames, 64, 100, slimeSheet);


            dwarf = new Dwarf(300, 300, SlimeMonster.runFrames, SlimeMonster.idleFrames, SlimeMonster.attackFrames, SlimeMonster.hitFrames, SlimeMonster.deathFrames, 64, 100, dwarfSheet);


            timerMovement.Start();



        }

        public void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MapController.DrawMap(g);
            slime.PlayAnimation(g);
            dwarf.PlayAnimation(g);

            if (monster != null)
            {
                monster.PlayAnimation(g);
            }
            player.PlayAnimation(g);

        }

    }
}
