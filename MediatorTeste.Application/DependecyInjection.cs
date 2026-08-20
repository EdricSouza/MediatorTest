using Microsoft.Extensions.DependencyInjection;

namespace MediatorTeste.Application;

public static class DependecyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependecyInjection).Assembly));

        return services;
    }
}