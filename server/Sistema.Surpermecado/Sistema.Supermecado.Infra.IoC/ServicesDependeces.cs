using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sistema.Supermecado.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Sistema.Supermecado.Aplication.Interfaces;
using Sistema.Supermecado.Aplication.Services;
using Sistema.Supermecado.Domain.Interfaces;
using Sistema.Supermecado.Infra.Data.Repository;
using Sistema.Supermecado.Aplication.Mapping;

namespace Sistema.Supermecado.Infra.IoC
{
    public static class ServicesDependeces
    {

        public static void DbServicesInjector(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("WebApiDatabase")));
        }
        public static void ServicesInjector(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IAutenticacaoService, AutenticacaoService>();

            services.AddAutoMapper(typeof(MappeamentoDomainParaDTO));
        }
        public static void RepositoryInjector(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
