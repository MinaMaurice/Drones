using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class ResponseResuls<T> where T : class
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Result { get; set; }
    }
}
