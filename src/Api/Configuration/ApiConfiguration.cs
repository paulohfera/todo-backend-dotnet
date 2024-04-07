using Asp.Versioning;
using Domain.Model.Settings;

namespace Api;

public static class ApiConfiguration
{
    public static IServiceCollection AddApiConfiguration(this IServiceCollection services, ApplicationSettings appSettings)
    {
        return services
        // .AddApplicationContext()
        // .AddResponseCompression()
        // .ConfigureExceptionHandler()
        // .AddControllersConfiguration()
        // .AddFluentValidationDependencies()
        // .AddApiFilters(appSettings)
        .AddVersioning();
    }

    private static IServiceCollection AddVersioning(this IServiceCollection services)
    {
        services.AddApiVersioning(o =>
        {
            o.DefaultApiVersion = new ApiVersion(1, 0);
            o.AssumeDefaultVersionWhenUnspecified = true;
            o.ReportApiVersions = true;
        })
        .AddApiExplorer(o =>
        {
            o.GroupNameFormat = "'v'VVV";
            o.SubstituteApiVersionInUrl = true;
        });

        return services;
    }
}
