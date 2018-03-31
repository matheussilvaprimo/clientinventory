using System;

namespace Infra.Exceptions
{
    public abstract class BaseException : Exception
    {
        public BaseException(string msg) : base(msg) { }
        public BaseException(string msg, Exception inner) : base(msg, inner) { }
    }
}
