using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.VoidResults
{
    public class SuccessResult : Result
    {
        // we are using the Result base class, we create again 2 constructorrs just like in Result class. Our first constructor gets  string param.
        // because of we are using the base class parameters, we need to give them a value so true and a string message 
        public SuccessResult(string message):base(true,message)
        {
                
        }
        // same constructor without a message param. We are using the secont base construcor which contains only a bool parameter.
        public SuccessResult():base(true)
        {

        }
    }
}
