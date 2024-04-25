using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Commons.Exceptions
{
    public class CustomException : Exception
    {
        public HttpStatusCode httpStatusCode { get; set; }

        public CustomException(HttpStatusCode code, string message) : base(message)
        {
            httpStatusCode = code;
        }
    }
}
