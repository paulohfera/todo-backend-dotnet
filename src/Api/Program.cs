using Api.Configuration;
using Domain.Model.Settings;

try
{
    var builder = WebApplication.CreateBuilder(args);
    var appSettings = DependenciesConfiguration.Initialize().Get<ApplicationSettings>();

    builder.Services
    .AddSingleton(appSettings)
    .AddDependencies(appSettings);

    var app = builder.Build();

    app
    .UseDependencies(appSettings, app.Services)
    .UseEndpoints(e => e.MapControllers());

    if (app.Environment.IsDevelopment())
    {
        app.UseSwaggerUI();
    }

    // Log.Info($"App is starting up - FPS Comms Preference Service.");

    app.Run();
}
catch (Exception e)
{
    Console.WriteLine(e);
    //logar
}
finally
{
    //logar
}
