using System;

namespace event_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();// Publisher class
            MailService mailService = new MailService();// Subscriber class

            #region mailService obj subscribes to logger obj.

            logger.ErrorLoggingEvent += mailService.OnErrorMessageLogged;

            #endregion

            logger.WriteLog("An obj referrence error encounterd!");

            Console.WriteLine("Process end.");
            Console.ReadKey();
        }
    }
}
