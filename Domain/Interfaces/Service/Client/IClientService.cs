using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service.Client
{
    public interface IClientService
    {
        Task<ClientEntity> Get(Guid Id);
        Task<IEnumerable<ClientEntity>> GetAll();
        Task<ClientEntity> Post(ClientEntity client);
        Task<ClientEntity> Put(ClientEntity client);
        Task<bool> Delete(Guid Id);
    }
}
