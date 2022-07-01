using System;
using MyUtilities;
namespace CsharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("\n Where should we go in May");
            WeatherUtilities.Report("San Francisco", WeatherUtilities.FahrenheitToCelcius(65), 73);
            WeatherUtilities.Report("Danver", WeatherUtilities.FahrenheitToCelcius(77), 55);
            WeatherUtilities.Report("Bologna",23,65);
        }
    }
}
