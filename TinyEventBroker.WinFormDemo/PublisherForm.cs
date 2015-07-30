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
    public partial class PublisherForm : Form
    {
        [EventPublication("topic://eventbreaker/winform/message", EventScope = EventScope.Local)]
        public event EventHandler<EventModelArgs<string>> MessageArrived;

        public PublisherForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var message = string.Format("message at {0}", DateTime.Now.ToString("HH:mm:ss"));

            txbSendMsg.Text = message;

            EventModelArgs<string> args = new EventModelArgs<string>();
            args.Data = message;

            if (MessageArrived != null)
                MessageArrived(this, args);
        }
    }
}
