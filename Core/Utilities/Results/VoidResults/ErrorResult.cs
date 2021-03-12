using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.VoidResults
{
   public class ErrorResult:Result
    {
         // the same thing that we did in successresult.cs but here we are sedingn an error with an error message.So therefor we setting the
         // bool params to false.
        public ErrorResult(string message) : base(false, message)
        {

        }
        
        public ErrorResult() : base(false)
        {

        }
    }
}
