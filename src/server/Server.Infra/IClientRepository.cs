using ClientInventory.Domain;

namespace Server.Infra
{
    public interface IClientRepository : IReadRepository<Client>, IWriteRepository<Client>
    {
    }
}
