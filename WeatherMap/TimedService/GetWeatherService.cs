using Domain.Command;
using MediatR;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace WeatherMap.TimedService
{
    public class GetWeatherService : IHostedService, IDisposable
    {
        private int _count = 0;
        private Timer? _timer = null;
        private IMediator _mediator;

        public GetWeatherService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(DoWork, null, TimeSpan.Zero.Milliseconds, 2*60*1000);

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        private void DoWork(object? state)
        {
            var count = Interlocked.Increment(ref _count);

            _mediator.Send(new CreateWeatherCommandRequest());
        }
    }
}
