using Application.Commons.Interfaces;
using Infrastructure.Persistance;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureService
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(configuration.GetConnectionString("default")));
        services.AddTransient<IDateTime, DateTimeService>();
        return services;
    }
}
