using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Survival.Models;
using Survival.Entities;
using Survival.Controllers;
using System.Runtime.InteropServices;
using System.Numerics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.IdentityModel.Metadata;
using System.Media;

namespace Survival
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        private SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\svinc\Downloads\Survival2-main (1)\Survival2-main\WindowsFormsApp1\Music\2021-08-30_-_Boss_Time_-_www.FesliyanStudios.com.wav");
        public static Random rnd = new Random();
        public Player player { get; set; }
        public bool isShopOpen { get; set; } = false;
        public int score { get; private set; } = 0;
        public int woodCount { get; set; } = 0;
        public int treesCount {  get; private set; } = 0;
        public User user { get; set; }
        public HashSet<Entity> entities { get; private set; } = new HashSet<Entity>();
        private HashSet<Entity> removeNextTick = new HashSet<Entity>();
        private HashSet<Entity> addNextTick = new HashSet<Entity>();
        private HashSet<Entity> updateNextTick = new HashSet<Entity>();

        public static FormMain ActiveScene;

        private static float TargetFrameRate = 1000;

        public static Dictionary<Keys, bool> PressedKeys = new Dictionary<Keys, bool>();

        private System.Diagnostics.Stopwatch Watch = new System.Diagnostics.Stopwatch();

        public static float deltaTime { get; private set; } = 0;

        public FormMain()
        {
            Constructor();
        }

        public FormMain(User user)
        {
            Constructor();
            this.user = user;
        }

        public void Constructor()
        {
            InitializeComponent();
            soundPlayer.Play();
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

        private void FreeKeyboard(object sender, KeyEventArgs e)
        {
            PressedKeys[e.KeyCode] = false;
        }

        private void Keyboard(object sender, KeyEventArgs e)
        {
            PressedKeys[e.KeyCode] = true;
        }

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
                entities.Add(entity);
            }

            addNextTick.Clear();

            UpdateEntity();

            foreach (var entity in updateNextTick)
            {
                if (!entity.HasParent())
                    entity.BaseUpdate();
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

            if (PressedKeys[Keys.E] && isShopOpen)
            {
                Pause();
                FormShop form7 = new FormShop(this);
                form7.ShowDialog();

                isShopOpen = false;
                PressedKeys[Keys.E] = false;
                PressedKeys[Keys.W] = false;
                PressedKeys[Keys.A] = false;
                PressedKeys[Keys.S] = false;
                PressedKeys[Keys.D] = false;
                PressedKeys[Keys.Space] = false;
            }
            Invalidate();
        }

        public void GameOver()
        {
            timerMovement.Stop();
            timerSpawnMonster.Stop();
            Watch.Stop();
            FormGameOverMenu form3 = new FormGameOverMenu(this);
            form3.Show();
            this.Hide();
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
            if (entity is Hitbox)
            {
                Console.WriteLine("added hitbox");
            }
            addNextTick.Add(entity);
        }

        public void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            List<Entity> sorted = new List<Entity>(entities);
            sorted.Sort((e1, e2) => e1.ZOffset.CompareTo(e2.ZOffset));

            MapController.DrawMap(g);
            foreach (Entity entity in sorted)
            {
                entity.Draw(g);
            }
        }

        public void Pause()
        {
            timerMovement.Stop();
            Watch.Stop();
        }

        public void Resume()
        {
            timerMovement.Start();
            Watch.Restart();
        }
        public void IncrementScore()
        {
            score++;
        }

        public void IncrementWood()
        {
            woodCount++;
            treesCount--;
        }

        public void IncrementTree()
        {
            treesCount++;
        }
        private void labelResume_Click(object sender, EventArgs e)
        {
            Resume();
            labelResume.Visible = false;
            labelQuit.Visible = false;
            labelMusic.Visible = false;
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
            FormMainMenu form2;
            if (this.user != null)
            {
                form2 = new FormMainMenu(this.user);
            }
            else
            {
                form2 = new FormMainMenu();
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
            Pause();
            labelResume.Visible = true;
            labelQuit.Visible = true;
            labelMusic.Visible = true;
            labelResume.BackColor = Color.Transparent;
            labelQuit.BackColor = Color.Transparent;
            labelMusic.BackColor = Color.Transparent;
        }

        private void labelMusic_Click(object sender, EventArgs e)
        {
            if (labelMusic.Tag == null || (string)labelMusic.Tag == "on")
            {
                labelMusic.Image = Properties.Resources.noteOff;
                labelMusic.Tag = "off";
                soundPlayer.Stop();
            }
            else
            {
                labelMusic.Image = Properties.Resources.note;
                labelMusic.Tag = "on";
                soundPlayer.Play();
            }
        }
    }
}