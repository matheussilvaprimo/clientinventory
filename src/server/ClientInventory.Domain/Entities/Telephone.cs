using Infra.Mongo.Repository;
using System;

namespace ClientInventory.Domain.Entities
{
    public class Telephone : MongoEntity
    {
        public Int64 Number { get; set; }
        public TelephoneType Type { get; set; }
    }
}
