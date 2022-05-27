namespace CustomerApp.Core.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}
