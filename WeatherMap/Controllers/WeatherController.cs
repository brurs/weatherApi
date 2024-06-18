using Domain.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WeatherMap.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private IMediator _mediator;

        public WeatherController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetWeather")]
        public async Task<IEnumerable<GetWeatherListQueryResult>> Get(string cidade, DateTime dataInicio, DateTime dataFim)
        {
            return await _mediator.Send(new GetWeatherListQueryRequest { Cidade = cidade, Fim = dataFim, Inicio = dataInicio });
        }
    }
}
