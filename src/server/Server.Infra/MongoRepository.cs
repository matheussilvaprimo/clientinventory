using ClientInventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Server.Infra
{
    public abstract class MongoRepository<T> : IReadRepository<T> where T : class, IEntity
    {
        private MongoContext _mongoContext;

        protected MongoRepository(MongoContext mongoContext)
        {
            _mongoContext = mongoContext;
        }

        public IEnumerable<T> FetchAll()
        {
            return _mongoContext.GetCollection<T>();
        }

        public T Get(string id)
        {
            return _mongoContext.GetCollection<T>().Where(x => x.ID == Guid.Parse(id)).FirstOrDefault();
        }

        public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return _mongoContext.GetCollection<T>().Where(expression);
        }
    }
}
