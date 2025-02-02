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
    public partial class FormShop : Form
    {
        private FormMain form1;
        public FormShop()
        {
            InitializeComponent();
        }
        public FormShop(FormMain form1)
        {
            InitializeComponent();
            this.form1 = form1;
            labelWoodLeft.Text = $"{this.form1.woodCount}";
        }

        private void labelBuyHeartForWood_Click(object sender, EventArgs e)
        {
            int price;
            if (int.TryParse(labelWoodPrice.Text, out price))
            {
                if(form1.woodCount >= price)
                {
                    
                    if (form1.player.healthComponent.health < 5)
                    {
                        form1.woodCount -= price;
                        form1.player.Heal();
                        labelError.Visible = false;
                        labelWoodLeft.Text = $"{this.form1.woodCount}";
                    }
                    else
                    {
                        labelError.Visible = true;
                        labelError.Text = "You have all hearts !";
                    }
                }
                else
                {
                    labelError.Visible = true;
                    labelError.Text = "You do not have enough wood !";
                }
            }
            else
            {
                labelError.Visible = true;
                labelError.Text = "Sorry, some technical issues !";
            }

        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Focus();
            form1.Resume();
        }

        private void labelBuyHeartForWood_MouseEnter(object sender, EventArgs e)
        {
            labelBuyHeartForWood.ForeColor = Color.White;
        }

        private void labelBuyHeartForWood_MouseLeave(object sender, EventArgs e)
        {
            labelBuyHeartForWood.ForeColor = SystemColors.ControlText;
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
