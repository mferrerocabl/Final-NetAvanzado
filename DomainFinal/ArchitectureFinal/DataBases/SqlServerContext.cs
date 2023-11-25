using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainFinal.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace InfrastructureFinal.DataBases
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Person> Persons {  get; set; }
    }
}
