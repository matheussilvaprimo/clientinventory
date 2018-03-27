using System;

namespace ClientInventory.Domain.Entities
{
    public class Telephone : IEntity
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
