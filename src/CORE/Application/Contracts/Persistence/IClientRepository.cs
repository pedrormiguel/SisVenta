using System;
using Domain.Entities;

namespace Application.Contracts.Persistence
{
    public interface IClientRepository : IAsyncRepository<Client>
    {
    }
}
