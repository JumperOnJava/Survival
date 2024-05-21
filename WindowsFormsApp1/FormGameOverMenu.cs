using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Survival.Models;
using Survival.Properties;

namespace Survival
{
    public partial class FormGameOverMenu : System.Windows.Forms.Form
    {
        private SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\svinc\Downloads\Survival2-main (1)\Survival2-main\WindowsFormsApp1\Music\2020-03-22_-_A_Bit_Of_Hope_-_David_Fesliyan.wav");
        public User user { get; set; }
        private FormMain form1;
        private FormMainMenu form2;
        private bool change = true;
        public FormGameOverMenu(FormMain f1)
        {
            InitializeComponent();
            //soundPlayer.Play();
            timerSkull.Interval = 1000;
            timerSkull.Tick += new EventHandler(UpdateSkull); 
            timerSkull.Start();

            form1 = f1;
            user = form1.user;
            labelScore.Text = $"Score: {form1.score}";
            
            if ((user != null) && user.Score < form1.score)
            {
                form1.user.Score = form1.score;

                using (GameDbContext context = new GameDbContext())
                {
                    var userToUpdate = context.User.FirstOrDefault(u => u.Id == form1.user.Id);

                    if (userToUpdate != null)
                    {
                        userToUpdate.Score = form1.score;
                        context.SaveChanges();
                    }
                }
                labelRecord.Visible = true;
            }          
        }

        private void UpdateSkull(object sender, EventArgs e)
        {
            labelScore.Text = $"Score: {form1.score}";
            if (change)
            {
                timerSkull.Interval = 2000;
                pictureBoxSkull.Image = Resources.skullBlack;
                change = false;
            }
            else
            {
                timerSkull.Interval = 1000;
                pictureBoxSkull.Image = Resources.skullWhite;
                change = true;
            }
        }
        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelQuit.ForeColor = Color.White;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelQuit.ForeColor = SystemColors.ControlText;
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                form2 = new FormMainMenu(user);
            }
            else
            {
                form2 = new FormMainMenu();
            }
            form2.Show();
            this.Hide();
        }

        private void labelLeaders_Click(object sender, EventArgs e)
        {
            FormLeaderBoard form5 = new FormLeaderBoard();
            form5.ShowDialog();
        }

        private void labelRestart_Click(object sender, EventArgs e)
        {
            FormMain newForm1;

            if (user != null)
            {
                newForm1 = new FormMain(user);
            }
            else
            {
                newForm1 = new FormMain();
            }

            newForm1.Show();
            this.Hide();
        }

        private void labelRestart_MouseEnter(object sender, EventArgs e)
        {
            labelRestart.ForeColor = Color.White;
        }

        private void labelRestart_MouseLeave(object sender, EventArgs e)
        {
            labelRestart.ForeColor = SystemColors.ControlText;
        }

        private void labelLeaders_MouseEnter(object sender, EventArgs e)
        {
            labelLeaders.ForeColor = Color.White;
        }

        private void labelLeaders_MouseLeave(object sender, EventArgs e)
        {
            labelLeaders.ForeColor = SystemColors.ControlText;
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            FormSignUpMenu form4 = new FormSignUpMenu(this);
            form4.ShowDialog();
        }

        private void labelLogIn_Click(object sender, EventArgs e)
        {
            FormLogInMenu form6 = new FormLogInMenu(this);
            form6.ShowDialog();
        }

        private void labelLogIn_MouseEnter(object sender, EventArgs e)
        {
            labelLogIn.ForeColor = Color.White;
        }

        private void labelLogIn_MouseLeave(object sender, EventArgs e)
        {
            labelLogIn.ForeColor = SystemColors.ControlText;
        }

        private void labelSignUp_MouseEnter(object sender, EventArgs e)
        {
            labelSignUp.ForeColor = Color.White;
        }

        private void labelSignUp_MouseLeave(object sender, EventArgs e)
        {
            labelSignUp.ForeColor = SystemColors.ControlText;
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
