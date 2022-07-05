using System;

namespace project
{
    class Program
    {
        // Hello world
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        // fahrenheit to celcius converter
        static float FahrenheitToCelcius(float temperature)
        {
            float tempratureCelsius = (temperature - 32) / 1.8f;
            return tempratureCelsius;
        }
    }
}