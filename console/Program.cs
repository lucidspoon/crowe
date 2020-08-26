using System;
using System.Configuration;
using logging.api;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = LoggerFactory.GetLogger();

            logger.Log("Hello World!");
        }
    }
}
