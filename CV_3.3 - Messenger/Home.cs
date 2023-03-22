using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_3._3___Messenger
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            WelcomeMsg.Text = "Welcome " + Login.username + "!";
        }

        private void ReceivedMsgsBtn_Click(object sender, EventArgs e)
        {

        }

        private void NewMsgBtn_Click(object sender, EventArgs e)
        {
            NewMessage newMessage = new NewMessage();
            newMessage.Owner = this;
            newMessage.Show();
        }

        private void SentMsgsBtn_Click(object sender, EventArgs e)
        {
            SentMsgs sentMsgs = new SentMsgs();
            sentMsgs.Show();
        }

        private void WelcomeMsg_Click(object sender, EventArgs e)
        {

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
