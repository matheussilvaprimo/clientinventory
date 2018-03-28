using ClientInventory.Domain.Entities;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Server.Infra
{
    public class MongoContext<TCollection> where TCollection : class, IEntity
    {
        private readonly IMongoDatabase _database;

        public IMongoQueryable<TCollection> GetCollection()
        {
            return _database.GetCollection<TCollection>(typeof(TCollection).Name).AsQueryable();
        }

        public MongoContext(string connString, string dbName)
        {
            _database = GetDatabase(connString, dbName);
        }

        private IMongoDatabase GetDatabase(string connString, string dbName) => new MongoClient(connString)?.GetDatabase(dbName);
    }
}
