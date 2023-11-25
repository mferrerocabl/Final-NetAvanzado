using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainFinal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfrastructureFinal.Configurations
{
    internal class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder) 
        {
            builder.ToTable("persons");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName).HasColumnName("FirstName");
            builder.Property(p => p.LastName).HasColumnName("LastName");
        }
    }
}
