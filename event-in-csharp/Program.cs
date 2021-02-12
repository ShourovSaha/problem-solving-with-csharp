using System;

namespace event_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arrays = new int[3];
                arrays[4] = 100;

                Console.WriteLine("Process end.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                errorLogging(new LoggerEventArgs()
                {
                    Message = ex.Message,
                    RequestTime = DateTime.Now
                });
            }
        }

        private static void errorLogging(LoggerEventArgs eventArgs)
        {
            Logger logger = new Logger(eventArgs);// Publisher class
            MailService mailService = new MailService();// Subscriber class
            SMSService smsService = new SMSService();// Subscriber class

            #region Service obj subscribes to logger publisher obj.

            logger.LoggingEventHandeler += mailService.OnMessageLogged;
            logger.LoggingEventHandeler += smsService.OnMessageLogged;

            #endregion

            logger.WriteLog();
        }
    }
}
