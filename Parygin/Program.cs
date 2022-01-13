using System;
using System.Windows.Forms;

namespace Parygin
{
    public class Forms
    {
        public static Form1 form1 = new Form1();
        public static Form2 form2 = new Form2();
        public static Form3 form3 = new Form3();
        public static void open1Form()
        {
            form1.Show();
            form2.Hide();
            form3.Hide();
        }
        public static void open2Form()
        {
            form1.Hide();
            form2.Show();
            form3.Hide();
        }
        public static void open3Form()
        {
            form1.Hide();
            form2.Hide();
            form3.Show();
        }
    }
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(Forms.form1);
        }
    }
}
