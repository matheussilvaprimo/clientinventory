using System;

namespace ClientInventory.Domain.Entities
{
    public interface IEntity
    {
        Guid ID { get; set; }
    }
}
