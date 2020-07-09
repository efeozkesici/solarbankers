using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketMicroservice.Business.Models
{
    public class ProductModel
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public bool IsRejected { get; set; }
        public int StockAmount { get; set; }

    }
}
