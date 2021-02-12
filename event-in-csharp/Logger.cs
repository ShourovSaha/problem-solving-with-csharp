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
        public EventHandler<LoggerEventArgs> LoggingEventHandeler = null;
        private readonly LoggerEventArgs _loggerEventArgs;
        public Logger(LoggerEventArgs args)
        {
            _loggerEventArgs = args;
        }

        public void WriteLog()
        {
            Console.WriteLine("Error message: " + _loggerEventArgs.Message
                                + ", Error occured at: " + _loggerEventArgs.RequestTime
                                + "\n\n");
            OnErrorMessageLogged(_loggerEventArgs);
        }

        protected virtual void OnErrorMessageLogged(LoggerEventArgs args)
        {
            LoggingEventHandeler?.Invoke(this, args);
        }
    }
}
