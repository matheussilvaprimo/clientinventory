using System;

namespace ClientInventory.API.Models
{
    public class Telephone 
    {
        public Guid ID { get; set; }
        public Int64 Number { get; set; }
        public TelephoneType Type { get; set; }
    }

    [Flags]
    public enum TelephoneType
    {
        Residential,
        Commercial,
        Mobile
    }
}
