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
        

        List<string> Weatherconditions = new List<string> { "Sunny", "Rainy", "Foggy", "Cold" };

        public Weather()
        {

        }


        //public Weather = new Weather;
        public void SetWeather()
        {
            temperature = RandomNumber();
            condition = RandomWeather();
            Console.WriteLine(temperature);
            Console.WriteLine(condition);
        }
        public int RandomNumber()
        {
            

            Random rng = new Random();
            //Console.WriteLine(temperature);
            return rng.Next(60, 99);
        }

        public string RandomWeather()
        {
            Random rng = new Random();
            return Weatherconditions[rng.Next(4)];
            Console.WriteLine(Weatherconditions);
            Console.ReadLine();
        }

    }
}
