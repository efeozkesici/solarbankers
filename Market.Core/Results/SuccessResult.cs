using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketMicroservice.Results
{
    public class SuccessResult : GeneralResult
    {
        public SuccessResult() : base(true)
        {
        }

        public SuccessResult(string message) : base(message, true)
        {
        }
    }
}
