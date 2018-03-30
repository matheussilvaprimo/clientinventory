using ClientInventory.Domain.Entities;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Server.Infra
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database;
        public IMongoQueryable<T> GetCollection<T>() where T : class, IEntity => _database.GetCollection<T>(typeof(T).Name).AsQueryable();

        public MongoContext(string connString, string dbName) => _database = GetDatabase(connString, dbName);

        private IMongoDatabase GetDatabase(string connString, string dbName) => new MongoClient(connString)?.GetDatabase(dbName);
    }
}
