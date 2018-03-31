using MongoDB.Bson;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Mongo.Repository
{
    public abstract class MongoRW<T> : IReadRepository<T>, IWriteRepository<T> where T : class, IEntity
    {
        private MongoContext _mongoContext;

        public MongoRW(string conn, string dbName)
        {
            _mongoContext = new MongoContext(conn, dbName);
        }

        public IQueryable<T> FetchAll()
        {
            return _mongoContext.QueryCollection<T>();
        }

        public T Get(string id)
        {
            return _mongoContext.QueryCollection<T>().Where(x => x.ID == id).FirstOrDefault();
        }

        public IQueryable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return _mongoContext.QueryCollection<T>().Where(expression);
        }

        public async Task<string> Insert(T e)
        {
            e.ID = ObjectId.GenerateNewId().ToString();
            await _mongoContext.Collection<T>().InsertOneAsync(e);
            return e.ID;
        }

        public async Task Update(T e)
        {
            await _mongoContext.Collection<T>().InsertOneAsync(e);
        }
    }
}
