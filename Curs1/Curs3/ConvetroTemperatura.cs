using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3
{
    internal static class ConvetroTemperatura
    {
        const double KELVIN = 273;
        public static double ConvertCelsiusToKelvin(double celsius)
        {
            return celsius + KELVIN;
        }

        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return celsius * 18 / 10 + 32;
        }
        public static double KelvinToCelsius(double kelvin)
        {
            return kelvin - KELVIN;
        }
    }
}
