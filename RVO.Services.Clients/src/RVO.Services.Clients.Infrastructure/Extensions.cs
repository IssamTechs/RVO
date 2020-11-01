using Microsoft.Extensions.DependencyInjection;
using RVO.Services.Clients.Core.Interface;
using RVO.Services.Clients.Infrastructure.Data;

namespace RVO.Services.Clients.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IRepository, EfRepository>();
            return services;
        }
    }
}
