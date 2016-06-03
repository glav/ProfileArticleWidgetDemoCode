using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetComponents.Contracts
{
    public interface ILoggingService
    {
        void Log(LogLevel level, string message);
    }

    public enum LogLevel
    {
        General,
        Warning,
        Error
    }
}
