using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Weather
    {
        public int temperature;
        public string condition;
        public int forecastTemperature;
        public string forecastCondition;
        Random random;
        public int[] TemperatureOfWeather = new int[] { 60, 70, 80, 90, 100 };

        List<string> Weatherconditions = new List<string> { "Sunny, Rainy, Foggy, Cold" };


        //public Weather = new Weather;

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
           
        }

    }
}
