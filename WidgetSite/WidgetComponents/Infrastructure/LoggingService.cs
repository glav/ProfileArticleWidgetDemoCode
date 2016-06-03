using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidgetComponents.Contracts;

namespace WidgetComponents.Infrastructure
{
    public class LoggingService : ILoggingService
    {
        public void Log(LogLevel level, string message)
        {
            var msg = $"[{level.ToString()} {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}] ";
            System.Diagnostics.Trace.WriteLine(msg);
        }
    }
}
