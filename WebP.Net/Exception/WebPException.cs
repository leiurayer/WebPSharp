using System.Runtime.Serialization;

namespace WebP.Net.Exception
{
    public class WebPException : System.Exception
    {
        public WebPException() : base()
        {
        }

        public WebPException(string message) : base(message)
        {
        }

        public WebPException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected WebPException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
