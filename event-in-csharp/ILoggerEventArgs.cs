using System;
using System.Collections.Generic;
using System.Text;

namespace event_in_csharp
{
    public interface ILoggerEventArgs
    {
        public DateTime RequestTime { get; set; }
        public string Message { get; set; }
    }
}
