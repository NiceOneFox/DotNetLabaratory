using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebApplicationStudents.Exceptions
{
    public class NotFoundInstanceException : Exception
    {
        public NotFoundInstanceException()
        {
        }

        public NotFoundInstanceException(string message) : base(message)
        {

        }

        public NotFoundInstanceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFoundInstanceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
