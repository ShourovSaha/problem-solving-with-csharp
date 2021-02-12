using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace event_in_csharp
{
    /// <summary>
    /// Subscriber class.
    /// The responsibility of this class is to send mail.
    /// </summary>
    public class MailService
    {
        public void OnMessageLogged(object sender, LoggerEventArgs args)
        {
            Console.WriteLine("Mail send starts...");
            Console.WriteLine("Mail body: \n Message:" + args.Message
                                + "\n Request-Time :" + args.RequestTime);
            Thread.Sleep(3000);
            Console.WriteLine("Mail send ends...");
        }
    }
}
