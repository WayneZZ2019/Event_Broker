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
    public partial class EventTrack : Form
    {
        public EventTrack()
        {
            InitializeComponent();
            EventContext.Instance.Write += TraceEvent;
        }

        void TraceEvent(string obj)
        {
            PrintOut(obj);
        }

        private void PrintOut(string text)
        {
            txbOutput.Text += text + Environment.NewLine;
        }
    }
}
