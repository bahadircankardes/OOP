﻿using System;
using _11_Interface.Loglama.Abstract;

namespace _11_Interface.Loglama.Concrete
{
	public class MailLoglayici:ILogger
	{
        public void Logla(string message)
        {
            Console.WriteLine($"{this.GetType().Name} Gelen {message} Logladi");

        }
    }
}

