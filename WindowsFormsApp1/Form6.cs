using Survival.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survival
{
    public partial class Form6 : Form
    {
        public User user = null;
        public User oldUser { get; set; }
        Form5 form5 = null;

        public Form6(Form5 f5)
        {
            InitializeComponent();
            form5 = f5;
        }

        public Form6(Form2 f2)
        {
            InitializeComponent();
            oldUser = f2.currentUser;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            if (form5 == null)
            {
                Form2 form2;
                if (user != null)
                {
                    form2 = new Form2(user);
                }
                else if (oldUser != null)
                {
                    form2 = new Form2(oldUser);
                }
                else
                {
                    form2 = new Form2();
                }
                form2.Show();
            }

            this.Hide();
        }


        private void labelConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEnterName.Text) || string.IsNullOrEmpty(textBoxEnterPassword.Text))
            {
                labelError.Text = "All fields must be filled !";
                labelError.Visible = true;
            }
            else
            {
                labelError.Visible = false;
                using (GameDbContext context = new GameDbContext())
                {
                    // Check if a user with the same name and password already exists
                    user = context.User.FirstOrDefault(u => u.Name == textBoxEnterName.Text && u.Password == textBoxEnterPassword.Text);


                    if (user != null)
                    {
                        labelInfo.Text = $"Hello, {user.Name}!";
                    }
                    else
                    {
                        labelError.Text = "User does not exist.";
                        labelError.Visible = true;
                        user = null;

                    }
                }
            }

        }

        private void labelConfirm_MouseEnter(object sender, EventArgs e)
        {
            labelConfirm.ForeColor = Color.White;
        }

        private void labelConfirm_MouseLeave(object sender, EventArgs e)
        {
            labelConfirm.ForeColor = SystemColors.ControlText;
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = SystemColors.ControlText;
        }
    }
}
        