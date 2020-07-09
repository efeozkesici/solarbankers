using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketMicroservice.Results
{
    public class FailResult : GeneralResult
    {
        public FailResult() : base(Success: false)
        {
        }

        public FailResult(string message) : base(message, false)
        {
        }

    }
}
