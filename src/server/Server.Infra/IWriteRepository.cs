using ClientInventory.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Server.Infra
{
    public interface IWriteRepository<TEntity> where TEntity : class, IEntity
    {
        Task<Guid> Insert(TEntity e);
        void Update(TEntity e);
    }
}
