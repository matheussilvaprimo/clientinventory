using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Infra.Mongo.Repository
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database;
        public IMongoCollection<T> Collection<T>() where T : class, IEntity => _database.GetCollection<T>(typeof(T).Name);
        public IMongoQueryable<T> QueryCollection<T>() where T : class, IEntity => _database.GetCollection<T>(typeof(T).Name).AsQueryable();
        public MongoContext(string conn, string dbName) => _database = GetDatabase(conn, dbName);
        private IMongoDatabase GetDatabase(string connString, string dbName) => new MongoClient(connString)?.GetDatabase(dbName);
    }
}
