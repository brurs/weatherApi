using DataStorage.DataAccess;
using DataStorage.Model;
using Domain.Command;
using Domain.Handler;
using Domain.Query;
using Moq;

namespace WeatherMap.Test
{
    public class WeatherTest
    {
        [Fact]
        public async Task GetWeatherList_returnsFiltered() 
        {
            var repositoryMock = new Mock<IDataAccess>();
            repositoryMock.Setup(r => r.Weather).Returns(Weathers);

            var handler = new GetWeatherListHandler(repositoryMock.Object);

            var result = await handler.Handle(new GetWeatherListQueryRequest { Cidade = "Florianopolis, Curitiba", Fim = DateTime.Now.AddDays(10), Inicio = DateTime.Now.AddDays(-10) }, new CancellationToken());

            Assert.True(result.Count() == 2);
        }

        [Fact]
        public async Task CreateWeather_AddsItems()
        {
            var repo = new WeatherDataAccess();
            var handler = new CreateWeatherHandler(repo);

            var result = await handler.Handle(new CreateWeatherCommandRequest(), new CancellationToken());

            Assert.True(repo.Weather.Count() == 3);
        }

        private List<Weather> Weathers {
            get
            {
                return new List<Weather> {
                    new Weather { Cidade = "Florianopolis", Data = DateTime.Now, Temperatura = 20.4d },
                    new Weather { Cidade = "Porto Alegre", Data = DateTime.Now, Temperatura = 12.3d },
                    new Weather { Cidade = "Curitiba", Data = DateTime.Now, Temperatura = 6.2d }
                };
            }
        }
    }
}
