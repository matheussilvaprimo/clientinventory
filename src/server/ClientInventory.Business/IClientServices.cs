using ClientInventory.API.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ClientInventory.Business
{
    public interface IClientServices
    {
        Client Get(string id);
        List<Client> FetchAll();
        Task<Guid> Insert(Client e);
        Task Update(Client e);
    }
}
