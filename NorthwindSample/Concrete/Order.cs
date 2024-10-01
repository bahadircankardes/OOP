namespace NorthwindSample.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }

        public string? CustomerId { get; set; }//Bu iki set butundur.Customer Id yi
        public Customer Customer { get; set; }//alacagı yeri entity ye gosterir

        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public float? Freight { get; set; }
        public string? ShipName { get; set; }
        public string? ShipAddress { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }


    }
}