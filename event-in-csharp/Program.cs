using System;

namespace event_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();// Publisher class
            MailService mailService = new MailService();// Subscriber class
            SMSService smsService = new SMSService();// Subscriber class

            #region Service obj subscribes to logger publisher obj.

            logger.ErrorLoggingEvent += mailService.OnMessageLogged;
            logger.ErrorLoggingEvent += smsService.OnMessageLogged;

            #endregion

            logger.WriteLog("An obj referrence error encounterd!");

            Console.WriteLine("Process end.");
            Console.ReadKey();
        }
    }
}
