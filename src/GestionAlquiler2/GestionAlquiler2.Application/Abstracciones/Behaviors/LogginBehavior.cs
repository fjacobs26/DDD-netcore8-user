using MediatR;
using GestionAlquiler2.Application.Abstracciones.Messaging;
using Microsoft.Extensions.Logging;

namespace GestionAlquiler2.Application.Abstracciones.Behaviors;

public class LogginBehavior<TRequest, TResponse>: IPipelineBehavior<TRequest, TResponse> where TRequest : IBaseCommand
{
    private readonly ILogger<TRequest> _logger;

    public LogginBehavior(ILogger<TRequest> logger)
    {
        _logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var name = request.GetType().Name;

        try
        {
            _logger.LogInformation($"ejecutando comando: {name}");
            var result = await next();
            if (result == null)
            {
                throw new Exception();
            }
            return result;
        }catch(NotImplementedException ex)
        {
            _logger.LogInformation(ex, $"El comando: {name} tuvo los siguientes errores:");
            throw new Exception();
        };
    }
}
