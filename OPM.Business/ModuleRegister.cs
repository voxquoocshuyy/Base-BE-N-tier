using Microsoft.Extensions.DependencyInjection;
using OPM.Business.Services;
using OPM.Business.ViewModels;

namespace OPM.Business;

public static class ModuleRegister
{
    public static void RegisterBusiness(this IServiceCollection services)
    {
        services.RegisterService();
        services.ConfigureAutoMapper();
    }
}