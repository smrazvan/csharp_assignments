using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Exceptions
{
    internal class UserUsernameDuplicateException : Exception
    {
        public UserUsernameDuplicateException(string? message) : base(message)
        {
        }
    }
}
