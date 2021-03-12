using Core.Utilities.Results.VoidResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.DataResults
{
   public class DataResult<T>:Result, IDataResult<T>
    {
        //here im making the same thing as in void results. instead of writing the codes again im just using the base of Result
        // And just dont make our shy class feel naked, we are implementing his Interface. Now they are both happy
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;

        }
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
