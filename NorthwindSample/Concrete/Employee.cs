using System;
namespace NorthwindSample.Concrete
{
	public partial class Employee
	{
		public int EmployeeId { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; }
        public string? Title { get; set; }
        public string? TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public Byte[]? Photo { get; set; }
        public string? Notes { get; set; }

        public int? ReportsTo { get; set; } //Kendi icinde iliski oldugundan
        public Employee ReportsToEmployee { get; set; }//Bunu yazdık.
                                                       //Navigation Property

        public string? Photo_Path { get; set; }

        public List<Order>? Orders { get; set; }






    }
}

