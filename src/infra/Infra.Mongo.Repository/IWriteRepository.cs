using System.Threading.Tasks;

namespace Infra.Mongo.Repository
{
    public interface IWriteRepository<TEntity> where TEntity : class, IEntity
    {
        Task<string> Insert(TEntity e);
        Task Update(TEntity e);
    }
}
