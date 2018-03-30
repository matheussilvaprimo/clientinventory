using ClientInventory.Domain.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Server.Infra.Utils;

namespace Server.Infra
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database;
        public IMongoCollection<T> Collection<T>() where T : class, IEntity => _database.GetCollection<T>(typeof(T).Name);
        public IMongoQueryable<T> QueryCollection<T>() where T : class, IEntity => _database.GetCollection<T>(typeof(T).Name).AsQueryable();
        public MongoContext(IOptions<AppSettings> settings) => _database = GetDatabase(settings.Value.ConnectionString, settings.Value.Database);
        private IMongoDatabase GetDatabase(string connString, string dbName) => new MongoClient(connString)?.GetDatabase(dbName);
    }
}
