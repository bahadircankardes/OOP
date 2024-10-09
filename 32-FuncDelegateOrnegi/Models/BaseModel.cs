using System;
namespace _32_FuncDelegateOrnegi.Models
{

	//Generic yapilarda T ifadesi Type Kelimesinin bas harfidir.
	//Siz istediginiz bir isim verebilirsiniz.
	public class BaseModel<T>
	{
		public T Id { get; set; }

	}
}

