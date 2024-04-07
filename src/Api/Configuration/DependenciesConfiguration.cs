using Domain.Model.Settings;
using Infra.IoC;

namespace Api.Configuration;

public static class DependenciesConfiguration
{
    public static IServiceCollection AddDependencies(this IServiceCollection services, ApplicationSettings appSettings)
    {
        return services
            .AddApiConfiguration(appSettings)
            .AddEndpointsApiExplorer()
            .AddSwaggerGen()
            .RegisterLocalServices(appSettings);
    }

    private static IServiceCollection RegisterLocalServices(this IServiceCollection services, ApplicationSettings appSettings)
    {
        services.RegisterServices(appSettings);

        return services;
    }

    public static IApplicationBuilder UseDependencies(this IApplicationBuilder app, ApplicationSettings appSettings, IServiceProvider services)
    {
        return app
            .UseRouting()
            .UseSwagger();
    }

    public static IConfiguration Initialize()
    {
        return new ConfigurationBuilder()
            .SetBasePath(Environment.CurrentDirectory)
            .AddJsonFile("appsettings.json", false, true)
            // .AddJsonFile("/vault/secrets/appsettings.json", true, true)
            .AddEnvironmentVariables()
            .Build();
    }
}
