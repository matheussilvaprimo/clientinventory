using ClientInventory.Domain.Entities;
using Microsoft.Extensions.Options;
using Server.Infra.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Infra
{
    public abstract class MongoRepository<T> : IReadRepository<T>, IWriteRepository<T> where T : class, IEntity
    {
        private MongoContext _mongoContext;

        public MongoRepository(IOptions<AppSettings> settings)
        {
            _mongoContext = new MongoContext(settings);
        }

        public IEnumerable<T> FetchAll()
        {
            return _mongoContext.QueryCollection<T>();
        }

        public T Get(string id)
        {
            return _mongoContext.QueryCollection<T>().Where(x => x.ID == Guid.Parse(id)).FirstOrDefault();
        }

        public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return _mongoContext.QueryCollection<T>().Where(expression);
        }

        public async Task<Guid> Insert(T e)
        {
            var id = Guid.NewGuid();
            e.ID = id;
            await _mongoContext.Collection<T>().InsertOneAsync(e);
            return id;
        }

        public async Task Update(T e)
        {
            await _mongoContext.Collection<T>().InsertOneAsync(e);
        }
    }
}
