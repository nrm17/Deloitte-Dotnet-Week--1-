using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class NoMatchException : Exception
    {
        public NoMatchException(string message) : base(message)
        {
            
        }
    }
}
