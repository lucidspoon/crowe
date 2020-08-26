using System;
using System.Configuration;

namespace logging.api
{
    public static class LoggerFactory
    {
        public static ILogger GetLogger()
        {
            string loggingType = ConfigurationManager.AppSettings["loggingType"];
            
            switch (loggingType)
            {
                case "console":
                    return new ConsoleLogger();
                default:
                    throw new NotImplementedException($"There is no logger named '{loggingType}'.");
            }
        }
    }
}