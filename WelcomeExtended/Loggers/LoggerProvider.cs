using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace WelcomeExtended.Loggers
{
	internal class LoggerProvider : ILoggerProvider
	{
		private static string categoryName;

		static HashLogger CreateLogger()
		{
			return new HashLogger(categoryName);
		}

		public ILogger CreateLogger(string categoryName)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}