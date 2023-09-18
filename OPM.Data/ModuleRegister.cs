using Microsoft.Extensions.DependencyInjection;
using OPM.Data.Repositories;

namespace OPM.Data;

public static class ModuleRegister
{
    public static IServiceCollection RegisterData(this IServiceCollection services)
    {
        // Register DbContext
        // services.AddScoped<DbContext, ManageContext>();
        services.RegisterRepository();
        return services;
    }
}