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
    public partial class Form2 : Form
    {    
        public Form2()
        {
            InitializeComponent();
        }    

        private void labelStart_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            //form1.gameIsStart = true;
            form1.Show();
            //newForm.gameIsStart = true;

            this.Hide();
        }



        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelStart_MouseEnter(object sender, EventArgs e)
        {
            labelStart.ForeColor = Color.White;
        }

        private void labelStart_MouseLeave(object sender, EventArgs e)
        {
            labelStart.ForeColor = SystemColors.ControlText;
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.White;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = SystemColors.ControlText;
        }
    }
}
