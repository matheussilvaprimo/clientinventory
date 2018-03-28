using ClientInventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Server.Infra
{
    public abstract class MongoRepository<TEntity> : IReadRepository<TEntity> where TEntity : class, IEntity
    {
        private MongoContext<TEntity> _mongoContext;

        protected MongoRepository(MongoContext<TEntity> mongoContext)
        {
            _mongoContext = mongoContext;
        }

        public IEnumerable<TEntity> FetchAll()
        {
            return _mongoContext.GetCollection();
        }

        public TEntity Get(string id)
        {
            return _mongoContext.GetCollection().Where(x => x.ID == Guid.Parse(id)).FirstOrDefault();
        }

        public IEnumerable<TEntity> Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> expression)
        {
            return _mongoContext.GetCollection().Where(expression);
        }
    }
}
