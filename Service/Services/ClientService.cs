using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Service.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ClientService : IClientService
    {
        private IRepository<ClientEntity> _repository;

        public ClientService(IRepository<ClientEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Guid Id)
        {
            return await _repository.DeleteAsync(Id);
        }

        public async Task<ClientEntity> Get(Guid Id)
        {
            return await _repository.SelectAsync(Id);
        }

        public async Task<IEnumerable<ClientEntity>> GetAll()   
        {
            return await _repository.SelectAsync();
        }

        public async Task<ClientEntity> Post(ClientEntity client)
        {
            return await _repository.InsertAsync(client);
        }

        public async Task<ClientEntity> Put(ClientEntity client)
        {
            return await _repository.UpdateAsync(client);
        }
    }
}
