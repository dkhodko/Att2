using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Att_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = textBox1.Text;
            int count = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (char.IsUpper(t[i]))
                {
                    count++;
                }
            }
            label1.Text = string.Concat(count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string t = textBox1.Text;
            int count = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (char.IsDigit(t[i]))
                {
                    count++;
                }
            }
            label1.Text = string.Concat(count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string t = textBox1.Text;
            int count = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (char.IsLower(t[i]))
                {
                    count++;
                }
            }
            label1.Text = string.Concat(count);
        }
    }
}
