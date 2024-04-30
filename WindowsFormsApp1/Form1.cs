using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Survival.Entites;
using Survival.Models;
using Survival.Controllers;


namespace Survival
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public bool gameOver = false;
        public Image playerSheet;
        public Image slimeSheet;
        public Image dwarfSheet;
        public Player player;
        //public Monster monster;
        public Slime slime;
        public Dwarf dwarf;
        public List<Monster> monsters = new List<Monster>();

        public int spawnTimer = 0;
        public int spawnTimerDead = 0;
        public int spawnInterval = 5000;
        public int deadInterval = 10000;
        // public int interval = 5000;


        public Form1(Form2 f)
        {
            InitializeComponent();

            timerMovement.Interval = 70;
            timerMovement.Tick += new EventHandler(Update);
            KeyDown += new KeyEventHandler(Keyboard);
            KeyUp += new KeyEventHandler(FreeKeyboard);

            timerSpawnMonster.Interval = 1000;
            timerSpawnMonster.Tick += new EventHandler(SpawnMonsterTick);
            timerSpawnMonster.Start();

            timerDeadMonster.Interval = 1000;
            timerDeadMonster.Tick += new EventHandler(DeadMonsterTick);
            timerDeadMonster.Start();

            Init();

        }

        private void DeadMonsterTick(object sender, EventArgs e)
        {
            spawnTimerDead += 1000; // Додаємо 1 секунду до таймера монстрів
            if (spawnTimerDead >= deadInterval)
            {
                for (int i = 0; i < monsters.Count; i++)
                {
                    Monster monster = monsters[i];
                    if (monster != null && monster.isDead)
                    {
                        monsters[i] = null;

                    }
                }

                spawnTimerDead = 0; // Скидаємо таймер, оскільки монстр з'явився
            }
        }

        private void SpawnMonsterTick(object sender, EventArgs e)
        {
            spawnTimer += 1000; // Додаємо 1 секунду до таймера монстрів
            if (spawnTimer >= spawnInterval)
            {
                SpawnMonster();
                spawnTimer = 0; // Скидаємо таймер, оскільки монстр з'явився
            }
        }

        private void SpawnMonster()
        {
            int x = rnd.Next(0, this.Width); // Випадкова координата X в межах ширини форми
            int y = rnd.Next(0, this.Height); // Випадкова координата Y в межах висоти форми

            Monster monster = new Monster(x, y, Hero.runFrames, Hero.idleFrames, Hero.attackFrames, Hero.hitFrames, Hero.deathFrames, 128, 200, playerSheet);
            monsters.Add(monster);
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

                    foreach (Monster monster in monsters)
                    {
                        if (player.IntersectsWith(monster))
                        {
                            player.PlayerAttack(monster);
                        }
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

            /*
            if (monsters.Count > 1) {
                foreach (Monster monster in monsters) // Перебираємо копію списку монстрів
                {
                    if (monster != null)
                    {
                        if (monster.isMoving)
                        {
                            monster.UpdateMonsterMovement(player);
                            monster.DetermineMonsterAnimation(player);
                        }

                        monster.MonsterAttack(player);
                        Control(monster, player);


                    }
                }
            }
        */

            for (int i = 0; i < monsters.Count; i++)
            {
                Monster monster = monsters[i];
                if (monster != null)
                {
                    if (monster.isMoving)
                    {
                        monster.UpdateMonsterMovement(player);
                        monster.DetermineMonsterAnimation(player);
                    }

                    monster.MonsterAttack(player);


                }
                Control(monster, player);
            }




            slime.UpdateMonsterMovement(player);
            slime.DetermineMonsterAnimation(player);

            Invalidate();
        }

        private void Control(Monster monster, Player player)
        {
            if (player.health == 0)
            {
                player.dirX = 0;
                player.dirY = 0;
                player.SetAnimationConfiguration(16);
                timerMovement.Stop();
            }

            if (monster != null)
            {
                if (monster.health <= 0)
                {

                    monster.isMoving = false;
                    monster.dirX = 0;
                    monster.dirY = 0;
                    monster.SetAnimationConfiguration(16);

                    monster.isDead = true;
                    //timerDeadMonster.Start();
                    //monsters.Remove(monster);
                    //MonsterDies();
                    //corpses.Add((monster, DateTime.Now));
                    //monsters.Remove(monster); // Видалити монстра зі списку
                    //timerDeleteMonster.Start(); // Запустіть таймер для видалення монстра
                    //corpses.Add((monster, DateTime.Now));
                    //timerDeleteMonster.Start(); // Запустіть таймер для видалення монстра
                }
                else
                {
                    monster.isMoving = true;
                }
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


            //monster = new Monster(150, 150, Hero.runFrames, Hero.idleFrames, Hero.attackFrames, Hero.hitFrames, Hero.deathFrames, 128, 100, playerSheet);


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

            /*
            foreach (Monster monster in monsters)
            {
                if (monster != null)
                    monster.PlayAnimation(g);
            }
            */

            for (int i = 0; i < monsters.Count; i++)
            {
                Monster monster = monsters[i];
                if (monster != null)
                {
                    monster.PlayAnimation(g);
                }
            }

            player.PlayAnimation(g);

        }

        

        private void labelPause_Click(object sender, EventArgs e)
        {
            timerMovement.Stop();
            timerSpawnMonster.Stop();
            timerDeadMonster.Stop();
            labelNoPause.Visible = true;
            labelExit.Visible = true;
            labelNoPause.BackColor = Color.Transparent;
            labelExit.BackColor = Color.Transparent;
        }

        private void labelNoPause_Click(object sender, EventArgs e)
        {
            timerMovement.Start();
            timerSpawnMonster.Start();
            timerDeadMonster.Start();
            labelNoPause.Visible = false;
            labelExit.Visible = false;
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   

    }
}