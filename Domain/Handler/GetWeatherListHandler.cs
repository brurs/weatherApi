using DataStorage.DataAccess;
using DataStorage.Model;
using Domain.Query;
using MediatR;

namespace Domain.Handler
{
    public sealed class GetWeatherListHandler : IRequestHandler<GetWeatherListQueryRequest, IEnumerable<GetWeatherListQueryResult>>
    {
        private readonly IDataAccess _data;
        public GetWeatherListHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<IEnumerable<GetWeatherListQueryResult>> Handle(GetWeatherListQueryRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.Weather.Where(x => x.Cidade.Equals(request.Cidade) && x.Data >= request.Inicio && x.Data <= request.Fim).Select(x => new GetWeatherListQueryResult(x)));
        }
    }
}
