using FluentValidation;
using GestionAlquiler2.Application.Abstracciones.Behaviors;
using Microsoft.Extensions.DependencyInjection;

namespace GestionAlquiler2.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddToApplication(this IServiceCollection services)
    {
        services.AddMediatR(configurations =>
        {
            configurations.AddOpenBehavior(typeof(LogginBehavior<,>));
        });
        services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

        return services;
    }
}
