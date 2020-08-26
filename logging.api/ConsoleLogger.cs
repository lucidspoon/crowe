using System;

namespace logging.api
{
    public class ConsoleLogger : BaseLogger
    {
        public override void Log(string text)
        {
            Console.WriteLine($"ConsoleLogger writing: {text}");

            base.Log(text);
        }
    }
}
