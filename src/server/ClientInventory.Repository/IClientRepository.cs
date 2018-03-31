using ClientInventory.Domain.Entities;
using Infra.Mongo.Repository;

namespace ClientInventory.Repository
{
    public interface IClientRepository : IReadRepository<Client>, IWriteRepository<Client>
    {
    }
}
