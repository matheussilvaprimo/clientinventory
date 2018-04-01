using System;

namespace Infra.Exceptions
{
    public abstract class BaseException : Exception
    {
        /// <summary>
        /// User friendly error code
        /// </summary>
        public int CustomCode { get; set; }
        /// <summary>
        /// User friendly message 
        /// </summary>
        public string CustomMessage { get; set; }
        public BaseException(string msg) : base(msg) { }
        public BaseException(string msg, Exception inner) : base(msg, inner) { }    
    }
}
