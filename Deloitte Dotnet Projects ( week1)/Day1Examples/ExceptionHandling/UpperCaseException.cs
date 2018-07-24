using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class UpperCaseException : Exception
    {
        string msg;
        public UpperCaseException()
        {
            msg = "Name has to be in upper case";

        }

        public UpperCaseException(string m)
        {
            msg = m;
        }

        public override string Message
        {
            get
            {
                return msg;
            }
        }
    }
}
