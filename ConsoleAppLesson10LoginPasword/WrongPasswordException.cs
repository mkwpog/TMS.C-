using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson10LoginPasword
{
    public class WrongPasswordException : Exception
    {
        public WrongPasswordException()
        { 
        }
        public WrongPasswordException(string message) : base(message) 
        {
        }
    }
}
