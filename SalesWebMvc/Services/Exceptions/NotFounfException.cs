using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFounfException : ApplicationException
    {
        public NotFounfException(string message) : base(message)
        {

        }
    }
}
