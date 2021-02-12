using System;
using System.Collections.Generic;
using System.Text;

namespace event_in_csharp
{
    public class LoggerEventArgs : EventArgs
    {
        public DateTime RequestTime { get; set; }
        public string Message { get; set; }
    }
}
