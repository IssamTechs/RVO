using Microsoft.Extensions.DependencyInjection;
using RVO.Services.Offices.Core.Interface;
using RVO.Services.Offices.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Offices.Infrastructure
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
