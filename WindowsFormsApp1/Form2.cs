using Survival.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survival
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\svinc\Downloads\Survival2-main (1)\Survival2-main\WindowsFormsApp1\Music\2020-03-22_-_A_Bit_Of_Hope_-_David_Fesliyan.wav");
        public User currentUser {  get; set; }
        public static Image spriteSheet;
        public bool ok = true;

        public Form2()
        {
            InitializeComponent();
            currentUser = null;
            CloudsMove();
        }

        public Form2(User user)
        {
            InitializeComponent();
            currentUser = user;
            labelUserLogin.Text = $"Hi, {user.Name}";
            CloudsMove();
        }

        public void CloudsMove()
        {
            //soundPlayer.Play();
            timerClouds.Interval = 1000;
            timerClouds.Tick += new EventHandler(UpdateClouds);
            timerClouds.Start();
        }

            private void UpdateClouds(object sender, EventArgs e)
        {

            if (pictureBoxCloud1.Visible)
            {
                pictureBoxCloud1.Visible = false;
                pictureBoxCloud2.Visible = true;
                pictureBoxCloud3.Visible = false;
                pictureBoxCloud4.Visible = false;
            }
            else if (pictureBoxCloud2.Visible)
            {
                pictureBoxCloud1.Visible = false;
                pictureBoxCloud2.Visible = false;            
                pictureBoxCloud3.Visible = true;
                pictureBoxCloud4.Visible = false;
            }
            else if (pictureBoxCloud3.Visible)
            {
                pictureBoxCloud1.Visible = false;
                pictureBoxCloud2.Visible = false;
                pictureBoxCloud3.Visible = false;
                pictureBoxCloud4.Visible = true;
            }
            else
            {
                pictureBoxCloud1.Visible = true;
                pictureBoxCloud2.Visible = false;
                pictureBoxCloud3.Visible = false;
                pictureBoxCloud4.Visible = false;
            }

        }

        private void labelStart_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(currentUser);
            form1.Show();

            this.Hide();
        }
        private void labelQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelStart_MouseEnter(object sender, EventArgs e)
        {
            labelStart.ForeColor = Color.White;
        }

        private void labelStart_MouseLeave(object sender, EventArgs e)
        {
            labelStart.ForeColor = SystemColors.ControlText;
        }

        private void labelQuit_MouseEnter(object sender, EventArgs e)
        {
            labelQuit.ForeColor = Color.White;
        }
        private void labelQuit_MouseLeave(object sender, EventArgs e)
        {
            labelQuit.ForeColor = SystemColors.ControlText;
        }

        private void labelJoin_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
            this.Hide();
        }

        private void labelJoin_MouseEnter(object sender, EventArgs e)
        {
            labelJoin.ForeColor = Color.White;
        }

        private void labelJoin_MouseLeave(object sender, EventArgs e)
        {
            labelJoin.ForeColor = SystemColors.ControlText;
        }
        private void labelLeaders_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            //this.Hide();
        }

        private void labelLeaders_MouseEnter(object sender, EventArgs e)
        {
            labelLeaders.ForeColor = Color.White;
        }

        private void labelLeaders_MouseLeave(object sender, EventArgs e)
        {
            labelLeaders.ForeColor = SystemColors.ControlText;
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.Show();
            this.Hide();
        }

        private void labelLogin_MouseEnter(object sender, EventArgs e)
        {
            labelLogin.ForeColor = Color.White;
        }

        private void labelLogin_MouseLeave(object sender, EventArgs e)
        {
            labelLogin.ForeColor = SystemColors.ControlText;
        }
    }
}
