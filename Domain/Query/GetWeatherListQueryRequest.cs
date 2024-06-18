using DataStorage.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Query
{
    public class GetWeatherListQueryRequest : IRequest<IEnumerable<GetWeatherListQueryResult>>
    {
        public string Cidade { get; set; } = string.Empty;
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
    }
}
