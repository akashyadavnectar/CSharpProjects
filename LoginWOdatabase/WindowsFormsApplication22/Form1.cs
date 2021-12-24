using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication22
{
    public partial class Form1 : Form
    {
        Double count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtUser.Clear();
           // txtUser.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = "root";
            pass = "password";
            if ((txtUser.Text == user) && (txtPass.Text == pass))
            {
                MessageBox.Show("Welcome User");
            }
            else
            {
                count = count + 1;
                double maxcount = 3;
                double remain;
                remain = maxcount - count;
                MessageBox.Show("Wrong user name or password" + "\t" + remain + "" + "tries left");
                txtPass.Clear();
                txtUser.Clear();
                txtUser.Focus();
                if (count == maxcount)
                {
                    MessageBox.Show("Max try exceeded.");
                    Application.Exit();
                }
            }             
         }
    }
}
