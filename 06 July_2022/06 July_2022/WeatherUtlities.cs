//using System;

//namespace MyUtilities
//{
//    class WeatherUtilities
//    {
//        public static float FahrenheitToCelcius(float temperatureFahrenheit)
//        {
//            return  (temperatureFahrenheit - 32) / 1.8f;
       
//        }
//        public static float CelciusToFahrenheit(float temperatureCelcius)
//        {
//            return (temperatureCelcius * 1.8f) + 32;
  
//        }
//        private static float ComfortIndex(float temperatureFahrenheit, float humidity)
//        {
//            return (temperatureFahrenheit + humidity) / 4;
   

//        }
//        static public void Report(string location, float temperatureCelcius, float humidity)
//        {
//            var temperaturefahrenheit = CelciusToFahrenheit(temperatureCelcius);
//            Console.WriteLine($"Comfort Index for {location}:{ComfortIndex(temperaturefahrenheit, humidity)}");
//        }
//        //static void Main(string[] args)
//        //{
//        //    WeatherUtilities.Report("Maldives", 23, 65);

//    }
//}