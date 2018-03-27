using ClientInventory.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ClientInventory.Domain
{
    public class Client : IEntity
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        public DateTime Joined { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Telephone> Telephones { get; set; }
        public ICollection <string> Emails { get; set; }
    }
}
