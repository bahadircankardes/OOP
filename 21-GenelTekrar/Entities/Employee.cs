using System;
using Dapper.Contrib.Extensions;

namespace _21_GenelTekrar
{
    public partial class Employee
	{
        [Key]
		public int employee_id { get; set; }
        public string last_name { get; set; } = string.Empty;
        public string first_name { get; set; }
        public string? title { get; set; }
        public string? title_of_courtesy { get; set; }
        public DateTime? birth_date { get; set; }
        public DateTime? hire_date { get; set; }
        public Byte[]? photo { get; set; }
        public string? notes { get; set; }

        public int? reports_to { get; set; } //Kendi icinde iliski oldugundan
        public Employee ReportsToEmployee { get; set; }//Bunu yazdık.
                                                       //Navigation Property

        public string? photo_path { get; set; }

        //public List<Order>? Orders { get; set; }






    }
}

