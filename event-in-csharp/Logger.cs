using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace event_in_csharp
{
    /// <summary>
    /// Publiser class.
    /// The reponsibility of this Logger class is to write log. 
    /// </summary>
    public class Logger
    {
        public delegate void LoggingEventHandeler(object sender, EventArgs args);

        public event LoggingEventHandeler ErrorLoggingEvent = null;

        public void WriteLog(string message)
        {
            Console.WriteLine("Error message: " + message);
            OnErrorMessageLogged();
        }

        protected virtual void OnErrorMessageLogged()
        {
            //if (ErrorLoggingEvent != null)
            //    ErrorLoggingEvent(this, EventArgs.Empty);

            ErrorLoggingEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
