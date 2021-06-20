using System;
namespace Domain.Entities
{
    public class SellDetails
    {
        public SellDetails()
        {
        }

        public Guid SellDetailsId { get; set; }
        public int Quantity { get; set; }
        public decimal PriceOfSell { get; set; }
        public double Discount { get; set; } = 0.0D;

        public Guid SellId { get; set; }
        public Sell Sell { get; set; }
    }
}
