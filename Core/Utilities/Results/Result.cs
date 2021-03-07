using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success) //overloading = aşırı yükleme
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
