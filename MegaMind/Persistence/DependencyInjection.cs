using MegaMind.Application.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MegaMind.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddScoped<IMegaMindDbContext, MegaMindDbContext>();

            return services;
        }
    }
}
