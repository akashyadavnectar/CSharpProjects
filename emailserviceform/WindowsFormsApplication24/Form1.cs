using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
using System.Net;
namespace WindowsFormsApplication24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string to, from, pass, mail, sub;
            to = (textto.Text).ToString();
            from = (textfrom.Text).ToString();
            mail = (TextBody.Text).ToString();
            pass = (textpassword.Text).ToString();
            sub = (textsubject.Text).ToString();
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mail;
            message.Subject = sub;

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(from, pass);
            try
            {
                client.Send(message);
                MessageBox.Show("mail sent", "sucessful", MessageBoxButtons.OK);
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
                      }
        public void Clear()
        {
            textfrom.Clear();
            textto.Clear();
            textsubject.Clear();
            TextBody.Clear();            
            textusername.Clear();
            textpassword.Clear();
           
          

        }
    }
}
