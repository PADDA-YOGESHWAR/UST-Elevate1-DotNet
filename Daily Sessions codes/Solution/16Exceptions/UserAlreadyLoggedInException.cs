using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Exceptions
{
    internal class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException(string message)//:base(message)
        {
            
        }
    }
}
