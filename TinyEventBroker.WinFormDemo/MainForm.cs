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
    public partial class MainForm : Form
    {
        private EventBroker broker = new EventBroker();

        public MainForm()
        {
            InitializeComponent();
        }

        private void NewForm(Form frm)
        {
            broker.Register(frm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void ToolStripMenuItemSubscribe_Click(object sender, EventArgs e)
        {
            NewForm(new SubscriberForm());
        }

        private void ToolStripMenuItemOutput_Click(object sender, EventArgs e)
        {
            NewForm(new EventTrack());
        }

        private void ToolStripMenuItemPublish_Click(object sender, EventArgs e)
        {
            NewForm(new PublisherForm());
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
