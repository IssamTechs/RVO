using Microsoft.Extensions.DependencyInjection;
using RVO.Services.Employees.Core.Interface;
using RVO.Services.Employees.Infrastructure.Data;

namespace RVO.Services.Employees.Infrastructure
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
