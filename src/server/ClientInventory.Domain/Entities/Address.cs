using ClientInventory.Utils;
using Infra.Mongo.Repository;

namespace ClientInventory.Domain.Entities
{
    public class Address : MongoEntity
    {
        public string Street { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public AddressType Type { get; set; }
    }
}
