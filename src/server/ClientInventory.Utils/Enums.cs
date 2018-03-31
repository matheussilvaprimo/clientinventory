using System;

namespace ClientInventory.Utils
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
