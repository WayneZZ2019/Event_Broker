using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyEventBroker.WinFormDemo
{
    public partial class SubscriberForm : Form
    {
        public SubscriberForm()
        {
            InitializeComponent();
        }

        [EventSubscription("topic://eventbreaker/winform/message", EventScope = EventScope.Local)]
        public void MessageReceived(object sender, EventModelArgs<string> message)
        {
            PrintOut(message.Data);
        }

        private void PrintOut(string text)
        {
            txbOutput.Text += text + Environment.NewLine;
        }
    }
}
