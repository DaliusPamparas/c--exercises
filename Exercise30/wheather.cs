using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise30
{
    class wheather
    {
        public enum WeatherTypes
        {
          Rainy,
          Cloudy,
          Sunny,
          Storm
        }




        public WeatherTypes Forecast(DateTime date)
        {
            Random random = new Random();
                
            int randomweather = random.Next(0, 4);
            return (WeatherTypes)randomweather; 

        }
    }
}
