using System;
using Dapper;
using System.ComponentModel.DataAnnotations;
//using Dapper.Contrib.Extensions;

namespace _22_GenericRepositoryforPostgre.Entities
{
	public class Shipper
	{
		[Key]
		public int shipper_id { get; set; }
		public string company_name { get; set; }
		public string phone { get; set; }


	}
}

