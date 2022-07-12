using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_July
{
    class CalculationException : Exception
    {
        private const string DefaultMessage = " An error occured dusing calculations.  "
    
        public CalculationException() : base(DefaultMessage)
        {

        }
        /// <summary>
        /// Create a new <see cref="CalculationException"/> with a user-supplied message.
        /// </summary>

        public CalculationException(string message): base(message)
        {

        }
        /// <summary>
        /// Create a new <see cref="CalculationException"/> with a predifned message and a wrapped and inner exception. 
        /// </summary>


        public CalculationException(Exception innerException): base(DefaultMessage,innerException)
        {

        }
        /// <summary>
        /// Create a new <see cref="CalculationException"/> with a user supplied message and a wrapped inner exception.

        public CalculationException(string message, Exception innerException):
            base(message, innerException)
        {

        }

       
    }
}
