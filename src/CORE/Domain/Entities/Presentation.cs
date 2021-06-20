using System;
using Domain.Common;

namespace Domain.Entities
{
    public class Presentation : AuditableEntity
    {
        public Guid PresentationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}