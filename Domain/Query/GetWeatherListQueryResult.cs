using DataStorage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Query
{
    public class GetWeatherListQueryResult
    {
        public GetWeatherListQueryResult(Weather weather)
        {
            Cidade = weather.Cidade;
            Data = weather.Data;
            Temperatura = weather.Temperatura;
        }

        public string Cidade { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public float Temperatura { get; set; }
    }
}
