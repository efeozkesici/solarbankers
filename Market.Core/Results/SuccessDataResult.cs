using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketMicroservice.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {

        public SuccessDataResult(T data, string Message) : base(data, true, Message)
        {
        }

        public SuccessDataResult(T data) : base(data, true)
        {
        }
        public SuccessDataResult(string message) : base(default, Success: true, message)
        {
        }

    }
}
