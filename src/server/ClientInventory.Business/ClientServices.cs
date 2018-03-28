using ClientInventory.Domain;
using Server.Infra;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ClientInventory.Business
{
    public class ClientServices : IClientServices
    {
        private IReadRepository<Client> _repository;

        public ClientServices(IReadRepository<Client> repository)
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
    }
}
