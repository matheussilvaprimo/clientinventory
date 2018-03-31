using ClientInventory.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientInventory.Business
{
    public interface IClientServices
    {
        Client Get(string id);
        List<Client> FetchAll();
        Task<string> Insert(Client e);
        Task Update(Client e);
    }
}
