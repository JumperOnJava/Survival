using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Survival.Models;
using Survival.Properties;

namespace Survival
{
    public partial class Form3 : System.Windows.Forms.Form
    {
        Form1 form1 = null;
        private bool change = true;
        public User user = null;
        public bool gameOver = false;
        public Form3(Form1 f)
        {
            InitializeComponent();

            timerSkull.Interval = 1000;
            timerSkull.Tick += new EventHandler(UpdateSkull);
            timerSkull.Start();

            form1 = f;
            labelScore.Text = $"Score: {form1.score}";

            
            if ((form1.user != null) && form1.user.Score < form1.score)
            {
                form1.user.Score = form1.score;
                user = form1.user;

                // Виконуємо збереження змін до бази даних
                using (GameDbContext context = new GameDbContext())
                {
                    // Отримуємо запис користувача з бази даних
                    var userToUpdate = context.User.FirstOrDefault(u => u.Id == form1.user.Id);

                    // Перевіряємо, чи знайдено користувача
                    if (userToUpdate != null)
                    {
                        // Оновлюємо значення рекорду
                        userToUpdate.Score = form1.score;

                        // Зберігаємо зміни до бази даних
                        context.SaveChanges();
                    }
                }

                labelRecord.Visible = true;
            }          
        }

        private void UpdateSkull(object sender, EventArgs e)
        {
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
            Form2 form2;
            if (form1.user != null)
            {
                form2 = new Form2(form1.user);
            }
            else
            {
                form2 = new Form2();
            }
            form2.Show();
            this.Hide();
        }

        private void labelLeaders_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void labelRestart_Click(object sender, EventArgs e)
        {
            //form1.Hide();
            //form1.Hide();
            Form1 newForm1;

            if (form1.user != null)
            {
                newForm1 = new Form1(form1.user);
            }
            else
            {
                newForm1 = new Form1();
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
    }
}
