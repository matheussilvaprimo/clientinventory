using ClientInventory.API.Models;
using entities = ClientInventory.Domain.Entities;
using Server.Infra;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Linq;

namespace ClientInventory.Business
{
    public class ClientServices : IClientServices
    {
        private IClientRepository _repository;

        public ClientServices(IClientRepository repository)
        {
            _repository = repository;
        }
        public List<Client> FetchAll()
        {
            return _repository.FetchAll().Select(x => x.MapClientToModel()).ToList();
        }

        public Client Get(string id)
        {
            return _repository.Get(id).MapClientToModel();
        }

        public async Task<Guid> Insert(Client e)
        {
            return await _repository.Insert(e.MapClientToEntity());
        }

        public async Task Update(Client e)
        {
            await _repository.Update(e.MapClientToEntity());
        }
    }
}
