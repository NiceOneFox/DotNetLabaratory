using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebApplicationStudents.Exceptions
{
    public class IndexLessThanZeroException : Exception
    {
        public IndexLessThanZeroException()
        {
        }

        public IndexLessThanZeroException(string message)
            : base(message)
        {
            // LOG
        }

        public IndexLessThanZeroException(string message, Exception innerException) : base(message, innerException)
        {
            // Using InnerExceptions, you can also track back the original exception
        }

        protected IndexLessThanZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
