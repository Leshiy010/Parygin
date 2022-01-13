using System;
using System.Windows.Forms;

namespace Parygin
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Forms.open1Form();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.open2Form();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.open3Form();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
