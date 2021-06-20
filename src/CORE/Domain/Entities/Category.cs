using System;
using Domain.Common;

namespace Domain.Entities
{
    public class Category : AuditableEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}