using Microsoft.Extensions.Logging;

namespace payment_service.config
{
    public static class Logger
    {
        public static void ConfigureLogging(this ILoggingBuilder logging)
        {
            logging.AddConsole();
            logging.AddDebug();
        }
    }
}
