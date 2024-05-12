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
    public partial class Form3 : Form
    {
        Form1 form1 = null;
        private bool change = true;
        public User user = null;
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
                // Оновлюємо рекорд користувача
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
            //Application.Exit();


            Form1 form1 = null;

            if (user != null)
            {
                form1 = new Form1(user);
            }
            else
            {
                form1= new Form1();
            }

            form1.Show();


            this.Hide();
        }
    }
}
