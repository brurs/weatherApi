using DataStorage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage.DataAccess
{
    public class WeatherDataAccess : IDataAccess
    {
        private List<Weather> weather = new();

        public WeatherDataAccess()
        {
            weather.Add(new Weather { Cidade = "Florianopolis", Data = DateTime.Now, Temperatura = 20.4f });
            weather.Add(new Weather { Cidade = "Porto Alegre", Data = DateTime.Now, Temperatura = 12.3f });
            weather.Add(new Weather { Cidade = "Curitiba", Data = DateTime.Now, Temperatura = 6.2f });
        }

        public List<Weather> Weather { get { return weather; } }

        public Weather AddWeather(string city, float temp)
        {
            Weather newWeather = new Weather { Cidade = city, Data = DateTime.Now, Temperatura = temp };
            weather.Add(newWeather);
            return newWeather;
        }
    }
}
