using System;
using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class Sell : AuditableEntity
    {
        public Sell()
        {
        }

        public Guid SellId { get; set; }
        public DateTime DateOfSell { get; set; }
        public BusinessDocument TypeOfDocument { get; set; }
        public string Document { get; set; }
        public double Taxes { get; set; } = 18.0D;


        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Guid ClientId { get; set; }
        public Client Client { get; set; }
    }
}
