using ClientInventory.Domain;
using Server.Infra;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ClientInventory.Business
{
    public class ClientServices : IClientServices
    {
        private IClientRepository _repository;

        public ClientServices(IClientRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Client> FetchAll()
        {
            return _repository.FetchAll();
        }

        public Client Get(string id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Client> Get(Expression<Func<Client, bool>> expression)
        {
            return _repository.Get(expression);
        }

        public async Task<Guid> Insert(Client e)
        {
            return await _repository.Insert(e);
        }

        public async Task Update(Client e)
        {
            await _repository.Update(e);
        }
    }
}
