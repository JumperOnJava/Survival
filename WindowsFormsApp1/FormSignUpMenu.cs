using Survival.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survival
{
    public partial class FormSignUpMenu : System.Windows.Forms.Form
    {
        private User user;
        private FormGameOverMenu form3;
        private FormMainMenu form2;

        public FormSignUpMenu(FormMainMenu f2)
        {
            InitializeComponent();
            form2 = f2;
            form3 = null;
        }

        public FormSignUpMenu(FormGameOverMenu f3)
        {
            InitializeComponent();
            form3 = f3;
            form2 = null;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            if (user != null && form2 != null)
            {
                form2.user = this.user;
                form2.Init();
            }
            else if (user != null && form3 != null)
            {
                form3.user = this.user;
            }
            this.Hide();
        }

        private void labelConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxEnterName.Text.Length > 12 || textBoxEnterPassword.Text.Length > 12)
            {
                labelError.Text = "Maximum length for name and password is 12 characters.";
                labelError.Visible = true;
                return;
            }

            if (textBoxEnterName.Text.Length < 1)
            {
                labelError.Text = "Minimum length for name is 1 character.";
                labelError.Visible = true;
                return;
            }

            if (textBoxEnterPassword.Text.Length < 5)
            {
                labelError.Text = "Password must be at least 5 characters long.";
                labelError.Visible = true;
                return;
            }

            if (!Regex.IsMatch(textBoxEnterName.Text, "^[^ ][.a-zA-Z0-9_ ]*$"))
            {
                labelError.Text = "The first symbol cannot be a space.";
                labelError.Visible = true;
                return;
            }

            if (!Regex.IsMatch(textBoxEnterPassword.Text, "^[a-zA-Z0-9_]+$"))
            {
                labelError.Text = "Password can only contain letters, numbers and underscores.";
                labelError.Visible = true;
                return;
            }

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
                    user = context.User.FirstOrDefault(u => u.Name == textBoxEnterName.Text && u.Password == textBoxEnterPassword.Text);

                    if (user == null)
                    {
                        user = new User();
                        user.Name = textBoxEnterName.Text;
                        user.Password = textBoxEnterPassword.Text;
                        user.Score = 0;
                        context.User.Add(user);
                        context.SaveChanges();
                        labelInfo.Text = $"Hello, {user.Name}!";
                    }
                    else
                    {
                        labelError.Text = "User already exists.";
                        labelError.Visible = true;
                    }
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
    }
}
