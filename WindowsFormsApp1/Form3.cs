using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private bool change = true;
        public Form3()
        {
            InitializeComponent();

            timerSkull.Interval = 1000;
            timerSkull.Tick += new EventHandler(UpdateSkull);
            timerSkull.Start();

        }

        private void UpdateSkull(object sender, EventArgs e)
        {
            if (change)
            {
                timerSkull.Interval = 2000;
                pictureBoxSkull.Image = Properties.Resources.skullWhite;
                change = false;
            }
            else
            {
                timerSkull.Interval = 4000;
                pictureBoxSkull.Image = Properties.Resources.skullBlack;
                change = true;
            }
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.White;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = SystemColors.ControlText;
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
