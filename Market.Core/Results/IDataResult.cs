using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketMicroservice.Results
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
    }
}
