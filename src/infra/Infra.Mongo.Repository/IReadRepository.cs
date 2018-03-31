using System;
using System.Linq;
using System.Linq.Expressions;

namespace Infra.Mongo.Repository
{
    public interface IReadRepository<TEntity> where TEntity : class, IEntity
    {
        TEntity Get(string id);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> FetchAll();
    }
}
