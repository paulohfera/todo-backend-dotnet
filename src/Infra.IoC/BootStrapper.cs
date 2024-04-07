using Data.Context;
using Data.Repositories;
using Domain;
using Domain.Interfaces.Repositories;
using Domain.Model.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.IoC;

public static class BootStrapper
{
    public static IServiceCollection RegisterServices(this IServiceCollection services, ApplicationSettings settings)
    {
        services.AddSingleton(settings.Mssql);

        services.AddSingleton<DapperContext>();

        services.AddSingleton<IItemRepository, ItemRepository>();

        services.AddSingleton<ItemUseCases>();

        return services;
    }
}
