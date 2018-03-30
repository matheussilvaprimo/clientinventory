using ClientInventory.Domain.Entities;

namespace Server.Infra
{
    public interface IClientRepository : IReadRepository<Client>, IWriteRepository<Client>
    {
    }
}
