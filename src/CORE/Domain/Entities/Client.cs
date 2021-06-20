using System;
using Domain.Common;

namespace Domain.Entities
{
    public class Client : Person
    {
        public Client() : base()
        {
        }

        public Guid ClientId { get; set; }
    }
}
