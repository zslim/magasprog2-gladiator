using System;
using System.Runtime.Serialization;

namespace Gladiators
{
    [Serializable]
    internal class EndOfServiceException : Exception
    {
        public EndOfServiceException()
        {
        }

        public EndOfServiceException(string message) : base(message)
        {
        }

        public EndOfServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EndOfServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}