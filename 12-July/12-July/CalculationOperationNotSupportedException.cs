using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_July
{
    public class CalculationOperationNotSupportedException : CalculationException
    {
        private const string DefaultMessage = "Specified operation was out of the range of valid values.";


        public string operation { get; }
        /// <summary>
        /// Create a new <see cref = "CalculationOperationNotSupportedException"/> with a predefined message.
        /// </summary>

        public CalculationOperationNotSupportedException() : base(DefaultMessage)
        {

        }
        /// <summary>
        /// Create a new <see cref = "CalculationOperationNotSupportedException"/> with a predefined message abnd a wrapped inner exception.
        /// </summary>


        public CalculationOperationNotSupportedException(Exception innerException) : base(DefaultMessage, innerException)
        {

        }

        /// <summary>
        /// Create a new <see cref = "CalculationOperationNotSupportedException"/> with a user-supplied message and a wrapped inner exception 
        /// </summary>

        public CalculationOperationNotSupportedException(string message,
                                                         Exception innerException) : base(message, innerException)
        {
        }
        /// <summary>
        /// Create a new <see cref = "CalculationOperationNotSupportedException"/> with the default message and the operation that is not supported.
        /// </summary>
        public CalculationOperationNotSupportedException(string operation) : base(DefaultMessage) => this.operation = operation;

        /// <summary>
        /// Create a new <see cref = "CalculationOperationNotSupportedException"/> with the operation
        /// that is not supported and a user-supplied message.
        /// </summary>

        public CalculationOperationNotSupportedException(string message, string operation) : base(DefaultMessage) => this.operation = operation;

        public override string ToString()
        {
            if (operation == null)
            { 
                return base.ToString();
        }
        return base.ToString() +  Environment.NewLine + $"Unsupported operation:{operation}";
        }
    }
}  
