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
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public bool gameOver = false;
        public Player player;
        public int score = 0;
        public User user {  get; set; }
        //public Entity monster;
        public List<Entity> entities = new List<Entity>();
        public List<Entity> removeNextTick = new List<Entity>();
        public List<Entity> addNextTick = new List<Entity>();

        public Corpse corpse;
        public List<Corpse> corpsesImages = new List<Corpse>();

        //public Heart heart;
        public List<Heart> hearts = new List<Heart>();

        static float TargetFrameRate = 1000;
        

        public Form1()
        {
            Constructor();
        }
        public Form1(Form2 form2)
        {
            Constructor();
            user = form2.currrentUser;
        }

        public Form1(User user)
        {
            Constructor();
            this.user = user;

        }

        public void Constructor()
        {
            InitializeComponent();

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
            labelnumKilled.Text = score.ToString();
            deltaTime = Watch.ElapsedMilliseconds / 1000f;
            Tick();
            Watch.Restart();
        }

        public void Tick()
        {
            foreach (var entity in addNextTick)
            {
                entities.Add(entity);
            }

            addNextTick.Clear();

            foreach (var entity in entities)
            {
                entity.Update();
            }
            
            foreach (var entity in removeNextTick)
            {
                entities.Remove(entity);
                
            }

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

            foreach (Heart heart in hearts)
            {
                heart.Update();
            }

            Invalidate();

            
            if (gameOver)
            {
                timerMovement.Stop();
                timerSpawnMonster.Stop();
                Watch.Stop();
                Form3 form3 = new Form3(this);
                form3.Show();
                this.Hide();

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
            addNextTick.Add(entity);
            entity.scene = this;

            if (entity is Heart heart)
            {
                heart.scene = this;
            }
        }

        public void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MapController.DrawMap(g);
            foreach(Entity entity in entities)
            {
                entity.Draw(g);
            }


            foreach(Heart heart in hearts)
            {
                heart.Draw(g);
            }
            
        }
        private void labelPause_Click(object sender, EventArgs e)
        {
            timerMovement.Stop();
            timerSpawnMonster.Stop();
            timerDeadMonster.Stop();
            Watch.Stop();
            labelGoOn.Visible = true;
            labelExit.Visible = true;
            labelGoOn.BackColor = Color.Transparent;
            labelExit.BackColor = Color.Transparent;
        }

        private void labelGoOn_Click(object sender, EventArgs e)
        {
            timerMovement.Start();
            timerSpawnMonster.Start();
            timerDeadMonster.Start();
            Watch.Start();
            labelGoOn.Visible = false;
            labelExit.Visible = false;
        }
        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelPause_MouseEnter(object sender, EventArgs e)
        {
            labelPause.ForeColor = Color.White;
        }

        private void labelPause_MouseLeave(object sender, EventArgs e)
        {
            labelPause.ForeColor = SystemColors.ControlText;
        }

        private void labelKilled_Click(object sender, EventArgs e)
        {

        }

        private void labelnumKilled_Click(object sender, EventArgs e)
        {

        }

        private void labelLevelName_Click(object sender, EventArgs e)
        {

        }
    }
}