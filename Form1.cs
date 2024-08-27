using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           // this.Text = "KeyUp";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //this.Text = "KeyDown";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.A)
            {
                // this.Text = ("Enter");
                //this.Text = Keys.A.ToString();

            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            this.Text = "Button_1 KeyDown";
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            this.Text = "Button_1 KeyUp";
        }
    }
}
