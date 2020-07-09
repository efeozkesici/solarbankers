using MarketMicroservice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketMicroservice.Core.Data.Entities
{
    public class Bill
    {
        public int BillId { get; set; }
        public DateTime Date { get; set; }
        public double Sum { get; set; }
        public bool IsCash { get; set; }
        public List<Product> Products { get; set; }
    }
}
