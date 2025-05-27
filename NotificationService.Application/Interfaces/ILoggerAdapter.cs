using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Interfaces
{
    public  interface ILoggerAdapter<T>
    {
        void LogInfo(string message);
        void LogError(string message, Exception ex);
    }
}
