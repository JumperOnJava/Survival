using Survival.Models;
using Survival.Properties;
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
    public partial class FormMainMenu : System.Windows.Forms.Form
    {
        private SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\svinc\Downloads\Survival2-main (1)\Survival2-main\WindowsFormsApp1\Music\2019-01-02_-_8_Bit_Menu_-_David_Renda_-_FesliyanStudios.com.wav");
        public User user { get; set; }

        public FormMainMenu()
        {
            InitializeComponent();
            user = null;
            Init();
        }

        public FormMainMenu(User newUser)
        {
            InitializeComponent();
            this.user = newUser;
            Init();
        }

        public void Updating()
        {
            if (user != null)
            {
                labelUserLogin.Text = $"Hi, {this.user.Name}";
            }
            else
            {
                labelUserLogin.Text = $"Hi, guest";
            }
        }

        public void Init()
        {
            Updating();
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
            FormMain form1 = new FormMain(user);
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

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            FormSignUpMenu form4 = new FormSignUpMenu(this);
            form4.ShowDialog();
        }

        private void labelSignUp_MouseEnter(object sender, EventArgs e)
        {
            labelSignUp.ForeColor = Color.White;
        }

        private void labelSignUp_MouseLeave(object sender, EventArgs e)
        {
            labelSignUp.ForeColor = SystemColors.ControlText;
        }
        private void labelLeaders_Click(object sender, EventArgs e)
        {
            FormLeaderBoard form5 = new FormLeaderBoard();
            form5.ShowDialog();
        }

        private void labelLeaders_MouseEnter(object sender, EventArgs e)
        {
            labelLeaders.ForeColor = Color.White;
        }

        private void labelLeaders_MouseLeave(object sender, EventArgs e)
        {
            labelLeaders.ForeColor = SystemColors.ControlText;
        }

        private void labelLogIn_Click(object sender, EventArgs e)
        {
            FormLogInMenu form6 = new FormLogInMenu(this);
            form6.ShowDialog();
            timerClouds.Stop();
        }

        private void labelLogIn_MouseEnter(object sender, EventArgs e)
        {
            labelLogIn.ForeColor = Color.White;
        }

        private void labelLogIn_MouseLeave(object sender, EventArgs e)
        {
            labelLogIn.ForeColor = SystemColors.ControlText;
        }

        private void labelMusic_Click(object sender, EventArgs e)
        {
            if ((string)labelMusic.Tag == "on")
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
