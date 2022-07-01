using System;
using System.Collections.Generic;
using System.Text;

namespace MyUtilities
{
    class WeatherUtilities
    {
        public static float FahrenheitToCelcius(float tempFahrenheit)
        {
            return (tempFahrenheit - 32) / 1.8f;
        }
        static float CelciusToFahrenheit(float tempCelcius)
        {
            return tempCelcius *1.8f+32;
        }

        // Higher index low comfort
        static float ComfortIndex(float tempFahrenheit, float humidityPercent)
        {
            //Not very reliable formula
            return (tempFahrenheit+ humidityPercent)/4;
        }

        public static void Report(String location,float tempCelcius, float humidityPercent)
        {
            var tempFahrenheit = CelciusToFahrenheit(tempCelcius);
            Console.WriteLine($"Comfort Index for {location}:{ComfortIndex(tempFahrenheit,humidityPercent)} ");
        }

    }

}
