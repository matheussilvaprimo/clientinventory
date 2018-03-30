using ClientInventory.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ClientInventory.Business
{
    public interface IClientServices
    {
        Client Get(string id);
        IEnumerable<Client> Get(Expression<Func<Client, bool>> expression);
        IEnumerable<Client> FetchAll();
        Task<Guid> Insert(Client e);
        Task Update(Client e);
    }
}
