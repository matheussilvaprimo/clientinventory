using System;

namespace ClientInventory.Domain
{
    [Flags]
    public enum AddressType
    {
        Residential,
        Commercial
    }

    [Flags]
    public enum TelephoneType
    {
        Residential,
        Commercial,
        Mobile
    }
}
