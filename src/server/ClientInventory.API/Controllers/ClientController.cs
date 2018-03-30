using ClientInventory.API.Models;
using ClientInventory.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientInventory.API.Controllers
{
    [Produces("application/json")]
    [Route("api/client")]
    public class ClientController : Controller
    {
        private readonly IClientServices _clientServices;

        public ClientController(IClientServices clientServices)
        {
            _clientServices = clientServices;
        }

        [HttpGet("{id}")]
        public async Task<Client> Get(string id)
        {
            return await Task.Run(() => { return _clientServices.Get(id); });
        }

        [HttpGet("api/client/all")]
        public async Task<IEnumerable<Client>> GetAll()
        {
            return await Task.Run(() => { return _clientServices.FetchAll(); });
        }

        [HttpPost("api/client")]
        public async Task<Guid> Insert(Client e)
        {
            return await _clientServices.Insert(e);
        }

        [HttpPut("api/client")]
        public async Task Update(Client e)
        {
            await _clientServices.Update(e);
        }
    }
}