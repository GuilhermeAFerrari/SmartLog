using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartLog.Application.Mappings;
using SmartLog.Application.Interfaces;
using SmartLog.Application.Services;
using SmartLog.Domain.Interfaces;
using SmartLog.Infra.Data.Context;
using SmartLog.Infra.Data.Repository;

namespace SmartLog.Infra.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration["DefaultConnection"])
        );

        services.AddScoped<ILogRepository, LogRepository>();

        services.AddScoped<ILogService, LogService>();

        services.AddAutoMapper(typeof(DTOToEntityLog));

        return services;
    }
}
