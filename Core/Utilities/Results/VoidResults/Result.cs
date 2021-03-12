using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.VoidResults
{
    public class Result : IResult
    {
        // 2 construcotrs, the first one using 2 parameters and to dont repeat ourselves its using the :this(success) to call the second constructor
        // and take his variable Success
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        // constructor taking 1 parameter so basicly if the user doesnt want to insert any message than is this constructor compilated.
        public Result(bool success)
        {
            Success = success;
        }
        // getters are readonly but you can give them a value in the constructor just as shown above in the constructor
        public bool Success { get; }

        public string Message { get; }
    }
}
