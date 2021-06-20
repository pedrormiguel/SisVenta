using System;
using Domain.Common;

namespace Domain.Entities
{
    public class Article : AuditableEntity
    {
        public Article()
        {
        }

        public Guid ArticuloId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid PresentacionId { get; set; }
        public Presentation Presentacion { get; set; }
    }
}
