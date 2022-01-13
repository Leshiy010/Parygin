using System.Windows.Forms;

namespace Parygin
{
    public partial class Form1 : Form
    {
        private string _text1 = "Text 1",
            _text2 = "Text 2",
            _text3 = "Text 3",
            _text4 = "Text 4",
            _header1 = "Header 1",
            _header2 = "Header 2",
            _header3 = "Header 3",
            _header4 = "Header 4";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Forms.open2Form();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Forms.open3Form();
        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            Forms.open1Form();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            richTextBox1.Text = _text1;
            label1.Text = _header1;
        }
        private void button5_Click(object sender, System.EventArgs e)
        {
            richTextBox1.Text = _text2;
            label1.Text = _header2;
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            richTextBox1.Text = _text3;
            label1.Text = _header3;
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            richTextBox1.Text = _text4;
            label1.Text = _header4;
        }

        
    }
}
