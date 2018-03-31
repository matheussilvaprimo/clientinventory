using ClientInventory.Utils;

namespace ClientInventory.API.Models
{
    public class Address 
    {
        public string ID { get; set; }
        public string Street { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public AddressType Type { get; set; }
    }  
}
