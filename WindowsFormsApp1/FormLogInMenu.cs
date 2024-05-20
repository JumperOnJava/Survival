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
    public partial class FormLogInMenu : Form
    {
        private User user;
        private FormMainMenu form2;
        private FormGameOverMenu form3;

        public FormLogInMenu(FormMainMenu f2)
        {
            InitializeComponent();
            form2 = f2;
            form3 = null;
        }

        public FormLogInMenu(FormGameOverMenu f3)
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
        