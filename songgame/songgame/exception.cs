using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songgame
{
    class EmptyTextBookException : Exception
    {
        public EmptyTextBookException() { }
        public EmptyTextBookException(string message) : base(message) { }
        public EmptyTextBookException(string message, Exception inner) : base(message, inner) { }
    }
}
