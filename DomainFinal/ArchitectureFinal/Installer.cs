using DomainFinal.Interfaces;
using InfrastructureFinal.Repositories;
using InfrastructureFinal.DataBases;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureFinal
{
    public static class Installer
    {
        public static void AddInfrastructure(this IServiceCollection services, string connectionString)
        {

            services.AddDbContext<SqlServerContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddScoped<IPersonRepository, PersonRepository>();
        }


    }
}
