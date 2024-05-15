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
    public partial class Form4 : System.Windows.Forms.Form
    {
        public User user = null;
        public User oldUser { get; set; }
        Form5 form5 = null;

        public Form4(Form5 f5)
        {
            InitializeComponent();
            form5 = f5;
        }

        public Form4(Form2 f2)
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
                else if (oldUser != null && user == null)
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
            // Validation for maximum length of textboxes
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

            // Validation for minimum password length
            if (textBoxEnterPassword.Text.Length < 5)
            {
                labelError.Text = "Password must be at least 5 characters long.";
                labelError.Visible = true;
                return;
            }

            // Validation for name pattern allowing all symbols but ensuring the first symbol is not a space
            if (!Regex.IsMatch(textBoxEnterName.Text, "^[^ ][.a-zA-Z0-9_ ]*$"))
            {
                labelError.Text = "The first symbol cannot be a space.";
                labelError.Visible = true;
                return;
            }

            // Validation for name and password patterns
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
                    // Check if a user with the same name and password already exists
                    user = context.User.FirstOrDefault(u => u.Name == textBoxEnterName.Text && u.Password == textBoxEnterPassword.Text);


                    if (user == null)
                    {
                        // User doesn't exist, create a new one
                        user = new User();
                        oldUser = null;
                        user.Name = textBoxEnterName.Text;
                        user.Password = textBoxEnterPassword.Text; // Assuming you have a Password field in your User model
                        user.Score = 0;
                        context.User.Add(user);
                        context.SaveChanges();
                        labelInfo.Text = $"Hello, {user.Name}!";
                    }
                    else
                    {
                        labelError.Text = "User already exists.";
                        labelError.Visible = true;
                        user = null;
                        //labelInfo.Text = $"Wellcome, {user.Name}!";
                       
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
