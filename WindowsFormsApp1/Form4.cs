using Survival.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survival
{
    public partial class Form4 : Form
    {
        public User user {  get; set; }
        public Form4(Form2 f)
        {
            InitializeComponent();

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Form2 form2;
            if(user != null)
            {
                form2 = new Form2(user);
            }
            else
            {
                form2 = new Form2();
            }
            form2.Show();

            this.Hide();
        }


        private void labelConfirm_Click(object sender, EventArgs e)
        {
            using (GameDbContext context = new GameDbContext())
            {
                // Check if a user with the same name and password already exists
                user = context.User.FirstOrDefault(u => u.Name == textBoxEnterName.Text && u.Password == textBoxEnterPassword.Text);

                if (user == null)
                {
                    // User doesn't exist, create a new one
                    user = new User();
                    user.Name = textBoxEnterName.Text;
                    user.Password = textBoxEnterPassword.Text; // Assuming you have a Password field in your User model
                    user.Score = 0;
                    context.User.Add(user);
                    context.SaveChanges();
                    labelInfo.Text = $"Hello, {user.Name}!";
                }
                else
                {
                    labelInfo.Text = $"Wellcome, {user.Name}!";
                    //Console.WriteLine("User already exists.");
                }
            }

        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = SystemColors.ControlText;
        }

        private void labelConfirm_MouseEnter(object sender, EventArgs e)
        {
            labelConfirm.ForeColor = Color.White;
        }

        private void labelConfirm_MouseLeave(object sender, EventArgs e)
        {
            labelConfirm.ForeColor = SystemColors.ControlText;
        }

        private void labelNmae_Click(object sender, EventArgs e)
        {

        }
    }
}
