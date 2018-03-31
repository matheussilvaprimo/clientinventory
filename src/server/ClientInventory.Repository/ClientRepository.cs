using ClientInventory.Domain.Entities;
using ClientInventory.Utils;
using Infra.Mongo.Repository;

namespace ClientInventory.Repository
{
    public class ClientRepository : MongoRW<Client>, IClientRepository
    {
        public ClientRepository(AppSettings settings) : base(settings.ConnectionString, settings.DBName)
        {
        }
    }
}
