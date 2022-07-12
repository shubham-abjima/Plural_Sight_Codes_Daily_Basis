using System;
using static System.Console;

namespace _12_July
{
    class Program
    {
        static void Main(String[] args)
        {
            AppDomain currentAppDomain = AppDomain.CurrentDomain;
            currentAppDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleException);

            WriteLine("Enter first name:");
            int number1 = int.Parse(ReadLine());

            WriteLine("Enter second number:");
            int number2 = int.Parse(ReadLine());

            WriteLine("Enter Operation:");
            String operation = ReadLine().ToUpperInvariant();

            var calculator = new Calculator();

            try
            {
                int result   =  calculator.Calculate(number1,number2,null);
                DisplayResult(result);
            }
            catch(ArgumentNullException ex) when(ex.ParamName == "o5" +
            "peration")
            {
                WriteLine($"Operation was not provided. {ex}");
            }
            catch (ArgumentNullException ex)
            {
                // Log.error(ex);
                WriteLine($"An Argument was null.{ex}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Log.error(ex);
                WriteLine($"Operation is not supported.{ex}");
            }
            //catch (Exception ex)
            //{
            //    WriteLine($"Sorry,something went wrong.{ex}");
            //}
            finally
            {
                WriteLine("Finally worked");
            }
            //int result   =  calculator.Calculate(number1, number2,operation);
            //DisplayResult(result);

            WriteLine("\n Press enter to exit.");
            ReadLine();
        }

        private static void DisplayResult(int result) => WriteLine($"Result is:{result}");

        private static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            WriteLine($"Sorry there was a prpblem and we need to close. Details:{e.ExceptionObject}");
        }
    }
}