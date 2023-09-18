using Microsoft.Extensions.DependencyInjection;

namespace OPM.Data.Repositories;

public static class ModuleRegister
{
    public static void RegisterRepository(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
    }
}