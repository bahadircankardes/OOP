using System;
using _11_Interface.Loglama.Abstract;

namespace _11_Interface.Loglama.Concrete
{
	public class Logger
	{
		public void Log(ILogger logger, string message)
		{
			logger.Logla(message);
		}
	}
}

