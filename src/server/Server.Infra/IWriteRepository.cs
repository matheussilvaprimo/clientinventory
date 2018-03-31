using ClientInventory.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Server.Infra
{
    public interface IWriteRepository<TEntity> where TEntity : class, IEntity
    {
        Task<string> Insert(TEntity e);
        Task Update(TEntity e);
    }
}
