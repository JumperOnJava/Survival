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
    public partial class FormLeaderBoard : System.Windows.Forms.Form
    {
        private Label[] labelsTop;

        public FormLeaderBoard()
        {
            InitializeComponent();

            labelsTop = new Label[5]
            {
                 labelTop1, labelTop2, labelTop3, labelTop4, labelTop5
            };

            using (GameDbContext context = new GameDbContext())
            {
                var topUsers = context.User.OrderByDescending(u => u.Score).Take(5).ToList();

                for (int i = 0; i < topUsers.Count; i++)
                {
                    if (topUsers[i].Score > 0)
                    {
                        labelsTop[i].Text = $"{i + 1}. {topUsers[i].Name} - {topUsers[i].Score}";
                    }
                }
            }
        }
        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void labelBack_MouseEnter(object sender, EventArgs e)
        {
            labelBack.ForeColor = Color.White;
        }

        private void labelBack_MouseLeave(object sender, EventArgs e)
        {
            labelBack.ForeColor = SystemColors.ControlText;
        }
    }
}
