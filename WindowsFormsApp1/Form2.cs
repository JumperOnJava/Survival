using Survival.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survival
{
    public partial class Form2 : Form
    {
        public User currrentUser {  get; set; }
        public static Image spriteSheet;
        public bool ok = true;

        public Form2()
        {
            InitializeComponent();
            CloudsMove();

        }

        public Form2(User user)
        {
            InitializeComponent();
            currrentUser = user;
            labelUserLogin.Text = $"Hi, {user.Name}";
            CloudsMove();
        }

        public void CloudsMove()
        {
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
            Form1 form1 = new Form1(this);
            //form1.gameIsStart = true;
            form1.Show();
            //newForm.gameIsStart = true;

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
    }
}
