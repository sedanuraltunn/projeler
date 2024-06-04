using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo;

internal class MsbException : Exception
{
    public MsbException(string message) : base(message) 
    {
        
    }

}
