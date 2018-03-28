using ClientInventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Server.Infra
{
    public interface IReadRepository<TEntity> where TEntity : class, IEntity
    {
        TEntity Get(string id);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> expression);
        IEnumerable<TEntity> FetchAll();
    }
}
