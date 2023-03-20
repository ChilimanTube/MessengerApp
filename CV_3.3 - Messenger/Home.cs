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
        }

        private void ReceivedMsgsBtn_Click(object sender, EventArgs e)
        {

        }

        private void NewMsgBtn_Click(object sender, EventArgs e)
        {
            NewMessage newMessage = new NewMessage();
            newMessage.Show();
        }
        
        private void SentMsgsBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
