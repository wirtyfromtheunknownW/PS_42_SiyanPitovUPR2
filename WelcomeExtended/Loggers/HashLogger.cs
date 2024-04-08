using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace WelcomeExtended.Loggers
{
    public class HashLogger :ILogger
    {
        private readonly ConcurrentDictionary<int, string> _logMessages;
        private readonly string _name;

        public HashLogger(string name)
        {  _name = name; 
           _logMessages = new ConcurrentDictionary<int, string>();
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull 
        {
            throw new NotImplementedException();
            return null;

        }

        public bool IsEnabled(LogLevel logLevel) 
        {
            throw new NotImplementedException();
            return true;

        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception,Func<TState>, Exception?, string> formatter) 
        {
            throw new NotImplementedException();
        }


    }
}
