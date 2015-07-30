using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyEventBroker
{
    [Flags]
    public enum EventScope
    {
        Local = 0x0001,
        Remote = 0x0002,
        Both = Local | Remote
    }
}
