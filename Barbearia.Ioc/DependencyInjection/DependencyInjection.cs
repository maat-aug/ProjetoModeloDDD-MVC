using Barbearia.Domain.Interfaces.Repositories;
using Barbearia.Domain.Interfaces.Repositories._Base;
using Barbearia.Domain.Interfaces.Services;
using Barbearia.Domain.Interfaces.Services._Base;
using Barbearia.Domain.Services;
using Barbearia.Domain.Services._Base;
using Barbearia.Infra.Data.Context;
using Barbearia.Infra.Data.Repositories;
using Barbearia.Infra.Data.Repositories._Base;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Barbearia.Ioc.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDepInjectionConfiguration(this IServiceCollection services)
        {

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IBarbeiroRepository, BarbeiroRepository>();

            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IBarbeiroService, BarbeiroService>();



            return services;
        }
    }
}
