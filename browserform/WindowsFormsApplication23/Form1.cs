using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void search_Click(object sender, EventArgs e)
        {
            Browser.Navigate(textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Browser.GoBack();
        }

        private void fwd_Click(object sender, EventArgs e)
        {
            Browser.GoForward();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "http;//www.google.com";
            Browser.Navigate(url);
        }
    }
}
