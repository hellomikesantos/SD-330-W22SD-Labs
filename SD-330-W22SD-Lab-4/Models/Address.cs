namespace SD_330_W22SD_Lab_4.Models
{
    public class Address
    {
        public int ID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryRegion { get; set; }
        public ICollection<Customer> Customers { get; set; }

    }
}
