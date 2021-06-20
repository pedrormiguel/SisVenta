using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class StockEntryDetail
    {
        public StockEntryDetail()
        {
        }

        public Guid StockEntryDetailId { get; set; }
        public decimal PriceBuy { get; set; }
        public decimal PriceSell { get; set; }
        public int Amount { get; set; }
        public int CurrentStock { get; set; }
        public DateTime DateOfProduction { get; set; }
        public DateTime DateOfExpiration { get; set; }

        public Guid ArticleId { get; set; }
        public Article Article { get; set; }

        public Guid StockEntryId { get; set; }
        public StockEntry StockEntry { get; set; }

    }
}
