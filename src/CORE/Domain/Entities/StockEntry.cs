using System;
using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class StockEntry : AuditableEntity
    {
        public Guid StockEntryId { get; set; }
        public DateTime Date { get; set; }
        public BusinessDocument TypeDocument { get; set; }
        public string Document { get; set; }
        public double Taxes { get; set; } = 18.0D;

        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }

        public Provider Provider { get; set; }
        public Guid ProviderId { get; set; }

    }
}
