using DataStorage.DataAccess;
using DataStorage.Model;
using Domain.Command;
using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Handler
{
    public sealed class CreateWeatherHandler : IRequestHandler<CreateWeatherCommandRequest, CreateWeatherCommandResult>
    {
        static string _address = "https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric";
        static string _token = "34d171868e9891501e724c29eb498014";
        private readonly IDataAccess _data;

        public CreateWeatherHandler(IDataAccess dataAccess) 
        {
            _data = dataAccess;
        }

        public async Task<CreateWeatherCommandResult> Handle(CreateWeatherCommandRequest request, CancellationToken cancellationToken)
        {
            foreach (var city in _data.Cities)
            {
                double temp = await RequestWeather(city);

                if (temp != double.NaN)
                {
                    _data.AddWeather(city, temp);
                }
            }

            return new CreateWeatherCommandResult();
        }

        public async Task<double> RequestWeather(string city)
        {
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(String.Format(_address, city, _token));
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();

            dynamic? json = JsonConvert.DeserializeObject(result);

            if (json != null)
            {
                return double.Parse(json["main"]["temp"].ToString());
            }

            return double.NaN;
        }
    }
}
