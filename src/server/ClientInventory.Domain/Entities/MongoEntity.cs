using MongoDB.Bson;

namespace ClientInventory.Domain.Entities
{
    public class MongoEntity : IEntity
    {
        public ObjectId _id { get; set; }
        public string ID
        {
            get => _id.ToString();
            set => _id = ObjectId.Parse(value);
        }
    }
}
