using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketMicroservice.Results
{
    public class DataResult<T> : GeneralResult, IDataResult<T>
    {
        public T Data { get; }
        public DataResult(T data, bool Success) : base(Success)
        {
            Data = data;
        }


        public DataResult(T data, bool Success, string Message) : base(Message, Success)
        {
            this.Data = data;
        }

    }

}

