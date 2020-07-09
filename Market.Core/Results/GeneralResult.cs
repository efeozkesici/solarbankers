using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketMicroservice.Results
{
    public class GeneralResult : IResult
    {
        public bool Success { get; }
        public string Message { get; }

        public GeneralResult(string Message, bool Success) : this(Success)
        {
            this.Message = Message;
        }
        public GeneralResult(bool Success)
        {
            this.Success = Success;
        }

    }
}
