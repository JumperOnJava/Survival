using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Survival.Entities;
using Survival.Models;
using Survival.Controllers;
using System.Runtime.InteropServices;
using System.Numerics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.IdentityModel.Metadata;


namespace Survival
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Random rnd = new Random();
        public bool gameOver = false;
        public Player player;
        public bool isShopOpen = false;

        public int score = 0;
        public int treesCount = 0;
        public int woodCount = 0;
        public User user {  get; set; }
        //public Entity monster;
        public HashSet<Entity> entities =       new HashSet<Entity>();
        public HashSet<Entity> removeNextTick = new HashSet<Entity>();
        public HashSet<Entity> addNextTick =    new HashSet<Entity>();
        public HashSet<Entity> updateNextTick = new HashSet<Entity>();
        //public List<Tree> trees = new List<Tree>();

        public Corpse corpse;
        public List<Corpse> corpsesImages = new List<Corpse>();

        public static Form1 ActiveScene;
        //public Heart heart;

        static float TargetFrameRate = 1000;
        

        public Form1()
        {
            Constructor();
        }
        public Form1(Form2 form2)
        {
            Constructor();
            user = form2.currentUser;
        }

        public Form1(User user)
        {
            Constructor();
            this.user = user;
        }

        public void Constructor()
        {
            InitializeComponent();
            ActiveScene = this;

            foreach (Keys keys in Enum.GetValues(typeof(Keys)))
            {
                PressedKeys[keys] = false;
            }

            timerMovement.Interval = (int)(1000 / TargetFrameRate);
            timerMovement.Tick += (DeltaUpdate);
            KeyDown += new KeyEventHandler(Keyboard);
            KeyUp += new KeyEventHandler(FreeKeyboard);


            Init();
        }

        public void RemoveEntity(Entity entity)
        {
            removeNextTick.Add(entity);
        }

        public void UpdateEntity()
        {
            foreach (var entity in entities)
            {
                updateNextTick.Add(entity);
            }            
        }

        public static Dictionary<Keys,bool> PressedKeys = new Dictionary<Keys,bool>();
        private void FreeKeyboard(object sender, KeyEventArgs e)
        {
            PressedKeys[e.KeyCode] = false;
        }

        private void Keyboard(object sender, KeyEventArgs e)
        {
            PressedKeys[e.KeyCode]=true;        
        }

        System.Diagnostics.Stopwatch Watch = new System.Diagnostics.Stopwatch();

        public static float deltaTime = 0;
        void DeltaUpdate(object sender, EventArgs e)
        {
            Watch.Stop();
            labelKilledCount.Text = score.ToString();
            labelWoodCount.Text = woodCount.ToString();
            deltaTime = Watch.ElapsedMilliseconds / 1000f;
            Tick();
            Watch.Restart();
        }

        public void Tick()
        {
            foreach (var entity in removeNextTick)
            {
                entities.Remove(entity);
            }

            foreach (var entity in addNextTick)
            {
                if(!entity.HasParent())
                    entities.Add(entity);
            }

            addNextTick.Clear();

            UpdateEntity();


            foreach (var entity in updateNextTick)
            {
                if (entity is Tree)
                {
                    Tree tree = (Tree)entity;
                    if (tree.isCutted)
                    {
                        woodCount += 3;
                    }
                    entity.BaseUpdate();
                }
                else
                    entity.BaseUpdate();
               // else if (entity is Tree && entity == null) woodCount++;

            }


            updateNextTick.Clear();
            
           

            if (score >= 5 && score < 10)
            {
                labelLevel.Text = "MEDIUM";
                labelLevel.ForeColor = Color.Chocolate;
            }
            else if (score >= 10) 
            {
                labelLevel.Text = "HARD";
                labelLevel.ForeColor = Color.Firebrick;
            }


            //labelWoodCount.Text = woodCount.ToString();


            Invalidate();

            
            if (gameOver)
            {
                timerMovement.Stop();
                timerSpawnMonster.Stop();
                Watch.Stop();
                //MapController.map = MapController.GetMap();
                Form3 form3 = new Form3(this);
                form3.Show();
                this.Dispose();
            }           
        }

        public void Init()
        {
            MapController.Init();

            AddEntities(new StartEntity());

            this.Width = MapController.GetWidth();
            this.Height = MapController.GetHeight();


            timerMovement.Start();
        }

        public void AddEntities(Entity entity)
        {
            //entity.scene = this;
            addNextTick.Add(entity);
        }

        public void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            new List<Entity>(entities).Sort((e1, e2) => e1.pos.Y.CompareTo(e2.pos.Y));
           

            MapController.DrawMap(g);
            foreach(Entity entity in entities)
            {
                entity.Draw(g);
            }

            /*
            foreach(Heart heart in hearts)
            {
                heart.Draw(g);
            }*/
            
        }

        private void labelResume_Click(object sender, EventArgs e)
        {
            timerMovement.Start();
            timerSpawnMonster.Start();
            timerDeadMonster.Start();
            Watch.Start();
            labelResume.Visible = false;
            labelQuit.Visible = false;
        }
        private void labelPause_MouseEnter(object sender, EventArgs e)
        {
            labelPause.ForeColor = Color.White;
        }

        private void labelPause_MouseLeave(object sender, EventArgs e)
        {
            labelPause.ForeColor = SystemColors.ControlText;
        }

        private void labelResume_MouseEnter(object sender, EventArgs e)
        {
            labelResume.ForeColor = Color.White;
        }

        private void labelResume_MouseLeave(object sender, EventArgs e)
        {
            labelResume.ForeColor = SystemColors.ControlText;
        }

        private void labelQuit_Click(object sender, EventArgs e)
        {
            Form2 form2;
            if (this.user != null)
            {
                form2 = new Form2(this.user);
            }
            else
            {
                form2 = new Form2();
            }
            form2.Show();
            this.Dispose();
        }

        private void labelQuit_MouseEnter(object sender, EventArgs e)
        {
            labelQuit.ForeColor = Color.White;
        }

        private void labelQuit_MouseLeave(object sender, EventArgs e)
        {
            labelQuit.ForeColor = SystemColors.ControlText;
        }

        private void labelPause_Click(object sender, EventArgs e)
        {
            timerMovement.Stop();
            timerSpawnMonster.Stop();
            timerDeadMonster.Stop();
            Watch.Stop();
            labelResume.Visible = true;
            labelQuit.Visible = true;
            labelResume.BackColor = Color.Transparent;
            labelQuit.BackColor = Color.Transparent;
        }

        private void labelWood_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}