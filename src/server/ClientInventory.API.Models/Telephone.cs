using ClientInventory.Utils;
using System;

namespace ClientInventory.API.Models
{
    public class Telephone 
    {
        public string ID { get; set; }
        public Int64 Number { get; set; }
        public TelephoneType Type { get; set; }
    }
}
