using System;

namespace Infra.Exceptions
{
    public class BusinessException : BaseException
    {
        private const string _business = "A business rule seems to be violated.";
        BusinessException() : base(_business) { }
        public BusinessException(string msg) : base(msg) { }
        public BusinessException(string msg, Exception inner) : base(msg, inner) { }

        /// <summary>
        /// Creates a new instance for a BusinessException with a pre-defined internal message.
        /// </summary>
        /// <returns></returns>
        public static BusinessException New() => new BusinessException();
    }
}
