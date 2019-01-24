using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xecryption_decryption
{
    public partial class Form1 : Form
    {
        bool useKey=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
         richTextBox2.Text=XECryption.Decryption(richTextBox1.Text, textBox1.Text, useKey);
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                useKey = true;
            }
            else
            {
                textBox1.Enabled = false;
                useKey = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
