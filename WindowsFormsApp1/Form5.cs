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
    public partial class Form5 : System.Windows.Forms.Form
    {
        public Label[] labelsTop;

        public Form5()
        {
            InitializeComponent();

            labelsTop = new Label[5]
            {
                 labelTop1, labelTop2, labelTop3, labelTop4, labelTop5
            };

            using (GameDbContext context = new GameDbContext())
            {
                // Retrieve the top 5 users ordered by score
                var topUsers = context.User.OrderByDescending(u => u.Score).Take(5).ToList();

                for (int i = 0; i < topUsers.Count; i++)
                {
                    // Assuming labelTop1, labelTop2, ..., labelTop5 are the name of your Label controls
                    if (topUsers[i].Score > 0)
                    {
                        string labelText = $"{i + 1}. {topUsers[i].Name} - {topUsers[i].Score}";

                        labelsTop[i].Text = labelText;
                    }

                }
            }

        }

        private void Form5cs_Load(object sender, EventArgs e)
        {

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
