using ClientInventory.Domain;

namespace Server.Infra
{
    public class ClientRepository : MongoRepository<Client>, IClientRepository
    {
    }
}
