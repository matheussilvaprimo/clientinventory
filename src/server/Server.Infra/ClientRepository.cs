using ClientInventory.Domain;
using Microsoft.Extensions.Options;
using Server.Infra.Utils;

namespace Server.Infra
{
    public class ClientRepository : MongoRepository<Client>, IClientRepository
    {
        public ClientRepository(IOptions<AppSettings> settings) : base(settings)
        {
        }
    }
}
