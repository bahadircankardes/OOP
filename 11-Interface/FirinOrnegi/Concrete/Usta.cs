﻿using System;
using _11_Interface.FirinOrnegi.Abstract;

namespace _11_Interface.FirinOrnegi.Concrete
{
	public class Usta:IYogurabilir
	{
        public string Adi { get; set; }

        public void HamurYogur()
		{
			Console.WriteLine($"{Adi}  hamur yogurdu.");
		}
	}
}

