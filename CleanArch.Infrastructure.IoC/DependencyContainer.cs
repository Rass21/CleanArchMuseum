using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application
            services.AddScoped<IArtworkService, ArtworkService>();

            //Domain.Interfaces  /  Infra.Data.Repositories
            services.AddScoped<IArtworkRepository, ArtworkRepository>();
        }
    }
}
