using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDateResult<T> : DataResult<T>
    {
        public ErrorDateResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorDateResult(T data) : base(data, false)
        {

        }

        public ErrorDateResult(string message) : base(default, false, message)
        {

        }

        public ErrorDateResult() : base(default, false)
        {

        }
    }
}
