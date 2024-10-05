using System;
using Dapper.Contrib.Extensions;

namespace _23_GenericRepositoryOdev.Entities
{
	public enum Rating
	{
		G=1,
		PC,
		PC_13,
		R,
		NC_17
	}

    [Table("film")]
    public class Film
	{
		[Key]
		public short film_id { get; set; }

		public string title { get; set; }

		public string? description { get; set; }

		public int? release_year { get; set; }

		public short language_id { get; set; }

        public byte? original_language_id { get; set; }

		public byte rental_duration { get; set; }

		public decimal rental_rate { get; set; }

		public short? length { get; set; }

		public decimal replacement_cost { get; set; }

		public Rating? rating { get; set; }//Ercan Hoca enum yapmadi.string aldi.

		public string[]? special_features { get; set; }//string yapilabilir bak

		public DateTime last_update { get; set; }



	}
}

