using System;

namespace Infra.Exceptions
{
    public class InternalServerException : BaseException
    {
        private const string _internal = "An internal server error has occurred.";

        InternalServerException() : base(_internal) { }
        public InternalServerException(string msg) : base(msg) { }

        public InternalServerException(string msg, Exception inner) : base(msg, inner) { }
        /// <summary>
        /// Creates a new instance for a InternalServerException with a pre-defined internal message.
        /// </summary>
        /// <returns></returns>
        public static InternalServerException New() => new InternalServerException(_internal);
    }
}
