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
        public void OnMessageLogged(object sender, EventArgs args)
        {
            Console.WriteLine("SMS send starts...");
            Thread.Sleep(3000);
            Console.WriteLine("SMS send ends...");
        }
    }
}
