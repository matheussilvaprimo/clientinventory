using System;
using System.Collections.Generic;

namespace ClientInventory.API.Models
{
    public class Client
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        public DateTime Joined { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Telephone> Telephones { get; set; }
        public List <string> Emails { get; set; }
    }
}
