using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_July
{
    public  class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            //throw new ArgumentNullException(paramName: nameof(number1));

            string nonNullOperation =  
                operation ?? throw new ArgumentNullException(nameof(operation));
            //if(operation == "null")
            //{
            //    throw new ArgumentNullException(nameof(operation));
            //}
            if (operation == "/")
            {
                try 
                {
                    return Divide(number1, number2);

                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine("Logging");
                    //Log.Error(ex);
                    //throw;
                    throw new ArithmeticException("An error occured during calculation. ", ex);

                }
            }
            else if (operation == "+")
            {
                return plus(number1, number2);
            }
            else if (operation == "-")
            {
                return minus(number1, number2);
            }
            //else if (operation == "*"){
            //    return multiply(number1, number2);
            //}
            else
            {
                throw new ArgumentOutOfRangeException(nameof(operation), "The mathematical operator is not supported");
                //Console.WriteLine("Unknown operation.");
                //return 0;
            }
        }
        private int Divide(int number, int divisor) => number / divisor;
        private int plus(int number, int plus) => number + plus;

        private int minus(int number, int minus) => number - minus;

        //private int multiply(int number, int multiply) => number * multiply;


    }
}
