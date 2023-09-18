using Microsoft.Extensions.DependencyInjection;
using OPM.Business.Utilities;

namespace OPM.Business.Services;

public static class ModuleRegister
{
    public static void RegisterService(this IServiceCollection services)
    {
        services.AddScoped<IJwtHelper, JwtHelper>();
    }
}