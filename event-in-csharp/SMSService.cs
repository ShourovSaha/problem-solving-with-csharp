using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace event_in_csharp
{
    /// <summary>
    /// Subscriber class.
    /// The responsibility of this class is to send SMS.
    /// </summary>
    public class SMSService
    {
        public void OnMessageLogged(object sender, LoggerEventArgs args)
        {
            Console.WriteLine("SMS send starts...");
            Console.WriteLine("SMS body: \n Message:" + args.Message
                                + "\n Request-Time :" + args.RequestTime);
            Thread.Sleep(3000);
            Console.WriteLine("SMS send ends...");
        }
    }
}
