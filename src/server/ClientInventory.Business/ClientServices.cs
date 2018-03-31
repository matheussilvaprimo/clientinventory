using ClientInventory.API.Models;
using ClientInventory.Repository;
using System.Collections.Generic;
using System.Linq;
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
        public List<Client> FetchAll() => _repository.FetchAll().ToList().Select(x => x.MapClientToModel()).ToList();

        public Client Get(string id)
        {
            return _repository.Get(id).MapClientToModel();
        }

        public async Task<string> Insert(Client e)
        {
            return await _repository.Insert(e.MapClientToEntity());
        }

        public async Task Update(Client e)
        {
            await _repository.Update(e.MapClientToEntity());
        }
    }
}
