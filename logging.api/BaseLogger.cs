using System;

namespace logging.api
{
    public class BaseLogger : ILogger
    {
        public virtual void Log(string text)
        {
            Console.WriteLine($"BaseLogger writing: {text}");
        }
    }
}