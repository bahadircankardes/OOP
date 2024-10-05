using System;
//using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace _23_GenericRepositoryOdev.Entities
{
	[Table("actor")] //Dapper contrib class ismini plural yapıp arıyor
					 //Actors tablosu olmadıgından bu şekilde belirtiliyor.
	public class Actor
	{ 
		[Key]
		public int actor_id { get; set; }
		public string  first_name { get; set; }
		public string last_name { get; set; }
		public DateTime last_update { get; set; }
	}
}

