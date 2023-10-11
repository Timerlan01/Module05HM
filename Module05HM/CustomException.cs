using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05HM
{
    class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }

    class WebResourceNotFoundException : Exception
    {
        public WebResourceNotFoundException(string message) : base(message) { }
    }

}
