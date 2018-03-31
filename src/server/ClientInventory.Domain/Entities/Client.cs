using Infra.Mongo.Repository;
using System;
using System.Collections.Generic;

namespace ClientInventory.Domain.Entities
{
    public class Client : MongoEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        public DateTime Joined { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Telephone> Telephones { get; set; }
        public List<string> Emails { get; set; }
    }
}
