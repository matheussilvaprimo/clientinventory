using System;

namespace Infra.Exceptions
{
    public class NotFoundException : BaseException
    {
        private const string _notFound = "The resource you are looking for was not found.";
        NotFoundException() : base(_notFound) { }
        public NotFoundException(string msg) : base(msg) { }

        public NotFoundException(string msg, Exception inner) : base(msg, inner) { }

        /// <summary>
        /// Creates a new instance for a NotFoundException with a pre-defined internal message.
        /// </summary>
        /// <returns></returns>
        public static NotFoundException New() => new NotFoundException();
    }
}
