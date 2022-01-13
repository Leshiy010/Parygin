using System;
using System.Windows.Forms;

namespace Parygin
{
    public partial class Form2 : Form
    {
        private string _test1text = "Test 1 text";
        private string _test2text = "Test 2 text";
        private string _test3text = "Test 3 text";

        public Form2()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _test3text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _test2text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _test1text;
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

        void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
