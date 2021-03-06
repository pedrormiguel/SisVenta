using System;
using Domain.Entities;

namespace Application.Contracts.Persistence
{
    public interface IProviderRepository : IAsyncRepository<Provider>
    {
    }
}
